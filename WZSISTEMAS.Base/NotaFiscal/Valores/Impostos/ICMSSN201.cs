using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

public class ICMSSN201
{
    [XmlElement("orig")]
    public string orig { get; set; } = default!;

    [XmlElement("CSOSN")]
    public string CSOSN { get; set; } = default!;

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

    [XmlElement("pCredSN")]
    public decimal pCredSN { get; set; } = default!;

    [XmlElement("vCredICMSSN")]
    public decimal vCredICMSSN { get; set; } = default!;
}
