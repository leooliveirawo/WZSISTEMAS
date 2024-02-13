using WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;
using WZSISTEMAS.Dados.Entidades.Interfaces;

namespace WZSISTEMAS.Dados.Entidades;

public class Item : Entidade, IItem
{
    public Item()
    {
        ModoItem = ModosItem.Padrao;
        UnidadeMedida = UnidadesMedidas.Unidade_UNID;

        TipoICMS = TiposICMS.ICMS00;
        TipoPIS = TiposPIS.PISAliq;
        TipoCOFINS = TiposCOFINS.COFINSAliq;

        VendasItens = new HashSet<VendaItem>();
        EntradasItens = new HashSet<EntradaItem>();
        PedidosItens = new HashSet<PedidoItem>();

        ItensDerivados = new HashSet<Item>();
    }

    public string? DescricaoPDV { get; set; }

    public string? CodigoAuxiliarBalanca { get; set; }
    public bool GerarDadosAuxiliarBalanca { get; set; }
    public bool UsarBalancaCheckout { get; set; }

    public decimal? CustoReal { get; set; }
    public decimal? MargemLucro { get; set; }
    public decimal PrecoFinal { get; set; }

    public decimal? CustoReal2 { get; set; }
    public decimal? MargemLucro2 { get; set; }
    public decimal? PrecoFinal2 { get; set; }

    public decimal? CustoReal3 { get; set; }
    public decimal? MargemLucro3 { get; set; }
    public decimal? PrecoFinal3 { get; set; }

    public bool MultiplosPrecos { get; set; }
    public ModosItem ModoItem { get; set; }

    public long EstoqueAtual { get; set; }
    public long EstoqueMinimo { get; set; }
    public bool GerenciarEstoque { get; set; }
    public bool NotificarEstoqueBaixo { get; set; }

    public ICollection<VendaItem> VendasItens { get; set; }
    public ICollection<EntradaItem> EntradasItens { get; set; }
    public ICollection<PedidoItem> PedidosItens { get; set; }

    public string CodigoBarras { get; set; } = default!;
    public string? CodigoReferencia { get; set; }
    public string Descricao { get; set; } = default!;
    public TipoItem TipoItem { get; set; }
    public UnidadesMedidas UnidadeMedida { get; set; }

    public string NCM { get; set; } = default!;
    public string CFOP { get; set; } = default!;

    public TiposICMS TipoICMS { get; set; }
    public string ICMS { get; set; } = default!;

    public TiposPIS TipoPIS { get; set; }
    public string PIS { get; set; } = default!;

    public TiposCOFINS TipoCOFINS { get; set; }
    public string COFINS { get; set; } = default!;

    public long? ItemPrincipalId { get; set; }

    public Item? ItemPrincipal { get; set; }

    public ICollection<Item> ItensDerivados { get; set; }
}