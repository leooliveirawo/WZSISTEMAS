namespace WZSISTEMAS.Dados.Servicos.Interfaces;

public interface IServicoClientes : IServicoEntidades<Cliente>, IServicoValidacaoEntidades<Cliente>
{
    Cliente? ObterPorCPF_CNPJ(string cPF_CNPJ);
    IEnumerable<Cliente> ListaPorNomeCompleto_RazaoSocial(string nomeCompleto_RazaoSocial);

    IEnumerable<Cliente> ListaConvenioPorCPF_CNPJ_NomeCompleto_RazaoSocial(
        string cPF_CNPJ_NomeCompleto_RazaoSocial);

    bool VerificarLimiteDisponivel(long clienteId, decimal valor);
}