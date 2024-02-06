using System.ComponentModel;
using WZSISTEMAS.Base.Helpers;
using WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;
using WZSISTEMAS.WinForms.Helpers;

namespace WZSISTEMAS.Controles;

public partial class ControleICMSSN202 : UserControl
{
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public ICMSSN202 ICMS
    {
        get => new()
        {
            orig = txtICMS_orig.Text,
            CSOSN = txtICMS_CSOSN.Text,
            modBCST = txtICMS_modBCST.Text,
            pMVAST = txtICMS_pMVAST.ConverterParaDecimal(),
            pRedBCST = txtICMS_pRedBCST.ConverterParaDecimal(),
            vBCST = txtICMS_vBCST.ConverterParaDecimal(),
            pICMSST = txtICMS_pICMSST.Text.ConverterParaDecimal(),
            vICMSST = txtICMS_vICMSST.ConverterParaDecimal()
        };
        set
        {
            txtICMS_orig.Text = value.orig;
            txtICMS_CSOSN.Text = value.CSOSN;
            txtICMS_modBCST.Text = value.modBCST;
            txtICMS_pMVAST.Text = value.pMVAST.ToString();
            txtICMS_pRedBCST.Text = value.pRedBCST.ToString();
            txtICMS_vBCST.Text = value.vBCST.ToString();
            txtICMS_pICMSST.Text = value.pICMSST.ToString();
            txtICMS_vICMSST.Text = value.vICMSST.ToString();
        }
    }

    public ControleICMSSN202()
    {
        InitializeComponent();
    }

    public void Clear()
    {
        txtICMS_orig.Clear();
        txtICMS_CSOSN.Clear();
        txtICMS_modBCST.Clear();
        txtICMS_pMVAST.Clear();
        txtICMS_pRedBCST.Clear();
        txtICMS_vBCST.Clear();
        txtICMS_pICMSST.Clear();
        txtICMS_vICMSST.Clear();
    }
}
