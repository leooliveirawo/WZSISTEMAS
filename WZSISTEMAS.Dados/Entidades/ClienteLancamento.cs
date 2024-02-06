namespace WZSISTEMAS.Dados.Entidades;

public class ClienteLancamento : Entidade
{
    public long FaturaId { get; set; }
    public long VendaPagamentoId { get; set; }
    public DateTime LancadoEm { get; set; }

    public decimal ValorLancamento { get; set; }
    public bool ParcialmentePago { get; set; }
    public bool Pago { get; set; }
    public decimal ValorRestante { get; set; }
    public decimal ValorPago { get; set; }

    public ClienteFatura Fatura { get; set; } = default!;
    public VendaPagamento VendaPagamento { get; set; } = default!;
}