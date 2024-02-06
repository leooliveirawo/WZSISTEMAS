using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

public class PIS
{
    [XmlElement("PISAliq", typeof(PISAliq))]
    [XmlElement("PISNT", typeof(PISNT))]
    [XmlElement("PISOutr", typeof(PISOutr))]
    [XmlElement("PISQtde", typeof(PISQtde))]
    [XmlChoiceIdentifier(nameof(TipoPIS))]
    public object ItemPIS { get; set; } = default!;

    [XmlIgnore]
    public TiposPIS TipoPIS { get; set; }
}
