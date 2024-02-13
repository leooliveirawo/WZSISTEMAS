using System.Linq.Expressions;
using AutoMapper;

using Microsoft.EntityFrameworkCore;
using WZSISTEMAS.Dados.Entidades.Interfaces;

namespace WZSISTEMAS.Dados.Servicos;

public class ServicoPedidos(
    DbContext dbContext,
    IServicoPedidosItens servicoPedidosItens,
    IServicoItens servicoItens,
    IServicoVendas servicoVendas,
    IServicoVendasItens servicoVendasItens) : ServicoEntidades<Pedido>(dbContext), IServicoPedidos
{
    private readonly IMapper mapper = new MapperConfiguration(cfg => { cfg.CreateMap<IItemItem, IItemItem>(); })
        .CreateMapper();

    public virtual (Pedido, PedidoItem) AdicionarItem(long pedidoId, long itemId,
        decimal precoUnitario, decimal quantidade = 1)
    {
        var pedido = ObterPorId(pedidoId, true)  ?? throw new InvalidOperationException("O pedido não foi encontrado");

        var vendaItem = servicoPedidosItens.Criar(pedidoId, itemId, precoUnitario, quantidade);

        pedido.Volume++;
        pedido.ValorTotal += vendaItem.ValorTotal;

        Editar(pedido);

        SalvarAlteracoes();
        DescartarAlteracoes();

        return ObterPedidoEPedidoItem(pedidoId, vendaItem.Id);
    }

    public virtual bool CancelarPedido(long pedidoId)
    {
        var pedido = ObterPedidoParaCancelamento(pedidoId)
                     ?? throw new InvalidOperationException("O pedido já foi cancelado");

        pedido.CanceladoEm = DateTime.Now;

        Editar(pedido);

        SalvarAlteracoes();
        DescartarAlteracoes();

        return true;
    }

    public virtual Venda ConverterParaVenda(long pedidoId, long terminalId, long caixaId)
    {
        var pedido = ObterPorId(pedidoId, true)
                     ?? throw new InvalidOperationException("O pedido não foi encontrado");

        pedido.FinalizadoEm = DateTime.Now;

        Editar(pedido);

        var itens = servicoPedidosItens.ObterTudoPorPedidoId(pedidoId);

        var venda = new Venda
        {
            CaixaId = caixaId,
            ValorTotal = pedido.ValorTotal,
            ValorTotalDesconto = pedido.ValorTotalDesconto,
            AbertaEm = DateTime.Now,
            Volume = pedido.Volume
        };

        servicoVendas.Criar(venda);

        foreach (var pedidoItem in itens)
        {
            var vendaItem = new VendaItem()
            {
                Venda = venda
            };

            mapper.Map<IItemItem, IItemItem>(pedidoItem, vendaItem);
            
            servicoVendasItens.Criar(vendaItem);
        }

        SalvarAlteracoes();

        DescartarAlteracoes();

        return servicoVendas.ObterVendaPorId(venda.Id)
               ?? throw new InvalidOperationException("A venda não foi encontrada");
    }

    public virtual Pedido ExcluirItem(long pedidoItemId)
    {
        var pedidoItem = servicoPedidosItens.ObterPedidoItemParaExcluirItem(pedidoItemId)
                         ?? throw new InvalidOperationException("O tipoItem do pedido já foi excluido");

        var pedido = ObterPorId(pedidoItem.PedidoId) ??
                     throw new InvalidOperationException("O pedido não foi encontrada");

        servicoPedidosItens.ExcluirPeloId(pedidoItemId);

        pedido.ValorTotal -= pedidoItem.ValorTotal;

        Editar(pedido);

        SalvarAlteracoes();
        DescartarAlteracoes();

        pedido = ObterPedidoAbertoPorFiltro(x => x.Id == pedido.Id)
                 ?? throw new InvalidOperationException("O pedido não foi encontrado");

        return pedido;
    }

    public IEnumerable<Pedido> ObterPedidosEmAbertoFrenteCaixa(DateTime filtrarPorDataDe, DateTime filtrarPorDataAte)
    {
        var filtrarPorDataAteUm = filtrarPorDataAte.AddDays(1);

        return DbContext.Set<Pedido>()
            .AsNoTracking()
            .Include(pedido => pedido.Funcionario)
            .Where(pedido => !pedido.CanceladoEm.HasValue
                             && !pedido.FinalizadoEm.HasValue
                             && pedido.AbertoEm >= filtrarPorDataDe
                             && pedido.AbertoEm < filtrarPorDataAteUm)
            .Select(pedido => new Pedido
            {
                Id = pedido.Id,
                ValorTotal = pedido.ValorTotal,
                Volume = pedido.Volume,
                AbertoEm = pedido.AbertoEm,
                Funcionario = new()
                {
                    NomeCompleto = pedido.Funcionario.NomeCompleto
                }
            })
            .ToList();
    }

    public Pedido? ObterPedidoEmAbertoComItens(long pedidoId)
        => DbContext.Set<Pedido>()
            .AsNoTracking()
            .Include(pedido => pedido.Itens)
            .Where(
                pedido => pedido.Id == pedidoId
                         && !pedido.FinalizadoEm.HasValue
                         && !pedido.CanceladoEm.HasValue)
            .Select(pedido => new Pedido
            {
                Id = pedido.Id,
                ValorTotal = pedido.ValorTotal,
                ValorTotalDesconto = pedido.ValorTotalDesconto,
                Volume = pedido.Volume,
                Itens = pedido.Itens.Select(item => new PedidoItem()
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

    public virtual Pedido NovoPedido(long funcionarioId)
    {
        var venda = new Pedido
        {
            FuncionarioId = funcionarioId,
            AbertoEm = DateTime.Now
        };

        Criar(venda);
        SalvarAlteracoes();

        DescartarAlteracoes();

        return venda;
    }

    public virtual Pedido? ObterPedidoPorId(long pedidoId)
    {
        return DbContext.Set<Pedido>()
            .AsNoTracking()
            .Include(pedido => pedido.Itens)
            .FirstOrDefault(pedido => pedido.Id == pedidoId);
    }

    public virtual Pedido? ObterPorIdComItensProduto(long id)
    {
        return DbContext.Set<Pedido>()
            .AsNoTracking()
            .Include(pedido => pedido.Itens)
            .ThenInclude(pedido => pedido.Item)
            .FirstOrDefault(pedido => pedido.Id == id);
    }

    public virtual IEnumerable<Pedido> ObterPedidosFinalizadosFrenteCaixaManutencao(DateTime filtrarPorDataDe, DateTime filtrarPorDataAte)
    {
        var filtrarPorDataAteUm = filtrarPorDataAte.AddDays(1);

        return DbContext.Set<Pedido>()
            .AsNoTracking()
            .Where(pedido => pedido.FinalizadoEm.HasValue
                             && !pedido.CanceladoEm.HasValue
                             && pedido.AbertoEm >= filtrarPorDataDe
                             && pedido.AbertoEm < filtrarPorDataAteUm)
            .Select(pedido => new Pedido
            {
                Id = pedido.Id,
                ValorTotal = pedido.ValorTotal,
                Volume = pedido.Volume,
                AbertoEm = pedido.AbertoEm
            })
            .ToList();
    }

    public virtual IEnumerable<Pedido> ObterPedidosCanceladosFrenteCaixaManutencao(
        DateTime filtrarPorDataDe, DateTime filtrarPorDataAte)
    {
        var filtrarPorDataAteUm = filtrarPorDataAte.AddDays(1);

        return DbContext.Set<Pedido>()
            .AsNoTracking()
            .Where(pedido => !pedido.FinalizadoEm.HasValue
                             && pedido.CanceladoEm.HasValue
                             && pedido.AbertoEm >= filtrarPorDataDe
                             && pedido.AbertoEm < filtrarPorDataAteUm)
            .Select(pedido => new Pedido
            {
                Id = pedido.Id,
                ValorTotal = pedido.ValorTotal,
                Volume = pedido.Volume,
                AbertoEm = pedido.AbertoEm
            })
            .ToList();
    }

    public virtual Pedido? ObterPedidoFrenteCaixaManutencao(long pedidoId)
    {
        return DbContext.Set<Pedido>()
            .AsNoTracking()
            .Include(pedido => pedido.Itens)
            .Where(pedido => pedido.Id == pedidoId)
            .Select(pedido => new Pedido
            {
                Id = pedido.Id,
                Itens = pedido.Itens.Select(item => new PedidoItem
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

    #region Serviços

    private readonly IServicoPedidosItens servicoPedidosItens = servicoPedidosItens
                                                                ?? throw new ArgumentNullException(
                                                                    nameof(servicoPedidosItens));

    private readonly IServicoItens servicoItens = servicoItens
                                                        ?? throw new ArgumentNullException(nameof(servicoItens));

    private readonly IServicoVendas servicoVendas = servicoVendas
                                                    ?? throw new ArgumentNullException(nameof(servicoVendas));

    private readonly IServicoVendasItens servicoVendasItens = servicoVendasItens
                                                              ?? throw new ArgumentNullException(
                                                                  nameof(servicoVendasItens));

    #endregion

    #region Métodos auxiliáres

    protected virtual Pedido? ObterPedidoAbertoPorFiltro(Expression<Func<Pedido, bool>> filtro)
    {
        return DbContext.Set<Pedido>()
            .AsNoTracking()
            .Include(pedido => pedido.Itens)
            .Where(filtro)
            .Select(x => new Pedido
            {
                Id = x.Id,
                AbertoEm = x.AbertoEm,
                ValorTotal = x.ValorTotal,
                Itens = x.Itens.Select(item => new PedidoItem
                {
                    Id = item.Id,
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

    protected virtual (Pedido, PedidoItem) ObterPedidoEPedidoItem(long pedidoId, long pedidoItemId)
    {
        var pedido =
            ObterPedidoAbertoPorFiltro(x =>
                x.Id == pedidoId && !x.FinalizadoEm.HasValue && !x.CanceladoEm.HasValue)
            ?? throw new InvalidOperationException("O pedido não foi encontrado");

        return (pedido, pedido.Itens.First(x => x.Id == pedidoItemId));
    }

    protected virtual Pedido? ObterPedidoParaCancelamento(long pedidoId)
    {
        return DbContext.Set<Pedido>()
            .Include(x => x.Itens)
            .ThenInclude(x => x.Item)
            .FirstOrDefault(x => x.Id == pedidoId && !x.CanceladoEm.HasValue);
    }

    #endregion
}