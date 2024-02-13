namespace WZSISTEMAS.Caixas;

public partial class FrmCaixaSaida : Form
{
    private readonly IServicoCaixas servicoCaixas;

    private long caixaId;
    private decimal valor;

    public FrmCaixaSaida(IServicoCaixas servicoCaixas)
    {
        InitializeComponent();

        this.servicoCaixas = servicoCaixas
            ?? throw new ArgumentNullException(nameof(servicoCaixas));
    }

    public void DefinirCaixaId(long caixaId)
    {
        this.caixaId = caixaId;
    }

    private void Retirar()
    {
        try
        {
            var tipo = cbbxTipoRetirada.Converter<TipoSaidaCaixa>();
            var valorRetirada = txtValorRetirada.Text.ConverterParaDecimal();

            servicoCaixas.RealizarSaida(caixaId, tipo, valorRetirada);

            DialogResult = DialogResult.OK;
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }


    private void FrmCaixaRetirada_Load(object sender, EventArgs e)
        => cbbxTipoRetirada.Configurar(TipoSaidaCaixaHelper.ObterLista());

    private void CbbxTipoRetirada_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            var caixa = servicoCaixas.ObterPorId(caixaId)
                ?? throw new InvalidOperationException("O caixa não foi encontrado");

            var tipo = cbbxTipoRetirada.Converter<TipoSaidaCaixa>();

            valor = tipo == TipoSaidaCaixa.Dinheiro
                ? caixa.SaldoDinheiro
                : tipo == TipoSaidaCaixa.Cheque
                ? caixa.SaldoCheque
                : caixa.SaldoOutros;

            lbValorDisponivelRetirada.Text = $"{valor:C2}";
            txtValorRetirada.Text = lbValorDisponivelRetirada.Text;

            if (valor == 0)
            {
                this.ExibirMensagem("Não é possível realizar uma retirada na forma de pagamento especificada.");

                txtValorRetirada.Desativar();
                btnRetirar.Desativar();
            }
            else
            {
                btnRetirar.Ativar();
                txtValorRetirada.Ativar();

                txtValorRetirada.Selecionar();
            }
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void BtnRetirar_Click(object sender, EventArgs e)
        => Retirar();

    private void TxtValorRetirada_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (btnRetirar.Enabled == true
            && Keys.Return.Comparar(e.KeyChar))
        {
            e.Handled = true;

            Retirar();
        }
    }

    private void TxtValorRetirada_TextChanged(object sender, EventArgs e)
    {
        btnRetirar.Enabled = decimal.TryParse(txtValorRetirada.Text, out var valorRetirada)
            && valorRetirada > 0
            && valorRetirada <= valor;
    }
}
