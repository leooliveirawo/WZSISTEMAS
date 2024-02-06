using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

public class ISSQNTotal
{
    [XmlElement("vServ")]
    public string ValorTotalServico { get; set; } = default!;

    [XmlElement("vBC")]
    public string ValorBaseCalculo { get; set; } = default!;

    [XmlElement("vISS")]
    public string ValorISS { get; set; } = default!;

    [XmlElement("vPIS")]
    public string ValorPIS { get; set; } = default!;

    [XmlElement("vCOFINS")]
    public string ValorCOFINS { get; set; } = default!;

    [XmlElement("dCompet")]
    public string DataPrestacaoServico { get; set; } = default!;

    [XmlElement("vDeducao")]
    public string ValorDeducaoBaseCalculo { get; set; } = default!;

    [XmlElement("vOutro")]
    public string ValorOutro { get; set; } = default!;

    [XmlElement("vDescIncond")]
    public string ValorDescontoIncondicionado { get; set; } = default!;

    [XmlElement("vDescCond")]
    public string ValorDescontoCondicionado { get; set; } = default!;

    [XmlElement("vISSRet")]
    public string ValorISSRetido { get; set; } = default!;

    [XmlElement("cRegTrib")]
    public string CodigoRegimeTributario { get; set; } = default!;
}
