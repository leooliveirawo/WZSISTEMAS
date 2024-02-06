namespace WZSISTEMAS.Dados.Helpers;

public static class TipoSuprimentoCaixaHelper
{
    public static string ConverterParaString(
        this TipoSuprimentoCaixa item,
        bool resumido = false)
    {
        return resumido
            ? item switch
            {
                TipoSuprimentoCaixa.Dinheiro => "DI",
                TipoSuprimentoCaixa.Cheque => "CH",
                TipoSuprimentoCaixa.Outros => "OU",
                _ => throw new NotSupportedException()
            }
            : item switch
            {
                TipoSuprimentoCaixa.Dinheiro => "Dinheiro",
                TipoSuprimentoCaixa.Cheque => "Cheque",
                TipoSuprimentoCaixa.Outros => "Outros",
                _ => throw new NotSupportedException()
            };
    }

    public static IEnumerable<ItemLista<TipoSuprimentoCaixa>> ObterLista(
        bool resumido = false)
    {
        return Enum.GetValues<TipoSuprimentoCaixa>()
            .Select(item => new ItemLista<TipoSuprimentoCaixa>
            {
                Descricao = item.ConverterParaString(resumido),
                Item = item
            })
            .ToList();
    }
}