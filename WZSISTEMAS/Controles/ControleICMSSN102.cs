using System.ComponentModel;
using WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

namespace WZSISTEMAS.Controles;

public partial class ControleICMSSN102 : UserControl
{
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public ICMSSN102 ICMS
    {
        get => new()
        {
            orig = txtICMS_orig.Text,
            CSOSN = txtICMS_CSOSN.Text
        };
        set
        {
            txtICMS_orig.Text = value.orig;
            txtICMS_CSOSN.Text = value.CSOSN;
        }
    }

    public ControleICMSSN102()
    {
        InitializeComponent();
    }

    public void Clear()
    {
        txtICMS_orig.Clear();
        txtICMS_CSOSN.Clear();
    }
}
