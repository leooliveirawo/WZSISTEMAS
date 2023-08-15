namespace WZSISTEMAS.Data.Servicos.Interfaces
{
    public interface IServicoClientes : IServicoClientesConsultas
    {
        Task CriarAsync(Cliente cadastro);
        Task EditarAsync(Cliente cadastro);
        Task ExcluirAsync(long id);
    }
}