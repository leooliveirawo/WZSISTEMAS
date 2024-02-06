namespace WZSISTEMAS.Dados.Servicos.Interfaces;

public interface IServicoFornecedores : IServicoEntidades<Fornecedor>, IServicoValidacaoEntidades<Fornecedor>
{
    Fornecedor? ObterPorCNPJ(string cNPJ);
    IEnumerable<Fornecedor> ListarPorRazaoSocial(string razaoSocial);
}