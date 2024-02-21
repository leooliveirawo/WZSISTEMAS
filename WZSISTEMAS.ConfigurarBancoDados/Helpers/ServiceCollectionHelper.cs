using Microsoft.Extensions.DependencyInjection;

namespace WZSISTEMAS.ConfigurarBancoDados.Helpers;

public static class ServiceCollectionHelper
{
    public static IServiceProvider Configurar(this IServiceCollection servicos)
    {
        servicos.AddTransient<FrmConfigurarBancoDados>();

        return servicos.ConfigurarCore()
            .ConfigurarDados()
            .BuildServiceProvider();
    }
}
