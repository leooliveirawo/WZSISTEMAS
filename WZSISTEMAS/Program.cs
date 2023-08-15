using Microsoft.Extensions.DependencyInjection;

using WZSISTEMAS.Cadastros;
using WZSISTEMAS.Data;
using WZSISTEMAS.Data.Servicos.Interfaces;

namespace WZSISTEMAS
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; } = ConfigurarServiceProvider();

        private static IServiceProvider ConfigurarServiceProvider()
        {
            var servicos = new ServiceCollection();

            servicos.AddDbContext<WZSISTEMASDbContext>();

            servicos.AddTransient<IServicoClientes, ServicoClientes>();
            servicos.AddTransient<IServicoClientesConsultas, ServicoClientes>();

            servicos.AddTransient<IServicoFornecedores, ServicoFornecedores>();
            servicos.AddTransient<IServicoFornecedoresConsultas, ServicoFornecedores>();

            servicos.AddTransient<IServicoCargos, ServicoCargos>();
            servicos.AddTransient<IServicoCargosConsultas, ServicoCargos>();

            return servicos.BuildServiceProvider();
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(
                new FrmCadastroClientes(ServiceProvider.GetRequiredService<IServicoClientes>()));

            Application.Run(
                new FrmCadastroFornecedores(ServiceProvider.GetRequiredService<IServicoFornecedores>()));

            Application.Run(
                new FrmCadastroCargos(ServiceProvider.GetRequiredService<IServicoCargos>()));
        }
    }
}