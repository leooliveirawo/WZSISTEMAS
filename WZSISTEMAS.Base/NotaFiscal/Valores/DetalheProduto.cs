using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores;

public class DetalheProduto
{
    [XmlElement("cProd")]
    public string CodigoProduto { get; set; } = default!;

    [XmlElement("cEAN")]
    public string CEAN { get; set; } = default!;

    [XmlElement("xProd")]
    public string Nome { get; set; } = default!;

    [XmlElement("NCM")]
    public string NCM { get; set; } = default!;

    [XmlElement("NVE")]
    public string NVE { get; set; } = default!;

    [XmlElement("EXTIPI")]
    public string EXTIPI { get; set; } = default!;

    [XmlElement("CFOP")]
    public string CFOP { get; set; } = default!;

    [XmlElement("uCom")]
    public decimal UnidadeComercial { get; set; } = default!;

    [XmlElement("qCom")]
    public decimal QuantidadeComercial { get; set; } = default!;

    [XmlElement("vUnCom")]
    public decimal ValorUnitarioComercial { get; set; } = default!;

    [XmlElement("vProd")]
    public decimal ValorProduto { get; set; } = default!;

    [XmlElement("cEANTrib")]
    public string CEANTrib { get; set; } = default!;

    [XmlElement("uTrib")]
    public decimal UnidadeTributavel { get; set; } = default!;


    [XmlElement("qTrib")]
    public decimal QuantidadeTributavel { get; set; } = default!;

    [XmlElement("vUnTrib")]
    public decimal ValorUnitarioTributavel { get; set; } = default!;

    [XmlElement("vFrete")]
    public decimal ValorFrete { get; set; } = default!;

    [XmlElement("vSeg")]
    public decimal ValorSeguro { get; set; } = default!;

    [XmlElement("vDesc")]
    public decimal ValorDesconto { get; set; } = default!;

    [XmlElement("vOutro")]
    public decimal ValorOutro { get; set; } = default!;

    [XmlElement("indTot")]
    public string IndicadorTotal { get; set; } = default!;
}
