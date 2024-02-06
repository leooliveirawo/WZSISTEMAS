using System.ComponentModel;
using WZSISTEMAS.Base.Helpers;
using WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

namespace WZSISTEMAS.Controles;

public partial class ControleICMSSN101 : UserControl
{
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public ICMSSN101 ICMS
    {
        get => new()
        {
            orig = txtICMS_orig.Text,
            CSOSN = txtICMS_CSOSN.Text,
            pCredSN = txtICMS_pCredSN.Text.ConverterParaDecimal(),
            vCredICMSSN = txtICMS_vCredICMSSN.Text.ConverterParaDecimal()
        };
        set
        {
            txtICMS_orig.Text = value.orig;
            txtICMS_CSOSN.Text = value.CSOSN;
            txtICMS_pCredSN.Text = value.pCredSN.ToString();
            txtICMS_vCredICMSSN.Text = value.vCredICMSSN.ToString();
        }
    }

    public ControleICMSSN101()
    {
        InitializeComponent();
    }

    public void Clear()
    {
        txtICMS_orig.Clear();
        txtICMS_CSOSN.Clear();
        txtICMS_pCredSN.Clear();
        txtICMS_vCredICMSSN.Clear();
    }
}
