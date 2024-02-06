using WZSISTEMAS.Base.Valores;

namespace WZSISTEMAS.WinForms.Helpers;

public static class AuxiliarComboBox
{
    public static void Configurar<T>(
        this ComboBox comboBox,
        IEnumerable<ItemLista<T>> itens)
    {
        comboBox.ValueMember = nameof(ItemLista<T>.Item);
        comboBox.DisplayMember = nameof(ItemLista<T>.Descricao);
        comboBox.DataSource = itens;
    }

    public static T? Converter<T>(this ComboBox comboBox)
        => comboBox.SelectedValue is null
        ? default
        : (T?)comboBox.SelectedValue;

    public static void Definir<T>(
        this ComboBox comboBox,
        T valor)
        => comboBox.SelectedValue = valor;

    public static bool Comparar<T>(
        this ComboBox comboBox,
        T valor)
    {
        var valorConvertido = comboBox.Converter<T>();

        return valorConvertido is null ? valor is null : valorConvertido.Equals(valor);
    }
}
