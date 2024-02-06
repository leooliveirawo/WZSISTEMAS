namespace WZSISTEMAS.WinForms.Helpers;

public static class AuxiliarKeys
{
    public static bool Comparar(this Keys key, char valor)
        => ((char)key).Equals(valor);
}
