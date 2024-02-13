using System.ComponentModel;

namespace WZSISTEMAS.Controles;

public partial class ControleCOFINSNT : UserControl
{
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public COFINSNT COFINS
    {
        get => new()
        {
            CST = txtCOFINS_CST.Text,
        };
        set => txtCOFINS_CST.Text = value.CST;
    }
    public ControleCOFINSNT()
    {
        InitializeComponent();
    }

    public void Clear()
    {
        txtCOFINS_CST.Clear();
    }
}
