namespace WZSISTEMAS.Base.Helpers;

public static class UFsHelpers
{
    public static UFs ConverterDeString(this string texto)
        => texto switch
        {
            "AC" => UFs.AC,
            "AL" => UFs.AL,
            "AM" => UFs.AM,
            "AP" => UFs.AP,
            "BA" => UFs.BA,
            "CE" => UFs.CE,
            "DF" => UFs.DF,
            "ES" => UFs.ES,
            "GO" => UFs.GO,
            "MA" => UFs.MA,
            "MG" => UFs.MG,
            "MS" => UFs.MS,
            "MT" => UFs.MT,
            "PA" => UFs.PA,
            "PB" => UFs.PB,
            "PE" => UFs.PE,
            "PI" => UFs.PI,
            "PR" => UFs.PR,
            "RJ" => UFs.RJ,
            "RN" => UFs.RN,
            "RR" => UFs.RR,
            "RO" => UFs.RO,
            "RS" => UFs.RS,
            "SC" => UFs.SC,
            "SE" => UFs.SE,
            "SP" => UFs.SP,
            "TO" => UFs.TO,
            _ => throw new NotImplementedException()
        };

    public static string ConverterParaString(this UFs item)
        => item switch
        {
            UFs.AC => "Acre (AC)",
            UFs.AL => "Alagoas (AL)",
            UFs.AM => "Amazonas (AM)",
            UFs.AP => "Amapá (AP)",
            UFs.BA => "Bahia (BA)",
            UFs.CE => "Ceará (CE)",
            UFs.DF => "Distrito Federal (DF)",
            UFs.ES => "Espírito Santo (ES)",
            UFs.GO => "Goiás (GO)",
            UFs.MA => "Maranhão (MA)",
            UFs.MG => "Minas Gerais (MG)",
            UFs.MS => "Mato Grosso do Sul (MS)",
            UFs.MT => "Mato Grosso (MT)",
            UFs.PA => "Pará (PA)",
            UFs.PB => "Paraíba (PB)",
            UFs.PE => "Pernambuco (PE)",
            UFs.PI => "Piauí (PI)",
            UFs.PR => "Paraná (PR)",
            UFs.RJ => "Rio de Janeiro (RJ)",
            UFs.RN => "Rio Grande do Norte (RN)",
            UFs.RR => "Roraima (RR)",
            UFs.RO => "Rondonia (RO)",
            UFs.RS => "Rio Grande do Sul (RS)",
            UFs.SC => "Santa Catarina (SC)",
            UFs.SE => "Sergipe (SE)",
            UFs.SP => "São Paulo (SP)",
            UFs.TO => "Tocantins (TO)",
            _ => throw new NotSupportedException()
        };

    public static IEnumerable<ItemLista<UFs>> ObterLista()
    {
        var itens = new List<ItemLista<UFs>>();

        foreach (var item in Enum.GetValues<UFs>())
            itens.Add(new ItemLista<UFs>
            {
                Descricao = item.ConverterParaString(),
                Item = item
            });

        return itens;
    }
}
