using WZSISTEMAS.Caixas;
using WZSISTEMAS.Dados.Entidades;
using WZSISTEMAS.Dados.Valores;

namespace WZSISTEMAS.Helpers;

public static class CaixaHelper
{
    public static string ConverterParaString(this TiposCaixaMovimentacao tipo, bool resumido = false)
    {
        return resumido
            ? tipo switch
            {
                TiposCaixaMovimentacao.Dinheiro => "DI",
                TiposCaixaMovimentacao.CartaoDebito => "CD",
                TiposCaixaMovimentacao.CartaoCredito => "CC",
                TiposCaixaMovimentacao.CartaoConvenio => "CN",
                TiposCaixaMovimentacao.CartaoVoucher => "CV",
                TiposCaixaMovimentacao.Cheque => "CH",
                TiposCaixaMovimentacao.Outros => "OU",
                _ => throw new NotSupportedException()
            }
            : tipo switch
            {
                TiposCaixaMovimentacao.Dinheiro => "Dinheiro",
                TiposCaixaMovimentacao.CartaoDebito => "Cartão de Débito",
                TiposCaixaMovimentacao.CartaoCredito => "Cartão de Crédito",
                TiposCaixaMovimentacao.CartaoConvenio => "Cartão de convênio",
                TiposCaixaMovimentacao.CartaoVoucher => "Cartão Voucher",
                TiposCaixaMovimentacao.Cheque => "Cheque",
                TiposCaixaMovimentacao.Outros => "Outros",
                _ => throw new NotSupportedException()
            };
    }

    public static string ConverterParaTextoCaixaMovimentacao(this Caixa caixa)
        => "SALDO INICIAL (I)";

    public static string ConverterParaTextoCaixaMovimentacao(this CaixaEntrada caixaEntrada)
        => "ENTRADA (+)";

    public static string ConverterParaTextoCaixaMovimentacao(this CaixaSaida caixaSaida)
        => "SAÍDA (-)";

    public static string ConverterParaTextoCaixaMovimentacao(this CaixaSuprimento caixaSuprimento)
        => "SUPRIMENTO (S)";

    public static TiposCaixaMovimentacao ConverterParaTipoCaixaMovimentacao(this TipoEntradaCaixa tipo)
    {
        return tipo switch
        {
            TipoEntradaCaixa.Dinheiro => TiposCaixaMovimentacao.Dinheiro,
            TipoEntradaCaixa.CartaoDebito => TiposCaixaMovimentacao.CartaoDebito,
            TipoEntradaCaixa.CartaoCredito => TiposCaixaMovimentacao.CartaoCredito,
            TipoEntradaCaixa.CartaoLoja => TiposCaixaMovimentacao.CartaoConvenio,
            TipoEntradaCaixa.CartaoVoucher => TiposCaixaMovimentacao.CartaoVoucher,
            TipoEntradaCaixa.Cheque => TiposCaixaMovimentacao.Cheque,
            TipoEntradaCaixa.Outros => TiposCaixaMovimentacao.Outros,
            _ => throw new NotSupportedException()
        };
    }

    public static TiposCaixaMovimentacao ConverterParaTipoCaixaMovimentacao(this TipoSaidaCaixa tipo)
    {
        return tipo switch
        {
            TipoSaidaCaixa.Dinheiro => TiposCaixaMovimentacao.Dinheiro,
            TipoSaidaCaixa.Cheque => TiposCaixaMovimentacao.Cheque,
            TipoSaidaCaixa.Outros => TiposCaixaMovimentacao.Outros,
            _ => throw new NotSupportedException()
        };
    }

    public static TiposCaixaMovimentacao ConverterParaTipoCaixaMovimentacao(this TipoSuprimentoCaixa tipo)
    {
        return tipo switch
        {
            TipoSuprimentoCaixa.Dinheiro => TiposCaixaMovimentacao.Dinheiro,
            TipoSuprimentoCaixa.Cheque => TiposCaixaMovimentacao.Cheque,
            TipoSuprimentoCaixa.Outros => TiposCaixaMovimentacao.Outros,
            _ => throw new NotSupportedException()
        };
    }
}
