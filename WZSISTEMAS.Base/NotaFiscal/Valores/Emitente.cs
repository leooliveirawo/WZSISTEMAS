using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores;

public class Emitente
{
    [XmlElement("CPF")]
    [XmlElement("CNPJ")]
    [XmlChoiceIdentifier(nameof(EmitenteTipoCPF_CNPJ))]
    public string CPF_CNPJ { get; set; } = default!;

    [XmlIgnore]
    public EmitenteTiposCPF_CNPJ EmitenteTipoCPF_CNPJ { get; set; }

    [XmlElement("xNome")]
    public string NomeOuRazaoSocial { get; set; } = default!;

    [XmlElement("xFant")]
    public string NomeFantasia { get; set; } = default!;

    [XmlElement("IE")]
    public string IE { get; set; } = default!;

    [XmlElement("IEST")]
    public string IEST { get; set; } = default!;

    [XmlElement("enderEmit")]
    public Endereco Endereco { get; set; } = new();
}
