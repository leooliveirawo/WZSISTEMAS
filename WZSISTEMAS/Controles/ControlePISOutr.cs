using System.ComponentModel;
using WZSISTEMAS.Base.Helpers;
using WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

namespace WZSISTEMAS.Controles;

public partial class ControlePISOutr : UserControl
{
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public PISOutr PIS
    {
        get => new()
        {
            CST = txtPIS_CST.Text,
            vBC = txtPIS_vBC.Text.ConverterParaDecimalNulo(),
            pPIS = txtPIS_pPIS.Text.ConverterParaDecimalNulo(),
            qBCProd = txtPIS_qBCProd.Text.ConverterParaDecimalNulo(),
            vAliqProd = txtPIS_vAliqProd.Text.ConverterParaDecimalNulo(),
            vPIS = txtPIS_vPIS.Text.ConverterParaDecimal()
        };
        set
        {
            txtPIS_CST.Text = value.CST;
            txtPIS_vBC.Text = value.vBC.ToString();
            txtPIS_pPIS.Text = value.pPIS.ToString();
            txtPIS_qBCProd.Text = value.qBCProd.ToString();
            txtPIS_vAliqProd.Text = value.vAliqProd.ToString();
            txtPIS_vPIS.Text = value.vPIS.ToString();
        }
    }

    public ControlePISOutr()
    {
        InitializeComponent();
    }

    public void Clear()
    {
        txtPIS_CST.Clear();
        txtPIS_vBC.Clear();
        txtPIS_pPIS.Clear();
        txtPIS_qBCProd.Clear();
        txtPIS_vAliqProd.Clear();
        txtPIS_vPIS.Clear();
    }
}
