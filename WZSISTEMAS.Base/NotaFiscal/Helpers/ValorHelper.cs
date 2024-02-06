using WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;
using WZSISTEMAS.Base.Valores;

namespace WZSISTEMAS.Base.NotaFiscal.Helpers;

public static class ValorHelper
{
    public static IEnumerable<ItemLista<TiposICMS>> ObterListaTipoICMS
        => Enum.GetValues<TiposICMS>()
            .Select(item => new ItemLista<TiposICMS>
            {
                Descricao = item.ConverterParaString(),
                Item = item

            }).ToList();


    public static IEnumerable<ItemLista<TiposPIS>> ObterListaTipoPIS
        => Enum.GetValues<TiposPIS>()
            .Select(item => new ItemLista<TiposPIS>
            {
                Descricao = item.ConverterParaString(),
                Item = item

            }).ToList();

    public static IEnumerable<ItemLista<TiposCOFINS>> ObterListaTipoCOFINS
        => Enum.GetValues<TiposCOFINS>()
            .Select(item => new ItemLista<TiposCOFINS>
            {
                Descricao = item.ConverterParaString(),
                Item = item

            }).ToList();

    public static string ConverterParaString(this TiposICMS item)
        => item switch
        {
            TiposICMS.ICMS00 => "ICMS00",
            TiposICMS.ICMS10 => "ICMS10",
            TiposICMS.ICMS20 => "ICMS20",
            TiposICMS.ICMS30 => "ICMS30",
            TiposICMS.ICMS40 => "ICMS40",
            TiposICMS.ICMS51 => "ICMS50",
            TiposICMS.ICMS60 => "ICMS60",
            TiposICMS.ICMS70 => "ICMS70",
            TiposICMS.ICMS90 => "ICMS80",
            TiposICMS.ICMSSN101 => "ICMSSN101",
            TiposICMS.ICMSSN102 => "ICMSSN102",
            TiposICMS.ICMSSN201 => "ICMSSN201",
            TiposICMS.ICMSSN202 => "ICMSSN202",
            TiposICMS.ICMSSN500 => "ICMSSN500",
            TiposICMS.ICMSSN900 => "ICMSSN900",
            TiposICMS.ICMSST => "ICMSST",
            _ => throw new NotSupportedException()
        };

    public static string ConverterParaString(this TiposPIS item)
        => item switch
        {
            TiposPIS.PISAliq => "PISAliq",
            TiposPIS.PISOutr => "PISOutr",
            TiposPIS.PISQtde => "PISQntde",
            TiposPIS.PISNT => "PISNT",
            TiposPIS.PISST => "PISST",
            _ => throw new NotSupportedException()
        };

    public static string ConverterParaString(this TiposCOFINS item)
        => item switch
        {
            TiposCOFINS.COFINSAliq => "COFINSAliq",
            TiposCOFINS.COFINSST => "COFINSST",
            TiposCOFINS.COFINSNT => "COFINSNT",
            TiposCOFINS.COFINSQtde => "COFINSQtde",
            TiposCOFINS.COFINSOutr => "COFINSOutr",
            _ => throw new NotSupportedException()
        };
}
