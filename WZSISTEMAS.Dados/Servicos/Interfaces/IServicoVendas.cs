namespace WZSISTEMAS.Dados.Servicos.Interfaces;

public interface IServicoVendas : IServicoEntidades<Venda>
{
    Venda? ObterPorIdComItensProduto(long id);
    Venda? ObterVendaAbertaPorCaixaId(long caixaId);
    Venda NovaVenda(long caixaId);
   void ColocarVendaEmEspera(long vendaId);
    bool CancelarVenda(long vendaId);
    Venda RetirarVendaEspera(long vendaId, long caixaId);
    (Venda, string) FecharVenda(long vendaId, IEnumerable<VendaPagamento> vendaPagamento, decimal troco = 0);

    IEnumerable<Venda> ObterVendasEmEspera(DateTime filtrarPorDataDe, DateTime filtrarPorDataAte);

    IEnumerable<Venda> ObterVendasFinalizadasFrenteCaixaManutencao(DateTime filtrarPorDataDe,
        DateTime filtrarPorDataAte);

    IEnumerable<Venda> ObterVendasCanceladasFrenteCaixaManutencao(DateTime filtrarPorDataDe,
        DateTime filtrarPorDataAte);

    Venda? ObterVendaPorId(long vendaId);
    Venda? ObterVendaEmEsperaComItens(long vendaId);
    Venda? ObterVendaFrenteCaixaManutencao(long vendaId);

    (Venda, VendaItem) AdicionarItem(long vendaId, long itemId, decimal precoUnitario,
        decimal quantidade = 1);

    Venda ExcluirItem(long vendaItemId);

    Venda? ObterPorIdCFe(long id);
    string? ObterCFeXmlPorId(long id);
}