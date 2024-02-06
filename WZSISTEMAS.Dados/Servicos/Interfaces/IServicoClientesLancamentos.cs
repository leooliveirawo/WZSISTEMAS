namespace WZSISTEMAS.Dados.Servicos.Interfaces;

public interface IServicoClientesLancamentos : IServicoEntidades<ClienteLancamento>
{
    ClienteLancamento Criar(
        long clienteId,
        long vendaPagamentoId,
        decimal valorTitulo);

    ClienteLancamento Criar(
        long clienteId,
        long vendaPagamentoId,
        decimal valorTitulo,
        Mes mesReferente,
        int anoReferente);

    IEnumerable<ClienteLancamento> CriarVarios(
        long clienteId,
        long vendaPagamentoId,
        decimal valorTitulo,
        int quantidade);

    IEnumerable<ClienteLancamento> ObterTudoPorClienteId(
        long clienteId,
        Mes mesReferente,
        int anoReferente);

   void RealizarPagamento(
        long clienteId,
        decimal valorPago,
        Mes mesReferente,
        int anoReferente);

    bool VerificarLancamentosEmAberto(long clienteId);
}