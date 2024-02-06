using System.Xml.Serialization;
using WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

namespace WZSISTEMAS.Base.NotaFiscal.Valores;

public class Imposto
{
    [XmlElement("ICMS", typeof(ICMS))]
    [XmlElement("ISSQN", typeof(ISSQN))]
    [XmlChoiceIdentifier(nameof(ImpostoTiposICMS_ISSQN))]
    public object ICMS_ISSQN { get; set; } = default!;

    [XmlElement("COFINS")]
    public COFINS COFINS { get; set; } = new();

    [XmlElement("PIS")]
    public PIS PIS { get; set; } = new();

    [XmlIgnore]
    public ImpostoTiposICMS_ISSQN ImpostoTiposICMS_ISSQN { get; set; }
}

