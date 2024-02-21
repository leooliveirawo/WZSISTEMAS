namespace WZSISTEMAS.Componentes;

public partial class FrmItemSelecionarPrecos : Form
{
    private readonly IServicoItens servicoItens;

    private long itemId;

    private decimal preco1;
    private decimal preco2;
    private decimal preco3;

    public decimal PrecoSelecionado { get; set; }

    public FrmItemSelecionarPrecos(
        IServicoItens servicoItens)
    {
        InitializeComponent();

        this.servicoItens = servicoItens
            ?? throw new ArgumentNullException(nameof(servicoItens));
    }

    public void DefinirProdutoId(long itemId)
        => this.itemId = itemId;

    private void FrmItemSelecionarPrecos_Load(object sender, EventArgs e)
    {
        try
        {
            var item = servicoItens.ObterPorId(itemId);

            if (item is null)
            {
                this.ExibirMensagem("O produto não foi encontrado.", "Produto não encontrado");

                Close();
            }
            else
            {
                preco1 = item.PrecoFinal;
                rbtnPreco1.Text = $"(F1) - {preco1:C2}";

                if (item.PrecoFinal2.HasValue)
                {
                    preco2 = item.PrecoFinal2.Value;
                    rbtnPreco2.Text = $"(F2) - {preco2:C2}";
                }
                else
                    rbtnPreco2.Desativar();
                if (item.PrecoFinal3.HasValue)
                {
                    preco3 = item.PrecoFinal3.Value;
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

    private void FrmItemSelecionarPrecos_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.VerificarTeclaEnter())
        {
            PrecoSelecionado = rbtnPreco1.Checked ? preco1 : rbtnPreco2.Checked ? preco2 : preco3;

            DialogResult = DialogResult.OK;
        }
        else if (Keys.Escape.Comparar(e.KeyChar))
            e.Handled = true;
    }

    private void FrmItemSelecionarPrecos_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyData == Keys.F1)
            rbtnPreco1.Marcar();
        else if (e.KeyData == Keys.F2)
        {
            if (rbtnPreco2.Enabled)
                rbtnPreco2.Marcar();
        }
        else if (e.KeyData == Keys.F3)
        {
            if (rbtnPreco3.Enabled)
                rbtnPreco3.Marcar();
        }
    }
}
