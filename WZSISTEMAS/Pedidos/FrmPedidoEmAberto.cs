namespace WZSISTEMAS.Pedidos;

public partial class FrmPedidoEmAberto : Form
{
    private readonly IServicoPedidos servicoPedidos;

    public Pedido? Pedido { get; private set; }

    public bool Concluiu { get; private set; }

    public FrmPedidoEmAberto(IServicoPedidos servicoPedidos)
    {
        InitializeComponent();

        this.servicoPedidos = servicoPedidos ?? throw new ArgumentNullException(nameof(servicoPedidos));
    }

    private void CarregarPedidos(IEnumerable<Pedido> pedidos)
    {
        dgvPedidos.Rows.Clear();
        dgvPedidoItens.Rows.Clear();

        foreach (var pedido in pedidos)
            dgvPedidos.Adicionar(
                pedido.Id,
                pedido.Id,
                pedido.Funcionario.NomeCompleto,
                pedido.ValorTotal,
                pedido.Volume,
                $"{pedido.AbertoEm:G}");

        dgvPedidos.SelecionarUltimaLinha();

        btnSelecionar.Enabled = false;
    }

    private void RecarregarPedidos()
    {
        try
        {
            var pedidos = servicoPedidos.ObterPedidosEmAbertoFrenteCaixa(
                dtpFiltrarPorDataDe.Value.Date,
                dtpFiltrarPorDataAte.Value.Date);

            CarregarPedidos(pedidos);
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void RecarregarItens()
    {
        RecarregarPedidos();
    }

    private void FrmFrenteCaixaEmEspera_Load(object sender, EventArgs e)
    {
        dtpFiltrarPorDataDe.Value = DateTime.Now.Date;
        dtpFiltrarPorDataAte.Value = DateTime.Now.Date;

        RecarregarPedidos();
    }

    private void DtpFiltrarPorData_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (Keys.Return.Comparar(e.KeyChar))
            RecarregarItens();
    }

    private void BtnFiltrarPorData_Click(object sender, EventArgs e)
        => RecarregarItens();

    private void CarregarPedido(long pedidoId)
    {
        var pedido = servicoPedidos.ObterPedidoEmAbertoComItens(pedidoId) ?? throw new InvalidOperationException("O pedido não foi localizado.");

        for (var i = 0; i < pedido.Itens.Count; i++)
        {
            var item = pedido.Itens.ElementAt(i);

            dgvPedidoItens.Adicionar(
                i + 1,
                item.CodigoBarrasCodigoReferencia(),
                item.Descricao,
                item.UnidadeMedida.ConverterParaString(true),
                $"{item.ValorUnitario:C2}",
                $"{item.Quantidade:0.000}",
                $"{item.ValorTotal:C2}");
        }
    }

    private void DgvItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.LinhaEColunaSelecionada())
        {
            try
            {
                var itemId = dgvPedidos.Converter<long>(e.RowIndex);

                dgvPedidoItens.Rows.Clear();
                CarregarPedido(itemId);
                dgvPedidoItens.SelecionarUltimaLinha();

                btnSelecionar.Enabled = true;
            }
            catch (Exception erro)
            {
                this.ExibirMensagemErro(erro);
            }
        }
    }

    private void BtnSelecionar_Click(object sender, EventArgs e)
    {
        try
        {
            var itemId = dgvPedidos.ConverterPrimeiroSelecionado<long>();

            Pedido = servicoPedidos.ObterPorIdComItensProduto(itemId);

            Concluiu = true;

            Close();
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }
}
