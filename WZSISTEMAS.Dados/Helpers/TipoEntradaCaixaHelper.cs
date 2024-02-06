namespace WZSISTEMAS.Dados.Helpers;

public static class TipoEntradaCaixaHelper
{
    public static char ObterTeclaAtalho(TipoEntradaCaixa type)
    {
        return type switch
        {
            TipoEntradaCaixa.Dinheiro => 'D',
            TipoEntradaCaixa.CartaoDebito => 'B',
            TipoEntradaCaixa.CartaoCredito => 'C',
            TipoEntradaCaixa.CartaoLoja => 'T',
            TipoEntradaCaixa.CartaoVoucher => 'V',
            TipoEntradaCaixa.Cheque => 'Q',
            TipoEntradaCaixa.Outros => 'O',
            _ => throw new NotSupportedException()
        };
    }

    public static bool CompararTecla(this TipoEntradaCaixa type, char key)
    {
        return ObterTeclaAtalho(type) == Convert.ToChar(key.ToString().ToUpper());
    }

    public static string ConverterParaString(this TipoEntradaCaixa item, bool resumido = false)
    {
        return resumido
            ? item switch
            {
                TipoEntradaCaixa.Dinheiro => "DI",
                TipoEntradaCaixa.CartaoDebito => "CD",
                TipoEntradaCaixa.CartaoCredito => "CC",
                TipoEntradaCaixa.CartaoLoja => "CN",
                TipoEntradaCaixa.CartaoVoucher => "CV",
                TipoEntradaCaixa.Cheque => "CH",
                TipoEntradaCaixa.Outros => "OU",
                _ => throw new NotSupportedException()
            }
            : item switch
            {
                TipoEntradaCaixa.Dinheiro => "Dinheiro",
                TipoEntradaCaixa.CartaoDebito => "Cartão de débito",
                TipoEntradaCaixa.CartaoCredito => "Cartão de crédito",
                TipoEntradaCaixa.CartaoLoja => "Cartão da loja",
                TipoEntradaCaixa.CartaoVoucher => "Cartão Voucher",
                TipoEntradaCaixa.Cheque => "Cheque",
                TipoEntradaCaixa.Outros => "Outros",
                _ => throw new NotSupportedException()
            };
    }

    public static IEnumerable<ItemLista<TipoEntradaCaixa>> ObterLista(bool resumido = false)
    {
        return Enum.GetValues<TipoEntradaCaixa>()
            .Select(item
                => new ItemLista<TipoEntradaCaixa>
                {
                    Descricao = item.ConverterParaString(resumido),
                    Item = item
                })
            .ToList();
    }
}