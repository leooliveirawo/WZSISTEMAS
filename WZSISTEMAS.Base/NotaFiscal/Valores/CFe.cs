using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores;

[XmlRoot("CFe")]
public class CFe
{
    [XmlElement("infCFe")]
    public InformacoesCFe InformacoesCFe { get; set; } = new();
}
