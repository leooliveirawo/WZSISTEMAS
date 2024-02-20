using Microsoft.Extensions.DependencyInjection;

namespace WZSISTEMAS.ConfigurarBancoDados;

internal static class Program
{
    public static bool EmDesenvolvimento { get; private set; }

    public static IServiceProvider ProvedorServicos { get; private set; } = default!;

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();


#if DEBUG
        EmDesenvolvimento = true;
        MessageBox.Show("Em desenvolvimento...");
#endif
        var servicos = new ServiceCollection();

        ProvedorServicos = servicos.Configurar();

        Application.Run(ProvedorServicos.GetRequiredService<FrmConfigurarBancoDados>());
    }
}