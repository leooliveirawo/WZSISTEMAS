using Microsoft.Extensions.DependencyInjection;
using WZSISTEMAS.Cadastros;
using WZSISTEMAS.Caixas;
using WZSISTEMAS.Consultas;
using WZSISTEMAS.Entradas;
using WZSISTEMAS.FrenteCaixa;
using WZSISTEMAS.Servicos;

namespace WZSISTEMAS.Helpers;

public static class ServicoCollectionHelper
{
    public static IServiceProvider Configurar(this IServiceCollection services)
    {
        services.ConfigurarCore();
        services.ConfigurarDados();

        services.AddTransient<IServicoLogin, ServicoLogin>();

        services.AddTransient<FrmEntrada>();
        services.AddTransient<FrmLogin>();
        services.AddTransient<FrmInicio>();
        services.AddTransient<FrmTerminal>();
        services.AddTransient<FrmClienteConvenio>();

        ConfigurarCadastros(services);
        ConfigurarConsultas(services);
        ConfigurarCaixa(services);
        ConfigurarFrenteCaixa(services);

        services.AddTransient<FrmFrenteCaixaManutencao>();

        return services.BuildServiceProvider();

        static void ConfigurarCadastros(IServiceCollection services)
        {
            services.AddTransient<FrmCadastroCargos>();
            services.AddTransient<FrmCadastroClientes>();
            services.AddTransient<FrmCadastroEmpresas>();
            services.AddTransient<FrmCadastroFornecedores>();
            services.AddTransient<FrmCadastroFuncionarios>();
            services.AddTransient<FrmCadastroProdutos>();
            services.AddTransient<FrmCadastroTransportadoras>();
        }

        static void ConfigurarConsultas(IServiceCollection services)
        {
            services.AddTransient<FrmConsultaAvancadaClientes>();
            services.AddTransient<FrmConsultaAvancadaEmpresas>();
            services.AddTransient<FrmConsultaAvancadaFornecedores>();
            services.AddTransient<FrmConsultaAvancadaFuncionarios>();
            services.AddTransient<FrmConsultaAvancadaItens>();
            services.AddTransient<FrmConsultaAvancadaTransportadoras>();

            services.AddTransient<FrmConsultaAvancadaConvenio>();
        }

        static void ConfigurarCaixa(IServiceCollection services)
        {
            services.AddTransient<FrmCaixa>();
            services.AddTransient<FrmCaixaAbertura>();
            services.AddTransient<FrmCaixaEntrada>();
            services.AddTransient<FrmCaixaFechamento>();
            services.AddTransient<FrmCaixaSaida>();
        }

        static void ConfigurarFrenteCaixa(IServiceCollection services)
        {
            services.AddTransient<FrmFrenteCaixa>();
            services.AddTransient<FrmFrenteCaixaEmEspera>();
            services.AddTransient<FrmFrenteCaixaFechamento>();
            services.AddTransient<FrmFrenteCaixaFechamentoCartao>();
            services.AddTransient<FrmFrenteCaixaCPF_CNPJNaNota>();
            services.AddTransient<FrmFrenteCaixaFechamentoConvenio>();
            services.AddTransient<FrmFrenteCaixaSelecionarPrecos>();
        }
    }
}
