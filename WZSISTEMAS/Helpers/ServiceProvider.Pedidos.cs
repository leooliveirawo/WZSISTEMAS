using Microsoft.Extensions.DependencyInjection;
using WZSISTEMAS.Pedidos;

namespace WZSISTEMAS.Helpers;
public static partial class ServiceProvider
{
    public static FrmPedido FrmPedido(this IServiceProvider services)
        => services.GetRequiredService<FrmPedido>();

    public static FrmPedidoManutencao FrmPedidoManutencao(this IServiceProvider services)
        => services.GetRequiredService<FrmPedidoManutencao>();
}
