using Microsoft.Extensions.DependencyInjection;
using WZSISTEMAS.Caixas;

namespace WZSISTEMAS.Helpers;

public static partial class ServiceProviderHelper
{
    public static FrmCaixa FrmCaixa(this IServiceProvider services)
        => services.GetRequiredService<FrmCaixa>();

    public static FrmCaixaAbertura FrmCaixaAbertura(this IServiceProvider services)
        => services.GetRequiredService<FrmCaixaAbertura>();

    public static FrmCaixaEntrada FrmCaixaEntrada(this IServiceProvider services)
        => services.GetRequiredService<FrmCaixaEntrada>();

    public static FrmCaixaSaida FrmCaixaSaida(this IServiceProvider services)
        => services.GetRequiredService<FrmCaixaSaida>();

}
