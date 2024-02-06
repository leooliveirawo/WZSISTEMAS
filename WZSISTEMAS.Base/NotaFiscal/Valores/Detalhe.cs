using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores;

public class Detalhe
{
    [XmlAttribute("nItem")]
    public string NumeroItem { get; set; } = default!;

    [XmlElement("prod")]
    public DetalheProduto Produto { get; set; } = new();

    [XmlElement("imposto")]
    public Imposto Imposto { get; set; } = new();
}
