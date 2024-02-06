using WZSISTEMAS.Dados.Entidades;
using WZSISTEMAS.Dados.Entidades.Helpers;
using WZSISTEMAS.Dados.Helpers;
using WZSISTEMAS.Dados.Servicos.Interfaces;
using WZSISTEMAS.WinForms.Helpers;

namespace WZSISTEMAS.FrenteCaixa;

public partial class FrmFrenteCaixaManutencao : Form
{
    private readonly IServicoVendas servicoVendas;
    private readonly IServicoPedidos servicoPedidos;

    private long caixaId;
    private long funcionarioId;

    private TipoFrenteCaixa servicoTipo;

    public FrmFrenteCaixaManutencao(
        IServicoVendas servicoVendas,
        IServicoPedidos servicoPedidos)
    {
        InitializeComponent();

        this.servicoVendas = servicoVendas 
            ?? throw new ArgumentNullException(nameof(servicoVendas));

        this.servicoPedidos = servicoPedidos
            ?? throw new ArgumentNullException(nameof(servicoPedidos));
    }

    public void DefinirCaixaId(long caixaId)
    {
        this.caixaId = caixaId;
    }

    public void DefinirFuncionarioId(long funcionarioId)
    {
        this.funcionarioId = funcionarioId;
    }

    public void DefinirTipo(TipoFrenteCaixa tipo)
    {
        this.servicoTipo = tipo;

        if (tipo == TipoFrenteCaixa.Pedido)
        {
            Text = "Manutenção de pedidos";
            gbxItens.Text = "Pedidos";
            gbxItemItens.Text = "Itens do pedido";

            btnCancelar.Text = "Cancelar pedido";
            gbxTipos.Text = "Pedidos";

            clnItemTerminal.Visible = false;
            clnItemCaixaId.Visible = false;
        }
        else if (tipo == TipoFrenteCaixa.Venda)
        {
            Text = "Manutenção de vendas";
            gbxItens.Text = "Vendas";
            gbxItemItens.Text = "Itens da venda";

            btnCancelar.Text = "Cancelar venda";
            gbxTipos.Text = "Vendas";

            clnItemTerminal.Visible = true;
            clnItemCaixaId.Visible = true;
        }
    }

    private void CarregarVendas(IEnumerable<Venda> itens)
    {
        dgvItens.Rows.Clear();
        dgvItemItens.Rows.Clear();

        foreach (var item in itens)
            dgvItens.Adicionar(
                item.Id,
                item.Caixa.TerminalId,
                item.CaixaId,
                item.ValorTotal,
                item.Volume,
                $"{item.AbertaEm:G}");

        dgvItens.SelecionarUltimaLinha();

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
    private void CarregarPedidos(IEnumerable<Pedido> itens)
    {
        dgvItens.Rows.Clear();
        dgvItemItens.Rows.Clear();

        foreach (var item in itens)
            dgvItens.Adicionar(
                item.Id,
                0,
                0,
                item.ValorTotal,
                item.Volume,
                $"{item.AbertoEm:G}");

        dgvItens.SelecionarUltimaLinha();

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
    
    private void RecarregarVendas()
    {
        try
        {
            var itens = rbtnVendasFinalizadas.Checked                
                ? servicoVendas.ObterVendasFinalizadasFrenteCaixaManutencao(
                    dtpFiltrarPorDataDe.Value.Date,
                    dtpFiltrarPorDataAte.Value.Date)
                : servicoVendas.ObterVendasCanceladasFrenteCaixaManutencao(
                    dtpFiltrarPorDataDe.Value.Date,
                    dtpFiltrarPorDataAte.Value.Date);

            CarregarVendas(itens);
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void RecarregarPedidos()
    {
        try
        {
            var itens = rbtnVendasFinalizadas.Checked
                ? servicoPedidos.ObterPedidosFinalizadosFrenteCaixaManutencao(
                    dtpFiltrarPorDataDe.Value.Date,
                    dtpFiltrarPorDataAte.Value.Date)
                : servicoPedidos.ObterPedidosCanceladosFrenteCaixaManutencao(
                    dtpFiltrarPorDataDe.Value.Date,
                    dtpFiltrarPorDataAte.Value.Date);

            CarregarPedidos(itens);
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void Recarregar()
    {
        if (servicoTipo == TipoFrenteCaixa.Venda)
            RecarregarVendas();
        else if (servicoTipo == TipoFrenteCaixa.Pedido)
            RecarregarPedidos();
    }

    private void FrmManutencaoVendas_Load(object sender, EventArgs e)
    {
        dtpFiltrarPorDataDe.Value = DateTime.Now;
        dtpFiltrarPorDataAte.Value = DateTime.Now;

        rbtnVendasFinalizadas.Marcar();
    }

    private void BtnFiltrarPorData_Click(object sender, EventArgs e)
    {
        RecarregarVendas();
    }

    private void DtpFiltrarPorData_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (Keys.Return.Comparar(e.KeyChar))
            Recarregar();
    }

    private void RbtnVendas_CheckedChanged(object sender, EventArgs e)
    {
        if (sender is RadioButton rbtn
            && rbtn.Checked)
            Recarregar();
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
                var id = dgvItens.Converter<long>(e.RowIndex);

                dgvItemItens.Rows.Clear();

                if (servicoTipo == TipoFrenteCaixa.Venda)
                    PreencherVendas(id);
                else if (servicoTipo == TipoFrenteCaixa.Pedido)
                    PreencherPedidos(id);

                dgvItemItens.SelecionarUltimaLinha();

                DefinirBotoesAcoes();
            }
            catch (Exception erro)
            {
                this.ExibirMensagemErro(erro);
            }
        }

        void PreencherVendas(long id)
        {
            var itens = servicoVendas.ObterVendaFrenteCaixaManutencao(id)
                ?? throw new InvalidOperationException("A venda não foi localizada.");

            for (var i = 0; i < itens.Itens.Count(); i++)
            {
                var item = itens.Itens.ElementAt(i);

                AdicionarItemVenda(item, i);
            }
        }

        void PreencherPedidos(long id)
        {
            var itens = servicoPedidos.ObterPedidoFrenteCaixaManutencao(id)
                ?? throw new InvalidOperationException("O pedido não foi localizado.");

            for (var i = 0; i < itens.Itens.Count(); i++)
            {
                var item = itens.Itens.ElementAt(i);

                AdicionarItemPedido(item, i);
            }

        }
       void AdicionarItemVenda(VendaItem item, int index)
        {
            dgvItemItens.Adicionar(
                index + 1,
                $"{item.ItemId:0000000}",
                item.CodigoBarrasCodigoReferencia(),
                item.Descricao,
                item.UnidadeMedida.ConverterParaString(true),
                $"{item.ValorUnitario:C2}",
                $"{item.Quantidade:0.000}",
                $"{item.ValorTotal:C2}");
        }

       void AdicionarItemPedido(PedidoItem item, int index)
        {
            dgvItemItens.Adicionar(
                index + 1,
                $"{item.ItemId:0000000}",
                item.CodigoBarrasCodigoReferencia(),
                item.Descricao,
                item.UnidadeMedida.ConverterParaString(true),
                $"{item.ValorUnitario:C2}",
                $"{item.Quantidade:0.000}",
                $"{item.ValorTotal:C2}");
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
            if (servicoTipo == TipoFrenteCaixa.Venda)
                CancelarVenda();
            else if (servicoTipo == TipoFrenteCaixa.Pedido)
                CancelarPedido();
        }
        catch (Exception erro)
        {
            servicoVendas.DescartarAlteracoes();

            this.ExibirMensagemErro(erro);
        }

        void CancelarVenda()
        {
            if (dgvItemItens.SelectedRows.Count > 0
                && this.ExibirMensagem("Tem certeza que deseja cancelar a venda?", "Confirmar cancelamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                servicoVendas.CancelarVenda(
                    dgvItens.ConverterPrimeiroSelecionado<long>());

                RecarregarVendas();

                this.ExibirMensagem(" A venda foi cancelada com sucesso.", "Venda cancelada");
            }
        }

        void CancelarPedido()
        {
            if (dgvItemItens.SelectedRows.Count > 0
                && this.ExibirMensagem("Tem certeza que deseja cancelar o pedido?", "Confirmar cancelamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                servicoPedidos.CancelarPedido(
                    dgvItens.ConverterPrimeiroSelecionado<long>());

                RecarregarPedidos();

                this.ExibirMensagem(" O pedido foi cancelado com sucesso.", "Pedido cancelado");
            }

        }
    }
}
