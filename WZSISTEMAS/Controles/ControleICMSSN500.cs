using System.ComponentModel;

namespace WZSISTEMAS.Controles;

public partial class ControleICMSSN500 : UserControl
{
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public ICMSSN500 ICMS
    {
        get => new()
        {
            orig = txtICMS_orig.Text,
            CSOSN = txtICMS_CSOSN.Text,
            vBCSTRet = txtICMS_vBCSTRet.Text.ConverterParaDecimalNulo(),
            vICMSSTRet = txtICMS_vICMSSTRet.Text.ConverterParaDecimalNulo()
        };
        set
        {
            txtICMS_orig.Text = value.orig;
            txtICMS_CSOSN.Text = value.CSOSN;
            txtICMS_vBCSTRet.Text = value.vBCSTRet?.ToString() ?? string.Empty;
            txtICMS_vICMSSTRet.Text = value.vICMSSTRet?.ToString() ?? string.Empty;
        }
    }

    public ControleICMSSN500()
    {
        InitializeComponent();
    }

    public void Clear()
    {
        txtICMS_orig.Clear();
        txtICMS_CSOSN.Clear();
        txtICMS_vBCSTRet.Clear();
        txtICMS_vICMSSTRet.Clear();
    }
}
