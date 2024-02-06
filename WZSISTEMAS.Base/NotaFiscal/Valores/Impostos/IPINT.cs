using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

public class IPINT
{
    [XmlElement("CST")]
    public string CST { get; set; } = default!;
}
