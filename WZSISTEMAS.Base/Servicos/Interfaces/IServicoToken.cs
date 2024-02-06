using WZSISTEMAS.Base.Valores;

namespace WZSISTEMAS.Base.Servicos.Interfaces;

public interface IServicoToken
{
    string Criptografar(string iV, string key, Token token);
    Token Descriptografar(string iV, string key, string tokenCriptografado);
    Token CriarToken(string valor);
    Token CriarToken(string valor, DateTime expiraEm);
    Token CriarToken(string valor, string chave);
    Token CriarToken(string valor, string chave, DateTime expireIn);
}
