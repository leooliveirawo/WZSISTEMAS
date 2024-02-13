using WZSISTEMAS.Base.NotaFiscal.Helpers;

namespace WZSISTEMAS.Controles;

public partial class ControlePIS : UserControl
{
    public TiposPIS TipoPIS
    {
        get
        {
            if (cbbxTipoPIS.SelectedValue is TiposPIS tipoPIS)
            {
                return tipoPIS;
            }
            else
            {
                cbbxTipoPIS.SelectedValue = TiposPIS.PISAliq;

                return (TiposPIS)cbbxTipoPIS.SelectedValue;
            }
        }
        set => cbbxTipoPIS.SelectedValue = value;
    }

    public ControlePIS()
    {
        InitializeComponent();

        if (!DesignMode)
        {
            cbbxTipoPIS.SelectedIndexChanged += CbbxTipoPIS_SelectedIndexChanged;
            cbbxTipoPIS.Configurar(ValorHelper.ObterListaTipoPIS);
        }
    }

    public void Clear()
    {
        ctPISAliq.Clear();
        ctPISNT.Clear();
        ctPISOutr.Clear();
        ctPISQtde.Clear();
        ctPISST.Clear();
    }

    public virtual (TiposPIS, string) ObterPIS(IServicoJson servicoJson)
    {
        var tipoPIS = TipoPIS;

        object ObterPIS()
        {
            object pIS;

            if (tipoPIS == TiposPIS.PISAliq)
                pIS = ctPISAliq.PIS;
            else if (tipoPIS == TiposPIS.PISNT)
                pIS = ctPISNT.PIS;
            else
            {
                pIS = tipoPIS == TiposPIS.PISQtde
                ? ctPISQtde.PIS
                : tipoPIS == TiposPIS.PISOutr
                ? ctPISOutr.PIS
                : tipoPIS == TiposPIS.PISST ? (object)ctPISST.PIS : throw new NotSupportedException();
            }

            return pIS;
        }

        return (tipoPIS,
            servicoJson.Serializar(ObterPIS()) ?? throw new InvalidOperationException("Os dados do ICMS não são válidos"));
    }

    public virtual void DefinirPIS(IServicoJson servicoJson, TiposPIS tipoPIS, string pIS)
    {
        void DefinirPIS()
        {
            if (pIS is null)
            {
                ctPISAliq.PIS = new();
            }
            else if (tipoPIS == TiposPIS.PISAliq)
            {
                ctPISAliq.PIS = servicoJson.Deserializar<PISAliq>(pIS) ?? throw new InvalidOperationException("Os dados do PIS são inválidos");
            }
            else if (tipoPIS == TiposPIS.PISNT)
            {
                ctPISNT.PIS = servicoJson.Deserializar<PISNT>(pIS) ?? throw new InvalidOperationException("Os dados do PIS são inválidos");
            }
            else if (tipoPIS == TiposPIS.PISOutr)
            {
                ctPISOutr.PIS = servicoJson.Deserializar<PISOutr>(pIS) ?? throw new InvalidOperationException("Os dados do PIS são inválidos");
            }
            else if (tipoPIS == TiposPIS.PISQtde)
            {
                ctPISQtde.PIS = servicoJson.Deserializar<PISQtde>(pIS) ?? throw new InvalidOperationException("Os dados do PIS são inválidos");
            }
            else
            {
                ctPISST.PIS = tipoPIS == TiposPIS.PISST
                ? servicoJson.Deserializar<PISST>(pIS) ?? throw new InvalidOperationException("Os dados do PIS são inválidos")
                : throw new NotSupportedException();
            }
        }

        TipoPIS = tipoPIS;

        DefinirPIS();
    }

    private void ControlePIS_Load(object sender, EventArgs e)
    {
    }

    private void CbbxTipoPIS_SelectedIndexChanged(object? sender, EventArgs e)
    {
       void OcultarControles()
        {
            ctPISAliq.Hide();
            ctPISNT.Hide();
            ctPISOutr.Hide();
            ctPISQtde.Hide();
            ctPISST.Hide();
        }

       void ExibirControle()
        {
            var tipoPIS = TipoPIS;

            if (tipoPIS == TiposPIS.PISAliq)
                ctPISAliq.Show();
            else if (tipoPIS == TiposPIS.PISNT)
                ctPISNT.Show();
            else if (tipoPIS == TiposPIS.PISOutr)
                ctPISOutr.Show();
            else if (tipoPIS == TiposPIS.PISQtde)
                ctPISQtde.Show();
            else if (tipoPIS == TiposPIS.PISST)
                ctPISST.Show();
        }

        Clear();
        OcultarControles();
        ExibirControle();
    }
}
