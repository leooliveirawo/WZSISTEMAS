namespace WZSISTEMAS.FrenteCaixa;

public partial class FrmFrenteCaixaFechamento : Form
{
    private readonly IServicoVendas servicoVendas;
    private readonly IServicoClientesLancamentos servicoClientesTitulos;
    private readonly IServicoFuncionarios servicoFuncionarios;

    private long vendaId;
    private long funcionarioId;

    private Venda venda = default!;
    private decimal valorPago;
    private decimal valorRestante;

    public bool Fechou { get; private set; }

    public FrmFrenteCaixaFechamento(
        IServicoVendas servicoVendas,
        IServicoClientesLancamentos servicoClientesTitulos,
        IServicoFuncionarios servicoFuncionarios)
    {
        InitializeComponent();

        this.servicoVendas = servicoVendas
                             ?? throw new ArgumentNullException(nameof(servicoVendas));

        this.servicoClientesTitulos = servicoClientesTitulos
                                      ?? throw new ArgumentNullException(nameof(servicoClientesTitulos));

        this.servicoFuncionarios = servicoFuncionarios
                                   ?? throw new ArgumentNullException(nameof(servicoFuncionarios));
    }

    public void DefinirVendaId(long vendaId)
        => this.vendaId = vendaId;

    public void DefinirFuncionarioId(long funcionarioId)
        => this.funcionarioId = funcionarioId;

    private void AdicionarPagamento(VendaPagamento vendaPagamento)
        => dgvItensVenda.Adicionar(
            vendaPagamento.Id,
            dgvItensVenda.ObterProximoIndex(),
            vendaPagamento.Tipo.ConverterParaString(),
            $"{vendaPagamento.ValorPago:C2}");

    private void FrmFrenteCaixaFechamento_Load(object sender, EventArgs e)
    {
        try
        {
            var venda = servicoVendas.ObterPorId(vendaId);

            if (venda is null)
            {
                this.ExibirMensagem("A venda solicitada não foi encontrada.", "Venda não encontrada");

                Close();
            }
            else
            {
                this.venda = venda;

                var funcionario = servicoFuncionarios.ObterPorId(funcionarioId)
                                  ?? throw new InvalidOperationException("O funcionário não foi encontrado");

                lbOperador.Text = funcionario.NomeCompleto;

                valorPago = 0;
                valorRestante = venda.ValorTotal;

                lbValorTotal.Text = $"{venda.ValorTotal:C2}";
                lbValorPago.Text = $"{0:C2}";
                lbValorRestanteTroco.Text = lbValorTotal.Text;

                txtValorAPagar.Text = $"{venda.ValorTotal:0.00}";
                txtValorAPagar.Focus();
                txtValorAPagar.SelectAll();

                if (venda.CPF_CNPJ_Nota is not null)
                    lbCPF_CNPJ.Text = venda.CPF_CNPJ_Nota;
            }
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }
        
    private void FrmFrenteCaixaFechamento_KeyUp(object sender, KeyEventArgs e)
    {
        if (VerificarCondicoesExcluir(e))
        {
            try
            {
                RecalcularValor(RemoverLinha());
                RecalcularValores();

                dgvItensVenda.RedefinirIndex(clnIndex.Index);
                dgvItensVenda.SelecionarUltimaLinha();
            }
            catch (Exception erro)
            {
                this.ExibirMensagemErro(erro);
            }
        }

        bool VerificarCondicoesExcluir(KeyEventArgs e)
        => e.KeyData == Keys.F4
        && !Fechou
        && dgvItensVenda.ExisteLinhasSelecionadas()
        && this.ExibirMensagemSimNao(
            "Tem certeza que deseja excluir o pagamento realizado?",
            "Confirmar exclusão");

        int RemoverLinha()
        {
            var linha = dgvItensVenda.ObterPrimeiraLinhaSelecionada();

            dgvItensVenda.Rows.Remove(linha);

            return linha.Index;
        }

       void RecalcularValor(int index)
        {
            var vendaPagamento = venda.Pagamentos.ElementAt(index);

            venda.Pagamentos.Remove(vendaPagamento);

            valorPago -= vendaPagamento.ValorPago;
            valorRestante = vendaPagamento.ValorPago;
        }
    }

    private void RecalcularValores()
    {
        lbValorPago.Text = $"{valorPago:C2}";
        lbValorRestanteTroco.Text = $"{valorRestante:C2}";

        txtValorAPagar.Text = $"{valorRestante:0.00}";

        txtValorAPagar.Selecionar();
    }

    private void FrmFrenteCaixaFechamento_KeyPress(object sender, KeyPressEventArgs e)
    {
        bool VerificarCondicoesFechamento()
            =>
            !string.IsNullOrEmpty(txtValorAPagar.Text)
            && !Fechou;

        void ExecutarPagamento(decimal valorAPagar)
        {
            var vendaPagamento = ObterVendaPagamento(valorAPagar);

            if (vendaPagamento is not null)
            {
                e.Handled = true;

                if (ExecutarOperacoesCartaoConvenio(vendaPagamento) == false)
                    return;

                if (ExecutarOperacoesDemaisCartoes(vendaPagamento) == false)
                    return;

                venda.Pagamentos.Add(vendaPagamento);

                valorPago += vendaPagamento.ValorPago;

                if (valorPago >= venda.ValorTotal)
                {
                    if (valorPago > venda.ValorTotal)
                        venda.Troco = valorPago - venda.ValorTotal;

                    valorPago = venda.ValorTotal;

                    vendaPagamento.ValorPagoLiquido = valorRestante;

                    valorRestante = 0;

                    AdicionarPagamento(vendaPagamento);

                    FecharVenda();
                }
                else
                {
                    valorRestante -= vendaPagamento.ValorPago;
                    vendaPagamento.ValorPagoLiquido = vendaPagamento.ValorPago;

                    AdicionarPagamento(vendaPagamento);
                    RecalcularValores();
                }
            }
        }

        try
        {
            if (VerificarCondicoesFechamento())
            {
                if (decimal.TryParse(txtValorAPagar.Text, out var valorAPagar))
                    ExecutarPagamento(valorAPagar);
                else
                {
                    txtValorAPagar.Selecionar();

                    this.ExibirMensagem("O valor a pagar não é válido.", "Valor a pago não é válido");
                }
            }
        }
        catch (Exception erro)
        {
            txtValorAPagar.Selecionar();

            this.ExibirMensagemErro(erro);
        }
        finally
        {
            servicoVendas.DescartarAlteracoes();
        }

        bool RealizarTransacao(VendaPagamento vendaPagamento)
        {
            using var frm = ProvedorServicos.FrmFrenteCaixaFechamentoCartao();

            frm.DefinirTipo(vendaPagamento.Tipo);
            frm.DefinirValorPago(vendaPagamento.ValorPago);

            frm.ShowDialog(this);

            if (!frm.Aprovado)
            {
                txtValorAPagar.Text = valorRestante.ToString();
                txtValorAPagar.Selecionar();

                return false;
            }
            else
                return true;
        }

        bool RegistrarTitulo(VendaPagamento vendaPagamento)
        {
            using var frm = ProvedorServicos.FrmFrenteCaixaFechamentoConvenio();

            frm.DefinirValor(vendaPagamento);

            if (frm.ShowDialog(this, DialogResult.OK))
                return true;
            else
            {
                txtValorAPagar.Text = valorRestante.ToString();
                txtValorAPagar.Selecionar();

                return false;
            }
        }

        VendaPagamento? ObterVendaPagamento(decimal valorAPagar)
            => TipoEntradaCaixa.Dinheiro.CompararTecla(e.KeyChar)
            ? new VendaPagamento
            {
                VendaId = vendaId,
                Tipo = TipoEntradaCaixa.Dinheiro,
                ValorPago = valorAPagar
            }
            : TipoEntradaCaixa.CartaoDebito.CompararTecla(e.KeyChar)
            ? new VendaPagamento
            {
                VendaId = vendaId,
                Tipo = TipoEntradaCaixa.CartaoDebito,
                ValorPago = valorAPagar
            }
            : TipoEntradaCaixa.CartaoCredito.CompararTecla(e.KeyChar)
            ? new VendaPagamento
            {
                VendaId = vendaId,
                Tipo = TipoEntradaCaixa.CartaoCredito,
                ValorPago = valorAPagar
            }
            : TipoEntradaCaixa.CartaoVoucher.CompararTecla(e.KeyChar)
            ? new VendaPagamento
            {
                VendaId = vendaId,
                Tipo = TipoEntradaCaixa.CartaoVoucher,
                ValorPago = valorAPagar
            }
            : TipoEntradaCaixa.CartaoLoja.CompararTecla(e.KeyChar)
            ? new VendaPagamento
            {
                VendaId = vendaId,
                Tipo = TipoEntradaCaixa.CartaoLoja,
                ValorPago = valorAPagar
            }
            : TipoEntradaCaixa.Cheque.CompararTecla(e.KeyChar)
            ? new VendaPagamento
            {
                VendaId = vendaId,
                Tipo = TipoEntradaCaixa.Cheque,
                ValorPago = valorAPagar
            }
            : TipoEntradaCaixa.Outros.CompararTecla(e.KeyChar)
            ? new VendaPagamento
            {
                VendaId = vendaId,
                Tipo = TipoEntradaCaixa.Outros,
                ValorPago = valorAPagar
            }
            : default;

        bool? ExecutarOperacoesCartaoConvenio(VendaPagamento vendaPagamento)
            => vendaPagamento.Tipo == TipoEntradaCaixa.CartaoLoja
            ? RegistrarTitulo(vendaPagamento)
            : (bool?)default;

        bool? ExecutarOperacoesDemaisCartoes(VendaPagamento vendaPagamento) 
            => vendaPagamento.Tipo == TipoEntradaCaixa.CartaoDebito
            || vendaPagamento.Tipo == TipoEntradaCaixa.CartaoCredito
            || vendaPagamento.Tipo == TipoEntradaCaixa.CartaoVoucher
            ? RealizarTransacao(vendaPagamento)
            : (bool?)default;

        void FecharVenda()
        {
            var vendaECFe = servicoVendas.FecharVenda(vendaId, venda.Pagamentos, venda.Troco);

            Fechou = true;

            lbValorPago.Text = $"{venda.ValorTotal:C2}";
            gbxValorAPagar.Hide();

            if (venda.Troco > 0)
            {
                gbxValorRestanteTroco.Text = "Troco (R$)";
                lbValorRestanteTroco.Text = $"{venda.Troco:C2}";
            }
            else
                gbxValorRestanteTroco.Hide();

            //servicoImpressoras.Imprimir(dadosImpressora, vendaECFe.Item2);
        }
    }
}
