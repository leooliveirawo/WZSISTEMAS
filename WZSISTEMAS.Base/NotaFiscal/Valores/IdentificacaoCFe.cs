using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores;

public class IdentificacaoCFe
{
    [XmlElement("cUF")]
    public string CodigoUF { get; set; } = default!;

    [XmlElement("cNF")]
    public string ChaveAcesso { get; set; } = default!;

    [XmlElement("mod")]
    public string Modelo { get; set; } = default!;

    [XmlElement("nserieSAT")]
    public string NumeroSerieSAT { get; set; } = default!;

    [XmlElement("nNF")]
    public string NumeroNotaFiscal { get; set; } = default!;

    [XmlElement("nCFe")]
    public string NumeroCFe { get; set; } = default!;

    [XmlElement("dEmi")]
    public string DataEmissao { get; set; } = default!;

    [XmlElement("hEmi")]
    public string HoraEmissao { get; set; } = default!;

    [XmlElement("cDV")]
    public string CDV { get; set; } = default!;

    [XmlElement("tpAmb")]
    public string TipoAmbiente { get; set; } = default!;

    [XmlElement("CNPJ")]
    public string CNPJ { get; set; } = default!;

    [XmlElement("signAC")]
    public string SignAC { get; set; } = default!;

    [XmlElement("assinaturaQRCODE")]
    public string AssinaturaQRCODE { get; set; } = default!;

    [XmlElement("numeroCaixa")]
    public string NumeroCaixa { get; set; } = default!;
}
