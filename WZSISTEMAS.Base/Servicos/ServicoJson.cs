using System.Text;
using System.Text.Json;

namespace WZSISTEMAS.Base.Servicos;

public class ServicoJson : IServicoJson
{
    public virtual T? Deserializar<T>(string json)
    {
        using var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(json));

        return JsonSerializer.Deserialize<T>(memoryStream);
    }

    public virtual string Serializar<T>(T obj)
    {
        using var memoryStream = new MemoryStream();
        using var streamReader = new StreamReader(memoryStream);

        JsonSerializer.Serialize(memoryStream, obj);

        memoryStream.Flush();

        memoryStream.Position = 0;

        return streamReader.ReadToEnd();
    }
}
