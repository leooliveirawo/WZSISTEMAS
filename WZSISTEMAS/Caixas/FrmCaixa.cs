using System.Linq;
using WZSISTEMAS.Dados.Entidades;
using WZSISTEMAS.Dados.Helpers;
using WZSISTEMAS.Dados.Servicos.Interfaces;
using WZSISTEMAS.Dados.Valores;
using WZSISTEMAS.Helpers;
using WZSISTEMAS.WinForms.Helpers;

namespace WZSISTEMAS.Caixas;

public partial class FrmCaixa : Form
{
    private readonly IServicoCaixas servico;
    private readonly IServicoVendas servicoVendas;

    private long caixaId;

    private IEnumerable<CaixaMovimentacoes> movimentacoes = default!;

    public bool FoiFechado { get; private set; }

    public FrmCaixa(
        IServicoCaixas servico,
        IServicoVendas servicoVendas)
    {
        InitializeComponent();

        this.servico = servico 
            ?? throw new ArgumentNullException(nameof(servico));

        this.servicoVendas = servicoVendas
            ?? throw new ArgumentNullException(nameof(servicoVendas));
    }

    public void DefinirCaixaId(long caixaId)
        => this.caixaId = caixaId;

    private void PreencherTela(Caixa caixa)
    {
        lbAbertoEm.Text = $"{caixa.AbertoEm:D}";

        lbSaldoInicial.Text = $"{caixa.SaldoInicial:C2}";
        lbSaldoFinal.Text = $"{caixa.SaldoFinal:C2}";
        lbSaldoDinheiro.Text = $"{caixa.SaldoDinheiro:C2}";

        lbNumeroCaixa.Text = caixa.Id.ToString();
        lbNumeroTerminal.Text = TerminalId.ToString();

        chbxEntradasCanceladas.Checked = false;
        chbxSaidasCanceladas.Checked = false;

        lbEntradaDinheiro.ForeColor = Color.SeaGreen;
        lbEntradaCartaoDebito.ForeColor = Color.SeaGreen;
        lbEntradaCartaoCredito.ForeColor = Color.SeaGreen;
        lbEntradaCartaoVoucher.ForeColor = Color.SeaGreen;
        lbEntradaCartaoConvenio.ForeColor = Color.SeaGreen;
        lbEntradaCheque.ForeColor = Color.SeaGreen;
        lbEntradaOutros.ForeColor = Color.SeaGreen;

        lbEntradaDinheiro.Text = $"{caixa.EntradaDinheiro:C2}";
        lbEntradaCartaoDebito.Text = $"{caixa.EntradaCartaoDebito:C2}";
        lbEntradaCartaoCredito.Text = $"{caixa.EntradaCartaoCredito:C2}";
        lbEntradaCartaoVoucher.Text = $"{caixa.EntradaCartaoVoucher:C2}";
        lbEntradaCartaoConvenio.Text = $"{caixa.EntradaCartaoConvenio:C2}";
        lbEntradaCheque.Text = $"{caixa.EntradaCheque:C2}";
        lbEntradaOutros.Text = $"{caixa.EntradaOutros:C2}";

        lbSaidaDinheiro.Text = $"{caixa.SaidaDinheiro:C2}";
        lbSaidaCheque.Text = $"{caixa.SaidaCheque:C2}";
        lbSaidaOutros.Text = $"{caixa.SaidaOutros:C2}";

        CriarMovimentacoes();

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
            dgvMovimentacoes.Rows[movimentacoes.Count() - 1].Selected = true;

       void CriarMovimentacoes()
        {
            var movimentacoes = new List<CaixaMovimentacoes>
            {
                new(
                    0,
                    caixa.AbertoEm,
                    caixa.ConverterParaTextoCaixaMovimentacao(),
                    ModosCaixaMovimentacao.SaldoInicial,
                    TipoEntradaCaixa.Dinheiro.ConverterParaString().ToUpper(),
                    $"{caixa.SaldoInicial:C2}",
                    TiposCaixaMovimentacao.Dinheiro,
                    false)
            };

            movimentacoes.AddRange(
                caixa.Entradas.Select(
                    entrada => new CaixaMovimentacoes(
                        entrada.Id,
                        entrada.DataEntrada,
                        entrada.ConverterParaTextoCaixaMovimentacao(),
                        ModosCaixaMovimentacao.Entrada,
                        entrada.Tipo.ConverterParaString().ToUpper(),
                        $"{entrada.Valor:C2}",
                        entrada.Tipo.ConverterParaTipoCaixaMovimentacao(),
                        entrada.FoiCancelada)));

            movimentacoes.AddRange(
                caixa.Saidas.Select(
                    saida => new CaixaMovimentacoes(
                        saida.Id,
                        saida.DataSaida,
                        saida.ConverterParaTextoCaixaMovimentacao(),
                        ModosCaixaMovimentacao.Saida,
                        saida.Tipo.ConverterParaString().ToUpper(),
                        $"{saida.Valor:C2}",
                        saida.Tipo.ConverterParaTipoCaixaMovimentacao(),
                        saida.FoiCancelada)));

            movimentacoes.AddRange(
                caixa.Suprimentos.Select(
                    suprimento => new CaixaMovimentacoes(
                        suprimento.Id,
                        suprimento.DataSuprimento,
                        suprimento.ConverterParaTextoCaixaMovimentacao(),
                        ModosCaixaMovimentacao.Suprimento,
                        suprimento.Tipo.ConverterParaString().ToUpper(),
                        $"{suprimento.Valor:C2}",
                        suprimento.Tipo.ConverterParaTipoCaixaMovimentacao(),
                        suprimento.FoiCancelado)));
            
            this.movimentacoes = movimentacoes.OrderBy(x => x.DataHora).ToList();
        }
    }

    private void FrmCaixa_Load(object sender, EventArgs e)
    {
        try
        {
            var caixa = servico.ObterPorId(caixaId);

            if (caixa is null)
            {
                this.ExibirMensagem("O caixa não foi encontrado.");

                return;
            }

            PreencherTela(caixa);
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void BtnFechar_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.ExibirMensagemSimNao(
                "Tem certeza que deseja realizar o fechamento do caixa?",
                "Confirmar fechamento do caixa"))
            {
                var caixa = servico.FecharCaixa(caixaId);

                Hide();

                using var frm = new FrmCaixaFechamento(caixa);

                frm.ShowDialog(this);

                FoiFechado = true;

                Close();
            }
        }
        catch (Exception erro)
        {
            servico.DescartarAlteracoes();

            this.ExibirMensagemErro(erro);
        }
    }

    private void BtnCancelar_Click(object sender, EventArgs e)
    {
        try
        {
            var index = dgvMovimentacoes.SelectedRows[0].Index;
            var movimentacao = movimentacoes.ElementAt(index);

            if (movimentacao.ModoMovimentacao == ModosCaixaMovimentacao.Entrada)
            {
                if (servico.VerificarEntradaVinculadaVenda(movimentacao.Id))
                {
                    if (this.ExibirMensagemSimNao(
                        "Essa entrada está vinculada a uma venda e para fazer o cancelamento, a venda também deve ser cancelada. Deseja cancelar a venda?\n\nObs: o cancelamento da venda irá gerar o cancelamento de todas as entradas vinculadas a venda.",
                        "Confirmar cancelamento"))
                    {
                        var vendaId = servico.GetVendaIdByCaixaEntradaId(movimentacao.Id);

                        if (vendaId.HasValue)
                        {
                            servicoVendas.CancelarVenda(vendaId.Value);

                            var caixa = servico.ObterCaixaResumidoPeloCaixaId(caixaId) 
                                ?? throw new InvalidOperationException("Os dados do caixa não foi encontrado");

                            PreencherTela(caixa);

                            this.ExibirMensagemOperacaoConcluida("A entrada foi cancelada.", "Entrada cancelada");
                        }
                        else
                        {
                            throw new InvalidOperationException("Erro interno");
                        }
                    }
                }
                else if (this.ExibirMensagemSimNao(
                    "Tem certeza que deseja cancelar a entrada do caixa?",
                    "Confirmar cancelamento"))
                {
                    var caixaCaixaEntrada = servico.CancelarEntrada(movimentacao.Id);

                    PreencherTela(caixaCaixaEntrada.Item1);

                    this.ExibirMensagemOperacaoConcluida("A entrada foi cancelada.", "Entrada cancelada");
                }
            }
            else if (movimentacao.ModoMovimentacao == ModosCaixaMovimentacao.Saida)
            {
                if (this.ExibirMensagemSimNao(
                    "Tem certeza que deseja cancelar a saida do caixa?",
                    "Confirmar cancelamento"))
                {

                }
            }
            else if (movimentacao.ModoMovimentacao == ModosCaixaMovimentacao.Suprimento)
            {
                if (this.ExibirMensagemSimNao(
                    "Tem certeza que deseja cancelar o suprimento do caixa?",
                    "Confirmar cancelamento"))
                {

                }
            }
            else
                throw new NotSupportedException();
        }
        catch (Exception erro)
        {
            servico.DescartarAlteracoes();

            this.ExibirMensagemErro(erro);
        }
    }

    private void BtnEntrada_Click(object sender, EventArgs e)
    {
        try
        {
            using var frm = ProvedorServicos.FrmCaixaEntrada();

            frm.DefinirCaixaId(caixaId);

            if (frm.ShowDialog(this) == DialogResult.OK)
                PreencherTela(frm.Caixa);
        }
        catch (Exception erro)
        {
            servico.DescartarAlteracoes();
            this.ExibirMensagemErro(erro);
        }
    }

    private void BtnSaida_Click(object sender, EventArgs e)
    {
        try
        {
            using var frm = ProvedorServicos.FrmCaixaSaida();

            frm.DefinirCaixaId(caixaId);

            if (frm.ShowDialog(this) == DialogResult.OK)
                PreencherTela(servico.ObterPorId(caixaId)
                    ?? throw new InvalidOperationException("O caixa não foi aberto"));
        }
        catch (Exception erro)
        {
            servico.DescartarAlteracoes();
            this.ExibirMensagemErro(erro);
        }
    }

    private void DgvMovimentacoes_SelectionChanged(object sender, EventArgs e)
        => btnCancelar.Enabled = dgvMovimentacoes.SelectedRows.Count > 0 && dgvMovimentacoes.SelectedRows[0].Index != 0;

    private void ChbxEntradasCanceladas_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            var caixa = servico.ObterPorId(caixaId)
                ?? throw new InvalidOperationException("Os dados do caixa não foi encontrado"); ;

            if (chbxEntradasCanceladas.Checked)
            {
                lbEntradaDinheiro.ForeColor = Color.DarkRed;
                lbEntradaCartaoDebito.ForeColor = Color.DarkRed;
                lbEntradaCartaoCredito.ForeColor = Color.DarkRed;
                lbEntradaCartaoVoucher.ForeColor = Color.DarkRed;
                lbEntradaCartaoConvenio.ForeColor = Color.DarkRed;
                lbEntradaCheque.ForeColor = Color.DarkRed;
                lbEntradaOutros.ForeColor = Color.DarkRed;

                lbEntradaDinheiro.Text = $"{caixa.EntradaCanceladaDinheiro:C2}";
                lbEntradaCartaoDebito.Text = $"{caixa.EntradaCanceladaCartaoDebito:C2}";
                lbEntradaCartaoCredito.Text = $"{caixa.EntradaCanceladaCartaoCredito:C2}";
                lbEntradaCartaoVoucher.Text = $"{caixa.EntradaCanceladaCartaoVoucher:C2}";
                lbEntradaCartaoConvenio.Text = $"{caixa.EntradaCanceladaCartaoConvenio:C2}";
                lbEntradaCheque.Text = $"{caixa.EntradaCanceladaCheque:C2}";
                lbEntradaOutros.Text = $"{caixa.EntradaCanceladaOutros:C2}";
            }
            else
            {
                lbEntradaDinheiro.ForeColor = Color.SeaGreen;
                lbEntradaCartaoDebito.ForeColor = Color.SeaGreen;
                lbEntradaCartaoCredito.ForeColor = Color.SeaGreen;
                lbEntradaCartaoVoucher.ForeColor = Color.SeaGreen;
                lbEntradaCartaoConvenio.ForeColor = Color.SeaGreen;
                lbEntradaCheque.ForeColor = Color.SeaGreen;
                lbEntradaOutros.ForeColor = Color.SeaGreen;

                lbEntradaDinheiro.Text = $"{caixa.EntradaDinheiro:C2}";
                lbEntradaCartaoDebito.Text = $"{caixa.EntradaCartaoDebito:C2}";
                lbEntradaCartaoCredito.Text = $"{caixa.EntradaCartaoCredito:C2}";
                lbEntradaCartaoVoucher.Text = $"{caixa.EntradaCartaoVoucher:C2}";
                lbEntradaCartaoConvenio.Text = $"{caixa.EntradaCartaoConvenio:C2}";
                lbEntradaCheque.Text = $"{caixa.EntradaCheque:C2}";
                lbEntradaOutros.Text = $"{caixa.EntradaOutros:C2}";
            }
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void ChbxSaidasCanceladas_CheckedChanged(object sender, EventArgs e)
    {
        var caixa = servico.ObterPorId(caixaId)
            ?? throw new InvalidOperationException("Os dados do caixa não foi encontrado"); ;

        if (chbxSaidasCanceladas.Checked)
        {
            lbSaidaDinheiro.ForeColor = Color.DarkRed;
            lbSaidaCheque.ForeColor = Color.DarkRed;
            lbSaidaOutros.ForeColor = Color.DarkRed;

            lbSaidaDinheiro.Text = $"{caixa.SaidaCanceladaDinheiro:C2}";
            lbSaidaCheque.Text = $"{caixa.SaidaCanceladaCheque:C2}";
            lbSaidaOutros.Text = $"{caixa.SaidaCanceladaOutros:C2}";
        }
        else
        {
            lbSaidaDinheiro.ForeColor = Color.SeaGreen;
            lbSaidaCheque.ForeColor = Color.SeaGreen;
            lbSaidaOutros.ForeColor = Color.SeaGreen;

            lbSaidaDinheiro.Text = $"{caixa.SaidaDinheiro:C2}";
            lbSaidaCheque.Text = $"{caixa.SaidaCheque:C2}";
            lbSaidaOutros.Text = $"{caixa.SaidaOutros:C2}";
        }
    }
}
