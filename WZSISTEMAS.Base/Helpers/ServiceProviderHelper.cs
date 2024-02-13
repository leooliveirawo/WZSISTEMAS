using Microsoft.Extensions.DependencyInjection;

namespace WZSISTEMAS.Base.Helpers;

public static class ServiceProviderHelper
{
    public static IDriverCartao DriverCartao(this IServiceProvider servicos)
        => servicos.GetRequiredService<IDriverCartao>();

    public static IServicoConexao ServicoConexao(this IServiceProvider servicos)
        => servicos.GetRequiredService<IServicoConexao>();
}
