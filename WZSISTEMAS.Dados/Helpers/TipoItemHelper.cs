namespace WZSISTEMAS.Dados.Helpers;

public static class TipoItemHelper
{
    public static string ConverterParaString(
        this TipoItem tipoItem,
        bool resumido = false)
    {
        return resumido
            ? tipoItem switch
            {
                TipoItem.Servico => "SERV",
                TipoItem.Produto => "PROD",
                _ => throw new NotSupportedException()
            }
            : tipoItem switch
            {
                TipoItem.Servico => "Serviço",
                TipoItem.Produto => "Produto",
                _ => throw new NotSupportedException()
            };
    }

    public static IEnumerable<ItemLista<TipoItem>> ObterLista(
        bool resumido = false)
    {
        return Enum.GetValues<TipoItem>()
            .Select(item => new ItemLista<TipoItem>
            {
                Descricao = item.ConverterParaString(),
                Item = item
            })
            .ToList();
    }
}