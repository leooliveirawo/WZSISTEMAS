using System.Security.Cryptography;
using System.Text;

namespace WZSISTEMAS.Base.Servicos;

public class ServicoHash : IServicoHash
{
    public virtual bool CompararHash(string texto, string hashEsperado)
        => GerarHash(texto) == hashEsperado;

    public virtual string GerarHash(string texto)
    {
        var hashBytes = SHA256.HashData(Encoding.UTF8.GetBytes(texto));
        var hash = string.Empty;

        hashBytes.ToList().ForEach(hashByte => hash += hashByte.ToString("x2"));

        return hash;
    }
}
