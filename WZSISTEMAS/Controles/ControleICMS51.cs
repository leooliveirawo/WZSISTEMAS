using WZSISTEMAS.Base.Helpers;
using WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

namespace WZSISTEMAS.Controles;

public partial class ControleICMS51 : UserControl
{
    public ICMS51 ICMS
    {
        get => new()
        {
            orig = txtICMS_orig.Text,
            CST = txtICMS_CST.Text,
            modBC = txtICMS_modBC.Text,
            pRedBC = txtICMS_pRedBC.Text.ConverterParaDecimal(),
            vBC = txtICMS_vBC.Text.ConverterParaDecimal(),
            pICMS = txtICMS_pICMS.Text.ConverterParaDecimal(),
            vICMSOp = txtICMS_vICMSOp.Text.ConverterParaDecimal(),
            pDif = txtICMS_pDif.Text.ConverterParaDecimal(),
            vICMSDif = txtICMS_vICMSDif.Text.ConverterParaDecimal(),
            vICMS = txtICMS_vICMS.Text.ConverterParaDecimal(),
        };
        set
        {
            txtICMS_orig.Text = value.orig;
            txtICMS_CST.Text = value.CST;
            txtICMS_modBC.Text = value.modBC;
            txtICMS_pRedBC.Text = value.pRedBC.ToString();
            txtICMS_vBC.Text = value.vBC.ToString();
            txtICMS_pICMS.Text = value.pICMS.ToString();
            txtICMS_vICMSOp.Text = value.vICMSOp.ToString();
            txtICMS_pDif.Text = value.pDif.ToString();
            txtICMS_vICMSDif.Text = value.vICMSDif.ToString();
            txtICMS_vICMS.Text = value.vICMS.ToString();
        }
    }

    public ControleICMS51()
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
        txtICMS_vICMSOp.Clear();
        txtICMS_pDif.Clear();
        txtICMS_vICMSDif.Clear();
        txtICMS_vICMS.Clear();
    }
}
