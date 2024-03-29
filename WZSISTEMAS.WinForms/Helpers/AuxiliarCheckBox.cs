﻿namespace WZSISTEMAS.WinForms.Helpers;

public static class AuxiliarCheckBox
{
    public static void Marcar(this CheckBox checkBox)
        => checkBox.Checked = true;

    public static void Desmarcar(this CheckBox checkBox)
        => checkBox.Checked = false;

    public static void Limpar(
        this CheckBox checkBox,
        bool valorPadrao = false)
        => checkBox.Checked = valorPadrao;
}
