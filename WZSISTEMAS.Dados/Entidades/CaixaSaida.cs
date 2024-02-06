namespace WZSISTEMAS.Dados.Entidades;

public class CaixaSaida : Entidade
{
    public CaixaSaida()
    {
        DataSaida = DateTime.Now;
        Tipo = TipoSaidaCaixa.Dinheiro;
    }

    public long CaixaId { get; set; }
    public DateTime DataSaida { get; set; }
    public TipoSaidaCaixa Tipo { get; set; }
    public decimal Valor { get; set; }
    public bool FoiCancelada { get; set; }
    public DateTime? CanceladaEm { get; set; }
    public string? MotivoCancelamento { get; set; }

    public Caixa Caixa { get; set; } = default!;
}