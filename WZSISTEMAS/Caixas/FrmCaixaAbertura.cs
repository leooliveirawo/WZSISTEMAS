namespace WZSISTEMAS.Caixas;

public partial class FrmCaixaAbertura : Form
{
    private readonly IServicoCaixas servicoCaixas;
    
    private long usuarioId;
    private long terminalId;

    private decimal saldoInicial;

    public Caixa? Caixa { get; private set; }

    public FrmCaixaAbertura(IServicoCaixas servicoCaixas)
    {
        InitializeComponent();

        this.servicoCaixas = servicoCaixas
            ?? throw new ArgumentNullException(nameof(servicoCaixas));
    }

    public void DefinirUsuarioId(long usuarioId)
    {
        this.usuarioId = usuarioId;
    }

    public void DefinirTerminalId(long terminalId)
    {
        this.terminalId = terminalId;
    }

    private void AbrirCaixa()
    {
        try
        {
            Caixa = servicoCaixas.AbrirCaixa(usuarioId, terminalId, saldoInicial);

            DialogResult = DialogResult.OK;
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void TxtSaldoInicial_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (btnAbrir.Enabled == true
            && Keys.Return.Comparar(e.KeyChar))
        {
            e.Handled = true;

            AbrirCaixa();
        }
    }

    private void BtnAbrir_Click(object sender, EventArgs e)
        => AbrirCaixa();

    private void TxtSaldoInicial_TextChanged(object sender, EventArgs e)
    {
        btnAbrir.Enabled = decimal.TryParse(txtSaldoInicial.Text, out var saldoInicial)
            && saldoInicial >= 0;

        this.saldoInicial = saldoInicial;
    }
}
