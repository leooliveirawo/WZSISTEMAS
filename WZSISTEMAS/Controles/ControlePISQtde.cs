using System.ComponentModel;
using WZSISTEMAS.Base.Helpers;
using WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;

namespace WZSISTEMAS.Controles;

public partial class ControlePISQtde : UserControl
{
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public PISQtde PIS
    {
        get => new()
        {
            CST = txtPIS_CST.Text,
            qBCProd = txtPIS_qBCProd.Text.ConverterParaDecimal(),
            vAliqProd = txtPIS_vAliqProd.Text.ConverterParaDecimal(),
            vPIS = txtPIS_vPIS.Text.ConverterParaDecimal()
        };
        set
        {
            txtPIS_CST.Text = value.CST;
            txtPIS_qBCProd.Text = value.qBCProd.ToString();
            txtPIS_vAliqProd.Text = value.vAliqProd.ToString();
            txtPIS_vPIS.Text = value.vPIS.ToString();

        }
    }

    public ControlePISQtde()
    {
        InitializeComponent();
    }

    public void Clear()
    {
        txtPIS_CST.Clear();
        txtPIS_qBCProd.Clear();
        txtPIS_vAliqProd.Clear();
        txtPIS_vPIS.Clear();
    }
}
