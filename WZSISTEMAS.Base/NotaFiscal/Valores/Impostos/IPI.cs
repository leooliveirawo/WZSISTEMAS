using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

public class IPI
{
    [XmlElement("clEnq")]
    public string ClEnq { get; set; } = default!;

    [XmlElement("CNPJProd")]
    public string CNPJProd { get; set; } = default!;

    [XmlElement("cEnq")]
    public string cEnq { get; set; } = default!;


    [XmlElement("IPINT", IsNullable = true)]
    public IPINT? IPINT { get; set; }
}
