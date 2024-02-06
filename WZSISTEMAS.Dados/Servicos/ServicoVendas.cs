using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using WZSISTEMAS.Base.NotaFiscal.Servicos.Interfaces;
using WZSISTEMAS.Base.NotaFiscal.Valores;

namespace WZSISTEMAS.Dados.Servicos;

public class ServicoVendas(
    DbContext dbContext,
    IServicoClientesLancamentos servicoClientesLancamentos,
    IServicoVendasItens servicoVendasItens,
    IServicoVendasPagamentos servicoVendasPagamentos,
    IServicoCaixas servicoCaixas,
    IServicoCaixasEntradas servicoCaixasEntradas,
    IServicoCaixasSaidas servicoCaixasSaidas,
    IServicoCaixasSuprimentos servicoCaixasSuprimentos,
    IServicoProdutos servicoProdutos,
    IServicoCFe2 icFe,
    IServicoSAT servicoSAT) : ServicoEntidades<Venda>(dbContext), IServicoVendas
{
    public virtual (Venda, VendaItem) AdicionarItem(
        long vendaId,
        long itemId,
        decimal precoUnitario,
        decimal quantidade = 1)
    {
        var venda = ObterPorId(vendaId, true)
                    ?? throw new InvalidOperationException("A venda não foi encontrada");

        var vendaItem = servicoVendasItens.Criar(vendaId, itemId, precoUnitario, quantidade);

        venda.Volume++;
        venda.ValorTotal += vendaItem.ValorTotal;

        Editar(venda);

        SalvarAlteracoes();
        DescartarAlteracoes();

        return ObterVendaEVendaItem(vendaId, vendaItem.Id);
    }

    public virtual bool CancelarVenda(long vendaId)
    {
        var venda = ObterVendaParaCancelamento(vendaId)
                    ?? throw new InvalidOperationException("A venda já foi cancelada");

        venda.CanceladaEm = DateTime.Now;

        Editar(venda);

        if (venda.FechadaEm.HasValue)
        {
            RedefinirItens();
            RedefinirPagamentos();
        }

        SalvarAlteracoes();
        DescartarAlteracoes();

        return true;

        void RedefinirItens()
        {
            if (venda.Itens.Any())
                foreach (var item in venda.Itens)
                    if (item.Item.GerenciarEstoque)
                    {
                        item.Item.EstoqueAtual += Convert.ToInt64(item.Quantidade);

                        servicoProdutos.Editar(item.Item);
                    }
        }

        void RedefinirPagamentos()
        {
            if (venda.Pagamentos.Any())
                foreach (var vendaPagamento in venda.Pagamentos)
                {
                    vendaPagamento.CanceladoEm = DateTime.Now;

                    servicoVendasPagamentos.Editar(vendaPagamento);

                    vendaPagamento.CaixaEntrada.CanceladaEm = DateTime.Now;
                    vendaPagamento.CaixaEntrada.FoiCancelada = true;

                    vendaPagamento.CaixaEntrada.Caixa.CancelarEntrada(vendaPagamento.CaixaEntrada.Tipo,
                        vendaPagamento.CaixaEntrada.Valor);

                    servicoCaixas.Editar(vendaPagamento.CaixaEntrada.Caixa);
                    servicoCaixasEntradas.Editar(vendaPagamento.CaixaEntrada);
                }
        }
    }

    public virtual void ColocarVendaEmEspera(long vendaId)
    {
        var venda = ObterVendaNaoEmEspera(vendaId)
                    ?? throw new InvalidOperationException("A venda não está aberta");

        venda.EmEspera = true;

        Editar(venda);
        SalvarAlteracoes();

        DescartarAlteracoes();
    }

    public virtual Venda ExcluirItem(long vendaItemId)
    {
        var vendaItem = servicoVendasItens.ObterVendaItemParaExcluirItem(vendaItemId)
                        ?? throw new InvalidOperationException("O tipoItem da venda já foi excluido");

        var venda = ObterPorId(vendaItem.VendaId) ??
                    throw new InvalidOperationException("A venda não foi encontrada");

        servicoVendasItens.ExcluirPeloId(vendaItemId);

        venda.ValorTotal -= vendaItem.ValorTotal;
        venda.Volume--;

        Editar(venda);

        SalvarAlteracoes();
        DescartarAlteracoes();

        venda = ObterVendaAbertoPorFiltro(x => x.Id == venda.Id) ??
                throw new InvalidOperationException("A venda não foi encontrada");

        return venda;
    }

    public virtual (Venda, string) FecharVenda(
        long vendaId,
        IEnumerable<VendaPagamento> vendasPagamentos,
        decimal troco = 0)
    {
        var venda = ObterVendaAbertaParaFechamento(vendaId)
                    ?? throw new InvalidOperationException("A venda já foi fechada");

        DefinirPagamentos();
        DefinirItens();
        var cFe = ConfigurarCFe();
        PreencherVenda();

        Editar(venda);

        SalvarAlteracoes();

        DescartarAlteracoes();

        venda = ObterVendaFechada(vendaId)
                ?? throw new InvalidOperationException("A venda não está aberta");

        return (venda, venda.CFeXml ?? string.Empty);

        Venda? ObterVendaAbertaParaFechamento(long vendaId)
        {
            return DbContext.Set<Venda>()
                .Include(x => x.Itens)
                .ThenInclude(x => x.Item)
                .Include(x => x.Caixa)
                .ThenInclude(x => x.Terminal)
                .ThenInclude(x => x.Empresa)
                .FirstOrDefault(x =>
                    x.Id == vendaId && !x.EmEspera && !x.CanceladaEm.HasValue && !x.FechadaEm.HasValue);
        }

        void PreencherVenda()
        {
            venda.FechadaEm = DateTime.Now;
            venda.Troco = troco;
            venda.CFeXml = servicoIcFe.ConverterParaXml(cFe);
        }

        void DefinirPagamentos()
        {
            foreach (var vendaPagamento in vendasPagamentos)
            {
                if (vendaPagamento.ClienteId.HasValue
                    && vendaPagamento.ClienteLancamentosNumero.HasValue)
                {
                    var valorPago = vendaPagamento.ValorPago / vendaPagamento.ClienteLancamentosNumero.Value;

                    if (vendaPagamento.ClienteLancamentosNumero > 1)
                        servicoClientesLancamentos.CriarVarios(
                            vendaPagamento.ClienteId.Value,
                            vendaPagamento.Id,
                            valorPago,
                            vendaPagamento.ClienteLancamentosNumero.Value);
                    else
                        servicoClientesLancamentos.Criar(
                            vendaPagamento.ClienteId.Value,
                            vendaPagamento.Id,
                            valorPago);
                }

                var caixaEntrada = new CaixaEntrada
                {
                    CaixaId = venda.CaixaId,
                    Valor = vendaPagamento.ValorPagoLiquido,
                    Tipo = vendaPagamento.Tipo,
                    DataEntrada = DateTime.Now
                };

                venda.Caixa.IncluirEntrada(caixaEntrada.Tipo, caixaEntrada.Valor);

                servicoCaixasEntradas.Criar(caixaEntrada);

                vendaPagamento.CaixaEntrada = caixaEntrada;

                servicoVendasPagamentos.Criar(vendaPagamento);
            }

            servicoCaixas.Editar(venda.Caixa);
        }

        void DefinirItens()
        {
            foreach (var item in venda.Itens)
                if (item.Item.GerenciarEstoque)
                {
                    item.Item.EstoqueAtual -= Convert.ToInt64(item.Quantidade);

                    servicoProdutos.Editar(item.Item);
                }
        }

        CFe ConfigurarCFe()
        {
            var dadosSAT = servicoSAT.CarregarDadosLocalmente()
                           ?? throw new InvalidOperationException("Os dados do SAT não foram encontrados");

            return servicoIcFe.ConvertVendaToCFe(dadosSAT, venda, venda.Itens, vendasPagamentos)
                   ?? throw new InvalidOperationException("Os dados do SAT ou da venda não são válidos");
        }
    }

    public virtual Venda NovaVenda(long caixaId)
    {
        var venda = ObterVendaAbertaPorCaixaId(caixaId);

        if (venda is null)
        {
            venda = new Venda
            {
                CaixaId = caixaId,
                AbertaEm = DateTime.Now
            };

            Criar(venda);
            SalvarAlteracoes();

            DescartarAlteracoes();
        }

        return venda;
    }

    public virtual Venda RetirarVendaEspera(long vendaId, long caixaId)
    {
        var venda = ObterVendaEmEspera(vendaId)
                    ?? throw new InvalidOperationException("A venda não está em espera");

        venda.EmEspera = false;
        venda.CaixaId = caixaId;

        Editar(venda);
        SalvarAlteracoes();

        return ObterPorIdComItensProduto(vendaId)
               ?? throw new InvalidOperationException("A venda não está em espera");
    }

    public virtual Venda? ObterVendaAbertaPorCaixaId(long caixaId)
    {
        return ObterVendaAbertoPorFiltro(
            venda => venda.CaixaId == caixaId
                     && !venda.FechadaEm.HasValue
                     && !venda.CanceladaEm.HasValue
                     && !venda.EmEspera);
    }

    public virtual Venda? ObterVendaEmEsperaComItens(long vendaId)
    {
        return DbContext.Set<Venda>()
            .AsNoTracking()
            .Include(venda => venda.Itens)
            .Where(
                venda => venda.Id == vendaId
                         && !venda.FechadaEm.HasValue
                         && !venda.CanceladaEm.HasValue
                         && venda.EmEspera)
            .Select(venda => new Venda
            {
                Id = venda.Id,
                Itens = venda.Itens.Select(item => new VendaItem
                {
                    CodigoBarras = item.CodigoBarras,
                    CodigoReferencia = item.CodigoReferencia,
                    Descricao = item.Descricao,
                    UnidadeMedida = item.UnidadeMedida,
                    ValorUnitario = item.ValorUnitario,
                    Quantidade = item.Quantidade,
                    ValorTotal = item.ValorTotal
                }).ToList()
            })
            .FirstOrDefault();
    }

    public virtual Venda? ObterVendaPorId(long vendaId)
    {
        return DbContext.Set<Venda>()
            .AsNoTracking()
            .Include(venda => venda.Itens)
            .FirstOrDefault(venda => venda.Id == vendaId);
    }

    public virtual IEnumerable<Venda> ObterVendasEmEspera(
        DateTime filtrarPorDataDe,
        DateTime filtrarPorDataAte)
    {
        var filtrarPorDataAteUm = filtrarPorDataAte.AddDays(1);

        return DbContext.Set<Venda>()
            .AsNoTracking()
            .Include(venda => venda.Caixa)
            .ThenInclude(caixa => caixa.Usuario)
            .ThenInclude(usuario => usuario.Funcionario)
            .Where(venda => !venda.FechadaEm.HasValue
                            && !venda.CanceladaEm.HasValue
                            && venda.EmEspera
                            && venda.AbertaEm >= filtrarPorDataDe
                            && venda.AbertaEm < filtrarPorDataAteUm)
            .Select(venda => new Venda
            {
                Id = venda.Id,
                ValorTotal = venda.ValorTotal,
                Volume = venda.Volume,
                AbertaEm = venda.AbertaEm,
                Caixa = new Caixa
                {
                    Usuario = new Usuario
                    {
                        Funcionario = new Funcionario
                        {
                            NomeCompleto = venda.Caixa.Usuario.Funcionario.NomeCompleto,
                            CPF = venda.Caixa.Usuario.Funcionario.CPF
                        }
                    }
                }
            })
            .ToList();
    }

    public virtual IEnumerable<Venda> ObterVendasCanceladasFrenteCaixaManutencao(
        DateTime filtrarPorDataDe,
        DateTime filtrarPorDataAte)
    {
        var filtrarPorDataAteUm = filtrarPorDataAte.AddDays(1);

        return DbContext.Set<Venda>()
            .AsNoTracking()
            .Include(venda => venda.Caixa)
            .Where(venda => venda.CanceladaEm.HasValue
                            && !venda.EmEspera
                            && venda.AbertaEm >= filtrarPorDataDe
                            && venda.AbertaEm < filtrarPorDataAteUm)
            .Select(venda => new Venda
            {
                Id = venda.Id,
                CaixaId = venda.CaixaId,
                Caixa = new Caixa
                {
                    TerminalId = venda.Caixa.TerminalId
                },
                ValorTotal = venda.ValorTotal,
                Volume = venda.Volume,
                AbertaEm = venda.AbertaEm
            })
            .ToList();
    }

    public virtual IEnumerable<Venda> ObterVendasFinalizadasFrenteCaixaManutencao(
        DateTime filtrarPorDataDe,
        DateTime filtrarPorDataAte)
    {
        var filtrarPorDataAteUm = filtrarPorDataAte.AddDays(1);

        return DbContext.Set<Venda>()
            .AsNoTracking()
            .Include(venda => venda.Caixa)
            .Where(venda => venda.FechadaEm.HasValue
                            && !venda.CanceladaEm.HasValue
                            && !venda.EmEspera
                            && venda.AbertaEm >= filtrarPorDataDe
                            && venda.AbertaEm < filtrarPorDataAteUm)
            .Select(venda => new Venda
            {
                Id = venda.Id,
                CaixaId = venda.CaixaId,
                Caixa = new Caixa
                {
                    TerminalId = venda.Caixa.TerminalId
                },
                ValorTotal = venda.ValorTotal,
                Volume = venda.Volume,
                AbertaEm = venda.AbertaEm
            })
            .ToList();
    }

    public virtual Venda? ObterPorIdComItensProduto(long id)
    {
        return DbContext.Set<Venda>()
            .AsNoTracking()
            .Include(venda => venda.Itens)
            .ThenInclude(venda => venda.Item)
            .FirstOrDefault(venda => venda.Id == id);
    }

    public virtual Venda? ObterVendaFrenteCaixaManutencao(long vendaId)
    {
        return DbContext.Set<Venda>()
            .AsNoTracking()
            .Include(venda => venda.Itens)
            .Where(venda => venda.Id == vendaId)
            .Select(venda => new Venda
            {
                Id = venda.Id,
                Itens = venda.Itens.Select(item => new VendaItem
                {
                    ItemId = item.ItemId,
                    CodigoBarras = item.CodigoBarras,
                    CodigoReferencia = item.CodigoReferencia,
                    Descricao = item.Descricao,
                    UnidadeMedida = item.UnidadeMedida,
                    ValorUnitario = item.ValorUnitario,
                    Quantidade = item.Quantidade,
                    ValorTotal = item.ValorTotal
                }).ToList()
            })
            .FirstOrDefault();
    }

    public virtual Venda? ObterPorIdCFe(long id)
    {
        return DbContext.Set<Venda>()
            .Include(venda => venda.Itens)
            .ThenInclude(venda => venda.Item)
            .Include(venda => venda.Pagamentos)
            .Include(venda => venda.Caixa)
            .ThenInclude(venda => venda.Usuario)
            .Include(venda => venda.Caixa)
            .ThenInclude(venda => venda.Terminal)
            .ThenInclude(venda => venda.Empresa)
            .AsNoTracking()
            .FirstOrDefault(venda => venda.Id == id);
    }

    public virtual string? ObterCFeXmlPorId(long id)
    {
        return DbContext.Set<Venda>()
            .AsNoTracking()
            .Where(venda => venda.Id == id)
            .Select(venda => venda.CFeXml)
            .FirstOrDefault();
    }

    public virtual Venda? ObterVendaNaoEmEspera(long vendaId)
    {
        return DbContext.Set<Venda>()
            .FirstOrDefault(
                venda => venda.Id == vendaId
                         && !venda.FechadaEm.HasValue
                         && !venda.CanceladaEm.HasValue
                         && !venda.EmEspera);
    }

    #region Servicos

    private readonly IServicoClientesLancamentos servicoClientesLancamentos
        = servicoClientesLancamentos
          ?? throw new ArgumentNullException(nameof(servicoClientesLancamentos));

    private readonly IServicoVendasItens servicoVendasItens
        = servicoVendasItens
          ?? throw new ArgumentNullException(nameof(servicoVendasItens));

    private readonly IServicoVendasPagamentos servicoVendasPagamentos
        = servicoVendasPagamentos
          ?? throw new ArgumentNullException(nameof(servicoVendasPagamentos));

    private readonly IServicoCaixas servicoCaixas
        = servicoCaixas
          ?? throw new ArgumentNullException(nameof(servicoCaixas));

    private readonly IServicoCaixasEntradas servicoCaixasEntradas
        = servicoCaixasEntradas
          ?? throw new ArgumentNullException(nameof(servicoCaixasEntradas));

    private readonly IServicoCaixasSaidas servicoCaixasSaidas
        = servicoCaixasSaidas
          ?? throw new ArgumentNullException(nameof(servicoCaixasSaidas));

    private readonly IServicoCaixasSuprimentos servicoCaixasSuprimentos
        = servicoCaixasSuprimentos
          ?? throw new ArgumentNullException(nameof(servicoCaixasSuprimentos));

    private readonly IServicoProdutos servicoProdutos
        = servicoProdutos
          ?? throw new ArgumentNullException(nameof(servicoProdutos));

    private readonly IServicoCFe2 servicoIcFe
        = icFe
          ?? throw new ArgumentNullException(nameof(icFe));

    private readonly IServicoSAT servicoSAT
        = servicoSAT
          ?? throw new ArgumentNullException(nameof(servicoSAT));

    #endregion

    #region Métodos auxiliares

    protected virtual Venda? ObterVendaAbertoPorFiltro(Expression<Func<Venda, bool>> filtro)
    {
        return DbContext.Set<Venda>()
            .AsNoTracking()
            .Include(venda => venda.Itens)
            .Where(filtro)
            .Select(venda => new Venda
            {
                Id = venda.Id,
                AbertaEm = venda.AbertaEm,
                ValorTotal = venda.ValorTotal,
                CPF_CNPJ_Nota = venda.CPF_CNPJ_Nota,
                Itens = venda.Itens.Select(item => new VendaItem
                {
                    Id = item.Id,
                    ItemId = item.ItemId,
                    CodigoBarras = item.CodigoBarras,
                    CodigoReferencia = item.CodigoReferencia,
                    Descricao = item.Descricao,
                    UnidadeMedida = item.UnidadeMedida,
                    TipoItem = item.TipoItem,
                    ValorUnitario = item.ValorUnitario,
                    Quantidade = item.Quantidade,
                    ValorTotal = item.ValorTotal
                }).ToList()
            })
            .FirstOrDefault();
    }

    protected virtual (Venda, VendaItem) ObterVendaEVendaItem(long vendaId, long vendaItemId)
    {
        var venda = ObterVendaAbertoPorFiltro(
                        venda => venda.Id == vendaId
                                 && !venda.FechadaEm.HasValue
                                 && !venda.CanceladaEm.HasValue
                                 && !venda.EmEspera)
                    ?? throw new InvalidOperationException("A venda não foi encontrada");

        return (venda, venda.Itens.First(x => x.Id == vendaItemId));
    }

    protected virtual Venda? ObterVendaEmEspera(long vendaId)
    {
        return DbContext.Set<Venda>()
            .AsNoTracking()
            .FirstOrDefault(
                venda => venda.Id == vendaId
                         && !venda.FechadaEm.HasValue
                         && !venda.CanceladaEm.HasValue
                         && venda.EmEspera);
    }

    protected virtual Venda? ObterVendaParaCancelamento(long vendaId)
    {
        return DbContext.Set<Venda>()
            .Include(venda => venda.Itens)
            .ThenInclude(venda => venda.Item)
            .Include(venda => venda.Pagamentos)
            .ThenInclude(venda => venda.CaixaEntrada)
            .ThenInclude(venda => venda.Caixa)
            .FirstOrDefault(
                venda => venda.Id == vendaId
                         && !venda.EmEspera
                         && !venda.CanceladaEm.HasValue);
    }

    private Venda? ObterVendaFechada(long vendaId)
    {
        return DbContext.Set<Venda>()
            .AsNoTracking()
            .Include(venda => venda.Itens)
            .ThenInclude(venda => venda.Item)
            .Include(venda => venda.Caixa)
            .Include(venda => venda.Pagamentos)
            .FirstOrDefault(venda => venda.Id == vendaId);
    }

    #endregion
}