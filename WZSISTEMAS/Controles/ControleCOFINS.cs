using WZSISTEMAS.Base.NotaFiscal.Helpers;

namespace WZSISTEMAS.Controles;

public partial class ControleCOFINS : UserControl
{
    public TiposCOFINS TipoCOFINS
    {
        get
        {
            if (cbbxTipoCOFINS.SelectedValue is TiposCOFINS tipoCOFINS)
            {
                return tipoCOFINS;
            }
            else
            {
                cbbxTipoCOFINS.SelectedValue = TiposCOFINS.COFINSAliq;

                return TiposCOFINS.COFINSAliq;
            }
        }
        set => cbbxTipoCOFINS.SelectedValue = value;
    }

    public ControleCOFINS()
    {
        InitializeComponent();

        if (!DesignMode)
        {
            cbbxTipoCOFINS.SelectedIndexChanged += CbbxTipoCOFINS_SelectedIndexChanged;
            cbbxTipoCOFINS.Configurar(ValorHelper.ObterListaTipoCOFINS);
        }
    }

    public virtual (TiposCOFINS, string) ObterCOFINS(IServicoJson servicoJson)
    {
        var tipoCOFINS = TipoCOFINS;

        object ObterCOFINS()
        {
            object cOFINS;

            if (tipoCOFINS == TiposCOFINS.COFINSAliq)
                cOFINS = ctCOFINSAliq.COFINS;
            else if (tipoCOFINS == TiposCOFINS.COFINSST)
                cOFINS = ctCOFINSST.COFINS;
            else
            {
                cOFINS = tipoCOFINS == TiposCOFINS.COFINSNT
                ? ctCOFINSNT.COFINS
                : tipoCOFINS == TiposCOFINS.COFINSOutr
                ? ctCOFINSOutr.COFINS
                : tipoCOFINS == TiposCOFINS.COFINSQtde ? (object)ctCOFINSQtde.COFINS : throw new NotSupportedException();
            }

            return cOFINS;
        }

        return (tipoCOFINS,
            servicoJson.Serializar(ObterCOFINS()) ?? throw new InvalidOperationException("Os dados do COFINS não são válidos"));
    }

    public virtual void DefinirCOFINS(IServicoJson servicoJson, TiposCOFINS tipoCOFINS, string cOFINS)
    {
        void DefinirCOFINS()
        {
            if (cOFINS is null)
            {
                ctCOFINSAliq.COFINS = new();
            }
            else if (tipoCOFINS == TiposCOFINS.COFINSAliq)
            {
                ctCOFINSAliq.COFINS = servicoJson.Deserializar<COFINSAliq>(cOFINS) ?? throw new InvalidOperationException("Os dados do COFINS são inválidos");
            }
            else if (tipoCOFINS == TiposCOFINS.COFINSQtde)
            {
                ctCOFINSQtde.COFINS = servicoJson.Deserializar<COFINSQtde>(cOFINS) ?? throw new InvalidOperationException("Os dados do COFINS são inválidos");
            }
            else if (tipoCOFINS == TiposCOFINS.COFINSNT)
            {
                ctCOFINSNT.COFINS = servicoJson.Deserializar<COFINSNT>(cOFINS) ?? throw new InvalidOperationException("Os dados do COFINS são inválidos");
            }
            else if (tipoCOFINS == TiposCOFINS.COFINSOutr)
            {
                ctCOFINSOutr.COFINS = servicoJson.Deserializar<COFINSOutr>(cOFINS) ?? throw new InvalidOperationException("Os dados do COFINS são inválidos");
            }
            else
            {
                ctCOFINSST.COFINS = tipoCOFINS == TiposCOFINS.COFINSST
                ? servicoJson.Deserializar<COFINSST>(cOFINS) ?? throw new InvalidOperationException("Os dados do COFINS são inválidos")
                : throw new NotSupportedException();
            }
        }

        TipoCOFINS = TipoCOFINS;

        DefinirCOFINS();
    }

    public void Clear()
    {
        ctCOFINSAliq.Clear();
        ctCOFINSQtde.Clear();
        ctCOFINSNT.Clear();
        ctCOFINSOutr.Clear();
        ctCOFINSST.Clear();
    }

    private void ControleCOFINS_Load(object sender, EventArgs e)
    {
    }

    private void CbbxTipoCOFINS_SelectedIndexChanged(object? sender, EventArgs e)
    {
       void OcultarControles()
        {
            ctCOFINSAliq.Hide();
            ctCOFINSQtde.Hide();
            ctCOFINSNT.Hide();
            ctCOFINSOutr.Hide();
            ctCOFINSST.Hide();
        }

       void ExibirControle()
        {
            var tipoCOFINS = TipoCOFINS;

            if (tipoCOFINS == TiposCOFINS.COFINSAliq)
                ctCOFINSAliq.Show();
            else if (tipoCOFINS == TiposCOFINS.COFINSQtde)
                ctCOFINSQtde.Show();
            else if (tipoCOFINS == TiposCOFINS.COFINSNT)
                ctCOFINSNT.Show();
            else if (tipoCOFINS == TiposCOFINS.COFINSOutr)
                ctCOFINSOutr.Show();
            else if (tipoCOFINS == TiposCOFINS.COFINSST)
                ctCOFINSST.Show();
        }

        Clear();
        OcultarControles();
        ExibirControle();
    }
}
