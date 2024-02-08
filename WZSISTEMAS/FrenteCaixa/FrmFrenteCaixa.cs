namespace WZSISTEMAS.FrenteCaixa;

public partial class FrmFrenteCaixa : Form
{
    private readonly IServicoCaixas servicoCaixas;
    private readonly IServicoVendas servicoVendas;
    private readonly IServicoProdutos servicoProdutos;
    private readonly IServicoFuncionarios servicoFuncionarios;

    private Venda? venda;

    private long caixaId;
    private long funcionarioId;

    private bool naoSelecionar;

    private bool naoCarregarVendaEmAberto;

    public FrmFrenteCaixa(IServicoCaixas servicoCaixas, IServicoVendas servicoVendas, IServicoProdutos servicoProdutos, IServicoFuncionarios servicoFuncionarios)
    {
        InitializeComponent();

        this.servicoCaixas = servicoCaixas ?? throw new ArgumentNullException(nameof(servicoCaixas));
        this.servicoVendas = servicoVendas ?? throw new ArgumentNullException(nameof(servicoVendas));
        this.servicoProdutos = servicoProdutos ?? throw new ArgumentNullException(nameof(servicoProdutos));
        this.servicoFuncionarios = servicoFuncionarios ?? throw new ArgumentNullException(nameof(servicoFuncionarios));
    }

    public void DefinirCaixaId(long caixaId)
        => this.caixaId = caixaId;

    public void DefinirVenda(Venda venda)
        => this.venda = venda;

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

    private FrmFrenteCaixaEmEspera ExibirFrenteCaixaEmEspera()
    {
        using var frm = ProvedorServicos.FrmFrenteCaixaEmAberto();

        frm.DefinirCaixaId(caixaId);

        frm.ShowDialog(this);

        return frm;
    }

    private void AbrirVendasEspera()
    {
        if (venda is null)
        {
            using var frm = ExibirFrenteCaixaEmEspera();

            if (frm.Concluiu)
            {
                venda = frm.Venda
                        ?? throw new InvalidOperationException("Um erro interno ocorreu no sistema");

                CarregarVenda();
            }
        }
    }

    private void RecalcularVendaTotal()
        => lbTotal.Text = $"{venda?.ValorTotal:C2}";

    private void RedefinirTelaVenda()
    {
        gbxNumero.Text = "Venda Nº";
        lbTotal.Text = $"{0:C2}";

        lbCPF_CNPJ.Clear("NÃO INFORMADO");

        RedefinirCamposConsulta();

        dgvItens.Rows.Clear();
    }

    private void CarregarVenda()
    {
        lbTotal.Text =
            $"{venda?.ValorTotal ?? throw new InvalidOperationException("Um erro interno aconteceu durante a venda"):C2}";

        gbxNumero.Text = $"Nº da Venda: {venda.Id}";

        DefinirCPFOuCNPJVenda();

        dgvItens.Rows.Clear();

        foreach (var item in venda.Itens)
            AdicionarItemVenda(item);

        dgvItens.SelecionarUltimaLinha();
    }

    private void AdicionarItemVenda(VendaItem item)
    {
        var count = dgvItens.Rows.GetRowCount(DataGridViewElementStates.Visible) + 1;

        dgvItens.Adicionar(
            item.Id,
            count,
            $"{item.ItemId:0000000}",
            item.CodigoBarrasCodigoReferencia(),
            item.DescricaoFormatada(),
            item.UnidadeMedida.ConverterParaString(true),
            $"{item.ValorUnitario:C2}",
            $"{item.Quantidade:0.000}",
            $"{item.ValorTotal:C2}");
    }

    private void RedefinirParametrosVenda()
        => venda = default;

    private void InformarCPFOuCNPJNaNotaVenda()
    {
        if (venda is not null)
        {
            using var frm = ProvedorServicos.FrmFrenteCaixaCPF_CNPJNaNota();

            frm.DefinirCPF_CNPJ(venda.CPF_CNPJ_Nota);

            if (frm.ShowDialog(this, DialogResult.OK))
            {
                venda = servicoVendas.ObterPorId(
                            venda.Id,
                            true)
                        ?? throw new InvalidOperationException("A venda não foi encontrada");

                venda.CPF_CNPJ_Nota = frm.CPF_CNPJ;

                servicoVendas.Editar(venda);

                servicoVendas.SalvarAlteracoes();

                servicoVendas.DescartarAlteracoes();

                DefinirCPFOuCNPJVenda();

                txtCodBarrasCodRef.Selecionar();
            }
        }
    }

    private void CancelarVenda()
    {
        if (venda is not null)
        {
            if (this.ExibirMensagemSimNao("Tem certeza que deseja cancelar a venda?", "Confirmar cancelamento"))
            {
                try
                {
                    servicoVendas.CancelarVenda(venda.Id);

                    RedefinirParametrosVenda();

                    RedefinirTelaVenda();

                    this.ExibirMensagemOperacaoConcluida("A venda foi cancelada com sucesso.");
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

    private void AcoesVenda(KeyEventArgs e)
    {
        if (e.KeyData == Keys.F4)
            ExcluirItemVenda();
        else if (e.KeyData == Keys.F5)
            FecharVenda();
        else if (e.KeyData == Keys.F6)
            ColocarEmEsperaVenda();
        else if (e.KeyData == Keys.F7)
            AbrirVendasEspera();
        else if (e.KeyData == Keys.F3)
            InformarCPFOuCNPJNaNotaVenda();
        else if (e.KeyData == Keys.F8)
        {
            naoSelecionar = true;
            dgvItens.Selecionar();
        }
        else if (e.KeyData != Keys.F2)
            naoSelecionar = true;
    }

    private void ExcluirItemVenda()
    {
        if (dgvItens.ExisteLinhasSelecionadas()
            && this.ExibirMensagemSimNao("Tem certeza que deseja excluir o tipoItem da venda?",
                "Excluir tipoItem da venda"))
        {
            venda = servicoVendas.ExcluirItem(
                dgvItens.ConverterPrimeiroSelecionado<long>());

            dgvItens.RemoverPrimeiraLinhaSelecionada();

            RecalcularPosicoes();
            RecalcularVendaTotal();
            RedefinirCamposConsulta();

            this.ExibirMensagemOperacaoConcluida("O tipoItem foi excluído da venda.");
        }

    }

    private void FecharVenda()
    {
        if (venda is not null
            && dgvItens.ExisteLinhas())
        {
            using var frm = ProvedorServicos.FrmFrenteCaixaFechamento();

            frm.DefinirVendaId(venda.Id);

            frm.ShowDialog(this);

            if (frm.Fechou)
            {
                RedefinirParametrosVenda();
                RedefinirTelaVenda();
            }
        }
    }

    private void ColocarEmEsperaVenda()
    {
        if (venda is not null
            && dgvItens.ExisteLinhas())
        {
            servicoVendas.ColocarVendaEmEspera(venda.Id);

            RedefinirParametrosVenda();
            RedefinirTelaVenda();
        }
    }

    private void AcoesVenda(Item item, decimal quantidade)
    {
        VerificarVenda();
        IncluirItemVenda(item, quantidade);
    }

    private void VerificarVenda()
    {
        if (venda is null)
        {
            venda = servicoVendas.NovaVenda(caixaId);

            CarregarVenda();

            InformarCPFOuCNPJNaNotaVenda();
        }
    }

    private void IncluirItemVenda(Item item1, decimal quantidade)
    {
        var precoFinal = SelecionarPrecoFinalItem(item1);

        var venda_VendaProduto = servicoVendas.AdicionarItem(
            venda?.Id
            ?? throw new InvalidOperationException("Um erro interno aconteceu durante a venda"),
            item1.Id,
            precoFinal,
            quantidade);

        venda = venda_VendaProduto.Item1;
        var item = venda_VendaProduto.Item2;

        AdicionarItemVenda(item);

        dgvItens.Rows[dgvItens.Rows.GetLastRow(DataGridViewElementStates.Visible)].Selected = true;
    }

    private void DefinirCPFOuCNPJVenda()
        => lbCPF_CNPJ.Text = venda?.CPF_CNPJ_Nota is null
            ? "NÃO INFORMADO"
            : venda.CPF_CNPJ_Nota
              ?? throw new InvalidOperationException("Um erro interno aconteceu durante a venda");

    private void FrmFrenteCaixa_Load(object sender, EventArgs e)
    {
        lbTerminalNumero.Text = $"Nº do terminal {TerminalId}";

        try
        {
            var funcionario = servicoFuncionarios.ObterPorId(funcionarioId)
                ?? throw new InvalidOperationException("O funcionário não foi encontrado");

            lbOperador.Text = funcionario.NomeCompleto;

            if (venda is null)
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

    private void FrmFrenteCaixa_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (Keys.Escape.Comparar(e.KeyChar))
        {
            CancelarVenda();
        }
    }

    private void FrmFrenteCaixa_KeyUp(object sender, KeyEventArgs e)
    {
        naoSelecionar = false;

        try
        {
            AcoesVenda(e);
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
                        AcoesVenda(item, quantidade);
                        RecalcularVendaTotal();
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

            frm.ShowDialog(this);
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void TimerDataHora_Tick(object sender, EventArgs e)
        => lbDataHora.Text = $"{DateTime.Now.ToLongDateString()} - {DateTime.Now.ToLongTimeString()}";
}
