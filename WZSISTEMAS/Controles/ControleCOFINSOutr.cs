using System.ComponentModel;
using WZSISTEMAS.Base.Helpers;
using WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

namespace WZSISTEMAS.Controles;

public partial class ControleCOFINSOutr : UserControl
{
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public COFINSOutr COFINS
    {
        get => new()
        {
            CST = txtCOFINS_CST.Text,
            vBC = txtCOFINS_vBC.Text.ConverterParaDecimalNulo(),
            qBCProd = txtCOFINS_qBCProd.Text.ConverterParaDecimalNulo(),
            vAliqProd = txtCOFINS_vAliqProd.Text.ConverterParaDecimalNulo(),
            pCOFINS = txtCOFINS_pCOFINS.Text.ConverterParaDecimalNulo(),
            vCOFINS = txtCOFINS_vCOFINS.Text.ConverterParaDecimal()
        };
        set
        {
            txtCOFINS_CST.Text = value.CST;
            txtCOFINS_vBC.Text = value.vBC.ToString();
            txtCOFINS_pCOFINS.Text = value.pCOFINS.ToString();
            txtCOFINS_qBCProd.Text = value.qBCProd.ToString();
            txtCOFINS_vAliqProd.Text = value.vAliqProd.ToString();
            txtCOFINS_vCOFINS.Text = value.vCOFINS.ToString();
        }
    }

    public ControleCOFINSOutr()
    {
        InitializeComponent();
    }

    public void Clear()
    {
        txtCOFINS_CST.Clear();
        txtCOFINS_vBC.Clear();
        txtCOFINS_pCOFINS.Clear();
        txtCOFINS_qBCProd.Clear();
        txtCOFINS_vAliqProd.Clear();
        txtCOFINS_vCOFINS.Clear();
    }
}
