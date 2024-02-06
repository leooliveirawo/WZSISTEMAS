using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores;


[XmlRoot("NFe", Namespace = "http://www.portalfiscal.inf.br/nfe")]
public class NFe
{
    [XmlElement("infNFe")]
    public InformacoesNFe InformacoesNFe { get; set; } = default!;
}
