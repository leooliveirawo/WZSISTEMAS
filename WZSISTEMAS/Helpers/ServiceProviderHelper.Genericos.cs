using Microsoft.Extensions.DependencyInjection;
using WZSISTEMAS.Entradas;

namespace WZSISTEMAS.Helpers;

public static partial class ServiceProviderHelper
{
    public static FrmEntrada FrmEntrada(this IServiceProvider services)
        => services.GetRequiredService<FrmEntrada>();

    public static FrmLogin FrmLogin(this IServiceProvider services) => services.GetRequiredService<FrmLogin>();

    public static FrmInicio FrmInicio(this IServiceProvider services) => services.GetRequiredService<FrmInicio>();
}
