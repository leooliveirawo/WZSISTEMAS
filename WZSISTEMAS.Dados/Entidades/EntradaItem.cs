namespace WZSISTEMAS.Dados.Entidades;

public class EntradaItem : Entidade
{
    public long EntradaId { get; set; }
    public long ItemId { get; set; }

    public string CodigoProduto { get; set; } = default!;
    public string Descricao { get; set; } = default!;
    public UnidadesMedidas UnidadeMedidaOrigem { get; set; }
    public UnidadesMedidas UnidadeMedidaDestino { get; set; }
    public decimal UnidadeMedidaConversao { get; set; }
    public decimal ValorUnitario { get; set; }
    public decimal Quantidade { get; set; }
    public decimal ValorTotal { get; set; }

    public Entrada Entrada { get; set; } = default!;
    public Item Item { get; set; } = default!;
}