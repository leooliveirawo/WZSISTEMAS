namespace WZSISTEMAS.FrenteCaixa;

public partial class FrmFrenteCaixaSelecionarPrecos : Form
{
    private readonly IServicoItens servicoItens;

    private long itemId;

    private decimal preco1;
    private decimal preco2;
    private decimal preco3;

    public decimal PrecoSelecionado { get; set; }

    public FrmFrenteCaixaSelecionarPrecos(
        IServicoItens servicoItens)
    {
        InitializeComponent();

        this.servicoItens = servicoItens
            ?? throw new ArgumentNullException(nameof(servicoItens));
    }

    public void DefinirProdutoId(long itemId)
        => this.itemId = itemId;

    private void FrmFrenteCadastroSelecionarPrecos_Load(object sender, EventArgs e)
    {
        try
        {
            var produto = servicoItens.ObterPorId(itemId);

            if (produto is null)
            {
                this.ExibirMensagem("O produto não foi encontrado.", "Produto não encontrado");

                Close();
            }
            else
            {
                preco1 = produto.PrecoFinal;
                rbtnPreco1.Text = $"(F1) - {preco1:C2}";

                if (produto.PrecoFinal2.HasValue)
                {
                    preco2 = produto.PrecoFinal2.Value;
                    rbtnPreco2.Text = $"(F2) - {preco2:C2}";
                }
                else
                    rbtnPreco2.Desativar();
                if (produto.PrecoFinal3.HasValue)
                {
                    preco3 = produto.PrecoFinal3.Value;
                    rbtnPreco3.Text = $"(F3) - {preco3:C2}";
                }
                else
                    rbtnPreco3.Desativar();
            }
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void FrmFrenteCadastroSelecionarPrecos_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.VerificarTeclaEnter())
        {
            PrecoSelecionado = rbtnPreco1.Checked ? preco1 : rbtnPreco2.Checked ? preco2 : preco3;

            DialogResult = DialogResult.OK;
        }
        else if (Keys.Escape.Comparar(e.KeyChar))
            e.Handled = true;
    }

    private void FrmFrenteCaixaSelecionarPrecos_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyData == Keys.F1)
            rbtnPreco1.Marcar();
        else if (e.KeyData == Keys.F2)
        {
            if (rbtnPreco2.Enabled == true)
                rbtnPreco2.Marcar();
        }
        else if (e.KeyData == Keys.F3)
        {
            if (rbtnPreco3.Enabled == true)
                rbtnPreco3.Marcar();
        }
    }
}
