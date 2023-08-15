namespace WZSISTEMAS.Data.Servicos.Interfaces
{
    public interface IServicoFornecedores : IServicoFornecedoresConsultas
    {
        Task CriarAsync(Fornecedor cadastro);
        Task EditarAsync(Fornecedor cadastro);
        Task ExcluirAsync(long id);        
    }
}