using Microsoft.Extensions.DependencyInjection;
using WZSISTEMAS.Utiliarios;

namespace WZSISTEMAS.Helpers;
public partial class ServiceProviderHelper
{
    public static FrmControleItens FrmControleItens(this IServiceProvider services)
        => services.GetRequiredService<FrmControleItens>();

    public static FrmConfigurarTerminal FrmConfigurarTerminal(this IServiceProvider services)
        => services.GetRequiredService<FrmConfigurarTerminal>();
}
