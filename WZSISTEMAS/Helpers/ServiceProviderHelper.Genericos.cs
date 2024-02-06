using Microsoft.Extensions.DependencyInjection;
using WZSISTEMAS.Entradas;
using WZSISTEMAS.FrenteCaixa;

namespace WZSISTEMAS.Helpers;

public static partial class ServiceProviderHelper
{
    public static FrmEntrada FrmEntrada(this IServiceProvider services)
        => services.GetRequiredService<FrmEntrada>();

    public static FrmLogin FrmLogin(this IServiceProvider services) => services.GetRequiredService<FrmLogin>();

    public static FrmInicio FrmInicio(this IServiceProvider services) => services.GetRequiredService<FrmInicio>();

    public static IServicoLogin ServicoLogin(this IServiceProvider services)
        => services.GetRequiredService<IServicoLogin>();

    public static FrmFrenteCaixaManutencao FrmFrenteCaixaManutencao(this IServiceProvider services)
        => services.GetRequiredService<FrmFrenteCaixaManutencao>();

    public static FrmTerminal FrmTerminal(this IServiceProvider services)
        => services.GetRequiredService<FrmTerminal>();
}
