namespace WZSISTEMAS.Dados.Entidades.Helpers;

public static class TerminalHelper
{
    public static string DefinirNome(this Terminal terminal)
        => terminal.DefinirNome(terminal.Empresa);

    public static string DefinirNome(this Terminal terminal, Empresa empresa)
        => $"Terminal {terminal.Id} - {empresa.RazaoSocial} ({empresa.CNPJ})";
}

public static class EmpresaHelper
{
    public static string RazaoSocial_CNJP(this Empresa empresa) 
        => $"{empresa.RazaoSocial} ({empresa.CNPJ})";
}
