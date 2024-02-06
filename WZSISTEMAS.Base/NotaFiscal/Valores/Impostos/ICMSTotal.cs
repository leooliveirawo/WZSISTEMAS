using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

public class ICMSTotal
{
    [XmlElement("vBC")]
    public string ValorBaseCalculo { get; set; } = default!;

    [XmlElement("vICMS")]
    public string ValorICMS { get; set; } = default!;

    [XmlElement("vICMSDeson")]
    public string ValorICMSDesonerado { get; set; } = default!;

    [XmlElement("vBCST")]
    public string ValorBaseCalculoST { get; set; } = default!;

    [XmlElement("vICMSST")]
    public string ValorICMSST { get; set; } = default!;

    [XmlElement("vST")]
    public string ValorST { get; set; } = default!;

    [XmlElement("vProd")]
    public string ValorProduto { get; set; } = default!;

    [XmlElement("vFrete")]
    public string ValorFrete { get; set; } = default!;

    [XmlElement("vSeg")]
    public string ValorSeguro { get; set; } = default!;

    [XmlElement("vDesconto")]
    public string ValorDesconto { get; set; } = default!;

    [XmlElement("vII")]
    public string ValorII { get; set; } = default!;

    [XmlElement("vIPI")]
    public string ValorIPI { get; set; } = default!;

    [XmlElement("vPIS")]
    public string ValorPIS { get; set; } = default!;

    [XmlElement("vCOFINS")]
    public string ValorCOFINS { get; set; } = default!;

    [XmlElement("vOutro")]
    public string ValorOutro { get; set; } = default!;

    [XmlElement("vNF")]
    public string ValorTotal { get; set; } = default!;

    [XmlElement("vTotTrib ")]
    public string ValorTotalTributos { get; set; } = default!;
}
