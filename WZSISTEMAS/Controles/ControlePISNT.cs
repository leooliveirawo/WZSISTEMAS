using System.ComponentModel;
using WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

namespace WZSISTEMAS.Controles;

public partial class ControlePISNT : UserControl
{
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public PISNT PIS
    {
        get => new()
        {
            CST = txtPIS_CST.Text
        };
        set => txtPIS_CST.Text = value.CST;
    }

    public ControlePISNT()
    {
        InitializeComponent();
    }

    public void Clear()
    {
        txtPIS_CST.Clear();
    }
}
