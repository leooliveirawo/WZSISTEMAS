using System.Xml;

namespace WZSISTEMAS.Base.Servicos.Interfaces;

public interface IServicoXml
{
    string LerArquivo(string path);

    T? ConverterDeString<T>(string xml);
    T? ConverterDeString<T>(XmlReader xmlReader);

    string? ConverterParaString<T>(T instance);
}