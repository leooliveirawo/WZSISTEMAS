using Microsoft.Extensions.DependencyInjection;
using WZSISTEMAS.Consultas;

namespace WZSISTEMAS.Helpers;

public static partial class ServiceProviderHelper
{
    public static FrmConsultaAvancadaClientes FrmConsultaAvancadaClientes(this IServiceProvider services)
        => services.GetRequiredService<FrmConsultaAvancadaClientes>();

    public static FrmConsultaAvancadaFornecedores FrmConsultaAvancadaFornecedores(this IServiceProvider services)
        => services.GetRequiredService<FrmConsultaAvancadaFornecedores>();

    public static FrmConsultaAvancadaFuncionarios FrmConsultaAvancadaFuncionarios(this IServiceProvider services)
        => services.GetRequiredService<FrmConsultaAvancadaFuncionarios>();

    public static FrmConsultaAvancadaItens FrmConsultaAvancadaItens(this IServiceProvider services)
        => services.GetRequiredService<FrmConsultaAvancadaItens>();

    public static FrmConsultaAvancadaTransportadoras FrmConsultaAvancadaTransportadoras(this IServiceProvider services)
        => services.GetRequiredService<FrmConsultaAvancadaTransportadoras>();

    public static FrmConsultaAvancadaEmpresas FrmConsultaAvancadaEmpresas(this IServiceProvider services)
        => services.GetRequiredService<FrmConsultaAvancadaEmpresas>();

    public static FrmConsultaAvancadaConvenio FrmConsultaAvancadaConvenio(this IServiceProvider services)
        => services.GetRequiredService<FrmConsultaAvancadaConvenio>();
}
