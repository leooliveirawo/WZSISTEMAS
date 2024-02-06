using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;


public class ICMSSN102
{
    [XmlElement("orig")]
    public string orig { get; set; } = default!;

    [XmlElement("CSOSN")]
    public string CSOSN { get; set; } = default!;
}
