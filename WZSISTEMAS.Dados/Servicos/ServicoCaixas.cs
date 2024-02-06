using Microsoft.EntityFrameworkCore;
using WZSISTEMAS.Dados.Helpers;

namespace WZSISTEMAS.Dados.Servicos;

public class ServicoCaixas(
    DbContext dbContext,
    IServicoCaixasEntradas servicoEntradasCaixas,
    IServicoCaixasSaidas servicoCaixasSaidas,
    IServicoCaixasSuprimentos servicoCaixasSuprimentos) : ServicoEntidades<Caixa>(dbContext), IServicoCaixas
{
    private readonly IServicoCaixasSaidas servicoCaixasSaidas =
        servicoCaixasSaidas ?? throw new ArgumentNullException(nameof(servicoCaixasSaidas));

    private readonly IServicoCaixasSuprimentos servicoCaixasSuprimentos =
        servicoCaixasSuprimentos ?? throw new ArgumentNullException(nameof(servicoCaixasSuprimentos));

    private readonly IServicoCaixasEntradas servicoEntradasCaixas =
        servicoEntradasCaixas ?? throw new ArgumentNullException(nameof(servicoEntradasCaixas));

    public  Caixa? ObterCaixaResumidoPeloCaixaId(long caixaId)
    {
        return DbContext.Set<Caixa>()
            .AsNoTracking()
            .Where(caixa => caixa.Id == caixaId)
            .PrepararCaixaResumido()
            .FirstOrDefault();
    }

    public  Caixa AbrirCaixa(
        long usuarioId,
        long terminalId,
        decimal saldoInicial)
    {
        var caixa = ObterCaixaResumidoPeloUsuarioId_TerminalId_Aberto(
            usuarioId,
            terminalId);

        if (caixa is null)
        {
            caixa = new Caixa
            {
                UsuarioId = usuarioId,
                TerminalId = terminalId,
                SaldoInicial = saldoInicial,
                Status = CaixaStatus.Aberto,
                SaldoFinal = saldoInicial,
                SaldoDinheiro = saldoInicial
            };

            Criar(caixa);
            SalvarAlteracoes();
            DescartarAlteracoes();

            return ObterCaixaResumidoPeloCaixaId(caixa.Id)
                   ?? throw new InvalidOperationException("O caixa não foi encontrado");
        }

        return caixa;
    }

    public  (Caixa, CaixaEntrada?) CancelarEntrada(long caixaEntradaId)
    {
        var caixaEntrada = servicoEntradasCaixas.ObterPorId(
                               caixaEntradaId,
                               true,
                               true)
                           ?? throw new InvalidOperationException("A entrada do caixa não foi encontrada");

        caixaEntrada.CanceladaEm = DateTime.Now;
        caixaEntrada.FoiCancelada = true;

        caixaEntrada.Caixa.CancelarEntrada(caixaEntrada.Tipo, caixaEntrada.Valor);

        Editar(caixaEntrada.Caixa);
        servicoEntradasCaixas.Editar(caixaEntrada);

        SalvarAlteracoes();
        DescartarAlteracoes();

        var caixa = ObterCaixaResumidoPeloCaixaId(caixaEntrada.CaixaId)
                    ?? throw new InvalidOperationException("O caixa não foi encontrado");

        return (
            caixa,
            caixa.Entradas.FirstOrDefault(
                entrada => entrada.Id == caixaEntradaId)
            ?? throw new InvalidOperationException("A entrada do caixa não foi encontrada"));
    }

    public  (Caixa, CaixaSaida?) CancelarSaida(
        long caixaSaidaId,
        string motivoCancelamento)
    {
        var caixaSaida = servicoCaixasSaidas.ObterPeloId(
                             caixaSaidaId,
                             true,
                             true)
                         ?? throw new InvalidOperationException("A saida do caixa já foi cancelada");

        caixaSaida.FoiCancelada = true;
        caixaSaida.CanceladaEm = DateTime.Now;
        caixaSaida.MotivoCancelamento = motivoCancelamento;

        caixaSaida.Caixa.CancelarSaida(caixaSaida.Tipo, caixaSaida.Valor);

        Editar(caixaSaida.Caixa);
        servicoCaixasSaidas.Editar(caixaSaida);

        SalvarAlteracoes();
        DescartarAlteracoes();

        var caixa = ObterCaixaResumidoPeloCaixaId(caixaSaida.CaixaId)
                    ?? throw new InvalidOperationException("O caixa especificado não está mais aberto");

        return (
            caixa,
            caixa.Saidas.FirstOrDefault(
                saida => saida.Id == caixaSaidaId)
            ?? throw new InvalidOperationException("A saida do caixa não foi encontrada"));
    }

    public  (Caixa, CaixaSuprimento?) CancelarSuprimento(
        long caixaSuprimentoId,
        string motivoCancelamento)
    {
        var caixaSuprimento = servicoCaixasSuprimentos.ObterPeloId(
                                  caixaSuprimentoId,
                                  true,
                                  true)
                              ?? throw new InvalidOperationException("O suprimento do caixa já foi cancelado");

        caixaSuprimento.FoiCancelado = true;
        caixaSuprimento.CanceladoEm = DateTime.Now;
        caixaSuprimento.MotivoCancelamento = motivoCancelamento;

        caixaSuprimento.Caixa.CancelarSuprimento(caixaSuprimento.Tipo, caixaSuprimento.Valor);

        Editar(caixaSuprimento.Caixa);
        servicoCaixasSuprimentos.Editar(caixaSuprimento);

        DescartarAlteracoes();
        SalvarAlteracoes();

        var caixa = ObterCaixaResumidoPeloCaixaId(caixaSuprimento.CaixaId)
                    ?? throw new InvalidOperationException("O caixa especificado não está mais aberto");

        return (
            caixa,
            caixa.Suprimentos.FirstOrDefault(
                suprimento => suprimento.Id == caixaSuprimentoId)
            ?? throw new InvalidOperationException("O suprimento do caixa não foi encontrado"));
    }

    public  (Caixa, CaixaEntrada) RealizarEntrada(
        long caixaId,
        TipoEntradaCaixa tipo,
        decimal valor)
    {
        var caixa = ObterPeloIdECaixaAberto(caixaId)
                    ?? throw new InvalidOperationException("O caixa especificado não está mais aberto");

        var caixaEntrada = new CaixaEntrada
        {
            CaixaId = caixaId,
            Tipo = tipo,
            Valor = valor
        };

        caixa.IncluirEntrada(tipo, valor);

        Editar(caixa);
        servicoEntradasCaixas.Criar(caixaEntrada);

        SalvarAlteracoes();
        DescartarAlteracoes();

        caixa = ObterCaixaResumidoPeloCaixaId(caixaId)
                ?? throw new InvalidOperationException("O caixa não foi encontrado");

        return (
            caixa,
            caixa.Entradas.FirstOrDefault(
                entrada => entrada.Id == caixaEntrada.Id)
            ?? throw new InvalidOperationException("A entrada do caixa não foi encontrada"));
    }

    public  (Caixa, CaixaSaida) RealizarSaida(long caixaId, TipoSaidaCaixa tipo, decimal valorSaida)
    {
        var caixa = ObterPeloIdECaixaAberto(caixaId)
                    ?? throw new InvalidOperationException("O caixa especificado não está mais aberto");

        var caixaSaida = new CaixaSaida
        {
            CaixaId = caixaId,
            Tipo = tipo,
            Valor = valorSaida
        };

        caixa.RealizarRetirada(tipo, valorSaida);

        Editar(caixa);
        servicoCaixasSaidas.Criar(caixaSaida);

        SalvarAlteracoes();
        DescartarAlteracoes();

        caixa = ObterCaixaResumidoPeloCaixaId(caixaId)
                ?? throw new InvalidOperationException("O caixa não foi encontrado");

        return (
            caixa,
            caixa.Saidas.FirstOrDefault(
                saida => saida.Id == caixaSaida.Id)
            ?? throw new InvalidOperationException("A saida do caixa não foi encontrada"));
    }

    public  (Caixa, CaixaSuprimento) RealizarSuprimento(long caixaId, TipoSuprimentoCaixa tipo,
        decimal valor)
    {
        var caixa = ObterPeloIdECaixaAberto(caixaId)
                    ?? throw new InvalidOperationException("O caixa especificado não está mais aberto");

        var caixaSuprimento = new CaixaSuprimento
        {
            CaixaId = caixaId,
            Tipo = tipo,
            Valor = valor
        };

        caixa.IncluirSuprimento(tipo, valor);

        Editar(caixa);
        servicoCaixasSuprimentos.Criar(caixaSuprimento);

        SalvarAlteracoes();
        DescartarAlteracoes();

        caixa = ObterCaixaResumidoPeloCaixaId(caixaId)
                ?? throw new InvalidOperationException("O caixa não foi encontrado");

        return (
            caixa,
            caixa.Suprimentos.FirstOrDefault(
                suprimento => suprimento.Id == caixaSuprimento.Id)
            ?? throw new InvalidOperationException("O suprimento do caixa não foi encontrado"));
    }

    public  Caixa FecharCaixa(long caixaId)
    {
        var caixa = ObterPeloIdECaixaAberto(caixaId) ??
                    throw new InvalidOperationException("O caixa especificado não está mais aberto");

        caixa.Status = CaixaStatus.Fechado;
        caixa.FechadoEm = DateTime.Now;

        Editar(caixa);

        SalvarAlteracoes();

        DescartarAlteracoes();

        return ObterCaixaResumidoPeloCaixaId(caixaId) ??
               throw new InvalidOperationException("O caixa não foi encontrado");
    }

    public  IEnumerable<Caixa> GelAllByUsuarioId(long usuarioId)
    {
        return DbContext.Set<Caixa>()
            .AsNoTracking()
            .Where(caixa => caixa.UsuarioId == usuarioId)
            .ToList();
    }

    public  Caixa? ObterCaixaResumidoPeloUsuarioId_TerminalId_Aberto(
        long usuarioId,
        long terminalId)
    {
        return DbContext.Set<Caixa>().AsNoTracking()
            .Where(
                caixa =>
                    caixa.UsuarioId == usuarioId
                    && caixa.TerminalId == terminalId
                    && caixa.Status == CaixaStatus.Aberto)
            .PrepararCaixaResumido()
            .FirstOrDefault();
    }

    public  bool VerificarEntradaVinculadaVenda(long caixaEntradaId)
    {
        return DbContext.Set<VendaPagamento>()
            .AsNoTracking()
            .Where(vendaPagamento => vendaPagamento.CaixaEntradaId == caixaEntradaId)
            .Select(vendaPagamento => vendaPagamento.Id)
            .Any();
    }

    public  long? GetVendaIdByCaixaEntradaId(long caixaEntradaId)
    {
        return DbContext.Set<Venda>()
            .Where(venda => venda.Pagamentos.Any(
                pagamento => pagamento.CaixaEntradaId == caixaEntradaId
            ))
            .Select(venda => venda.Id)
            .FirstOrDefault();
    }

    private  Caixa? ObterPeloIdECaixaAberto(long caixaId)
    {
        return DbContext.Set<Caixa>()
            .FirstOrDefault(caixa => caixa.Id == caixaId && caixa.Status == CaixaStatus.Aberto);
    }
}