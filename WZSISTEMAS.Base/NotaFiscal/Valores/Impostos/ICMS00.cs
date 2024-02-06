using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

public class ICMS00
{
    [XmlElement("orig")]
    public string orig { get; set; } = default!;

    [XmlElement("CST")]
    public string CST { get; set; } = default!;

    [XmlElement("modBC")]
    public string modBC { get; set; } = default!;

    [XmlElement("vBC")]
    public decimal vBC { get; set; }

    [XmlElement("pICMS")]
    public decimal pICMS { get; set; }

    [XmlElement("vICMS")]
    public decimal vICMS { get; set; }
}
