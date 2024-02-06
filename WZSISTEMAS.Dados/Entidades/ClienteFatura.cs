namespace WZSISTEMAS.Dados.Entidades;

public class ClienteFatura : Entidade
{
    public long ClienteId { get; set; }

    public DiaDeFechamentoEVencimento DiaFechamentoVencimento { get; set; }

    public Mes MesReferente { get; set; }
    public int AnoReferente { get; set; }

    public decimal ValorFatura { get; set; }
    public bool ParcialmentePago { get; set; }
    public bool Pago { get; set; }
    public decimal ValorRestante { get; set; }
    public decimal ValorPago { get; set; }

    public Cliente Cliente { get; set; } = default!;

    public ICollection<ClienteLancamento> Lancamentos { get; set; } = new HashSet<ClienteLancamento>();
}