using Microsoft.Extensions.DependencyInjection;
using WZSISTEMAS.Cadastros;
using WZSISTEMAS.Caixas;
using WZSISTEMAS.Entradas;
using WZSISTEMAS.FrenteCaixa;
using WZSISTEMAS.Pedidos;
using WZSISTEMAS.Servicos;
using WZSISTEMAS.Utiliarios;

namespace WZSISTEMAS.Helpers;

public static class ServicoCollectionHelper
{
    public static IServiceProvider Configurar(this IServiceCollection servicos)
    {
        servicos.ConfigurarCore();
        servicos.ConfigurarDados();

        servicos.AddTransient<IServicoLogin, ServicoLogin>();

        servicos.AddTransient<FrmEntrada>();
        servicos.AddTransient<FrmLogin>();
        servicos.AddTransient<FrmInicio>();
        servicos.AddTransient<FrmTerminal>();
        servicos.AddTransient<FrmClienteConvenio>();
        servicos.AddTransient<FrmControleItens>();

        ConfigurarCadastros(servicos);
        ConfigurarConsultas(servicos);
        ConfigurarCaixa(servicos);
        ConfigurarFrenteCaixa(servicos);
        ConfigurarPedidos(servicos);

        servicos.AddTransient<FrmFrenteCaixaManutencao>();

        return servicos.BuildServiceProvider();

        static void ConfigurarCadastros(IServiceCollection servicos)
        {
            servicos.AddTransient<FrmCadastroCargos>();
            servicos.AddTransient<FrmCadastroClientes>();
            servicos.AddTransient<FrmCadastroEmpresas>();
            servicos.AddTransient<FrmCadastroFornecedores>();
            servicos.AddTransient<FrmCadastroFuncionarios>();
            servicos.AddTransient<FrmCadastroProdutos>();
            servicos.AddTransient<FrmCadastroTransportadoras>();
        }

        static void ConfigurarConsultas(IServiceCollection servicos)
        {
            servicos.AddTransient<FrmConsultaAvancadaClientes>();
            servicos.AddTransient<FrmConsultaAvancadaEmpresas>();
            servicos.AddTransient<FrmConsultaAvancadaFornecedores>();
            servicos.AddTransient<FrmConsultaAvancadaFuncionarios>();
            servicos.AddTransient<FrmConsultaAvancadaItens>();
            servicos.AddTransient<FrmConsultaAvancadaTransportadoras>();

            servicos.AddTransient<FrmConsultaAvancadaConvenio>();
        }

        static void ConfigurarCaixa(IServiceCollection servicos)
        {
            servicos.AddTransient<FrmCaixa>();
            servicos.AddTransient<FrmCaixaAbertura>();
            servicos.AddTransient<FrmCaixaEntrada>();
            servicos.AddTransient<FrmCaixaFechamento>();
            servicos.AddTransient<FrmCaixaSaida>();
        }

        static void ConfigurarFrenteCaixa(IServiceCollection servicos)
        {
            servicos.AddTransient<FrmFrenteCaixa>();
            servicos.AddTransient<FrmFrenteCaixaEmEspera>();
            servicos.AddTransient<FrmFrenteCaixaFechamento>();
            servicos.AddTransient<FrmFrenteCaixaFechamentoCartao>();
            servicos.AddTransient<FrmFrenteCaixaCPF_CNPJNaNota>();
            servicos.AddTransient<FrmFrenteCaixaFechamentoConvenio>();
            servicos.AddTransient<FrmFrenteCaixaSelecionarPrecos>();
        }
        static void ConfigurarPedidos(IServiceCollection servicos)
        {
            servicos.AddTransient<FrmPedido>();
            servicos.AddTransient<FrmPedidoEmAberto>();
            servicos.AddTransient<FrmPedidoManutencao>();
        }
    }
}
