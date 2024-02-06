using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

public class ICMSST
{
    [XmlElement("orig")]
    public string orig { get; set; } = default!;

    [XmlElement("CST")]
    public string CST { get; set; } = default!;

    [XmlElement("vBCSTRet")]
    public decimal vBCSTRet { get; set; } = default!;

    [XmlElement("vICMSSTRet")]
    public decimal vICMSSTRet { get; set; } = default!;

    [XmlElement("vBCSTDest")]
    public decimal vBCSTDest { get; set; } = default!;

    [XmlElement("vICMSSTDest")]
    public decimal vICMSSTDest { get; set; } = default!;
}
