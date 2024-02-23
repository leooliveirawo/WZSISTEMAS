namespace WZSISTEMAS.Base;
public static class ConfiguracoesBase
{
    public static IServiceProvider ProvedorServicos { get; set; } = default!;

    public static bool EmDesenvolvimento { get; private set; } = ConfigurarEmDesenvolvimento();

    private static bool ConfigurarEmDesenvolvimento()
    {

#if DEBUG
        return true;
#else
        return false;
#endif
    }

}
