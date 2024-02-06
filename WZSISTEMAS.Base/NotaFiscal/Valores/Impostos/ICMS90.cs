using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

public class ICMS90
{
    [XmlElement("orig")]
    public string orig { get; set; } = default!;

    [XmlElement("CST")]
    public string CST { get; set; } = default!;

    [XmlElement("modBC", IsNullable = true)]
    public string? modBC { get; set; }

    [XmlElement("vBC", IsNullable = true)]
    public decimal? vBC { get; set; }

    [XmlElement("pRedBC", IsNullable = true)]
    public decimal? pRedBC { get; set; }

    [XmlElement("pICMS", IsNullable = true)]
    public decimal? pICMS { get; set; }

    [XmlElement("vICMS", IsNullable = true)]
    public decimal? vICMS { get; set; }

    [XmlElement("modBCST", IsNullable = true)]
    public string? modBCST { get; set; }

    [XmlElement("pMVAST", IsNullable = true)]
    public decimal? pMVAST { get; set; }

    [XmlElement("pRedBCST", IsNullable = true)]
    public decimal? pRedBCST { get; set; }

    [XmlElement("vBCST", IsNullable = true)]
    public decimal? vBCST { get; set; }

    [XmlElement("pICMSST", IsNullable = true)]
    public decimal? pICMSST { get; set; }

    [XmlElement("vICMSST", IsNullable = true)]
    public decimal? vICMSST { get; set; }

}
