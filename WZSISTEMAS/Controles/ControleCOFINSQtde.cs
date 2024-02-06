using System.ComponentModel;
using WZSISTEMAS.Base.Helpers;
using WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

namespace WZSISTEMAS.Controles;

public partial class ControleCOFINSQtde : UserControl
{
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public COFINSQtde COFINS
    {
        get => new()
        {
            CST = txtCOFINS_CST.Text,
            qBCProd = txtCOFINS_qBCProd.Text.ConverterParaDecimal(),
            vAliqProd = txtCOFINS_vAliqProd.Text.ConverterParaDecimal(),
            vCOFINS = txtCOFINS_vCOFINS.Text.ConverterParaDecimal()
        };
        set
        {
            txtCOFINS_CST.Text = value.CST;
            txtCOFINS_qBCProd.Text = value.qBCProd.ToString();
            txtCOFINS_vAliqProd.Text = value.vAliqProd.ToString();
            txtCOFINS_vCOFINS.Text = value.vCOFINS.ToString();
        }
    }

    public ControleCOFINSQtde()
    {
        InitializeComponent();
    }

    public void Clear()
    {
        txtCOFINS_CST.Clear();
        txtCOFINS_qBCProd.Clear();
        txtCOFINS_vAliqProd.Clear();
        txtCOFINS_vCOFINS.Clear();
    }
}
