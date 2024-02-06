using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores.SAT;

[XmlRoot("configuracoes")]
public class DadosSAT
{
    [XmlElement("nserieSAT")]
    public string NumeroSerieSAT { get; set; } = default!;

    [XmlElement("nSeg")]
    public string NumeroSeguranca { get; set; } = default!;

    [XmlElement("cAtiv")]
    public string CodigoAtivacao { get; set; } = default!;

    [XmlElement("versaoSchema")]
    public string VersaoSchema { get; set; } = default!;

    [XmlElement("versaoLayoutCFe")]
    public string VersaoLayoutCFe { get; set; } = default!;
}
