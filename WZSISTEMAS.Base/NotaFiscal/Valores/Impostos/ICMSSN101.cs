using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

public class ICMSSN101
{
    [XmlElement("orig")]
    public string orig { get; set; } = default!;

    [XmlElement("CSOSN")]
    public string CSOSN { get; set; } = default!;

    [XmlElement("pCredSN")]
    public decimal pCredSN { get; set; } = default!;

    [XmlElement("vCredICMSSN")]
    public decimal vCredICMSSN { get; set; } = default!;
}
