using System.ComponentModel;
using WZSISTEMAS.Base.Helpers;
using WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

namespace WZSISTEMAS.Controles;

public partial class ControleICMSSN900 : UserControl
{
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public ICMSSN900 ICMS
    {
        get => new()
        {
            orig = txtICMS_orig.Text,
            CSOSN = txtICMS_CSOSN.Text,
            pICMS = txtICMS_pICMS.Text.ConverterParaDecimal()
        };
        set
        {
            txtICMS_orig.Text = value.orig;
            txtICMS_CSOSN.Text = value.CSOSN;
            txtICMS_pICMS.Text = value.pICMS.ToString();
        }
    }

    public ControleICMSSN900()
    {
        InitializeComponent();
    }

    public void Clear()
    {
        txtICMS_orig.Clear();
        txtICMS_CSOSN.Clear();
        txtICMS_pICMS.Clear();
    }
}
