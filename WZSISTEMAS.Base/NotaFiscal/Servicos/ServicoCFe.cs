using System.Xml;
using WZSISTEMAS.Base.NotaFiscal.Valores;

namespace WZSISTEMAS.Base.NotaFiscal.Servicos;

public class ServicoCFe(IServicoXml servicoXml) : IServicoCFe
{
    protected virtual IServicoXml ServicoXml { get; } = servicoXml
        ?? throw new ArgumentNullException(nameof(servicoXml));

    private static XmlReader PrepararXml(string xml)
    {
        var textReader = new StringReader(xml);
        var xmlReader = XmlReader.Create(textReader);
        xmlReader.MoveToContent();

        if (xmlReader.LocalName == "cfeProc")
            xmlReader.ReadToDescendant("CFe");

        return xmlReader;
    }

    public virtual string? ConverterParaXml(CFe cFe)
        => ServicoXml.ConverterParaString(cFe);

    public virtual CFe? ConverterParaCFe(string xml)
        => ServicoXml.ConverterDeString<CFe?>(
            PrepararXml(xml));

    public virtual CFe? LerEConverterParaCFe(string caminho)
        => ServicoXml.ConverterDeString<CFe?>(
            PrepararXml(
                ServicoXml.LerArquivo(caminho)));
}
