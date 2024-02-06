using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores;

public class FormaPagamentoCFe
{
    [XmlElement("cMP")]
    public required string CodigoFormaPagamento { get; set; }

    [XmlElement("vMP")]
    public decimal ValorPago { get; set; }
}
