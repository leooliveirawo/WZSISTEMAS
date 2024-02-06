namespace WZSISTEMAS.Dados.Servicos.Interfaces;

public interface IServicoCaixas : IServicoEntidades<Caixa>
{
    Caixa? ObterCaixaResumidoPeloCaixaId(long caixaId);

    Caixa? ObterCaixaResumidoPeloUsuarioId_TerminalId_Aberto(
        long usuarioId,
        long terminalId);

    IEnumerable<Caixa> GelAllByUsuarioId(long usuarioId);

    Caixa AbrirCaixa(
        long usuarioId,
        long terminalId,
        decimal saldoInicial);

    Caixa FecharCaixa(long caixaId);

    (Caixa, CaixaEntrada) RealizarEntrada(
        long caixaId,
        TipoEntradaCaixa tipo,
        decimal valor);

    (Caixa, CaixaSuprimento) RealizarSuprimento(
        long caixaId,
        TipoSuprimentoCaixa tipo,
        decimal valor);

    (Caixa, CaixaSuprimento?) CancelarSuprimento(
        long caixaSuprimentoId,
        string motivoCancelamento);

    long? GetVendaIdByCaixaEntradaId(long caixaEntradaId);

    (Caixa, CaixaEntrada?) CancelarEntrada(long caixaEntradaId);

    (Caixa, CaixaSaida) RealizarSaida(
        long caixaId,
        TipoSaidaCaixa tipo,
        decimal valorSaida);

    (Caixa, CaixaSaida?) CancelarSaida(
        long caixaSaidaId,
        string motivoCancelamento);

    bool VerificarEntradaVinculadaVenda(long caixaEntradaId);
}