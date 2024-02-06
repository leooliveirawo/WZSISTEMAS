using System.Xml;
using System.Xml.Serialization;
using WZSISTEMAS.Base.Servicos.Interfaces;

namespace WZSISTEMAS.Base.Servicos;

public class ServicoXml : IServicoXml
{
    public virtual string LerArquivo(string path)
        => File.ReadAllText(path);

    public virtual T? ConverterDeString<T>(string xml)
    {
        using var textReader = new StringReader(xml);
        using var xmlReader = XmlReader.Create(textReader);

        return ConverterDeString<T>(xmlReader);

    }

    public virtual T? ConverterDeString<T>(XmlReader xmlReader)
        => (T?)new XmlSerializer(typeof(T?)).Deserialize(xmlReader);

    public virtual string? ConverterParaString<T>(T instance)
    {
        using var textWriter = new StringWriter();

        new XmlSerializer(typeof(T?)).Serialize(textWriter, instance);

        return textWriter.ToString();
    }

}
