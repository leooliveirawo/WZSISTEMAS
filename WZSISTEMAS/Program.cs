namespace WZSISTEMAS;

internal static class Program
{
    public static string? Token { get; set; }

    public static long UsuarioId { get; set; }
    public static long FuncionarioId { get; set; }
    public static long TerminalId { get; set; }

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        if (EmDesenvolvimento)
            MessageBox.Show("Em desenvolvimento...");

        ProvedorServicos = ServicoCollectionHelper.Criar();

        Application.Run(ProvedorServicos.FrmLogin());
    }
}