namespace WZSISTEMAS.Dados.Entidades;

public class Venda : Entidade
{
    public Venda()
    {
        Itens = new HashSet<VendaItem>();
        Pagamentos = new HashSet<VendaPagamento>();
    }

    public long CaixaId { get; set; }
    public long Volume { get; set; }

    public decimal ValorTotal { get; set; }
    public decimal? ValorTotalDesconto { get; set; }
    public decimal Troco { get; set; }

    public string? CPF_CNPJ_Nota { get; set; }

    public DateTime AbertaEm { get; set; }
    public DateTime? FechadaEm { get; set; }
    public DateTime? CanceladaEm { get; set; }

    public bool EmEspera { get; set; }

    public string? CFeXml { get; set; }

    public Caixa Caixa { get; set; } = default!;
    public ICollection<VendaItem> Itens { get; set; }
    public ICollection<VendaPagamento> Pagamentos { get; set; }
}