namespace WZSISTEMAS.Data.Auxilares
{
    public static class AuxiliarTextBox
    {
        public static string? ObterStringNula(this TextBox textBox)
        {
            return textBox.Text.ObterStringNula();
        }

        public static DateTime? ObterDateTimeNulo(this DateTimePicker dateTimePicker, bool uTC, bool condicional)
        {
            if (condicional)
                return default;

            if (uTC)
                return dateTimePicker.Value.ToUniversalTime();
            else
                return dateTimePicker.Value;
        }

        public static void Clear(this CheckBox checkBox, bool valorPadrao = false)
        {
            checkBox.Checked = valorPadrao;
        }

        public static void Clear(this DateTimePicker dateTimePicker, DateTime valorPadrao = default)
        {
            dateTimePicker.Value = valorPadrao;
        }
    }
}
