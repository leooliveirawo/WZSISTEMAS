namespace WZSISTEMAS.Dados.Servicos.Interfaces;

public interface IServicoItens : IServicoEntidades<Item>, IServicoValidacaoEntidades<Item>
{
    Item? ObterPorIdOuCodigoBarras(string idOuCodigoBarras);
    Item? ObterPorCodigoReferencia(string codigoReferencia);
    IEnumerable<Item> ListarPorIdCodigoBarrasCodigoReferenciaDescricao(
        string valor,
        TipoConsultaItens tipo = TipoConsultaItens.Padrao);
}