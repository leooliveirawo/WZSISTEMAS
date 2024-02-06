using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

public class ICMS40
{
    [XmlElement("orig")]
    public string orig { get; set; } = default!;

    [XmlElement("CST")]
    public string CST { get; set; } = default!;

    [XmlElement("vICMSDeson", IsNullable = true)]
    public decimal? vICMSDeson { get; set; }

    [XmlElement("motDesICMS", IsNullable = true)]
    public string? motDesICMS { get; set; }
}
