using WZSISTEMAS.Base.Cartoes.Eventos;

namespace WZSISTEMAS;
public partial class FrmSimuladorCartao : Form
{
    private readonly IDriverCartaoVirtual servicoDriverCartaoVirtual;

    public FrmSimuladorCartao(IDriverCartaoVirtual driverCartaoVirtual)
    {
        InitializeComponent();

        this.servicoDriverCartaoVirtual = driverCartaoVirtual ?? throw new ArgumentNullException(nameof(driverCartaoVirtual));

        driverCartaoVirtual.Iniciou += DriverCartaoVirtualStarted;
        driverCartaoVirtual.Cancelou += DriverCartaoVirtualCanceled;
        driverCartaoVirtual.Finalizou += DriverCartaoVirtualConcluded;
    }

    private void Carregar(TransacaoCartaoEventArgs e)
    {
        var formaPagamento = string.Empty;

        if (e.Transacao.MetodoPagamento == 1)
            formaPagamento = "CARTÃO DE DÉBITO";
        else if (e.Transacao.MetodoPagamento == 2)
            formaPagamento = "CARTÃO DE CRÉDITO";
        else if (e.Transacao.MetodoPagamento == 3)
            formaPagamento = "CARTÃO VOUCHER";
        else if (e.Transacao.MetodoPagamento == 4)
            formaPagamento = "CARTÃO CONVÊNIO";

        lbMensagem.Text = $"FORMA DE PAGAMENTO: {formaPagamento}\n\nVALOR: {e.Transacao.ValorPago:C2}\n\n{e.Transacao.MensagemRetorno}";
    }

    private void FrmSimuladorCartao_Load(object sender, EventArgs e)
    {
        lbMensagem.Text = "AGUARDANDO...";

        btnAprovar.Enabled = false;
        btnNaoAprovado.Enabled = false;
    }

    private void DriverCartaoVirtualConcluded(object sender, TransacaoCartaoEventArgs e)
    {
        Carregar(e);

        btnAprovar.Enabled = false;
        btnNaoAprovado.Enabled = false;
    }

    private void DriverCartaoVirtualCanceled(object sender, TransacaoCartaoEventArgs e)
    {
        Carregar(e);

        btnAprovar.Enabled = false;
        btnNaoAprovado.Enabled = false;
    }

    private void DriverCartaoVirtualStarted(object sender, TransacaoCartaoEventArgs e)
    {
        Carregar(e);

        btnAprovar.Enabled = true;
        btnNaoAprovado.Enabled = true;
    }

    private void BtnAprovar_Click(object sender, EventArgs e)
    {
        servicoDriverCartaoVirtual.Aprovado();

        Close();
    }

    private void BtnNaoAprovado_Click(object sender, EventArgs e)
    {
        servicoDriverCartaoVirtual.NaoAprovado();

        Close();
    }
}
