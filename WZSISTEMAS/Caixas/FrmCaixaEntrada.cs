namespace WZSISTEMAS.Caixas;

public partial class FrmCaixaEntrada : Form
{
    private readonly IServicoCaixas servicoCaixas;

    private long caixaId;
    private decimal valorSuprimento;

    public Caixa Caixa { get; private set; } = default!;

    public FrmCaixaEntrada(IServicoCaixas servicoCaixas)
    {
        InitializeComponent();

        this.servicoCaixas = servicoCaixas
            ?? throw new ArgumentNullException(nameof(servicoCaixas));
    }

    public void DefinirCaixaId(long caixaId)
    {
        this.caixaId = caixaId;
    }

    private void Suprir()
    {
        try
        {
            var caixaCaixaEntrada = servicoCaixas.RealizarSuprimento(caixaId, TipoSuprimentoCaixa.Dinheiro, valorSuprimento);

            DialogResult = DialogResult.OK;
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void TxtValorSuprimento_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (btnSuprir.Enabled == true
            && Keys.Return.Comparar(e.KeyChar))
        {
            e.Handled = true;

            Suprir();
        }
    }

    private void BtnSuprir_Click(object sender, EventArgs e)
        => Suprir();

    private void TxtValorSuprimento_TextChanged(object sender, EventArgs e)
    {
        valorSuprimento = txtValorSuprimento.Text.ConverterParaDecimal();

        btnSuprir.Enabled = valorSuprimento > 0;
    }
}
