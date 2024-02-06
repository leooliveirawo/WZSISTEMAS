using System.Security.Cryptography;
using System.Text;
using WZSISTEMAS.Base.Servicos.Interfaces;

namespace WZSISTEMAS.Base.Servicos;

public class ServicoCriptografia : IServicoCriptografia
{
    private static Aes CriarAes(string iV, string key)
    {
        var iVBytes = Encoding.UTF8.GetBytes(iV);
        var keyBytes = Encoding.UTF8.GetBytes(key);

        var aes = Aes.Create();

        aes.IV = iVBytes;
        aes.Key = keyBytes;

        return aes;
    }

    public virtual string Criptografar(
        string iV,
        string key,
        string dados)
    {
        var aes = CriarAes(iV, key);

        var memoryStream = new MemoryStream();
        var stream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write);

        var dadosBytes = Encoding.UTF8.GetBytes(dados);

        stream.Write(dadosBytes);
        stream.FlushFinalBlock();

        var dadosCriptografadosBytes = memoryStream.ToArray();

        return Convert.ToBase64String(dadosCriptografadosBytes);
    }

    public virtual string Descriptografar(string iV, string key, string dadosCriptografados)
    {
        var aes = CriarAes(iV, key);

        var memoryStream = new MemoryStream();
        var stream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write);

        var dadosCriptografadosBytes = Convert.FromBase64String(dadosCriptografados);

        stream.Write(dadosCriptografadosBytes);
        stream.FlushFinalBlock();

        var dadosBytes = memoryStream.ToArray();

        return Encoding.UTF8.GetString(dadosBytes);
    }
}
