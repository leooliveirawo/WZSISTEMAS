using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

public class ICMS60
{
    [XmlElement("orig")]
    public string orig { get; set; } = default!;

    [XmlElement("CST")]
    public string CST { get; set; } = default!;

    [XmlElement("vBCSTRet", IsNullable = true)]
    public decimal? vBCSTRet { get; set; }

    [XmlElement("vICMSSTRet", IsNullable = true)]
    public decimal? vICMSSTRet { get; set; }

}
