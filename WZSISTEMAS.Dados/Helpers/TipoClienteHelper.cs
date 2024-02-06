namespace WZSISTEMAS.Dados.Helpers;

public static class TipoClienteHelper
{
    public static string ConverterParaString(
        this TipoCliente item,
        bool resumido = false)
    {
        return resumido
            ? item switch
            {
                TipoCliente.PessoaFisica => "PF",
                TipoCliente.PessoaJuridica => "PJ",
                _ => throw new NotSupportedException()
            }
            : item switch
            {
                TipoCliente.PessoaFisica => "Pessoa Fisica (PF)",
                TipoCliente.PessoaJuridica => "Pessoa Juridica (PJ)",
                _ => throw new NotSupportedException()
            };
    }

    public static IEnumerable<ItemLista<TipoCliente>> ObterLista(
        bool resumido = false)
    {
        return Enum.GetValues<TipoCliente>()
            .Select(item => new ItemLista<TipoCliente>
            {
                Descricao = item.ConverterParaString(),
                Item = item
            })
            .ToList();
    }
}