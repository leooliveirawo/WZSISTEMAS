namespace WZSISTEMAS.Data.Servicos.Interfaces
{
    public interface IServicoFuncionariosConsultas
    {
        Task<Funcionario?> ObterPorCPFAsync(string cPF);
        Task<Funcionario?> ObterPorIdAsync(long id);
        Task<IEnumerable<Funcionario>> ObterPorNomeCompletoAsync(string nomeCompleto);
    }
}
