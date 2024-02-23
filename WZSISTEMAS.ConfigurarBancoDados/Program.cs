using Microsoft.Extensions.DependencyInjection;

namespace WZSISTEMAS.ConfigurarBancoDados;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        if (EmDesenvolvimento)
            MessageBox.Show("Em desenvolvimento...");

        ProvedorServicos = Helpers.ServiceCollectionHelper.Criar();

        Application.Run(ProvedorServicos.GetRequiredService<FrmConfigurarBancoDados>());
    }
}