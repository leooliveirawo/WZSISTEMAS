using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

public class PISQtde
{
    [XmlElement("CST")]
    public string CST { get; set; } = default!;

    [XmlElement("qBCProd")]
    public decimal qBCProd { get; set; } = default!;

    [XmlElement("vAliqProd")]
    public decimal vAliqProd { get; set; } = default!;

    [XmlElement("vPIS")]
    public decimal vPIS { get; set; } = default!;
}
