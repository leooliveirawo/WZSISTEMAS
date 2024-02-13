using System.ComponentModel;

namespace WZSISTEMAS.Controles;

public partial class ControleCOFINSAliq : UserControl
{
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public COFINSAliq COFINS
    {
        get => new()
        {
            CST = txtCOFINS_CST.Text,
            vBC = txtCOFINS_vBC.Text.ConverterParaDecimal(),
            pCOFINS = txtCOFINS_pCOFINS.Text.ConverterParaDecimal(),
            vCOFINS = txtCOFINS_vCOFINS.Text.ConverterParaDecimal()
        };
        set
        {
            txtCOFINS_CST.Text = value.CST;
            txtCOFINS_vBC.Text = value.vBC.ToString();
            txtCOFINS_pCOFINS.Text = value.pCOFINS.ToString();
            txtCOFINS_vCOFINS.Text = value.vCOFINS.ToString();
        }
    }

    public ControleCOFINSAliq()
    {
        InitializeComponent();
    }

    public void Clear()
    {
        txtCOFINS_CST.Clear();
        txtCOFINS_vBC.Clear();
        txtCOFINS_pCOFINS.Clear();
        txtCOFINS_vCOFINS.Clear();
    }
}
