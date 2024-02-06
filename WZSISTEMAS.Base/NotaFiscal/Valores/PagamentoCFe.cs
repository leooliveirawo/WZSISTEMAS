using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores;

public class PagamentoCFe
{
    [XmlElement("vTroco")]
    public decimal ValorTroco { get; set; }

    [XmlElement("MP")]
    public List<FormaPagamentoCFe> FormaPagamento { get; set; } = new();
}
