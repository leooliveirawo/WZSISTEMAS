namespace WZSISTEMAS.Base.Helpers;
public static class NumerosHelper
{
    public static decimal AplicarPorcentagem(this decimal valor, decimal porcentagem)
        => valor / 100 * porcentagem + valor;

    public static decimal CalcularPorcentagem(this decimal valorCompleto, decimal valorPorcentagem)
        => valorPorcentagem * 100 / valorCompleto;
}
