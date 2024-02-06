using System.ComponentModel;
using WZSISTEMAS.Base.Helpers;
using WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

namespace WZSISTEMAS.Controles;

public partial class ControleICMS40 : UserControl
{
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public ICMS40 ICMS
    {
        get => new()
        {
            orig = txtICMS_orig.Text,
            CST = txtICMS_CST.Text,
            vICMSDeson = txtICMS_vICMSDeson.Text.ConverterParaDecimalNulo(),
            motDesICMS = txtICMS_motDesICMS.Text.ObterStringNula()
        };
        set
        {
            txtICMS_orig.Text = value.orig;
            txtICMS_CST.Text = value.CST;
            txtICMS_vICMSDeson.Text = value.vICMSDeson?.ToString() ?? string.Empty;
            txtICMS_motDesICMS.Text = value.motDesICMS;
        }
    }
    public ControleICMS40()
    {
        InitializeComponent();
    }

    public void Clear()
    {
        txtICMS_orig.Clear();
        txtICMS_CST.Clear();
        txtICMS_vICMSDeson.Clear();
        txtICMS_motDesICMS.Clear();
    }
}
