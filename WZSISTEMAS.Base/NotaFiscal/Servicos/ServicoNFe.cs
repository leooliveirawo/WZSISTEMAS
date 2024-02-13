using System.Xml;
using WZSISTEMAS.Base.NotaFiscal.Valores;

namespace WZSISTEMAS.Base.NotaFiscal.Servicos;

public class ServicoNFe(IServicoXml servicoXml) : Interfaces.ServicoNFe
{
    protected virtual IServicoXml ServicoXml { get; } = servicoXml ?? throw new ArgumentNullException(nameof(servicoXml));

    private static XmlReader PrepareXml(string xml)
    {
        var textReader = new StringReader(xml);
        var xmlReader = XmlReader.Create(textReader);
        xmlReader.MoveToContent();

        if (xmlReader.LocalName == "nfeProc")
        {
            xmlReader.ReadToDescendant("NFe");
        }

        return xmlReader;
    }

    public virtual NFe? ConverterParaNFe(string xml)
    {
        return ServicoXml.ConverterDeString<NFe?>(PrepareXml(xml));
    }

    public virtual NFe? LerEConverterParaNFe(string caminho)
    {
        return ServicoXml.ConverterDeString<NFe?>(
            PrepareXml(
                ServicoXml.LerArquivo(caminho)));
    }
}
