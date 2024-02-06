namespace WZSISTEMAS.WinForms.Helpers;

public static class AuxiliarLabel
{
    public static void Clear(
        this Label label,
        string valorPadrao = "")
        => label.Text = valorPadrao;
}
