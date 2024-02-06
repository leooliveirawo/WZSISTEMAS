namespace WZSISTEMAS.Dados.Servicos.Interfaces;

public interface IServicoEmpresas : IServicoEntidades<Empresa>, IServicoValidacaoEntidades<Empresa>
{
    Empresa? ObterPorCNPJOuCodigoReferencia(string cNPJOuCodigoReferencia);
    IEnumerable<Empresa> ListarPorRazaoSocial(string razaoSocial);
}