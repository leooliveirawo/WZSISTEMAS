namespace WZSISTEMAS.FrenteCaixa;

public partial class FrmFrenteCaixaFechamentoConvenio : Form
{
    private readonly IServicoClientes servicoClientes;

    private long clienteId;
    private VendaPagamento vendaPagamento = default!;

    public FrmFrenteCaixaFechamentoConvenio(
        IServicoClientes servicoClientes)
    {
        InitializeComponent();

        this.servicoClientes = servicoClientes
            ?? throw new ArgumentNullException(nameof(servicoClientes));
    }

    public void DefinirValor(VendaPagamento vendaPagamento)
    {
        this.vendaPagamento = vendaPagamento;

        lbValorTotal.Text = $"{vendaPagamento.ValorPago:C2}";
        lbParcela.Text = $"{vendaPagamento.ValorPago:C2}";
    }

    private void Consultar()
    {
        try
        {
            using var frm = ProvedorServicos.FrmConsultaAvancadaConvenio();

            if (frm.ShowDialog(this, DialogResult.OK))
            {
                clienteId = frm.Id;

                RecarregarConsulta();
            }
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void RecarregarConsulta()
    {
        txtCPF_CNPJ.Clear();
        txtNomeCompleto_RazaoSocial.Clear();

        if (!servicoClientes.VerificarLimiteDisponivel(clienteId, vendaPagamento.ValorPago))
        {
            this.ExibirMensagem("O cliente não possuí limite disponível, por favor, contate o financeiro.", "Limite indisponível");

            clienteId = 0;

            btnConfirmar.Enabled = false;

            return;
        }

        var cliente = servicoClientes.ObterPorId(clienteId)
            ?? throw new InvalidOperationException("Cliente não encontrado");

        txtNomeCompleto_RazaoSocial.Text = cliente.NomeCompleto_RazaoSocial;
        txtCPF_CNPJ.Text = cliente.CPF_CNPJ;

        btnConfirmar.Enabled = true;
    }

    private void BtnConsultar_Click(object sender, EventArgs e)
        => Consultar();

    private void NmduNumeroParcelas_ValueChanged(object sender, EventArgs e)
        => lbParcela.Text = $"{vendaPagamento.ValorPago / nmduNumeroParcelas.Value:C2}";

    private void BtnConfirmar_Click(object sender, EventArgs e)
    {
        vendaPagamento.ClienteId = clienteId;
        vendaPagamento.ClienteLancamentosNumero = Convert.ToInt32(nmduNumeroParcelas.Value);

        DialogResult = DialogResult.OK;
    }

    private void BtnVoltar_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void FrmFrenteCaixaFechamentoConvenio_Load(object sender, EventArgs e)
    {
        btnConfirmar.Enabled = false;
    }
}
