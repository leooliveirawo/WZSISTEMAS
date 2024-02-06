namespace WZSISTEMAS.Dados.Servicos.Interfaces;

public interface IServicoClientesFaturas : IServicoEntidades<ClienteFatura>
{
    ClienteFatura? ObterPorId(
        long id,
        bool usarTracking = false,
        bool incluirLancamentos = false,
        bool incluirCliente = false);

    ClienteFatura? ObterPorClienteId(
        long clienteId,
        Mes mesReferente,
        int anoReferentes,
        bool usarTracking = false,
        bool incluirLancamentos = false,
        bool incluirCliente = false);

    ClienteFatura? ListarPorClienteId(
        long clienteId,
        bool incluirLancamentos = false,
        bool incluirCliente = false);
}