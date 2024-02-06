using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores;

public class Destinatario
{
    [XmlElement("CPF")]
    [XmlElement("CNPJ")]
    [XmlChoiceIdentifier(nameof(DestinatarioTipoCPF_CNPJ))]
    public string CPF_CNPJ { get; set; } = default!;

    [XmlIgnore]
    public DestinatarioTiposCPF_CNPJ DestinatarioTipoCPF_CNPJ { get; set; }

    [XmlElement("idEstrangeiro")]
    public string IdentificacaoEstrangeiro { get; set; } = default!;

    [XmlElement("xNome")]
    public string NomeOuRazaoSocial { get; set; } = default!;

    [XmlElement("xFant")]
    public string NomeFantasia { get; set; } = default!;

    [XmlElement("indIEDest")]
    public string IndicadorIEDestinatario { get; set; } = default!;

    [XmlElement("IE")]
    public string IE { get; set; } = default!;

    [XmlElement("ISUF")]
    public string InscricaoSUFRAMA { get; set; } = default!;

    [XmlElement("IM")]
    public string IM { get; set; } = default!;

    [XmlElement("email")]
    public string Email { get; set; } = default!;

    [XmlElement("enderDest")]
    public Endereco Endereco { get; set; } = new();

}
