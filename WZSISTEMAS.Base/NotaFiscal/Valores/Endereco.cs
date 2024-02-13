using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores;

public class Endereco : IEndereco
{
    [XmlElement("xLgr")]
    public string Logradouro { get; set; } = default!;

    [XmlElement("nro")]
    public string? LogradouroNumero { get; set; } = default!;

    [XmlElement("xCpl")]
    public string? Complemento { get; set; } = default!;

    [XmlElement("xBairro")]
    public string Bairro { get; set; } = default!;

    [XmlElement("cMun")]
    public string CodigoCidade { get; set; } = default!;

    [XmlElement("xMun")]
    public string Cidade { get; set; } = default!;

    [XmlElement("UF")]
    public UFs UF { get; set; } = default!;

    [XmlElement("CEP")]
    public string CEP { get; set; } = default!;

    [XmlElement("cPais")]
    public string? CodigoPais { get; set; } = default!;

    [XmlElement("xPais")]
    public string? Pais { get; set; } = default!;

    [XmlElement("emit")]
    public string? Telefone { get; set; } = default!;
}
