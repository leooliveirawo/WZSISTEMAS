using System.ComponentModel;

namespace WZSISTEMAS.Controles;

public partial class ControleICMS20 : UserControl
{
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public ICMS20 ICMS
    {
        get => new()
        {
            orig = txtICMS_orig.Text,
            CST = txtICMS_CST.Text,
            pRedBC = txtICMS_pRedBC.Text.ConverterParaDecimal(),
            modBC = txtICMS_modBC.Text,
            vBC = txtICMS_vBC.Text.ConverterParaDecimal(),
            pICMS = txtICMS_pICMS.Text.ConverterParaDecimal(),
            vICMS = txtICMS_vICMS.Text.ConverterParaDecimal(),
            vICMSDeson = txtICMS_vICMSDeson.Text.ConverterParaDecimalNulo(),
            motDesICMS = txtICMS_motDesICMS.Text.ObterStringNula()
        };
        set
        {
            txtICMS_orig.Text = value.orig;
            txtICMS_CST.Text = value.CST;
            txtICMS_modBC.Text = value.modBC;
            txtICMS_pRedBC.Text = value.pRedBC.ToString();
            txtICMS_vBC.Text = value.vBC.ToString();
            txtICMS_pICMS.Text = value.pICMS.ToString();
            txtICMS_vICMS.Text = value.vICMS.ToString();
            txtICMS_vICMSDeson.Text = value.vICMSDeson.ToString();
            txtICMS_motDesICMS.Text = value.motDesICMS;
        }
    }

    public ControleICMS20()
    {
        InitializeComponent();
    }

    public void Clear()
    {
        txtICMS_orig.Clear();
        txtICMS_CST.Clear();
        txtICMS_modBC.Clear();
        txtICMS_pRedBC.Clear();
        txtICMS_vBC.Clear();
        txtICMS_pICMS.Clear();
        txtICMS_vICMS.Clear();
        txtICMS_vICMSDeson.Clear();
        txtICMS_motDesICMS.Clear();
    }

    private void TxtICMS_pRedBC_TextChanged(object sender, EventArgs e)
    {

    }
}
