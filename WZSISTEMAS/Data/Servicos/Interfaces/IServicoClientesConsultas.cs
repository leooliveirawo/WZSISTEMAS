namespace WZSISTEMAS.Data.Servicos.Interfaces
{
    public interface IServicoClientesConsultas
    {
        Task<Cliente?> ObterPorCPF_CNPJAsync(string cPF_CNPJ);
        Task<Cliente?> ObterPorIdAsync(long id);
        Task<IEnumerable<Cliente>> ObterPorNomeCompleto_RazaoSocialAsync(string nomeCompleto_RazaoSocial);
    }
}
