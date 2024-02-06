using System.ComponentModel;
using WZSISTEMAS.Base.Helpers;
using WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

namespace WZSISTEMAS.Controles;

public partial class ControleICMS30 : UserControl
{
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public ICMS30 ICMS
    {
        get => new()
        {
            orig = txtICMS_orig.Text,
            CST = txtICMS_CST.Text,
            modBC = txtICMS_modBC.Text,
            vBC = txtICMS_vBC.Text.ConverterParaDecimal(),
            pICMS = txtICMS_pICMS.Text.ConverterParaDecimal(),
            vICMS = txtICMS_vICMS.Text.ConverterParaDecimal(),
            modBCST = txtICMS_modBCST.Text,
            pMVAST = txtICMS_pMVAST.Text.ConverterParaDecimal(),
            pRedBCST = txtICMS_pRedBCST.Text.ConverterParaDecimal(),
            vBCST = txtICMS_vBCST.Text.ConverterParaDecimal(),
            pICMSST = txtICMS_pICMSST.Text.ConverterParaDecimal(),
            vICMSST = txtICMS_vICMSST.Text.ConverterParaDecimal(),
            vICMSDeson = txtICMS_vICMSDeson.Text.ConverterParaDecimalNulo(),
            motDesICMS = txtICMS_motDesICMS.Text.ObterStringNula()
        };
        set
        {
            txtICMS_orig.Text = value.orig;
            txtICMS_CST.Text = value.CST;
            txtICMS_modBC.Text = value.modBC;
            txtICMS_vBC.Text = value.vBC.ToString();
            txtICMS_pICMS.Text = value.pICMS.ToString();
            txtICMS_vICMS.Text = value.vICMS.ToString();
            txtICMS_modBCST.Text = value.modBCST;
            txtICMS_pMVAST.Text = value.pMVAST.ToString();
            txtICMS_pRedBCST.Text = value.pRedBCST.ToString();
            txtICMS_vBCST.Text = value.vBCST.ToString();
            txtICMS_pICMSST.Text = value.pICMSST.ToString();
            txtICMS_vICMSST.Text = value.vICMSST.ToString();
            txtICMS_vICMSDeson.Text = value.vICMSDeson.ToString();
            txtICMS_motDesICMS.Text = value.motDesICMS;
        }
    }

    public ControleICMS30()
    {
        InitializeComponent();
    }

    public void Clear()
    {
        txtICMS_orig.Clear();
        txtICMS_CST.Clear();
        txtICMS_modBC.Clear();
        txtICMS_vBC.Clear();
        txtICMS_pICMS.Clear();
        txtICMS_vICMS.Clear();
        txtICMS_modBCST.Clear();
        txtICMS_pMVAST.Clear();
        txtICMS_pRedBCST.Clear();
        txtICMS_vBCST.Clear();
        txtICMS_pICMSST.Clear();
        txtICMS_vICMSST.Clear();
        txtICMS_vICMSDeson.Clear();
        txtICMS_motDesICMS.Clear();
    }
}
