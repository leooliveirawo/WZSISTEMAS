namespace WZSISTEMAS.Dados.Servicos.Interfaces;

public interface IServicoPedidosItens : IServicoEntidades<PedidoItem>
{
    PedidoItem Criar(long pedidoId, long itemId, decimal precoUnitario, decimal quantidade = 1);
    PedidoItem? ObterPedidoItemParaExcluirItem(long pedidoItemId);
    IEnumerable<PedidoItem> ObterTudoPorPedidoId(long pedidoId);
}