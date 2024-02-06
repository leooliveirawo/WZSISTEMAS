using WZSISTEMAS.Base.Diretorios.Interfaces;

namespace WZSISTEMAS.Base.Diretorios;

public class GerenciadorDiretorios(IConfiguracoes configuracoes) : IGerenciadorDiretorios
{
    public virtual IConfiguracoes Configuracoes { get; }
        = configuracoes
        ?? throw new ArgumentNullException(nameof(configuracoes));
}
