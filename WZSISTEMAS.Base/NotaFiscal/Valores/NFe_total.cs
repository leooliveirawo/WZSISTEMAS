using System.Xml.Serialization;
using WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

namespace WZSISTEMAS.Base.NotaFiscal.Valores;

public class NFe_total
{
    [XmlElement("ICMSTot", typeof(ICMSTotal))]
    [XmlElement("ISSQNTot", typeof(ISSQNTotal))]
    [XmlChoiceIdentifier(nameof(totalTipoICMSTot_ISSQNTot))]
    public object ICMSTotalOuISSQNTotal { get; set; } = default!;

    [XmlIgnore]
    public totalTiposICMSTot_ISSQNTot totalTipoICMSTot_ISSQNTot { get; set; }
}
public class TotalCFe
{
    [XmlElement("ICMSTot", typeof(ICMSTotal))]
    [XmlElement("ISSQNTot", typeof(ISSQNTotal))]
    [XmlChoiceIdentifier(nameof(totalTipoICMSTot_ISSQNTot))]
    public object ICMSTotalOuISSQNTotal { get; set; } = default!;

    [XmlIgnore]
    public totalTiposICMSTot_ISSQNTot totalTipoICMSTot_ISSQNTot { get; set; }

    [XmlElement("vCFe")]
    public decimal ValorTotal { get; set; } = default!;
}
