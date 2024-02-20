using WZSISTEMAS.Base.Helpers;

namespace WZSISTEMAS.WinForms.Helpers;

public static class AuxiliarTextBox
{
    public enum TiposValidacao
    {
        Positivo,
        Zero,
        Negativo,
        ZeroPositivo,
        ZeroNegativo,
        PositivoNegativo,
        Todos
    }

    public static string? ObterStringNula(this TextBox textBox)
        => textBox.Text.ObterStringNula();

    public static void Selecionar(this TextBox textBox)
    {
        textBox.Focus();
        textBox.SelectAll();
    }

    public static void SomenteLeitura(this TextBox textBox)
        => textBox.ReadOnly = true;

    public static void LeituraEEscrita(this TextBox textBox)
        => textBox.ReadOnly = false;

    public static void Clear(
        this TextBox textBox,
        string valorPadrao = "")
        => textBox.Text = valorPadrao;

    public static bool VerificarDecimal(this TextBox textBox, TiposValidacao tipoValidacao = TiposValidacao.Todos)
        => decimal.TryParse(textBox.Text, out var valor)
        && (tipoValidacao == TiposValidacao.Todos
        || (tipoValidacao == TiposValidacao.Zero
        ? valor == 0
        : tipoValidacao == TiposValidacao.ZeroPositivo
        ? valor >= 0
        : tipoValidacao == TiposValidacao.ZeroNegativo
        ? valor <= 0
        : tipoValidacao == TiposValidacao.Positivo
        ? valor > 0
        : tipoValidacao == TiposValidacao.Negativo ? valor < 0 : valor > 0 || valor < 0));

    public static long ConverterParaLong(this TextBox textBox)
        => textBox.Text.ConverterParaLong();

    public static decimal ConverterParaDecimal(this TextBox textBox)
        => textBox.Text.ConverterParaDecimal();

    public static decimal? ConverterParaDecimalNulo(this TextBox textBox)
        => textBox.Text.ConverterParaDecimalNulo();
}
