namespace WZSISTEMAS.Dados.Entidades;

public class ClienteTituloPagamento : Entidade
{
    public long ClienteId { get; set; }
    public DateTime DataLancamento { get; set; }
    public decimal ValorPagamento { get; set; }
}