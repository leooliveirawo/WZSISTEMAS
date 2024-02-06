namespace WZSISTEMAS.Dados.Servicos.Interfaces;

public interface IServicoPedidos : IServicoEntidades<Pedido>
{
    Pedido? ObterPorIdComItensProduto(long id);
    Pedido? ObterPedidoEmAbertoComItens(long pedidoId);
    Pedido NovoPedido(long funcionarioId);
    bool CancelarPedido(long pedidoId);
    Venda ConverterParaVenda(long pedidoId, long terminalId, long caixaId);

    Pedido? ObterPedidoPorId(long pedidoId);

    (Pedido, PedidoItem) AdicionarItem(long pedidoId, long itemId, decimal precoUnitario,
        decimal quantidade = 1);

    Pedido ExcluirItem(long pedidoItemId);

    IEnumerable<Pedido> ObterPedidosEmAbertoFrenteCaixa(DateTime filtrarPorDataDe, DateTime filtrarPorDataAte);

    IEnumerable<Pedido> ObterPedidosFinalizadosFrenteCaixaManutencao(DateTime filtrarPorDataDe, DateTime filtrarPorDataAte);

    IEnumerable<Pedido> ObterPedidosCanceladosFrenteCaixaManutencao(DateTime filtrarPorDataDe, DateTime filtrarPorDataAte);

    Pedido? ObterPedidoFrenteCaixaManutencao(long pedidoId);
}