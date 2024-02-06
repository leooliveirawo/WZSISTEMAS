using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores;

public class InformacoesNFe
{
    [XmlAttribute("Id")]
    public string Id { get; set; } = default!;

    [XmlElement("ide")]
    public NFe_ide ide { get; set; } = default!;

    [XmlElement("emit")]
    public Emitente Emitente { get; set; } = default!;

    [XmlElement("dest")]
    public Destinatario Destinatario { get; set; } = default!;

    [XmlElement("det")]
    public List<Detalhe> det { get; set; } = default!;

    [XmlElement("total")]
    public NFe_total total { get; set; } = default!;
}
