using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

public class PISST
{
    [XmlElement("vBC")]
    public decimal? vBC { get; set; }

    [XmlElement("pPIS")]
    public decimal? pPIS { get; set; }

    [XmlElement("qBCProd")]
    public decimal? qBCProd { get; set; }

    [XmlElement("vAliqProd")]
    public decimal? vAliqProd { get; set; }

    [XmlElement("vPIS")]
    public decimal? vPIS { get; set; }
}
