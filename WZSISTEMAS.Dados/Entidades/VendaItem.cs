using WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;
using WZSISTEMAS.Dados.Entidades.Interfaces;

namespace WZSISTEMAS.Dados.Entidades;

public class VendaItem : Entidade, IItemItem
{
    public long VendaId { get; set; }

    public Venda Venda { get; set; } = default!;
    public Item Item { get; set; } = default!;
    public long ItemId { get; set; }

    public DateTime? CanceladoEm { get; set; }

    public string Descricao { get; set; } = default!;
    public string CodigoBarras { get; set; } = default!;
    public string? CodigoReferencia { get; set; }
    public UnidadesMedidas UnidadeMedida { get; set; }
    public TipoItem TipoItem { get; set; }

    public string NCM { get; set; } = default!;
    public string CFOP { get; set; } = default!;

    public TiposICMS TipoICMS { get; set; }
    public string ICMS { get; set; } = default!;

    public TiposPIS TipoPIS { get; set; }
    public string PIS { get; set; } = default!;

    public TiposCOFINS TipoCOFINS { get; set; }
    public string COFINS { get; set; } = default!;

    public decimal ValorUnitario { get; set; }
    public decimal? ValorUnitarioDesconto { get; set; }

    public decimal Quantidade { get; set; }

    public decimal ValorTotal { get; set; }
    public decimal? ValorTotalDesconto { get; set; }

    public string DescricaoFormatada()
    {
        if (TipoItem == TipoItem.Produto)
            return Descricao;

        return $"{Descricao} (SERVIÇO)";
    }
}