namespace WZSISTEMAS.WinForms.Helpers;

public static class AuxiliarRadioButton
{
    public static void Marcar(this RadioButton radioButton)
        => radioButton.Checked = true;

    public static void Desmarcar(this RadioButton radioButton)
        => radioButton.Checked = false;

    public static void Limpar(
        this RadioButton radioButton,
        bool valorPadrao = false)
        => radioButton.Checked = valorPadrao;
}