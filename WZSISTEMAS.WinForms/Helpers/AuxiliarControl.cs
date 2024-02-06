namespace WZSISTEMAS.WinForms.Helpers;

public static class AuxiliarControl
{
    public static void Ativar(this Control control)
        => control.Enabled = true;

    public static void Desativar(this Control control)
        => control.Enabled = false;

    public static void Selecionar(this Control control)
    {
        control.Focus();
        control.Select();
    }
}
