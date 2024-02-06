using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

public class ICMSSN500
{
    [XmlElement("orig")]
    public string orig { get; set; } = default!;

    [XmlElement("CSOSN")]
    public string CSOSN { get; set; } = default!;

    [XmlElement("vBCSTRet", IsNullable = true)]
    public decimal? vBCSTRet { get; set; }

    [XmlElement("vICMSSTRet", IsNullable = true)]
    public decimal? vICMSSTRet { get; set; }
}
