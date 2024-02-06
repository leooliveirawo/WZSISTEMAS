namespace WZSISTEMAS.Dados.Entidades;

public class Entrada : Entidade
{
    public Entrada()
    {
        Itens = new HashSet<EntradaItem>();
    }

    public DateTime DataEmissao { get; set; }
    public DateTime DataSaida { get; set; }
    public DateTime DataEntrada { get; set; }
    public long TerminalId { get; set; }
    public long EmitenteId { get; set; }
    public long TransportadoraId { get; set; }
    public long DestinarioId { get; set; }

    public Terminal Terminal { get; set; } = default!;

    public Fornecedor Emitente { get; set; } = default!;
    public Transportadora Transportadora { get; set; } = default!;
    public Empresa Destinario { get; set; } = default!;

    public ICollection<EntradaItem> Itens { get; set; }
}