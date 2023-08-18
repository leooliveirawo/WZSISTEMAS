namespace WZSISTEMAS.Data.Servicos.Interfaces
{
    public interface IServicoCargos : IServicoCargosConsultas
    {
        Task CriarAsync(Cargo cadastro);
        Task EditarAsync(Cargo cadastro);
        Task ExcluirAsync(long id);
    }
}
