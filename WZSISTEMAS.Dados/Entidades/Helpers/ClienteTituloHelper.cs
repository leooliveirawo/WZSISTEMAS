﻿namespace WZSISTEMAS.Dados.Entidades.Helpers;

public static class ClienteTituloHelper
{
    public static decimal CalcularValorTotal(this IEnumerable<ClienteLancamento> titulos)
    {
        var valorTotal = 0m;

        foreach (var titulo in titulos)
            valorTotal += titulo.ValorLancamento;

        return valorTotal;
    }
}