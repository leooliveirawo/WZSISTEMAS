using System.ComponentModel;

namespace WZSISTEMAS.Controles;

public partial class ControlePISAliq : UserControl
{
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public PISAliq PIS
    {
        get => new()
        {
            CST = txtPIS_CST.Text,
            vBC = txtPIS_vBC.Text.ConverterParaDecimal(),
            pPIS = txtPIS_pPIS.Text.ConverterParaDecimal(),
            vPIS = txtPIS_vPIS.Text.ConverterParaDecimal()
        };
        set
        {
            txtPIS_CST.Text = value.CST;
            txtPIS_vBC.Text = value.vBC.ToString();
            txtPIS_pPIS.Text = value.pPIS.ToString();
            txtPIS_vPIS.Text = value.vPIS.ToString();

        }
    }

    public ControlePISAliq()
    {
        InitializeComponent();
    }

    public void Clear()
    {
        txtPIS_CST.Clear();
        txtPIS_vBC.Clear();
        txtPIS_pPIS.Clear();
        txtPIS_vPIS.Clear();
    }
}
