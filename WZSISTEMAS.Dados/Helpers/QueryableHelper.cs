using Microsoft.EntityFrameworkCore;

namespace WZSISTEMAS.Dados.Helpers;

public static class QueryableHelper
{
    public static IQueryable<Caixa> IncluirPropriedades_Entradas_Saidas_Suprimentos(this IQueryable<Caixa> query)
    {
        return query.Include(caixa => caixa.Entradas)
            .Include(caixa => caixa.Saidas)
            .Include(caixa => caixa.Suprimentos);
    }

    public static IQueryable<Caixa> PrepararCaixaResumido(this IQueryable<Caixa> query)
    {
        return query.IncluirPropriedades_Entradas_Saidas_Suprimentos()
            .Select(caixa => new Caixa
            {
                Id = caixa.Id,
                TerminalId = caixa.TerminalId,
                UsuarioId = caixa.UsuarioId,
                SaldoInicial = caixa.SaldoInicial,
                SaldoFinal = caixa.SaldoFinal,
                SaldoDinheiro = caixa.SaldoDinheiro,
                SaldoCheque = caixa.SaldoCheque,
                SaldoOutros = caixa.SaldoOutros,
                SaldoSuprimento = caixa.SaldoSuprimento,
                EntradaDinheiro = caixa.EntradaDinheiro,
                EntradaCheque = caixa.EntradaCheque,
                EntradaCartaoDebito = caixa.EntradaCartaoDebito,
                EntradaCartaoCredito = caixa.EntradaCartaoCredito,
                EntradaCartaoVoucher = caixa.EntradaCartaoVoucher,
                EntradaCartaoConvenio = caixa.EntradaCartaoConvenio,
                EntradaOutros = caixa.EntradaOutros,
                EntradaCanceladaDinheiro = caixa.EntradaCanceladaDinheiro,
                EntradaCanceladaCheque = caixa.EntradaCanceladaCheque,
                EntradaCanceladaCartaoDebito = caixa.EntradaCanceladaCartaoDebito,
                EntradaCanceladaCartaoCredito = caixa.EntradaCanceladaCartaoCredito,
                EntradaCanceladaCartaoVoucher = caixa.EntradaCanceladaCartaoVoucher,
                EntradaCanceladaCartaoConvenio = caixa.EntradaCanceladaCartaoConvenio,
                EntradaCanceladaOutros = caixa.EntradaCanceladaOutros,
                SaidaDinheiro = caixa.SaidaDinheiro,
                SaidaCheque = caixa.SaidaCheque,
                SaidaOutros = caixa.SaidaOutros,
                SaidaCanceladaDinheiro = caixa.SaidaCanceladaDinheiro,
                SaidaCanceladaCheque = caixa.SaidaCanceladaCheque,
                SaidaCanceladaOutros = caixa.SaidaCanceladaOutros,
                Entradas = caixa.Entradas.Select(
                        entrada => new CaixaEntrada
                        {
                            Id = entrada.Id,
                            Tipo = entrada.Tipo,
                            Valor = entrada.Valor,
                            DataEntrada = entrada.DataEntrada,
                            FoiCancelada = entrada.FoiCancelada
                        })
                    .ToList(),
                Saidas = caixa.Saidas.Select(
                        saida => new CaixaSaida
                        {
                            Id = saida.Id,
                            Tipo = saida.Tipo,
                            Valor = saida.Valor,
                            DataSaida = saida.DataSaida,
                            FoiCancelada = saida.FoiCancelada
                        })
                    .ToList(),
                Suprimentos = caixa.Suprimentos.Select(
                        suprimento => new CaixaSuprimento
                        {
                            Id = suprimento.Id,
                            Tipo = suprimento.Tipo,
                            Valor = suprimento.Valor,
                            DataSuprimento = suprimento.DataSuprimento,
                            FoiCancelado = suprimento.FoiCancelado
                        })
                    .ToList()
            });
    }
}