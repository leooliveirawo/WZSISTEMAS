namespace WZSISTEMAS.Base.Helpers;

public static class MesesHelper
{
    public static string ConverterParaString(this Mes item)
        => item switch
        {
            Mes.Janeiro => "Janeiro",
            Mes.Fevereiro => "Fevereiro",
            Mes.Marco => "Março",
            Mes.Abril => "Abril",
            Mes.Maio => "Maio",
            Mes.Junho => "Junho",
            Mes.Julho => "Julho",
            Mes.Agosto => "Agosto",
            Mes.Setembro => "Setembro",
            Mes.Outubro => "Outubro",
            Mes.Novembro => "Novembro",
            Mes.Dezembro => "Dezembro",
            _ => throw new NotSupportedException()
        };

    public static IEnumerable<ItemLista<Mes>> CriarLista()
    {
        var itens = new List<ItemLista<Mes>>();

        foreach (var item in Enum.GetValues<Mes>())
            itens.Add(new ItemLista<Mes>
            {
                Descricao = item.ConverterParaString(),
                Item = item
            });

        return itens;
    }
}
