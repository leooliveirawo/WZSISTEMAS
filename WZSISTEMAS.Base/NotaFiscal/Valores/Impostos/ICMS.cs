using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

public class ICMS
{
    [XmlElement("ICMS00", typeof(ICMS00))]
    [XmlElement("ICMS10", typeof(ICMS10))]
    [XmlElement("ICMS20", typeof(ICMS20))]
    [XmlElement("ICMS30", typeof(ICMS30))]
    [XmlElement("ICMS40", typeof(ICMS40))]
    [XmlElement("ICMS51", typeof(ICMS51))]
    [XmlElement("ICMS60", typeof(ICMS60))]
    [XmlElement("ICMS70", typeof(ICMS70))]
    [XmlElement("ICMS90", typeof(ICMS90))]
    [XmlElement("ICMSSN101", typeof(ICMSSN101))]
    [XmlElement("ICMSSN102", typeof(ICMSSN102))]
    [XmlElement("ICMSSN201", typeof(ICMSSN201))]
    [XmlElement("ICMSSN202", typeof(ICMSSN202))]
    [XmlElement("ICMSSN500", typeof(ICMSSN500))]
    [XmlElement("ICMSSN900", typeof(ICMSSN900))]
    [XmlElement("ICMSST", typeof(ICMSST))]
    [XmlChoiceIdentifier(nameof(TipoICMS))]
    public object ItemICMS { get; set; } = default!;

    [XmlIgnore]

    public TiposICMS TipoICMS { get; set; }

    public  string? ConverterParaJson(IServicoJson servicoJson)
    {
        return servicoJson.Serializar(ItemICMS);
    }

    public void ConverterDeJson(IServicoJson servicoJson, TiposICMS tipoICMS, string jsonICMS)
    {
        ItemICMS = tipoICMS switch
        {
            TiposICMS.ICMS00 => servicoJson.Deserializar<ICMS00>(jsonICMS) ?? throw new InvalidOperationException("O JSON do ICMS não é válido"),
            TiposICMS.ICMS10 => servicoJson.Deserializar<ICMS10>(jsonICMS) ?? throw new InvalidOperationException("O JSON do ICMS não é válido"),
            TiposICMS.ICMS20 => servicoJson.Deserializar<ICMS20>(jsonICMS) ?? throw new InvalidOperationException("O JSON do ICMS não é válido"),
            TiposICMS.ICMS30 => servicoJson.Deserializar<ICMS30>(jsonICMS) ?? throw new InvalidOperationException("O JSON do ICMS não é válido"),
            TiposICMS.ICMS40 => servicoJson.Deserializar<ICMS40>(jsonICMS) ?? throw new InvalidOperationException("O JSON do ICMS não é válido"),
            TiposICMS.ICMS51 => servicoJson.Deserializar<ICMS51>(jsonICMS) ?? throw new InvalidOperationException("O JSON do ICMS não é válido"),
            TiposICMS.ICMS60 => servicoJson.Deserializar<ICMS60>(jsonICMS) ?? throw new InvalidOperationException("O JSON do ICMS não é válido"),
            TiposICMS.ICMS70 => servicoJson.Deserializar<ICMS70>(jsonICMS) ?? throw new InvalidOperationException("O JSON do ICMS não é válido"),
            TiposICMS.ICMS90 => servicoJson.Deserializar<ICMS90>(jsonICMS) ?? throw new InvalidOperationException("O JSON do ICMS não é válido"),
            TiposICMS.ICMSSN101 => servicoJson.Deserializar<ICMSSN101>(jsonICMS) ?? throw new InvalidOperationException("O JSON do ICMS não é válido"),
            TiposICMS.ICMSSN102 => servicoJson.Deserializar<ICMSSN102>(jsonICMS) ?? throw new InvalidOperationException("O JSON do ICMS não é válido"),
            TiposICMS.ICMSSN201 => servicoJson.Deserializar<ICMSSN201>(jsonICMS) ?? throw new InvalidOperationException("O JSON do ICMS não é válido"),
            TiposICMS.ICMSSN202 => servicoJson.Deserializar<ICMSSN202>(jsonICMS) ?? throw new InvalidOperationException("O JSON do ICMS não é válido"),
            TiposICMS.ICMSSN500 => servicoJson.Deserializar<ICMSSN500>(jsonICMS) ?? throw new InvalidOperationException("O JSON do ICMS não é válido"),
            TiposICMS.ICMSSN900 => servicoJson.Deserializar<ICMSSN900>(jsonICMS) ?? throw new InvalidOperationException("O JSON do ICMS não é válido"),
            TiposICMS.ICMSST => servicoJson.Deserializar<ICMSST>(jsonICMS) ?? throw new InvalidOperationException("O JSON do ICMS não é válido"),
            _ => throw new NotSupportedException(),
        };

        TipoICMS = tipoICMS;

    }
}


