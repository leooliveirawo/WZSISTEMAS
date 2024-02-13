using System.ComponentModel;

namespace WZSISTEMAS.Controles;

public partial class ControleICMSST : UserControl
{
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public ICMSST ICMS
    {
        get => new()
        {
            orig = txtICMS_orig.Text,
            CST = txtICMS_CST.Text,
            vBCSTDest = txtICMS_vBCSTDest.Text.ConverterParaDecimal(),
            vICMSSTDest = txtICMS_vICMSSTDest.Text.ConverterParaDecimal(),
            vBCSTRet = txtICMS_vBCSTRet.ConverterParaDecimal(),
            vICMSSTRet = txtICMS_vICMSSTRet.ConverterParaDecimal()
        };
        set
        {
            txtICMS_orig.Text = value.orig;
            txtICMS_CST.Text = value.CST;
            txtICMS_vBCSTRet.Text = value.vBCSTRet.ToString();
            txtICMS_vICMSSTRet.Text = value.vICMSSTDest.ToString();
            txtICMS_vBCSTDest.Text = value.vBCSTDest.ToString();
            txtICMS_vICMSSTDest.Text = value.vICMSSTDest.ToString();
        }
    }

    public ControleICMSST()
    {
        InitializeComponent();
    }

    public void Clear()
    {
        txtICMS_orig.Clear();
        txtICMS_CST.Clear();
        txtICMS_vBCSTRet.Clear();
        txtICMS_vICMSSTRet.Clear();
        txtICMS_vBCSTDest.Clear();
        txtICMS_vICMSSTDest.Clear();
    }
}
