namespace WZSISTEMAS.Base.Servicos.Interfaces;

public interface IServicoJson
{
    string Serializar<T>(T obj);
    T? Deserializar<T>(string json);
}
