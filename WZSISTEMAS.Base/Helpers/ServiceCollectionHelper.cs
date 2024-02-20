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
    public static IServiceCollection ConfigurarCore(this IServiceCollection servicos)
    {
        servicos.AddTransient<IServicoRandomico, ServicoRandomico>();
        servicos.AddTransient<IServicoCodigoBarras, ServicoCodigoBarras>();
        servicos.AddTransient<IServicoConexao, ServicoConexao>();
        servicos.AddTransient<IServicoDataNascimento, ServicoDataNascimento>();
        servicos.AddTransient<IServicoConsultaCEP, ServicoConsultaCEP>();

        servicos.AddTransient<IGerenciadorDiretorios, GerenciadorDiretorios>();
        servicos.AddTransient<IConfiguracoes, Configuracoes>();
        
        return servicos.ConfigurarSeguranca()
            .ConfigurarArquivos()
            .ConfigurarNotaFiscal()
            .ConfigurarDocumentos()
            .ConfigurarCartoes(); ;
    }

    private static IServiceCollection ConfigurarNotaFiscal(this IServiceCollection servicos)
    {
        servicos.AddTransient<ServicoNFe, NotaFiscal.Servicos.ServicoNFe>();
        servicos.AddTransient<ServicoCFe, ServicoCFe>();
        servicos.AddTransient<IServicoSAT, ServicoSAT>();

        return servicos;
    }

    private static IServiceCollection ConfigurarDocumentos(this IServiceCollection servicos)
    {
        servicos.AddTransient<IServicoCPF, ServicoCPF>();
        servicos.AddTransient<IServicoCNPJ, ServicoCNPJ>();
        servicos.AddTransient<IServicoInscricaoEstadual, ServicoInscricaoEstadual>();

        return servicos;
    }

    private static IServiceCollection ConfigurarCartoes(this IServiceCollection servicos)
    {
        servicos.AddSingleton<IDriverCartao, DriverCartaoVirtual>();

        servicos.AddTransient<IServicoCartaoDebito, ServicoCartaoDebito>();
        servicos.AddTransient<IServicoCartaoCredito, ServicoCartaoCredito>();
        servicos.AddTransient<IServicoCartaoVoucher, ServicoCartaoVoucher>();
        servicos.AddTransient<IServicoCartaoLoja, ServicoCartaoLoja>();

        return servicos;
    }

    private static IServiceCollection ConfigurarSeguranca(this IServiceCollection servicos)
    {
        servicos.AddTransient<IServicoCredenciais, ServicoCredenciais>();
        servicos.AddTransient<IServicoCriptografia, ServicoCriptografia>();
        servicos.AddTransient<IServicoHash, ServicoHash>();
        servicos.AddTransient<IServicoToken, ServicoToken>();

        return servicos;
    }

    private static IServiceCollection ConfigurarArquivos(this IServiceCollection servicos)
    {
        servicos.AddTransient<IServicoJson, ServicoJson>();
        servicos.AddTransient<IServicoXml, ServicoXml>();

        return servicos;
    }
}
