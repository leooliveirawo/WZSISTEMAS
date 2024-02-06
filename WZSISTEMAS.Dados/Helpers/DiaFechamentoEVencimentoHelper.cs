namespace WZSISTEMAS.Dados.Helpers;

public static class DiaFechamentoEVencimentoHelper
{
    public static string ConverterParaString(
        this DiaDeFechamentoEVencimento item)
    {
        return item switch
        {
            DiaDeFechamentoEVencimento.Dia1_8 => "Dia 1 (Dia 8)",
            DiaDeFechamentoEVencimento.Dia2_9 => "Dia 2 (Dia 9)",
            DiaDeFechamentoEVencimento.Dia3_10 => "Dia 3 (Dia 10)",
            DiaDeFechamentoEVencimento.Dia3_11 => "Dia 4 (Dia 11)",
            DiaDeFechamentoEVencimento.Dia5_12 => "Dia 5 (Dia 12)",
            DiaDeFechamentoEVencimento.Dia6_13 => "Dia 6 (Dia 13)",
            DiaDeFechamentoEVencimento.Dia7_14 => "Dia 7 (Dia 14)",
            DiaDeFechamentoEVencimento.Dia8_15 => "Dia 8 (Dia 15)",
            DiaDeFechamentoEVencimento.Dia9_16 => "Dia 9 (Dia 16)",
            DiaDeFechamentoEVencimento.Dia10_17 => "Dia 10 (Dia 17)",
            DiaDeFechamentoEVencimento.Dia11_18 => "Dia 11 (Dia 18)",
            DiaDeFechamentoEVencimento.Dia12_19 => "Dia 12 (Dia 19)",
            DiaDeFechamentoEVencimento.Dia13_20 => "Dia 13 (Dia 20)",
            DiaDeFechamentoEVencimento.Dia14_21 => "Dia 14 (Dia 21)",
            DiaDeFechamentoEVencimento.Dia15_22 => "Dia 15 (Dia 22)",
            DiaDeFechamentoEVencimento.Dia16_23 => "Dia 16 (Dia 23)",
            DiaDeFechamentoEVencimento.Dia17_24 => "Dia 17 (Dia 24)",
            DiaDeFechamentoEVencimento.Dia18_25 => "Dia 18 (Dia 25)",
            DiaDeFechamentoEVencimento.Dia19_26 => "Dia 19 (Dia 26)",
            DiaDeFechamentoEVencimento.Dia20_27 => "Dia 20 (Dia 27)",
            DiaDeFechamentoEVencimento.Dia21_28 => "Dia 21 (Dia 28)",
            _ => throw new NotSupportedException()
        };
    }

    public static int ObterDiaFechamento(this DiaDeFechamentoEVencimento item)
    {
        return item switch
        {
            DiaDeFechamentoEVencimento.Dia1_8 => 1,
            DiaDeFechamentoEVencimento.Dia2_9 => 2,
            DiaDeFechamentoEVencimento.Dia3_10 => 3,
            DiaDeFechamentoEVencimento.Dia3_11 => 4,
            DiaDeFechamentoEVencimento.Dia5_12 => 5,
            DiaDeFechamentoEVencimento.Dia6_13 => 6,
            DiaDeFechamentoEVencimento.Dia7_14 => 7,
            DiaDeFechamentoEVencimento.Dia8_15 => 8,
            DiaDeFechamentoEVencimento.Dia9_16 => 9,
            DiaDeFechamentoEVencimento.Dia10_17 => 10,
            DiaDeFechamentoEVencimento.Dia11_18 => 11,
            DiaDeFechamentoEVencimento.Dia12_19 => 12,
            DiaDeFechamentoEVencimento.Dia13_20 => 13,
            DiaDeFechamentoEVencimento.Dia14_21 => 14,
            DiaDeFechamentoEVencimento.Dia15_22 => 15,
            DiaDeFechamentoEVencimento.Dia16_23 => 16,
            DiaDeFechamentoEVencimento.Dia17_24 => 17,
            DiaDeFechamentoEVencimento.Dia18_25 => 18,
            DiaDeFechamentoEVencimento.Dia19_26 => 19,
            DiaDeFechamentoEVencimento.Dia20_27 => 20,
            DiaDeFechamentoEVencimento.Dia21_28 => 21,
            _ => throw new NotSupportedException()
        };
    }

    public static int ObterDiaVencimento(this DiaDeFechamentoEVencimento item)
    {
        return item switch
        {
            DiaDeFechamentoEVencimento.Dia1_8 => 8,
            DiaDeFechamentoEVencimento.Dia2_9 => 9,
            DiaDeFechamentoEVencimento.Dia3_10 => 10,
            DiaDeFechamentoEVencimento.Dia3_11 => 11,
            DiaDeFechamentoEVencimento.Dia5_12 => 12,
            DiaDeFechamentoEVencimento.Dia6_13 => 13,
            DiaDeFechamentoEVencimento.Dia7_14 => 14,
            DiaDeFechamentoEVencimento.Dia8_15 => 15,
            DiaDeFechamentoEVencimento.Dia9_16 => 16,
            DiaDeFechamentoEVencimento.Dia10_17 => 17,
            DiaDeFechamentoEVencimento.Dia11_18 => 18,
            DiaDeFechamentoEVencimento.Dia12_19 => 19,
            DiaDeFechamentoEVencimento.Dia13_20 => 20,
            DiaDeFechamentoEVencimento.Dia14_21 => 21,
            DiaDeFechamentoEVencimento.Dia15_22 => 22,
            DiaDeFechamentoEVencimento.Dia16_23 => 23,
            DiaDeFechamentoEVencimento.Dia17_24 => 24,
            DiaDeFechamentoEVencimento.Dia18_25 => 25,
            DiaDeFechamentoEVencimento.Dia19_26 => 26,
            DiaDeFechamentoEVencimento.Dia20_27 => 27,
            DiaDeFechamentoEVencimento.Dia21_28 => 28,
            _ => throw new NotSupportedException()
        };
    }

    public static IEnumerable<ItemLista<DiaDeFechamentoEVencimento>> ObterLista()
    {
        var itens = new List<ItemLista<DiaDeFechamentoEVencimento>>();

        foreach (var item in Enum.GetValues<DiaDeFechamentoEVencimento>())
            itens.Add(new ItemLista<DiaDeFechamentoEVencimento>
            {
                Descricao = item.ConverterParaString(),
                Item = item
            });

        return itens;
    }
}