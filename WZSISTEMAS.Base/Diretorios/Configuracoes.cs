
using WZSISTEMAS.Base.Diretorios.Interfaces;

namespace WZSISTEMAS.Base.Diretorios;

public class Configuracoes : Diretorio, IConfiguracoes
{
    public override string Caminho  
        => Path.Combine(CaminhoAppData, "Configuracoes");
}
