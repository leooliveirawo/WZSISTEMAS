using System.ComponentModel.DataAnnotations.Schema;

namespace WZSISTEMAS.Dados.Entidades;

public class VendaPagamento : Entidade
{
    public long VendaId { get; set; }
    public long CaixaEntradaId { get; set; }

    public DateTime? CanceladoEm { get; set; }

    public TipoEntradaCaixa Tipo { get; set; }
    public decimal ValorPago { get; set; }
    public decimal ValorPagoLiquido { get; set; }

    public Venda Venda { get; set; } = default!;
    public CaixaEntrada CaixaEntrada { get; set; } = default!;

    [NotMapped] public long? ClienteId { get; set; }

    [NotMapped] public int? ClienteLancamentosNumero { get; set; }

    public ICollection<ClienteLancamento> ClientesTitulos { get; set; }
        = new HashSet<ClienteLancamento>();
}