namespace WZSISTEMAS.Dados.Helpers;

public static class TipoSaidaCaixaHelper
{
    public static string ConverterParaString(
        this TipoSaidaCaixa item,
        bool resumido = false)
    {
        return resumido
            ? item switch
            {
                TipoSaidaCaixa.Dinheiro => "DI",
                TipoSaidaCaixa.Cheque => "CH",
                TipoSaidaCaixa.Outros => "OU",
                _ => throw new NotSupportedException()
            }
            : item switch
            {
                TipoSaidaCaixa.Dinheiro => "Dinheiro",
                TipoSaidaCaixa.Cheque => "Cheque",
                TipoSaidaCaixa.Outros => "Outros",
                _ => throw new NotSupportedException()
            };
    }

    public static IEnumerable<ItemLista<TipoSaidaCaixa>> ObterLista(
        bool resumido = false)
    {
        return Enum.GetValues<TipoSaidaCaixa>()
            .Select(item => new ItemLista<TipoSaidaCaixa>
            {
                Descricao = item.ConverterParaString(resumido),
                Item = item
            })
            .ToList();
    }
}