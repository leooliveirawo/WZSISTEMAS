using Microsoft.Extensions.DependencyInjection;
using WZSISTEMAS.Entradas;
using WZSISTEMAS.Utiliarios;

namespace WZSISTEMAS.Helpers;

public static partial class ServiceProviderHelper
{
    public static FrmControleItens FrmControleItens(this IServiceProvider services)
        => services.GetRequiredService<FrmControleItens>();

    public static FrmEntrada FrmEntrada(this IServiceProvider services)
        => services.GetRequiredService<FrmEntrada>();

    public static FrmLogin FrmLogin(this IServiceProvider services) => services.GetRequiredService<FrmLogin>();

    public static FrmInicio FrmInicio(this IServiceProvider services) => services.GetRequiredService<FrmInicio>();

    public static IServicoLogin ServicoLogin(this IServiceProvider services)
        => services.GetRequiredService<IServicoLogin>();

    public static FrmTerminal FrmTerminal(this IServiceProvider services)
        => services.GetRequiredService<FrmTerminal>();
}
