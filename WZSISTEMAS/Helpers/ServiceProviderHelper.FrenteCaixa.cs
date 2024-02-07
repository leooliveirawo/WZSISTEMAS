using Microsoft.Extensions.DependencyInjection;
using WZSISTEMAS.FrenteCaixa;

namespace WZSISTEMAS.Helpers;

public static partial class ServiceProviderHelper
{
    public static FrmFrenteCaixa FrmFrenteCaixa(this IServiceProvider services)
        => services.GetRequiredService<FrmFrenteCaixa>();

    public static FrmFrenteCaixaCPF_CNPJNaNota FrmFrenteCaixaCPF_CNPJNaNota(this IServiceProvider services)
        => services.GetRequiredService<FrmFrenteCaixaCPF_CNPJNaNota>();

    public static FrmFrenteCaixaEmEspera FrmFrenteCaixaEmAberto(this IServiceProvider services)
        => services.GetRequiredService<FrmFrenteCaixaEmEspera>();

    public static FrmFrenteCaixaFechamento FrmFrenteCaixaFechamento(this IServiceProvider services)
        => services.GetRequiredService<FrmFrenteCaixaFechamento>();

    public static FrmFrenteCaixaFechamentoCartao FrmFrenteCaixaFechamentoCartao(this IServiceProvider services)
        => services.GetRequiredService<FrmFrenteCaixaFechamentoCartao>();

    public static FrmFrenteCaixaFechamentoConvenio FrmFrenteCaixaFechamentoConvenio(this IServiceProvider services)
        => services.GetRequiredService<FrmFrenteCaixaFechamentoConvenio>();

    public static FrmFrenteCaixaSelecionarPrecos FrmFrenteCaixaSelecionarPrecos(this IServiceProvider services)
        => services.GetRequiredService<FrmFrenteCaixaSelecionarPrecos>();

    public static FrmFrenteCaixaManutencao FrmFrenteCaixaManutencao(this IServiceProvider services)
        => services.GetRequiredService<FrmFrenteCaixaManutencao>();
}
