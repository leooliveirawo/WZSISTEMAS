using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores;

public class InformacoesCFe
{
    [XmlAttribute("Id")]
    public string Id { get; set; } = default!;

    [XmlAttribute("versao")]
    public string Versao { get; set; } = default!;

    [XmlAttribute("versaoDadosEnt")]
    public string VersaoDadosEntrada { get; set; } = default!;

    [XmlAttribute("versaoSB")]
    public string VersaoSB { get; set; } = default!;

    [XmlElement("ide")]
    public IdentificacaoCFe Identificacao { get; set; } = new();

    [XmlElement("emit")]
    public Emitente Emitente { get; set; } = new();

    [XmlElement("dest")]
    public Destinatario Destinatario { get; set; } = new();

    [XmlElement("det")]
    public List<Detalhe> Detalhes { get; set; } = new();

    [XmlElement("total")]
    public TotalCFe Total { get; set; } = new();

    [XmlElement("pgto")]
    public PagamentoCFe Pagamento { get; set; } = new();
}
