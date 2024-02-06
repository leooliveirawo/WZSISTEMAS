namespace WZSISTEMAS.FrenteCaixa;

public partial class FrmFrenteCaixa : Form
{
    private readonly IServicoCaixas servicoCaixas;
    private readonly IServicoVendas servicoVendas;
    private readonly IServicoPedidos servicoPedidos;
    private readonly IServicoProdutos servicoProdutos;

    private TipoFrenteCaixa tipo;

    private Venda? venda;
    private Pedido? pedido;

    private long caixaId;
    private long funcionarioId;

    private bool naoSelecionar;

    private bool naoCarregarVendaEmAberto;

    public FrmFrenteCaixa(IServicoCaixas servicoCaixas, IServicoVendas servicoVendas, IServicoPedidos servicoPedidos, IServicoProdutos servicoProdutos)
    {
        InitializeComponent();

        this.servicoCaixas = servicoCaixas ?? throw new ArgumentNullException(nameof(servicoCaixas));
        this.servicoVendas = servicoVendas ?? throw new ArgumentNullException(nameof(servicoVendas));
        this.servicoPedidos = servicoPedidos  ?? throw new ArgumentNullException(nameof(servicoPedidos));
        this.servicoProdutos = servicoProdutos ?? throw new ArgumentNullException(nameof(servicoProdutos));
    }

    public void DefinirCaixaId(long caixaId)
        => this.caixaId = caixaId;

    public void DefinirFuncionarioId(long funcionarioId)
        => this.funcionarioId = funcionarioId;

    private void DefinirTipoVenda()
    {
        gbxItens.Text = "Itens da venda (F8)";

        lbF3Texto.Show();
        lbF3.Show();

        lbF5Texto.Text = "Fechar venda";
        lbESCTexto.Text = "Cancelar venda";
        lbF7Texto.Text = "Vendas em espera";
        lbF6Texto.Text = "Colocar em espera";
        tsmiFrenteCaixaManutencao.Text = "Manutenção de vendas";
        tsmiItensEmAberto.Text = "Vendas em espera";

        gbxCPF_CNPJ_NaNota.Show();

        try
        {
            venda = servicoVendas.ObterVendaAbertaPorCaixaId(caixaId);

            if (!naoCarregarVendaEmAberto
                && venda is not null)
                CarregarVenda();
            else
            {
                gbxNumero.Text = "Nº da venda";
                lbTotal.Text = $"{0:C2}";
            }
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
        finally
        {
            txtCodBarrasCodRef.Selecionar();
        }
    }

    private void DefinirTipoPedido()
    {
        gbxNumero.Text = "Nº do pedido";
        gbxItens.Text = "Itens do pedido (F8)";
        lbF3Texto.Hide();
        lbF3.Hide();

        lbF5Texto.Text = "Converter para venda";
        lbESCTexto.Text = "Cancelar pedido";
        lbF7Texto.Text = "Pedidos em aberto";
        lbF6Texto.Text = "Novo pedido";
        tsmiFrenteCaixaManutencao.Text = "Manutenção de pedidos";
        tsmiItensEmAberto.Text = "Pedidos em aberto";

        gbxCPF_CNPJ_NaNota.Hide();
    }

    public void DefinirTipo(TipoFrenteCaixa tipo)
    {
        this.tipo = tipo;
        venda = default;
        pedido = default;

        lbTerminalNumero.Text = $"Nº do Terminal: {TerminalId}";

        lbTotal.Text = $"{0:C2}";

        if (tipo == TipoFrenteCaixa.Venda)
            DefinirTipoVenda();
        else if (tipo == TipoFrenteCaixa.Pedido)
            DefinirTipoPedido();
    }

    private void RedefinirCamposConsulta()
    {
        txtCodBarrasCodRef.Clear();
        txtQntd.Clear("1");

        chbxFiltrarCodRef.Desmarcar();
    }

    private void RecalcularPosicoes()
    {
        var numeroLinhas = dgvItens.ObterNumeroLinhas();

        if (numeroLinhas > 0)
        {
            dgvItens.SelecionarUltimaLinha();

            for (var i = 0; i < numeroLinhas; i++)
                dgvItens[clnIndex.Index, i].Value = i + 1;
        }
    }

    private decimal SelecionarPrecoFinalItem(Item item1)
    {
        var precoFinal = item1.PrecoFinal;

        if (item1.MultiplosPrecos)
        {
            using var frm = ProvedorServicos.FrmFrenteCaixaSelecionarPrecos();

            frm.DefinirProdutoId(item1.Id);

            if (frm.ShowDialog(this, DialogResult.OK))
                precoFinal = frm.PrecoSelecionado;
        }

        return precoFinal;
    }

    private Item? BuscarItem()
        => chbxFiltrarCodRef.Checked
            ? servicoProdutos.ObterPorCodigoReferencia(txtCodBarrasCodRef.Text)
            : servicoProdutos.ObterPorIdOuCodigoBarras(txtCodBarrasCodRef.Text);

    private FrmFrenteCaixaEmAberto ExibirFrenteCaixaEmEspera()
    {
        using var frm = ProvedorServicos.FrmFrenteCaixaEmAberto();

        frm.DefinirCaixaId(caixaId);
        frm.DefinirTipo(tipo);

        frm.ShowDialog(this);

        return frm;
    }

    private void FrmFrenteCaixa_Load(object sender, EventArgs e)
    {
        
    }

    private void FrmFrenteCaixa_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (Keys.Escape.Comparar(e.KeyChar))
        {
            if (tipo == TipoFrenteCaixa.Venda)
                CancelarVenda();
            else if (tipo == TipoFrenteCaixa.Pedido)
                CancelarPedido();
        }
    }

    private void FrmFrenteCaixa_KeyUp(object sender, KeyEventArgs e)
    {
        naoSelecionar = false;

        try
        {
            if (tipo == TipoFrenteCaixa.Venda)
                AcoesVenda(e);
            else if (tipo == TipoFrenteCaixa.Pedido)
                AcoesPedido(e);
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
        finally
        {
            if (!naoSelecionar)
                txtCodBarrasCodRef.Selecionar();
        }

    }

    private void TxtQntd_Leave(object sender, EventArgs e)
    {
        if (!txtQntd.VerificarDecimal(AuxiliarTextBox.TiposValidacao.Positivo))
            txtQntd.Clear();
    }

    private void TxtCodBarrasCodRef_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (Keys.Return.Comparar(e.KeyChar))
        {
            e.Handled = true;

            if (string.IsNullOrWhiteSpace(txtCodBarrasCodRef.Text))
                txtQntd.Selecionar();
            else
            {
                try
                {
                    var item = BuscarItem();

                    txtQntd.Text.ConverterParaDecimal(out var quantidade);

                    if (item is null)
                        this.ExibirMensagem("O ítem com o Id, código de barras ou código referência não foi encontrado.", "Item não encontrado");
                    else
                    {
                        if (tipo == TipoFrenteCaixa.Venda)
                        {
                            AcoesVenda(item, quantidade);
                            RecalcularVendaTotal();
                        }
                        else if (tipo == TipoFrenteCaixa.Pedido)
                        {
                            AcoesPedido(item, quantidade);
                            RecalcularPedidoTotal();
                        }

                        RedefinirCamposConsulta();
                    }
                }
                catch (Exception erro)
                {
                    this.ExibirMensagemErro(erro);
                }
                finally
                {
                    txtCodBarrasCodRef.Selecionar();
                }
            }
        }


    }

    private void TxtQntd_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (Keys.Return.Comparar(e.KeyChar))
        {
            e.Handled = true;

            txtCodBarrasCodRef.Selecionar();
        }
    }

    private void CadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            using var frm = ProvedorServicos.FrmCadastroClientes();

            frm.ShowDialog(this);
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void CadastroDeFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            using var frm = ProvedorServicos.FrmCadastroFuncionarios();

            frm.ShowDialog(this);
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void CadastroDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            using var frm = ProvedorServicos.FrmCadastroFornecedores();

            frm.ShowDialog(this);
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void CadastroDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            using var frm = ProvedorServicos.FrmCadastroProdutos();

            frm.ShowDialog(this);
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void VendasEmEmAbertoToolStripMenuItemClick(object sender, EventArgs e)
    {
        try
        {
            AbrirVendasEspera();
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void TsmiFrenteCaixaManutencao_Click(object sender, EventArgs e)
    {
        try
        {
            using var frm = ProvedorServicos.FrmFrenteCaixaManutencao();

            frm.DefinirCaixaId(caixaId);
            frm.DefinirFuncionarioId(funcionarioId);
            frm.DefinirTipo(tipo);

            frm.ShowDialog(this);
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }
}
