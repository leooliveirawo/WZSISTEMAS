using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

public class ICMS70
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

    [XmlElement("pMVAST")]
    public decimal pMVAST { get; set; } = default!;

    [XmlElement("pRedBCST")]
    public decimal pRedBCST { get; set; } = default!;

    [XmlElement("vBCST")]
    public decimal vBCST { get; set; } = default!;

    [XmlElement("pICMSST")]
    public decimal pICMSST { get; set; } = default!;

    [XmlElement("vICMSST")]
    public decimal vICMSST { get; set; } = default!;

    [XmlElement("vICMSDeson", IsNullable = true)]
    public decimal? vICMSDeson { get; set; }

    [XmlElement("motDesICMS", IsNullable = true)]
    public string? motDesICMS { get; set; }
}
