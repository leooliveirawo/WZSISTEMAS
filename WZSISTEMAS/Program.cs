using Microsoft.Extensions.DependencyInjection;

namespace WZSISTEMAS;

internal static class Program
{
    public static bool EmDesenvolvimento { get; private set; }

    public static IServiceProvider ProvedorServicos { get; set; } = default!;

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

#if DEBUG
        EmDesenvolvimento = true;
        MessageBox.Show("Em desenvolvimento...");
#endif
        ProvedorServicos = new ServiceCollection().Configurar();
        Application.Run(ProvedorServicos.FrmLogin());
    }
}