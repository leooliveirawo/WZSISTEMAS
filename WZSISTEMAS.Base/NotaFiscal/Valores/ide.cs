using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores;

public class NFe_ide
{
    [XmlElement("cUF")]
    public string cUF { get; set; } = default!;

    [XmlElement("cNF")]
    public string cNF { get; set; } = default!;

    [XmlElement("natOp")]
    public string natOp { get; set; } = default!;

    [XmlElement("indPag")]
    public string indPag { get; set; } = default!;

    [XmlElement("mod")]
    public string mod { get; set; } = default!;

    [XmlElement("serie")]
    public string serie { get; set; } = default!;

    [XmlElement("nNF")]
    public string nNF { get; set; } = default!;

    [XmlElement("dhEmi")]
    public string dhEmi { get; set; } = default!;

    [XmlElement("dhSaiEnt")]
    public string dhSaiEnt { get; set; } = default!;

    [XmlElement("tpNF")]
    public string tpNF { get; set; } = default!;

    [XmlElement("idDest")]
    public string idDest { get; set; } = default!;

    [XmlElement("cMunFG")]
    public string cMunFG { get; set; } = default!;

    [XmlElement("tpImp")]
    public string tpImp { get; set; } = default!;

    [XmlElement("tpEmis")]
    public string tpEmis { get; set; } = default!;

    [XmlElement("cDV")]
    public string cDV { get; set; } = default!;

    [XmlElement("tpAmb")]
    public string tpAmb { get; set; } = default!;

    [XmlElement("findNFe")]
    public string findNFe { get; set; } = default!;

    [XmlElement("indPres")]
    public string indPres { get; set; } = default!;

    [XmlElement("procEmi")]
    public string procEmi { get; set; } = default!;

    [XmlElement("verProc")]
    public string verProc { get; set; } = default!;
}
