using Microsoft.Extensions.DependencyInjection;
using WZSISTEMAS.Base.Helpers;
using WZSISTEMAS.Dados.Helpers;

namespace WZSISTEMAS.ConfigurarBancoDados;

internal static class Program
{
    public static bool EmDesenvolvimento { get; private set; }

    public static IServiceProvider ProvedorServicos { get; private set; }

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

        servicos.ConfigurarDados();
        servicos.ConfigurarCore();

        servicos.AddTransient<FrmConfigurarBancoDados>();

        ProvedorServicos = servicos.BuildServiceProvider();

        Application.Run(ProvedorServicos.GetRequiredService<FrmConfigurarBancoDados>());
    }
}