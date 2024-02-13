namespace WZSISTEMAS.Caixas;

public partial class FrmCaixaFechamento : Form
{
    private class Movimentacoes
    {
        public long Id { get; set; }
        public DateTime DataHora { get; set; }
        public string Movimentacao { get; set; } = default!;
        public string Tipo { get; set; } = default!;
        public string Valor { get; set; } = default!;
    }

    private readonly Caixa caixa;

    public FrmCaixaFechamento(Caixa caixa)
    {
        InitializeComponent();

        this.caixa = caixa;
    }

    private void PreencherTela(Caixa caixa)
    {
        lbAbertoEm.Text = $"{caixa.AbertoEm:D}";

        lbSaldoInicial.Text = $"{caixa.SaldoInicial:C2}";
        lbSaldoFinal.Text = $"{caixa.SaldoFinal:C2}";

        lbEntradaDinheiro.Text = $"{caixa.EntradaDinheiro:C2}";
        lbEntradaCartaoDebito.Text = $"{caixa.EntradaCartaoDebito:C2}";
        lbEntradaCartaoCredito.Text = $"{caixa.EntradaCartaoCredito:C2}";
        lbEntradaCartaoVoucher.Text = $"{caixa.EntradaCartaoVoucher:C2}";
        lbEntradaCartaoConvenio.Text = $"{caixa.EntradaDinheiro:C2}";
        lbEntradaCheque.Text = $"{caixa.EntradaCheque:C2}";
        lbEntradaOutros.Text = $"{caixa.EntradaOutros:C2}";

        lbSaidaDinheiro.Text = $"{caixa.SaidaDinheiro:C2}";
        lbSaidaCheque.Text = $"{caixa.SaidaCheque:C2}";
        lbSaidaOutros.Text = $"{caixa.SaidaOutros:C2}";

        var movimentacoes = new List<CaixaMovimentacoes>
        {
            new(
                0,
                caixa.AbertoEm,
                caixa.ConverterParaTextoCaixaMovimentacao(),
                ModosCaixaMovimentacao.SaldoInicial,
                TiposCaixaMovimentacao.Dinheiro.ConverterParaString().ToUpper(),
                $"{caixa.SaldoInicial:C2}",
                TiposCaixaMovimentacao.Dinheiro,
                false)
            
        };

        foreach (var entrada in caixa.Entradas)
            movimentacoes.Add(
                new(
                    entrada.Id,
                    entrada.DataEntrada,
                    entrada.ConverterParaTextoCaixaMovimentacao(),
                    ModosCaixaMovimentacao.Entrada,
                    entrada.Tipo.ConverterParaString().ToUpper(),
                    $"{entrada.Valor:C2}",
                    entrada.Tipo.ConverterParaTipoCaixaMovimentacao(),
                    entrada.FoiCancelada));

        foreach (var saida in caixa.Saidas)
            movimentacoes.Add(
                new(
                    saida.Id,
                    saida.DataSaida,
                    saida.ConverterParaTextoCaixaMovimentacao(),
                    ModosCaixaMovimentacao.Saida,
                    saida.Tipo.ConverterParaString().ToUpper(),
                    $"{saida.Valor:C2}",
                    saida.Tipo.ConverterParaTipoCaixaMovimentacao(),
                    saida.FoiCancelada));

        foreach (var suprimento in caixa.Suprimentos)
            movimentacoes.Add(
                new(
                    suprimento.Id,
                    suprimento.DataSuprimento,
                    suprimento.ConverterParaTextoCaixaMovimentacao(),
                    ModosCaixaMovimentacao.Suprimento,
                    suprimento.Tipo.ConverterParaString().ToUpper(),
                    $"{suprimento.Valor:C2}",
                    suprimento.Tipo.ConverterParaTipoCaixaMovimentacao(),
                    suprimento.FoiCancelado));

        movimentacoes = movimentacoes.OrderBy(x => x.DataHora).ToList();

        dgvMovimentacoes.Rows.Clear();

        foreach (var movimentacao in movimentacoes)
        {
            var index = dgvMovimentacoes.Adicionar(movimentacao.TextoMovimentacao, movimentacao.Tipo, movimentacao.Valor, $"{movimentacao.DataHora:G}");

            if (movimentacao.FoiCancelada)
            {
                dgvMovimentacoes.Rows[index].DefaultCellStyle.BackColor = Color.DarkRed;
                dgvMovimentacoes.Rows[index].DefaultCellStyle.ForeColor = Color.WhiteSmoke;

                dgvMovimentacoes.Rows[index].DefaultCellStyle.SelectionBackColor = Color.IndianRed;
                dgvMovimentacoes.Rows[index].DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            }
            else
            {
                dgvMovimentacoes.Rows[index].DefaultCellStyle.BackColor = Color.SeaGreen;
                dgvMovimentacoes.Rows[index].DefaultCellStyle.ForeColor = Color.WhiteSmoke;

                dgvMovimentacoes.Rows[index].DefaultCellStyle.SelectionBackColor = Color.MediumSeaGreen;
                dgvMovimentacoes.Rows[index].DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            }
        }

        if (movimentacoes.Any())
            dgvMovimentacoes.Rows[movimentacoes.Count - 1].Selected = true;

    }

    private void FrmDetalhesFechamentoCaixa_Load(object sender, EventArgs e)
    {
        try
        {
            PreencherTela(caixa);

            this.ExibirMensagem(
                "O caixa foi fechado com sucesso.",
                "Caixa fechado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }
}
