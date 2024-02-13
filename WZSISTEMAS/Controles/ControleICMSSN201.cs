using System.ComponentModel;

namespace WZSISTEMAS.Controles;

public partial class ControleICMSSN201 : UserControl
{
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public ICMSSN201 ICMS
    {
        get => new()
        {
            orig = txtICMS_orig.Text,
            CSOSN = txtICMS_CSOSN.Text,
            modBCST = txtICMS_modBCST.Text,
            pRedBCST = txtICMS_pRedBCST.Text.ConverterParaDecimal(),
            vBCST = txtICMS_vBCST.Text.ConverterParaDecimal(),
            pMVAST = txtICMS_pMVAST.Text.ConverterParaDecimal(),
            vICMSST = txtICMS_vICMSST.Text.ConverterParaDecimal(),
            pICMSST = txtICMS_pICMSST.Text.ConverterParaDecimal(),
            pCredSN = txtICMS_pCredSN.Text.ConverterParaDecimal(),
            vCredICMSSN = txtICMS_vCredICMSSN.Text.ConverterParaDecimal(),
        };
        set
        {
            txtICMS_orig.Text = value.orig;
            txtICMS_CSOSN.Text = value.CSOSN;
            txtICMS_modBCST.Text = value.modBCST;
            txtICMS_pRedBCST.Text = value.pRedBCST.ToString();
            txtICMS_vBCST.Text = value.vBCST.ToString();
            txtICMS_pMVAST.Text = value.pMVAST.ToString();
            txtICMS_vICMSST.Text = value.vICMSST.ToString();
            txtICMS_pCredSN.Text = value.pCredSN.ToString();
            txtICMS_vCredICMSSN.Text = value.vCredICMSSN.ToString();

        }
    }

    public ControleICMSSN201()
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
        txtICMS_pCredSN.Clear();
        txtICMS_vCredICMSSN.Clear();
    }
}
