﻿namespace WZSISTEMAS.Base.Helpers;

public static class StringHelper
{
    public static string? ObterStringNula(this string texto)
        => string.IsNullOrEmpty(texto)
        ? default
        : texto;

    public static int ConverterParaInt(this string texto)
    {
        int.TryParse(texto, out var saida);

        return saida;
    }

    public static long ConverterParaLong(this string texto)
    {
        long.TryParse(texto, out var saida);

        return saida;
    }

    public static decimal ConverterParaDecimal(this string texto)
    {
        decimal.TryParse(texto, out var saida);

        return saida;
    }

    public static void ConverterParaDecimal(
        this string texto,
        out decimal numero)
        => decimal.TryParse(texto, out numero);

    public static decimal? ConverterParaDecimalNulo(this string texto)
        => decimal.TryParse(
            texto, 
            out var saida)
        ? saida
        : (decimal?)default;

    public static void ConverterParaDecimalNulo(
        this string texto,
        out decimal? numero)
        => numero = !decimal.TryParse(
            texto, 
            out var saida)
        ? saida :
        (decimal?)default;
}