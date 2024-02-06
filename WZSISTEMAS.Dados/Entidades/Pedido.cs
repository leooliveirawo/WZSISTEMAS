namespace WZSISTEMAS.Dados.Entidades;

public class Pedido : Entidade
{
    public Pedido()
    {
        Itens = new HashSet<PedidoItem>();
    }

    public long FuncionarioId { get; set; }
    public decimal ValorTotal { get; set; }
    public decimal? ValorTotalDesconto { get; set; }
    public long Volume { get; set; }

    public DateTime AbertoEm { get; set; }
    public DateTime? FinalizadoEm { get; set; }
    public DateTime? CanceladoEm { get; set; }

    public Funcionario Funcionario { get; set; } = default!;

    public ICollection<PedidoItem> Itens { get; set; }
}