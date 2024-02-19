namespace WZSISTEMAS.Utiliarios;

public class ItemDerivado
{
    public long Id { get; set; }
    public string Descricao { get; set; } = default!;
    public decimal PesoKG { get; set; }
    public decimal CustoRealKG { get; set; }
    public decimal MargemLucro { get; set; }
    public decimal PrecoFinalKG { get; set; }

}