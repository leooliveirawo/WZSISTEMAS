namespace WZSISTEMAS.Dados.Servicos.Interfaces;

public interface IServicoProdutos : IServicoEntidades<Item>, IServicoValidacaoEntidades<Item>
{
    Item? ObterPorIdOuCodigoBarras(string idOuCodigoBarras);
    Item? ObterPorCodigoReferencia(string codigoReferencia);
    IEnumerable<Item> ListarPorDescricao(string descricao);
}