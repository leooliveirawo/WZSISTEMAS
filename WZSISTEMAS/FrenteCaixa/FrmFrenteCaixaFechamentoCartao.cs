namespace WZSISTEMAS.FrenteCaixa;

public partial class FrmFrenteCaixaFechamentoCartao : Form
{
    private readonly IServicoCartaoDebito servicoCartaoDebito;
    private readonly IServicoCartaoCredito servicoCartaoCredito;
    private readonly IServicoCartaoVoucher servicoCartaoVoucher;
    private readonly IServicoCartaoLoja servicoCartaoLoja;

    private IServicoCartao servicoCartao = default!;

    private decimal valorPago;
    private TipoEntradaCaixa tipo;

    public bool Finalizado { get; private set; }
    public bool Aprovado { get; private set; }
    public bool Cancelado { get; private set; }

    public FrmFrenteCaixaFechamentoCartao(
        IServicoCartaoDebito servicoCartaoDebito,
        IServicoCartaoCredito servicoCartaoCredito,
        IServicoCartaoVoucher servicoCartaoVoucher,
        IServicoCartaoLoja servicoCartaoLoja)
    {
        InitializeComponent();

        this.servicoCartaoDebito = servicoCartaoDebito ?? throw new ArgumentNullException(nameof(servicoCartaoDebito));
        this.servicoCartaoCredito = servicoCartaoCredito ?? throw new ArgumentNullException(nameof(servicoCartaoCredito));
        this.servicoCartaoVoucher = servicoCartaoVoucher ?? throw new ArgumentNullException(nameof(servicoCartaoVoucher));
        this.servicoCartaoLoja = servicoCartaoLoja ?? throw new ArgumentNullException(nameof(servicoCartaoLoja));
    }

    public void DefinirValorPago(decimal valorPago)
        => this.valorPago = valorPago;

    public void DefinirTipo(TipoEntradaCaixa tipo)
        => this.tipo = tipo;


    public IServicoCartao ObterServicoCartoes()
        => tipo == TipoEntradaCaixa.CartaoDebito
        ? servicoCartaoDebito
        : tipo == TipoEntradaCaixa.CartaoCredito
        ? servicoCartaoCredito
        : tipo == TipoEntradaCaixa.CartaoLoja
        ? servicoCartaoLoja
        : tipo == TipoEntradaCaixa.CartaoVoucher
        ? servicoCartaoVoucher
        : throw new NotSupportedException();

    private void FrmFrenteCaixaFechamentoCartao_Load(object sender, EventArgs e)
    {
        try
        {
            if (EmDesenvolvimento)
                this.AbrirSimuladorCartao(sender, e);

            servicoCartao = ObterServicoCartoes();

            lbMensagem.Text = "AGUARDANDO A APROVAÇÃO";
            lbMensagem.ForeColor = Color.DarkBlue;

            servicoCartao.Finalizou += ServicoCartoes_Finalizou;
            servicoCartao.Cancelou += ServicoCartoes_Cancelou;
            servicoCartao.IniciarTransacao(valorPago);
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);

            Close();
        }
    }

    private void FrmFrenteCaixaFechamentoCartao_KeyDown(object sender, KeyEventArgs e)
    {
        try
        {
            if (e.KeyData.Equals(Keys.Escape))
            {
                if (!Finalizado)
                {
                    if (!Cancelado)
                        servicoCartao.CancelarTransacao();
                    else
                        Close();
                }
                else
                    Close();
            }
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);

            Close();
        }
    }

    private void FrmFrenteCaixaFechamentoCartao_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (Keys.Return.Comparar(e.KeyChar))
        {
            if (Finalizado
                || Cancelado)
                Close();
        }
    }

    private void ServicoCartoes_Finalizou(object sender, TransacaoCartaoEventArgs e)
    {
        Finalizado = true;

        if (e.Transacao.Aprovado)
        {
            lbMensagem.Text = "APROVADO";
            lbMensagem.ForeColor = Color.SeaGreen;

            Aprovado = true;
        }
        else
        {
            lbMensagem.Text = e.Transacao.MensagemRetorno;
            lbMensagem.ForeColor = Color.DarkRed;
        }
    }

    private void ServicoCartoes_Cancelou(object sender, TransacaoCartaoEventArgs e)
    {
        if (e.Transacao.Cancelado)
        {
            lbMensagem.Text = "CANCELADO";
            lbMensagem.ForeColor = Color.DarkRed;

            Cancelado = true;            
        }
        else
        {
            lbMensagem.Text = e.Transacao.MensagemRetorno;
            lbMensagem.ForeColor = Color.DarkRed;
        }
    }

    private void FrmFrenteCaixaFechamentoCartao_FormClosing(object sender, FormClosingEventArgs e)
    {
        try
        {
            if (!Finalizado)
            {
                if (!Cancelado)
                {
                    servicoCartao.CancelarTransacao();

                    e.Cancel = true;
                }
            }
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);

            Close();
        }
    }
}

