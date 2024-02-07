using Microsoft.Extensions.DependencyInjection;
using WZSISTEMAS.Componentes;

namespace WZSISTEMAS.Helpers;
public partial class ServiceProviderHelper
{
    public static FrmItemSelecionarPrecos FrmItemSelecionarPrecos(this IServiceProvider services)
        => services.GetRequiredService<FrmItemSelecionarPrecos>();
}
