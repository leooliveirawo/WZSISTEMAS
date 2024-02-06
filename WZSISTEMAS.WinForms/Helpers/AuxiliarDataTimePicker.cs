namespace WZSISTEMAS.WinForms.Helpers;

public static class AuxiliarDataTimePicker
{
    public static DateTime? ObterDateTimeSoDataNulo(
        this DateTimePicker dateTimePicker,
        bool condicional)
        => condicional
        ? default
        : (DateTime?)dateTimePicker.Value.Date;

    public static DateTime? ObterDateTimeNulo(
        this DateTimePicker dateTimePicker,
        bool uTC,
        bool condicional)
        => condicional
        ? default
        : (DateTime?)(uTC
        ? dateTimePicker.Value.ToUniversalTime()
        : dateTimePicker.Value);

    public static void Limpar(
        this DateTimePicker dateTimePicker,
        DateTime valorPadrao = default)
        => dateTimePicker.Value = valorPadrao;

}
