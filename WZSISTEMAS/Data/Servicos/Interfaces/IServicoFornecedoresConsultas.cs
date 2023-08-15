namespace WZSISTEMAS.Data.Servicos.Interfaces
{
    public interface IServicoFornecedoresConsultas
    {
        Task<Fornecedor?> ObterPorCNPJAsync(string cNPJ);
        Task<Fornecedor?> ObterPorIdAsync(long id);
        Task<IEnumerable<Fornecedor>> ObterPorRazaoSocialAsync(string razaoSocial);
    }
}