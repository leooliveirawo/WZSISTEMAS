using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

public class COFINSST
{
    [XmlElement("vBC")]
    public decimal? vBC { get; set; }

    [XmlElement("pCOFINS")]
    public decimal? pCOFINS { get; set; }

    [XmlElement("qBCProd")]
    public decimal? qBCProd { get; set; }

    [XmlElement("vAliqProd")]
    public decimal? vAliqProd { get; set; }

    [XmlElement("vCOFINS")]
    public decimal? vCOFINS { get; set; }
}
