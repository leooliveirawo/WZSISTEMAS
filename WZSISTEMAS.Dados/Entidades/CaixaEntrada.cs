namespace WZSISTEMAS.Dados.Entidades;

public class CaixaEntrada : Entidade
{
    public CaixaEntrada()
    {
        DataEntrada = DateTime.Now;
        Tipo = TipoEntradaCaixa.Dinheiro;
    }

    public long CaixaId { get; set; }
    public DateTime DataEntrada { get; set; }
    public TipoEntradaCaixa Tipo { get; set; }
    public decimal Valor { get; set; }
    public DateTime? CanceladaEm { get; set; }
    public bool FoiCancelada { get; set; }
    public string? MotivoCancelamento { get; set; }

    public Caixa Caixa { get; set; } = default!;

    public VendaPagamento? VendaPagamento { get; set; }
}