using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

public class COFINS
{
    [XmlElement("COFINSAliq", typeof(COFINSAliq))]
    [XmlElement("COFINSNT", typeof(COFINSNT))]
    [XmlElement("COFINSOutr", typeof(COFINSOutr))]
    [XmlElement("COFINSQtde", typeof(COFINSQtde))]
    [XmlElement("COFINSST", typeof(COFINSST))]
    [XmlChoiceIdentifier(nameof(TipoCOFINS))]
    public object ItemCOFINS { get; set; } = default!;

    [XmlIgnore]
    public TiposCOFINS TipoCOFINS { get; set; }
}
