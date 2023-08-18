namespace WZSISTEMAS.Data.Servicos.Interfaces
{
    public interface IServicoCargosConsultas
    {
        Task<IEnumerable<Cargo>> ObterPorNomeAsync(string nome);
        Task<Cargo?> ObterPorIdAsync(long id);
        Task<IEnumerable<Cargo>> ListarAsync();
    }
}
