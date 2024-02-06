using System.ComponentModel;
using WZSISTEMAS.Base.Helpers;
using WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

namespace WZSISTEMAS.Controles;

public partial class ControleICMS60 : UserControl
{
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public ICMS60 ICMS
    {
        get => new()
        {
            orig = txtICMS_orig.Text,
            CST = txtICMS_CST.Text,
            vBCSTRet = txtICMS_vBCSTRet.Text.ConverterParaDecimalNulo(),
            vICMSSTRet = txtICMS_vICMSSTRet.Text.ConverterParaDecimalNulo()
        };
        set
        {
            txtICMS_orig.Text = value.orig;
            txtICMS_CST.Text = value.CST;
            txtICMS_vBCSTRet.Text = value.vBCSTRet?.ToString() ?? string.Empty;
            txtICMS_vICMSSTRet.Text = value.vICMSSTRet?.ToString() ?? string.Empty;
        }
    }

    public ControleICMS60()
    {
        InitializeComponent();
    }

    public void Clear()
    {
        txtICMS_orig.Clear();
        txtICMS_CST.Clear();
        txtICMS_vBCSTRet.Clear();
        txtICMS_vICMSSTRet.Clear();
    }
}
