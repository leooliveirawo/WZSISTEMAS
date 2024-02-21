namespace WZSISTEMAS.Pedidos;

public partial class FrmPedido : Form
{
    private readonly IServicoCaixas servicoCaixas;
    private readonly IServicoVendas servicoVendas;
    private readonly IServicoPedidos servicoPedidos;
    private readonly IServicoItens servicoItens;

    private Pedido? pedido;

    private long caixaId;
    private long funcionarioId;

    private bool naoSelecionar;

    public Venda? Venda { get; private set; }
    public bool PedidoConvertidoParaVenda { get; private set; }

    public FrmPedido(IServicoCaixas servicoCaixas, IServicoVendas servicoVendas, IServicoPedidos servicoPedidos, IServicoItens servicoItens)
    {
        InitializeComponent();

        this.servicoCaixas = servicoCaixas ?? throw new ArgumentNullException(nameof(servicoCaixas));
        this.servicoVendas = servicoVendas ?? throw new ArgumentNullException(nameof(servicoVendas));
        this.servicoPedidos = servicoPedidos ?? throw new ArgumentNullException(nameof(servicoPedidos));
        this.servicoItens = servicoItens ?? throw new ArgumentNullException(nameof(servicoItens));
    }

    public void DefinirCaixaId(long caixaId)
        => this.caixaId = caixaId;

    public void DefinirFuncionarioId(long funcionarioId)
        => this.funcionarioId = funcionarioId;

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

    private decimal SelecionarPrecoFinal(Item item)
    {
        if (item.MultiplosPrecos)
        {
            using var frm = ProvedorServicos.FrmItemSelecionarPrecos();

            frm.DefinirProdutoId(item.Id);

            if (frm.ShowDialog(this, DialogResult.OK))
                return frm.PrecoSelecionado;
        }

        return item.PrecoFinal;
    }

    private Item? BuscarItem()
        => chbxFiltrarCodRef.Checked
            ? servicoItens.ObterPorCodigoReferencia(txtCodBarrasCodRef.Text)
            : servicoItens.ObterPorIdOuCodigoBarras(txtCodBarrasCodRef.Text);

    private void AbrirPedidosEmAberto()
    {
        if (pedido is null)
        {
            using var frm = ProvedorServicos.FrmPedidoEmAberto();

            frm.ShowDialog(this);

            if (frm.Concluiu)
            {
                pedido = frm.Pedido
                         ?? throw new InvalidOperationException("Um erro interno ocorreu no sistema");

                CarregarPedido();
            }
        }
    }

    private void RecalcularValorTotal()
        => lbTotal.Text = $"{pedido?.ValorTotal ?? 0:C2}";

    private void RedefinirTela()
    {
        gbxNumero.Text = "Nº do pedido";
        lbTotal.Text = $"{0:C2}";

        RedefinirCamposConsulta();

        dgvItens.Rows.Clear();

        txtBuscarPorNumeroPedido.Ativar();
    }

    private void CarregarPedido()
    {
        lbTotal.Text =
            $"{pedido?.ValorTotal ?? throw new InvalidOperationException("Um erro interno aconteceu durante o pedido"):C2}";

        gbxNumero.Text = $"Nº do pedido: {pedido.Id}";

        dgvItens.Rows.Clear();

        txtBuscarPorNumeroPedido.Clear();

        foreach (var item in pedido.Itens)
            AdicionarPedidoItem(item);

        dgvItens.SelecionarUltimaLinha();

        txtBuscarPorNumeroPedido.Desativar();
    }

    private void AdicionarPedidoItem(PedidoItem item)
    {
        var count = dgvItens.Rows.GetRowCount(DataGridViewElementStates.Visible) + 1;

        dgvItens.Adicionar(
            item.Id,
            count,
            $"{item.ItemId:0000000}",
            item.CodigoBarrasCodigoReferencia(),
            item.Descricao,
            item.UnidadeMedida.ConverterParaString(true),
            $"{item.ValorUnitario:C2}",
            $"{item.Quantidade:0.000}",
            $"{item.ValorTotal:C2}");
    }

    private void RedefinirParametrosPedido()
        => pedido = default;

    private void CancelarPedido()
    {
        if (pedido is not null)
        {
            if (this.ExibirMensagemSimNao("Tem certeza que deseja cancelar o pedido?", "Confirmar cancelamento"))
            {
                try
                {
                    servicoPedidos.CancelarPedido(pedido.Id);

                    RedefinirParametrosPedido();

                    RedefinirTela();

                    this.ExibirMensagemOperacaoConcluida("O pedido foi cancelado com sucesso.");
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
        else
            Close();
    }

    private void ExecutarAcoes(KeyEventArgs e)
    {
        if (e.KeyData == Keys.F4)
            ExcluirItemPedido();
        else if (e.KeyData == Keys.F5)
            ConverterPedidoParaVenda();
        else if (e.KeyData == Keys.F6)
            NovoPedido();
        else if (e.KeyData == Keys.F7)
            AbrirPedidosEmAberto();
        else if (e.KeyData == Keys.F8)
        {
            naoSelecionar = true;
            dgvItens.Selecionar();
        }
        else if (e.KeyData != Keys.F2)
            naoSelecionar = true;
    }

    private void ExcluirItemPedido()
    {
        if (dgvItens.ExisteLinhasSelecionadas()
            && this.ExibirMensagemSimNao("Tem certeza que deseja excluir o tipoItem do pedido?", "Excluir tipoItem do pedido"))
        {
            pedido = servicoPedidos.ExcluirItem(dgvItens.ConverterPrimeiroSelecionado<long>());

            dgvItens.RemoverPrimeiraLinhaSelecionada();

            RecalcularPosicoes();
            RecalcularValorTotal();
            RedefinirCamposConsulta();

            this.ExibirMensagemOperacaoConcluida("O ítem foi excluído do pedido.");
        }
    }

    private void NovoPedido()
    {
        if (pedido is not null)
        {
            try
            {
                RedefinirParametrosPedido();
                RedefinirCamposConsulta();
                RedefinirTela();
            }
            catch (Exception erro)
            {
                this.ExibirMensagemErro(erro);
            }
        }
    }

    private void VerificarPedido()
    {
        if (pedido is null)
        {
            pedido = servicoPedidos.NovoPedido(funcionarioId);

            CarregarPedido();
        }
    }

    private void IncluirItemPedido(Item item1, decimal quantidade)
    {
        var precoFinal = SelecionarPrecoFinal(item1);

        var pedido_PedidoItem = servicoPedidos.AdicionarItem(
            pedido?.Id
            ?? throw new InvalidOperationException("Um erro interno aconteceu durante a venda"),
            item1.Id,
            precoFinal,
            quantidade);

        pedido = pedido_PedidoItem.Item1;
        var item = pedido_PedidoItem.Item2;

        AdicionarPedidoItem(item);

        dgvItens.Rows[dgvItens.Rows.GetLastRow(DataGridViewElementStates.Visible)].Selected = true;
    }

    private void ConverterPedidoParaVenda()
    {
        try
        {
            if (pedido is not null)
            {
                Venda = servicoPedidos.ConverterParaVenda(pedido.Id, TerminalId, caixaId) ??
                            throw new InvalidOperationException("A venda não foi gerada corretamente");

                PedidoConvertidoParaVenda = true;

                Close();
            }
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }

    }

    private void FrmPedido_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (Keys.Escape.Comparar(e.KeyChar))
            CancelarPedido();
    }

    private void FrmPedido_KeyUp(object sender, KeyEventArgs e)
    {
        naoSelecionar = false;

        try
        {
            ExecutarAcoes(e);
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
        if (e.VerificarTeclaEnter())
        {
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
                        VerificarPedido();
                        IncluirItemPedido(item, quantidade);
                        RecalcularValorTotal();
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
        if (e.VerificarTeclaEnter())
            txtCodBarrasCodRef.Selecionar();
    }

    private void TsmiCadastroCliente_Click(object sender, EventArgs e)
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

    private void TsmiCadastroFuncionario_Click(object sender, EventArgs e)
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

    private void TsmiCadastroFornecedor_Click(object sender, EventArgs e)
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

    private void TsmiCadastroProduto_Click(object sender, EventArgs e)
    {
        try
        {
            using var frm = ProvedorServicos.FrmCadastroItens();

            frm.ShowDialog(this);
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void TsmiPedidosEmAberto_Click(object sender, EventArgs e)
    {
        try
        {
            AbrirPedidosEmAberto();
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void TsmiPedidoManutencao_Click(object sender, EventArgs e)
    {
        try
        {
            using var frm = ProvedorServicos.FrmPedidoManutencao();

            frm.DefinirFuncionarioId(funcionarioId);
            frm.ShowDialog(this);
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void FrmPedido_Load(object sender, EventArgs e)
    {
        lbTerminalNumero.Text = $"Nº do terminal {TerminalId}";
        lbTotal.Text = $"{0:C2}";
    }

    private void TxtBuscarPorNumeroPedido_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.VerificarTeclaEnter()
            && !string.IsNullOrWhiteSpace(txtBuscarPorNumeroPedido.Text))
        {
            try
            {
                if (long.TryParse(txtBuscarPorNumeroPedido.Text, out var pedidoId))
                {
                    pedido = servicoPedidos.ObterPedidoEmAbertoComItens(pedidoId);

                    if (pedido is not null)
                        CarregarPedido();
                    else
                        this.ExibirMensagem("O pedido não foi encontrado.", "Pedido não encontrado");
                }
                else
                    this.ExibirMensagem("O Id do pedido informado não é válido.", "Id inválido");
            }
            catch (Exception erro)
            {
                this.ExibirMensagemErro(erro);
            }
        }

    }
}
