using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

public class PISOutr
{
    [XmlElement("CST")]
    public string CST { get; set; } = default!;

    [XmlElement("vBC", IsNullable = true)]
    public decimal? vBC { get; set; }

    [XmlElement("pPIS", IsNullable = true)]
    public decimal? pPIS { get; set; }

    [XmlElement("qBCProd", IsNullable = true)]
    public decimal? qBCProd { get; set; }

    [XmlElement("vAliqProd", IsNullable = true)]
    public decimal? vAliqProd { get; set; }

    [XmlElement("vPIS")]
    public decimal vPIS { get; set; } = default!;
}
