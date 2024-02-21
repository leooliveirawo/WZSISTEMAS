namespace WZSISTEMAS.Pedidos;

public partial class FrmPedidoManutencao : Form
{
    private readonly IServicoPedidos servicoPedidos;

    private long funcionarioId;

    public FrmPedidoManutencao(IServicoPedidos servicoPedidos)
    {
        InitializeComponent();

        this.servicoPedidos = servicoPedidos
            ?? throw new ArgumentNullException(nameof(servicoPedidos));
    }

    public void DefinirFuncionarioId(long funcionarioId)
    {
        this.funcionarioId = funcionarioId;
    }
    
    private void CarregarPedidos(IEnumerable<Pedido> itens)
    {
        dgvPedidos.Rows.Clear();
        dgvPedidoItens.Rows.Clear();

        foreach (var item in itens)
            dgvPedidos.Adicionar(
                item.Id,
                0,
                0,
                item.ValorTotal,
                item.Volume,
                $"{item.AbertoEm:G}");

        dgvPedidos.SelecionarUltimaLinha();

        if (rbtnVendasFinalizadas.Checked)
        {
            btnImprimirNota.Show();
            btnImprimirCupom.Show();
            btnCancelar.Show();

            btnImprimirNota.Desativar();
            btnImprimirCupom.Desativar();
            btnCancelar.Desativar();
        }
        else
        {
            btnImprimirNota.Hide();
            btnImprimirCupom.Hide();
            btnCancelar.Hide();
        }
    }
    
    private void RecarregarPedido()
    {
        try
        {
            CarregarPedidos(ConsultarPedidos());
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private IEnumerable<Pedido> ConsultarPedidos()
        => rbtnVendasFinalizadas.Checked
            ? servicoPedidos.ObterPedidosFinalizadosFrenteCaixaManutencao(
                dtpFiltrarPorDataDe.Value.Date,
                dtpFiltrarPorDataAte.Value.Date)
            : servicoPedidos.ObterPedidosCanceladosFrenteCaixaManutencao(
                dtpFiltrarPorDataDe.Value.Date,
                dtpFiltrarPorDataAte.Value.Date);

    private void FrmManutencaoVendas_Load(object sender, EventArgs e)
    {
        dtpFiltrarPorDataDe.Value = DateTime.Now;
        dtpFiltrarPorDataAte.Value = DateTime.Now;

        rbtnVendasFinalizadas.Marcar();
    }

    private void BtnFiltrarPorData_Click(object sender, EventArgs e)
        => RecarregarPedido();

    private void DtpFiltrarPorData_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.VerificarTeclaEnter())
            RecarregarPedido();
    }

    private void RbtnVendas_CheckedChanged(object sender, EventArgs e)
    {
        if (sender is RadioButton rbtn
            && rbtn.Checked)
            RecarregarPedido();
    }

    private void DefinirBotoesAcoes()
    {
        if (rbtnVendasFinalizadas.Checked)
        {
            btnImprimirNota.Ativar();
            btnImprimirCupom.Ativar();
            btnCancelar.Ativar();
        }
    }

    private void PreencherPedidos(long id)
    {
        var itens = servicoPedidos.ObterPedidoFrenteCaixaManutencao(id)
                    ?? throw new InvalidOperationException("O pedido não foi localizado.");

        for (var i = 0; i < itens.Itens.Count(); i++)
        {
            var item = itens.Itens.ElementAt(i);

            AdicionarItemPedido(item, i);
        }

    }

    private void AdicionarItemPedido(PedidoItem item, int index)
        => dgvPedidoItens.Adicionar(
            index + 1,
            $"{item.ItemId:0000000}",
            item.CodigoBarrasCodigoReferencia(),
            item.Descricao,
            item.UnidadeMedida.ConverterParaString(true),
            $"{item.ValorUnitario:C2}",
            $"{item.Quantidade:0.000}",
            $"{item.ValorTotal:C2}");

    private void DgvVendas_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.LinhaEColunaSelecionada())
            DefinirBotoesAcoes();
    }

    private void DgvVendas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.LinhaEColunaSelecionada())
        {
            try
            {
                var id = dgvPedidos.Converter<long>(e.RowIndex);

                dgvPedidoItens.Rows.Clear();

                PreencherPedidos(id);

                dgvPedidoItens.SelecionarUltimaLinha();

                DefinirBotoesAcoes();
            }
            catch (Exception erro)
            {
                this.ExibirMensagemErro(erro);
            }
        }

    }

    private void BtnImprimirNota_Click(object sender, EventArgs e)
        => this.ExibirMensagemNaoImplementado();

    private void BtnImprimirCupom_Click(object sender, EventArgs e)
        => this.ExibirMensagemNaoImplementado();

    private void BtnCancelar_Click(object sender, EventArgs e)
    {
        try
        {
            if (dgvPedidoItens.SelectedRows.Count > 0
                && this.ExibirMensagem("Tem certeza que deseja cancelar o pedido?", "Confirmar cancelamento",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                servicoPedidos.CancelarPedido(
                    dgvPedidos.ConverterPrimeiroSelecionado<long>());

                RecarregarPedido();

                this.ExibirMensagem(" O pedido foi cancelado com sucesso.", "Pedido cancelado");
            }
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
        finally
        {
            servicoPedidos.DescartarAlteracoes();
        }

    }
}
