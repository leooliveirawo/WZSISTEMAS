namespace WZSISTEMAS.Data.Servicos.Interfaces
{
    public interface IServicoFuncionarios : IServicoFuncionariosConsultas
    {
        Task CriarAsync(Funcionario cadastro);
        Task EditarAsync(Funcionario cadastro);
        Task ExcluirAsync(long id);
    }
}
