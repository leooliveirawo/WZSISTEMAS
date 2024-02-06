namespace WZSISTEMAS.Base.Servicos.Interfaces;

public interface IServicoHash
{
    string GerarHash(string texto);
    bool CompararHash(string texto, string hashEsperado);
}
