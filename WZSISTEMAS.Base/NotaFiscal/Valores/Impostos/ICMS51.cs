using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

public class ICMS51
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

    [XmlElement("vICMSOp")]
    public decimal vICMSOp { get; set; } = default!;

    [XmlElement("pDif")]
    public decimal pDif { get; set; } = default!;

    [XmlElement("vICMSDif")]
    public decimal vICMSDif { get; set; } = default!;

    [XmlElement("vICMS")]
    public decimal vICMS { get; set; } = default!;

}
