using System.ComponentModel;

namespace WZSISTEMAS.Controles;

public partial class ControlePISST : UserControl
{
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public PISST PIS
    {
        get => new()
        {
            vBC = txtPIS_vBC.Text.ConverterParaDecimalNulo(),
            pPIS = txtPIS_vBC.Text.ConverterParaDecimalNulo(),
            qBCProd = txtPIS_qBCProd.Text.ConverterParaDecimalNulo(),
            vAliqProd = txtPIS_vAliqProd.Text.ConverterParaDecimalNulo(),
            vPIS = txtPIS_vPIS.Text.ConverterParaDecimal()
        };
        set
        {
            txtPIS_vBC.Text = value.vBC.ToString();
            txtPIS_pPIS.Text = value.pPIS.ToString();
            txtPIS_qBCProd.Text = value.qBCProd.ToString();
            txtPIS_vAliqProd.Text = value.vAliqProd.ToString();
            txtPIS_vPIS.Text = value.vPIS.ToString();
        }
    }
    public ControlePISST()
    {
        InitializeComponent();
    }

    public void Clear()
    {
        txtPIS_vBC.Clear();
        txtPIS_pPIS.Clear();
        txtPIS_qBCProd.Clear();
        txtPIS_vAliqProd.Clear();
        txtPIS_vPIS.Clear();
    }
}
