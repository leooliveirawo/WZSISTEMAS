namespace WZSISTEMAS.Dados.Servicos.Interfaces;

public interface IServicoVendasItens : IServicoEntidades<VendaItem>
{
    VendaItem Criar(long vendaId, long itemId, decimal precoUnitario, decimal quantidade = 1);
    VendaItem? ObterVendaItemParaExcluirItem(long vendaItemId);
}