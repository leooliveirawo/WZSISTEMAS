using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

public class COFINSAliq
{
    [XmlElement("CST")]
    public string CST { get; set; } = default!;

    [XmlElement("vBC")]
    public decimal vBC { get; set; } = default!;

    [XmlElement("pCOFINS")]
    public decimal pCOFINS { get; set; } = default!;

    [XmlElement("vCOFINS")]
    public decimal vCOFINS { get; set; } = default!;
}
