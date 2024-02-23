using Microsoft.Extensions.DependencyInjection;
using WZSISTEMAS.Cadastros;
using WZSISTEMAS.Caixas;
using WZSISTEMAS.Consultas;
using WZSISTEMAS.Entradas;
using WZSISTEMAS.FrenteCaixa;
using WZSISTEMAS.Pedidos;
using WZSISTEMAS.Servicos;
using WZSISTEMAS.Utiliarios;

namespace WZSISTEMAS.Helpers;

public static class ServicoCollectionHelper
{
    public static IServiceProvider Criar()
        => new ServiceCollection().Configurar();

    public static IServiceProvider Configurar(this IServiceCollection servicos)
    {
        servicos.AddTransient<FrmEntrada>();
        servicos.AddTransient<FrmLogin>();
        servicos.AddTransient<FrmInicio>();
        servicos.AddTransient<FrmClienteConvenio>();
        
        return servicos.ConfigurarCore()
            .ConfigurarDados()
            .ConfigurarCadastros()
            .ConfigurarConsultas()
            .ConfigurarCaixa()
            .ConfigurarFrenteCaixa()
            .ConfigurarPedidos()
            .ConfigurarUtilitarios()
            .ConfigurarServicos()
            .BuildServiceProvider();
    }

    private static IServiceCollection ConfigurarServicos(this IServiceCollection servicos)
    {
        servicos.AddTransient<IServicoLogin, ServicoLogin>();

        return servicos;
    }
    
    private static IServiceCollection ConfigurarCadastros(this IServiceCollection servicos)
    {
        servicos.AddTransient<FrmCadastroCargos>();
        servicos.AddTransient<FrmCadastroClientes>();
        servicos.AddTransient<FrmCadastroEmpresas>();
        servicos.AddTransient<FrmCadastroFornecedores>();
        servicos.AddTransient<FrmCadastroFuncionarios>();
        servicos.AddTransient<FrmCadastroItens>();
        servicos.AddTransient<FrmCadastroTransportadoras>();

        return servicos;
    }

    private static IServiceCollection ConfigurarConsultas(this IServiceCollection servicos)
    {
        servicos.AddTransient<FrmConsultaAvancadaClientes>();
        servicos.AddTransient<FrmConsultaAvancadaEmpresas>();
        servicos.AddTransient<FrmConsultaAvancadaFornecedores>();
        servicos.AddTransient<FrmConsultaAvancadaFuncionarios>();
        servicos.AddTransient<FrmConsultaAvancadaItens>();
        servicos.AddTransient<FrmConsultaAvancadaTransportadoras>();

        servicos.AddTransient<FrmConsultaAvancadaConvenio>();

        return servicos;
    }

    private static IServiceCollection ConfigurarCaixa(this IServiceCollection servicos)
    {
        servicos.AddTransient<FrmCaixa>();
        servicos.AddTransient<FrmCaixaAbertura>();
        servicos.AddTransient<FrmCaixaEntrada>();
        servicos.AddTransient<FrmCaixaFechamento>();
        servicos.AddTransient<FrmCaixaSaida>();

        return servicos;
    }

    private static IServiceCollection ConfigurarFrenteCaixa(this IServiceCollection servicos)
    {
        servicos.AddTransient<FrmFrenteCaixa>();
        servicos.AddTransient<FrmFrenteCaixaEmEspera>();
        servicos.AddTransient<FrmFrenteCaixaFechamento>();
        servicos.AddTransient<FrmFrenteCaixaFechamentoCartao>();
        servicos.AddTransient<FrmFrenteCaixaCPF_CNPJNaNota>();
        servicos.AddTransient<FrmFrenteCaixaFechamentoConvenio>();
        servicos.AddTransient<FrmFrenteCaixaSelecionarPrecos>();
        servicos.AddTransient<FrmFrenteCaixaManutencao>();

        return servicos;
    }
   
    private static IServiceCollection ConfigurarPedidos(this IServiceCollection servicos)
    {
        servicos.AddTransient<FrmPedido>();
        servicos.AddTransient<FrmPedidoEmAberto>();
        servicos.AddTransient<FrmPedidoManutencao>();

        return servicos;
    }

    private static IServiceCollection ConfigurarUtilitarios(this IServiceCollection servicos)
    {
        servicos.AddTransient<FrmConfigurarTerminal>();
        servicos.AddTransient<FrmControleItens>();

        return servicos;
    }
}
