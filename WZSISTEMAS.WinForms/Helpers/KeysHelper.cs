namespace WZSISTEMAS.WinForms.Helpers;

public static class KeysHelper
{
    public static bool Comparar(this Keys key, char valor)
        => ((char)key).Equals(valor);

    public static bool VerificarTeclaEnter(this KeyPressEventArgs e)
    {
        if (Keys.Return.Comparar(e.KeyChar))
        {
            e.Handled = true;

            return true;
        }
        else
            return false;
    }
}
