namespace WZSISTEMAS.Base.Servicos.Interfaces;

public interface IServicoCriptografia
{
    string Criptografar(string iV, string key, string dados);
    string Descriptografar(string iV, string key, string dadosCriptografados);
}
