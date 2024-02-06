using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

public class COFINSOutr
{
    [XmlElement("CST")]
    public string CST { get; set; } = default!;

    [XmlElement("vBC", IsNullable = true)]
    public decimal? vBC { get; set; }

    [XmlElement("pCOFINS", IsNullable = true)]
    public decimal? pCOFINS { get; set; }

    [XmlElement("qBCProd", IsNullable = true)]
    public decimal? qBCProd { get; set; }

    [XmlElement("vAliqProd", IsNullable = true)]
    public decimal? vAliqProd { get; set; }

    [XmlElement("vCOFINS")]
    public decimal vCOFINS { get; set; }


}
