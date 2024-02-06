namespace WZSISTEMAS.Base.Servicos.Interfaces;
public interface IServicoRandomico
{
    int GerarRandomicamente();
    int GerarRandomicamente(int numeroMinimo, int numeroMaximo);
    string GerarRandomicamente(int numeroCaracteres);
}
