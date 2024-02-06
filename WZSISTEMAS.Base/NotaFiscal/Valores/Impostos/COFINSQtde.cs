using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

public class COFINSQtde
{
    [XmlElement("CST")]
    public string CST { get; set; } = default!;

    [XmlElement("qBCProd")]
    public decimal qBCProd { get; set; }

    [XmlElement("vAliqProd")]
    public decimal vAliqProd { get; set; }

    [XmlElement("vCOFINS")]
    public decimal vCOFINS { get; set; }
}
