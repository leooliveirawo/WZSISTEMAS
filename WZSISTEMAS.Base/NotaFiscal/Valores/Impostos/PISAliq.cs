using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

public class PISAliq
{
    [XmlElement("CST")]
    public string CST { get; set; } = default!;

    [XmlElement("vBC")]
    public decimal vBC { get; set; } = default!;

    [XmlElement("pPIS")]
    public decimal pPIS { get; set; } = default!;

    [XmlElement("vPIS")]
    public decimal vPIS { get; set; } = default!;
}
