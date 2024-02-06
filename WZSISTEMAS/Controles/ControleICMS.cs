using WZSISTEMAS.Base.NotaFiscal.Helpers;
using WZSISTEMAS.Base.NotaFiscal.Valores.Impostos;
using WZSISTEMAS.Base.Servicos.Interfaces;
using WZSISTEMAS.WinForms.Helpers;

namespace WZSISTEMAS.Controles;

public partial class ControleICMS : UserControl
{
    public TiposICMS TipoICMS
    {
        get
        {
            if (cbbxTipoICMS.SelectedValue is TiposICMS tipoICMS)
            {
                return tipoICMS;
            }
            else
            {
                cbbxTipoICMS.SelectedValue = TiposICMS.ICMS00;

                return (TiposICMS)cbbxTipoICMS.SelectedValue;
            }
        }
        set => cbbxTipoICMS.SelectedValue = value;
    }

    public ControleICMS()
    {
        InitializeComponent();

        if (!DesignMode)
        {
            cbbxTipoICMS.SelectedIndexChanged += CbbxTipoICMS_SelectedIndexChanged;
            cbbxTipoICMS.Configurar(ValorHelper.ObterListaTipoICMS);
        }
    }

    public void Clear()
    {
        ctICMS00.Clear();
        ctICMS10.Clear();
        ctICMS20.Clear();
        ctICMS30.Clear();
        ctICMS40.Clear();
        ctICMS51.Clear();
        ctICMS60.Clear();
        ctICMS70.Clear();
        ctICMS90.Clear();
        ctICMSSN101.Clear();
        ctICMSSN102.Clear();
        ctICMSSN201.Clear();
        ctICMSSN202.Clear();
        ctICMSSN500.Clear();
        ctICMSSN900.Clear();
        ctICMSST.Clear();
    }

    public virtual (TiposICMS, string) ObterICMS(IServicoJson servicoJson)
    {
        var tipoICMS = TipoICMS;

        object ObterICMS()
        {
            object iCMS;

            if (tipoICMS == TiposICMS.ICMS00)
                iCMS = ctICMS00.ICMS;
            else if (tipoICMS == TiposICMS.ICMS10)
                iCMS = ctICMS10.ICMS;
            else if (tipoICMS == TiposICMS.ICMS20)
                iCMS = ctICMS20.ICMS;
            else if (tipoICMS == TiposICMS.ICMS30)
                iCMS = ctICMS30.ICMS;
            else if (tipoICMS == TiposICMS.ICMS40)
                iCMS = ctICMS40.ICMS;
            else if (tipoICMS == TiposICMS.ICMS51)
                iCMS = ctICMS51.ICMS;
            else if (tipoICMS == TiposICMS.ICMS60)
                iCMS = ctICMS60.ICMS;
            else if (tipoICMS == TiposICMS.ICMS70)
                iCMS = ctICMS70.ICMS;
            else if (tipoICMS == TiposICMS.ICMS90)
                iCMS = ctICMS90.ICMS;
            else if (tipoICMS == TiposICMS.ICMSSN101)
                iCMS = ctICMSSN101.ICMS;
            else if (tipoICMS == TiposICMS.ICMSSN102)
                iCMS = ctICMSSN102.ICMS;
            else if (tipoICMS == TiposICMS.ICMSSN201)
                iCMS = ctICMSSN201.ICMS;
            else if (tipoICMS == TiposICMS.ICMSSN202)
                iCMS = ctICMSSN202.ICMS;
            else
            {
                iCMS = tipoICMS == TiposICMS.ICMSSN500
                ? ctICMSSN500.ICMS
                : tipoICMS == TiposICMS.ICMSSN900
                ? ctICMSSN900.ICMS
                : tipoICMS == TiposICMS.ICMSST ? (object)ctICMSST.ICMS : throw new NotSupportedException();
            }

            return iCMS;
        }

        return (tipoICMS,
            servicoJson.Serializar(ObterICMS()) ?? throw new InvalidOperationException("Os dados do ICMS não são válidos"));
    }

    public virtual void DefinirICMS(IServicoJson servicoJson, TiposICMS tipoICMS, string iCMS)
    {
        TipoICMS = tipoICMS;

        DefinirICMS();

        void DefinirICMS()
        {
            if (iCMS is null)
            {
                ctICMS00.ICMS = new();
            }
            else if (tipoICMS == TiposICMS.ICMS00)
            {
                ctICMS00.ICMS = servicoJson.Deserializar<ICMS00>(iCMS) ?? throw new InvalidOperationException("Os dados do ICMS são inválidos");
            }
            else if (TipoICMS == TiposICMS.ICMS10)
            {
                ctICMS10.ICMS = servicoJson.Deserializar<ICMS10>(iCMS)
                    ?? throw new InvalidOperationException("Os dados do ICMS são inválidos");
            }
            else if (TipoICMS == TiposICMS.ICMS20)
            {
                ctICMS20.ICMS = servicoJson.Deserializar<ICMS20>(iCMS)
                    ?? throw new InvalidOperationException("Os dados do ICMS são inválidos");
            }
            else if (TipoICMS == TiposICMS.ICMS30)
            {
                ctICMS30.ICMS = servicoJson.Deserializar<ICMS30>(iCMS)
                    ?? throw new InvalidOperationException("Os dados do ICMS são inválidos");
            }
            else if (TipoICMS == TiposICMS.ICMS40)
            {
                ctICMS40.ICMS = servicoJson.Deserializar<ICMS40>(iCMS) ?? throw new InvalidOperationException("Os dados do ICMS são inválidos");
            }
            else if (TipoICMS == TiposICMS.ICMS51)
            {
                ctICMS51.ICMS = servicoJson.Deserializar<ICMS51>(iCMS)
                    ?? throw new InvalidOperationException("Os dados do ICMS são inválidos");
            }
            else if (TipoICMS == TiposICMS.ICMS60)
            {
                ctICMS60.ICMS = servicoJson.Deserializar<ICMS60>(iCMS)
                    ?? throw new InvalidOperationException("Os dados do ICMS são inválidos");
            }
            else if (TipoICMS == TiposICMS.ICMS70)
            {
                ctICMS70.ICMS = servicoJson.Deserializar<ICMS70>(iCMS)
                    ?? throw new InvalidOperationException("Os dados do ICMS são inválidos");
            }
            else if (TipoICMS == TiposICMS.ICMS90)
            {
                ctICMS90.ICMS = servicoJson.Deserializar<ICMS90>(iCMS)
                    ?? throw new InvalidOperationException("Os dados do ICMS são inválidos");
            }
            else if (TipoICMS == TiposICMS.ICMSSN101)
            {
                ctICMSSN101.ICMS = servicoJson.Deserializar<ICMSSN101>(iCMS)
                    ?? throw new InvalidOperationException("Os dados do ICMS são inválidos");
            }
            else if (TipoICMS == TiposICMS.ICMSSN102)
            {
                ctICMSSN102.ICMS = servicoJson.Deserializar<ICMSSN102>(iCMS)
                    ?? throw new InvalidOperationException("Os dados do ICMS são inválidos");
            }
            else if (TipoICMS == TiposICMS.ICMSSN201)
            {
                ctICMSSN201.ICMS = servicoJson.Deserializar<ICMSSN201>(iCMS) ?? throw new InvalidOperationException("Os dados do ICMS são inválidos");
            }
            else if (TipoICMS == TiposICMS.ICMSSN202)
            {
                ctICMSSN202.ICMS = servicoJson.Deserializar<ICMSSN202>(iCMS)
                    ?? throw new InvalidOperationException("Os dados do ICMS são inválidos");
            }
            else if (TipoICMS == TiposICMS.ICMSSN500)
            {
                ctICMSSN500.ICMS = servicoJson.Deserializar<ICMSSN500>(iCMS)
                    ?? throw new InvalidOperationException("Os dados do ICMS são inválidos");
            }
            else if (TipoICMS == TiposICMS.ICMSSN900)
            {
                ctICMSSN900.ICMS = servicoJson.Deserializar<ICMSSN900>(iCMS)
                    ?? throw new InvalidOperationException("Os dados do ICMS são inválidos");
            }
            else
            {
                ctICMSST.ICMS = TipoICMS == TiposICMS.ICMSST
                ? servicoJson.Deserializar<ICMSST>(iCMS)
                ?? throw new InvalidOperationException("Os dados do ICMS são inválidos")
                : throw new NotSupportedException();
            }
        }

    }

    private void ControleICMS_Load(object sender, EventArgs e)
    {
    }

    private void CbbxTipoICMS_SelectedIndexChanged(object? sender, EventArgs e)
    {
       void OcultarControles()
        {
            ctICMS00.Hide();
            ctICMS10.Hide();
            ctICMS20.Hide();
            ctICMS30.Hide();
            ctICMS40.Hide();
            ctICMS51.Hide();
            ctICMS60.Hide();
            ctICMS70.Hide();
            ctICMS90.Hide();
            ctICMSSN101.Hide();
            ctICMSSN102.Hide();
            ctICMSSN201.Hide();
            ctICMSSN202.Hide();
            ctICMSSN500.Hide();
            ctICMSSN900.Hide();
            ctICMSST.Hide();
        }

       void ExibirControle()
        {
            var tipoICMS = TipoICMS;

            if (tipoICMS == TiposICMS.ICMS00)
                ctICMS00.Show();
            else if (tipoICMS == TiposICMS.ICMS10)
                ctICMS10.Show();
            else if (tipoICMS == TiposICMS.ICMS20)
                ctICMS20.Show();
            else if (tipoICMS == TiposICMS.ICMS30)
                ctICMS30.Show();
            else if (tipoICMS == TiposICMS.ICMS40)
                ctICMS40.Show();
            else if (tipoICMS == TiposICMS.ICMS51)
                ctICMS51.Show();
            else if (tipoICMS == TiposICMS.ICMS60)
                ctICMS60.Show();
            else if (tipoICMS == TiposICMS.ICMS70)
                ctICMS70.Show();
            else if (tipoICMS == TiposICMS.ICMS90)
                ctICMS90.Show();
            else if (tipoICMS == TiposICMS.ICMSSN101)
                ctICMSSN101.Show();
            else if (tipoICMS == TiposICMS.ICMSSN102)
                ctICMSSN102.Show();
            else if (tipoICMS == TiposICMS.ICMSSN201)
                ctICMSSN201.Show();
            else if (tipoICMS == TiposICMS.ICMSSN202)
                ctICMSSN202.Show();
            else if (tipoICMS == TiposICMS.ICMSSN500)
                ctICMSSN500.Show();
            else if (tipoICMS == TiposICMS.ICMSSN900)
                ctICMSSN900.Show();
            else ctICMSST.Visible = tipoICMS == TiposICMS.ICMSST ? true : throw new NotSupportedException();
        }

        Clear();
        OcultarControles();
        ExibirControle();
    }
}
