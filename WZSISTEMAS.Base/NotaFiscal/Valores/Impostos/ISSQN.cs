using System.Xml.Serialization;

namespace WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

public class ISSQN
{
    [XmlElement("vBC")]
    public string ValorBaseCalculo { get; set; } = default!;

    [XmlElement("vAliq")]
    public string ValorAliquota { get; set; } = default!;

    [XmlElement("cMunFG")]
    public string CodigoMunicipioFatorGerador { get; set; } = default!;

    [XmlElement("cListServ")]
    public string ListaServicos { get; set; } = default!;

    [XmlElement("vDeducao")]
    public string Deducao { get; set; } = default!;

    [XmlElement("vOutro")]
    public string ValorOutrasRetencoes { get; set; } = default!;

    [XmlElement("vDescIncond")]
    public string ValorDescontoIncondicionado { get; set; } = default!;

    [XmlElement("vDescCond")]
    public string ValorDescontoCondicionado { get; set; } = default!;

    [XmlElement("vISSRet")]
    public string ValorRetencaoISS { get; set; } = default!;

    [XmlElement("idISS")]
    public string IndicadorExigibilidadeISS { get; set; } = default!;

    [XmlElement("cServico")]
    public string CodigoServicoPrestado { get; set; } = default!;

    [XmlElement("cMun")]
    public string CodigoMunicipio { get; set; } = default!;

    [XmlElement("cPais")]
    public string CodigoPais { get; set; } = default!;

    [XmlElement("nProcesso")]
    public string NumeroProcesso { get; set; } = default!;

    [XmlElement("indIncentivo")]
    public string IndicadorIncentivoFiscal { get; set; } = default!;

    [XmlElement("impostoDevol")]
    public string ImpostoDevolvido { get; set; } = default!;

    [XmlElement("IPI")]
    public string InformacaoIPIDevolvido { get; set; } = default!;

    [XmlElement("vIPIDevol")]
    public string ValorIPIDevolvido { get; set; } = default!;

    [XmlElement("infAddProd")]
    public string InformacoesAdicionaisProduto { get; set; } = default!;


    [XmlElement("")]
    public string Nome { get; set; } = default!;
}
