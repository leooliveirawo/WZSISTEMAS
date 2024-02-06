namespace WZSISTEMAS.Dados.Entidades;

public class CaixaSuprimento : Entidade
{
    public CaixaSuprimento()
    {
        Tipo = TipoSuprimentoCaixa.Dinheiro;
        DataSuprimento = DateTime.Now;
    }

    public long CaixaId { get; set; }
    public TipoSuprimentoCaixa Tipo { get; set; }
    public DateTime DataSuprimento { get; set; }
    public decimal Valor { get; set; }
    public bool FoiCancelado { get; set; }
    public DateTime? CanceladoEm { get; set; }
    public string? MotivoCancelamento { get; set; }

    public Caixa Caixa { get; set; } = default!;
}