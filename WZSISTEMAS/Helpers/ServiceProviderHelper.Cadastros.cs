using Microsoft.Extensions.DependencyInjection;
using WZSISTEMAS.Cadastros;

namespace WZSISTEMAS.Helpers;

public static partial class ServiceProviderHelper
{
    public static FrmCadastroCargos FrmCadastroCargos(this IServiceProvider services)
        => services.GetRequiredService<FrmCadastroCargos>();

    public static FrmCadastroClientes FrmCadastroClientes(this IServiceProvider services)
        => services.GetRequiredService<FrmCadastroClientes>();

    public static FrmCadastroEmpresas FrmCadastroEmpresas(this IServiceProvider services)
        => services.GetRequiredService<FrmCadastroEmpresas>();

    public static FrmCadastroFornecedores FrmCadastroFornecedores(this IServiceProvider services)
        => services.GetRequiredService<FrmCadastroFornecedores>();

    public static FrmCadastroFuncionarios FrmCadastroFuncionarios(this IServiceProvider services)
        => services.GetRequiredService<FrmCadastroFuncionarios>();

    public static FrmCadastroProdutos FrmCadastroProdutos(this IServiceProvider services)
        => services.GetRequiredService<FrmCadastroProdutos>();

    public static FrmCadastroTransportadoras FrmCadastroTransportadoras(this IServiceProvider services)
        => services.GetRequiredService<FrmCadastroTransportadoras>();
    
    public static FrmClienteConvenio FrmClienteConvenio(this IServiceProvider services)
        => services.GetRequiredService<FrmClienteConvenio>();
}
