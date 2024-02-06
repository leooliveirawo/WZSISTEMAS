namespace WZSISTEMAS.Dados.Servicos.Interfaces;

public interface IServicoTerminais : IServicoEntidades<Terminal>
{
    Terminal? ObterTerminalVinculado(bool usarTracking = false);
    Terminal VincularTerminal(long empresaId);
}