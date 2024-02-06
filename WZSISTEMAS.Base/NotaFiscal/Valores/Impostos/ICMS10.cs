using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

public class ICMS10
{
    [XmlElement(elementName: "orig")]
    public string orig { get; set; } = default!;

    [XmlElement("CST")]
    public string CST { get; set; } = default!;

    [XmlElement("modBC")]
    public string modBC { get; set; } = default!;

    [XmlElement("vBC")]
    public decimal vBC { get; set; } = default!;

    [XmlElement("pICMS")]
    public decimal pICMS { get; set; }

    [XmlElement("vICMS")]
    public decimal vICMS { get; set; }

    [XmlElement("modBCST")]
    public string modBCST { get; set; } = default!;

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
}
