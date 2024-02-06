namespace WZSISTEMAS.Dados.Helpers;

public static class UnidadeMedidaHelper
{
    public static string ConverterParaString(this UnidadesMedidas item, bool resumido = false)
    {
        return resumido
            ? item switch
            {
                UnidadesMedidas.Caixa_CX => "CX",
                UnidadesMedidas.Centimetro_CM => "CM",
                UnidadesMedidas.Duzia_DZ => "DZ",
                UnidadesMedidas.Grama_G => "G",
                UnidadesMedidas.MeiaCaixa_MCX => "MCX",
                UnidadesMedidas.MeiaDuzia_MDZ => "MDZ",
                UnidadesMedidas.Metro_M => "M",
                UnidadesMedidas.Milimetro_MM => "MM",
                UnidadesMedidas.Quilograma_KG => "KG",
                UnidadesMedidas.Unidade_UNID => "UND",
                _ => throw new NotSupportedException()
            }
            : item switch
            {
                UnidadesMedidas.Caixa_CX => "Caixa (CX)",
                UnidadesMedidas.Centimetro_CM => "Centimetro (CM)",
                UnidadesMedidas.Duzia_DZ => "Duzia (DZ)",
                UnidadesMedidas.Grama_G => "Grama (G)",
                UnidadesMedidas.MeiaCaixa_MCX => "Meia Caixa (MCX)",
                UnidadesMedidas.MeiaDuzia_MDZ => "Meia Duzia (MDZ)",
                UnidadesMedidas.Metro_M => "Metro (M)",
                UnidadesMedidas.Milimetro_MM => "Milimetro (MM)",
                UnidadesMedidas.Quilograma_KG => "Quilograma (KG)",
                UnidadesMedidas.Unidade_UNID => "Unidade (UND)",
                _ => throw new NotSupportedException()
            };
    }

    public static IEnumerable<ItemLista<UnidadesMedidas>> ObterLista(bool resumido = false)
    {
        return Enum.GetValues<UnidadesMedidas>()
            .Select(item => new ItemLista<UnidadesMedidas>
            {
                Descricao = item.ConverterParaString(),
                Item = item
            })
            .ToList();
    }
}