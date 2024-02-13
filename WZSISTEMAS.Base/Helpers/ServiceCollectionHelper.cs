using Microsoft.Extensions.DependencyInjection;
using WZSISTEMAS.Base.Cartoes.Drivers;
using WZSISTEMAS.Base.Cartoes.Servicos;
using WZSISTEMAS.Base.Cartoes.Servicos.Interfaces;
using WZSISTEMAS.Base.Diretorios;
using WZSISTEMAS.Base.EF.Servicos;
using WZSISTEMAS.Base.NotaFiscal.Servicos;
using WZSISTEMAS.Base.Servicos;
using ServicoNFe = WZSISTEMAS.Base.NotaFiscal.Servicos.Interfaces.ServicoNFe;

namespace WZSISTEMAS.Base.Helpers;

public static class ServiceCollectionHelper
{
    public static void ConfigurarCore(this IServiceCollection servicos)
    {
        servicos.AddTransient<IServicoRandomico, ServicoRandomico>();
        servicos.AddTransient<IServicoCodigoBarras, ServicoCodigoBarras>();
        servicos.AddTransient<IServicoConexao, ServicoConexao>();
        servicos.AddTransient<IServicoDataNascimento, ServicoDataNascimento>();
        servicos.AddTransient<IServicoConsultaCEP, ServicoConsultaCEP>();

        servicos.AddTransient<IGerenciadorDiretorios, GerenciadorDiretorios>();
        servicos.AddTransient<IConfiguracoes, Configuracoes>();

        servicos.ConfigurarCoreSeguranca();
        servicos.ConfigurarCoreArquivos();
        servicos.ConfigurarCoreNotaFiscal();
        servicos.ConfigurarCoreDocumentos();
        servicos.ConfigurarCoreCartoes();

    }

    static void ConfigurarCoreNotaFiscal(this IServiceCollection services)
    {
        services.AddTransient<ServicoNFe, NotaFiscal.Servicos.ServicoNFe>();
        services.AddTransient<ServicoCFe, ServicoCFe>();
        services.AddTransient<IServicoSAT, ServicoSAT>();
    }

    static void ConfigurarCoreDocumentos(this IServiceCollection services)
    {
        services.AddTransient<IServicoCPF, ServicoCPF>();
        services.AddTransient<IServicoCNPJ, ServicoCNPJ>();
        services.AddTransient<IServicoInscricaoEstadual, ServicoInscricaoEstadual>();
    }

    static void ConfigurarCoreCartoes(this IServiceCollection services)
    {
        services.AddSingleton<IDriverCartao, DriverCartaoVirtual>();

        services.AddTransient<IServicoCartaoDebito, ServicoCartaoDebito>();
        services.AddTransient<IServicoCartaoCredito, ServicoCartaoCredito>();
        services.AddTransient<IServicoCartaoVoucher, Cartoes.Servicos.ServicoCartaoVoucher>();
        services.AddTransient<IServicoCartaoLoja, ServicoCartaoLoja>();
    }

    static void ConfigurarCoreSeguranca(this IServiceCollection services)
    {
        services.AddTransient<IServicoCredenciais, ServicoCredenciais>();
        services.AddTransient<IServicoCriptografia, ServicoCriptografia>();
        services.AddTransient<IServicoHash, ServicoHash>();
        services.AddTransient<IServicoToken, ServicoToken>();
    }

    static void ConfigurarCoreArquivos(this IServiceCollection services)
    {
        services.AddTransient<IServicoJson, ServicoJson>();
        services.AddTransient<IServicoXml, ServicoXml>();
    }
}
