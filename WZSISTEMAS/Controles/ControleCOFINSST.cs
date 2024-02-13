using System.ComponentModel;

namespace WZSISTEMAS.Controles;

public partial class ControleCOFINSST : UserControl
{
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public COFINSST COFINS
    {
        get => new()
        {
            vBC = txtCOFINS_vBC.Text.ConverterParaDecimalNulo(),
            qBCProd = txtCOFINS_qBCProd.Text.ConverterParaDecimalNulo(),
            vAliqProd = txtCOFINS_vAliqProd.Text.ConverterParaDecimalNulo(),
            pCOFINS = txtCOFINS_pCOFINS.Text.ConverterParaDecimalNulo(),
            vCOFINS = txtCOFINS_vCOFINS.Text.ConverterParaDecimal()
        };
        set
        {
            txtCOFINS_vBC.Text = value.vBC.ToString();
            txtCOFINS_pCOFINS.Text = value.pCOFINS.ToString();
            txtCOFINS_qBCProd.Text = value.qBCProd.ToString();
            txtCOFINS_vAliqProd.Text = value.vAliqProd.ToString();
            txtCOFINS_vCOFINS.Text = value.vCOFINS.ToString();
        }
    }
    public ControleCOFINSST()
    {
        InitializeComponent();
    }

    public void Clear()
    {
        txtCOFINS_vBC.Clear();
        txtCOFINS_pCOFINS.Clear();
        txtCOFINS_qBCProd.Clear();
        txtCOFINS_vAliqProd.Clear();
        txtCOFINS_vCOFINS.Clear();
    }
}
