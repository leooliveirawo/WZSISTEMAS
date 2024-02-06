using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

public class ICMS20
{
    [XmlElement("orig")]
    public string orig { get; set; } = default!;

    [XmlElement("CST")]
    public string CST { get; set; } = default!;

    [XmlElement("modBC")]
    public string modBC { get; set; } = default!;

    [XmlElement("pRedBC")]
    public decimal pRedBC { get; set; } = default!;

    [XmlElement("vBC")]
    public decimal vBC { get; set; } = default!;

    [XmlElement("pICMS")]
    public decimal pICMS { get; set; } = default!;

    [XmlElement("vICMS")]
    public decimal vICMS { get; set; } = default!;

    [XmlElement("vICMSDeson", IsNullable = true)]
    public decimal? vICMSDeson { get; set; }

    [XmlElement("motDesICMS", IsNullable = true)]
    public string? motDesICMS { get; set; }
}
