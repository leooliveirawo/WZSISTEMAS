namespace WZSISTEMAS.Dados.Servicos.Interfaces;

public interface IServicoTransportadoras : IServicoEntidades<Transportadora>, IServicoValidacaoEntidades<Transportadora>
{
    Transportadora? ObterPorCNPJOuCodigoReferencia(string cNPJ);
    IEnumerable<Transportadora> ListarPorRazaoSocial(string razaoSocial);
}