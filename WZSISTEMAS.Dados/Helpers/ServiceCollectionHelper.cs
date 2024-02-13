using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WZSISTEMAS.Dados.EF;
using WZSISTEMAS.Dados.Servicos;
using WZSISTEMAS.Dados.Validacoes;

namespace WZSISTEMAS.Dados.Helpers;

public static class ServiceCollectionHelper
{
    public static void ConfigurarDados(this IServiceCollection servicos)
    {
        servicos.ConfigurarDadosDbContext();
        servicos.ConfigurarDadosServicos();
        servicos.ConfigurarDadosValidadacoes();
    }

    private static void ConfigurarDadosDbContext(this IServiceCollection servicos)
        => servicos.AddScoped<DbContext, WZSISTEMASDbContext>();

    private static void ConfigurarDadosServicos(this IServiceCollection servicos)
    {
        servicos.AddTransient<IServicoClientes, ServicoClientes>();
        servicos.AddTransient<IServicoClientesFaturas, ServicoClientesFaturas>();
        servicos.AddTransient<IServicoClientesLancamentos, ServicoClientesLancamentos>();
        servicos.AddTransient<IServicoFornecedores, ServicoFornecedores>();
        servicos.AddTransient<IServicoCargos, ServicoCargos>();
        servicos.AddTransient<IServicoFuncionarios, ServicoFuncionarios>();
        servicos.AddTransient<IServicoUsuarios, ServicoUsuarios>();
        servicos.AddTransient<IServicoItens, ServicoItens>();
        servicos.AddTransient<IServicoCaixas, ServicoCaixas>();
        servicos.AddTransient<IServicoCaixasEntradas, ServicoCaixasEntradas>();
        servicos.AddTransient<IServicoCaixasSaidas, ServicoCaixasSaidas>();
        servicos.AddTransient<IServicoCaixasSuprimentos, ServicoCaixasSuprimentos>();
        servicos.AddTransient<IServicoVendas, ServicoVendas>();
        servicos.AddTransient<IServicoVendasItens, ServicoVendasItens>();
        servicos.AddTransient<IServicoVendasPagamentos, ServicoVendasPagamentos>();
        servicos.AddTransient<IServicoTerminais, ServicoTerminais>();
        servicos.AddTransient<IServicoEmpresas, ServicoEmpresas>();
        servicos.AddTransient<IServicoTransportadoras, ServicoTransportadoras>();
        servicos.AddTransient<IServicoEntradas, ServicoEntradas>();
        servicos.AddTransient<IServicoPedidos, ServicoPedidos>();
        servicos.AddTransient<IServicoPedidosItens, ServicoPedidosItens>();

        servicos.AddTransient<IServicoCFe2, ServicoCFe2>();

        servicos.AddTransient<IServicoDesenvolvedor, ServicoDesenvolvedor>();
    }

    private static void ConfigurarDadosValidadacoes(this IServiceCollection servicos)
    {
        servicos.AddTransient<IValidator<Item>, ValidacaoProduto>();
        servicos.AddTransient<IValidator<Cliente>, ValidacaoCliente>();
        servicos.AddTransient<IValidator<Funcionario>, ValidacaoFuncionario>();
        servicos.AddTransient<IValidator<Fornecedor>, ValidacaoFornecedor>();
        servicos.AddTransient<IValidator<Empresa>, ValidacaoEmpresa>();
        servicos.AddTransient<IValidator<Transportadora>, ValidacaoTransportador>();
        servicos.AddTransient<IValidator<Usuario>, ValidacaoUsuario>();
        servicos.AddTransient<IValidator<Cargo>, ValidacaoCargo>();
        servicos.AddTransient<IValidator<UsuarioCredenciais>, ValidacaoUsuarioCredencial>();
    }
}