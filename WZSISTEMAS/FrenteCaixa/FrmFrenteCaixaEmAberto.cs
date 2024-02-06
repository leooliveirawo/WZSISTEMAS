using WZSISTEMAS.Dados.Entidades;
using WZSISTEMAS.Dados.Entidades.Helpers;
using WZSISTEMAS.Dados.Helpers;
using WZSISTEMAS.Dados.Servicos.Interfaces;
using WZSISTEMAS.WinForms.Helpers;

namespace WZSISTEMAS.FrenteCaixa;

public partial class FrmFrenteCaixaEmAberto : Form
{
    private readonly IServicoVendas servicoVendas;
    private readonly IServicoPedidos servicoPedidos;

    private long caixaId;

    public Venda? Venda { get; private set; }
    public Pedido? Pedido { get; private set; }

    public bool Concluiu { get; private set; }

    private TipoFrenteCaixa tipo;

    public FrmFrenteCaixaEmAberto(IServicoVendas servicoVendas, IServicoPedidos servicoPedidos)
    {
        InitializeComponent();

        this.servicoVendas = servicoVendas ?? throw new ArgumentNullException(nameof(servicoVendas));
        this.servicoPedidos = servicoPedidos ?? throw new ArgumentNullException(nameof(servicoPedidos));
    }

    public void DefinirCaixaId(long caixaId)
        => this.caixaId = caixaId;

    public void DefinirTipo(TipoFrenteCaixa tipo)
    {
        this.tipo = tipo;

        ConfigurarTela();
    }

    private void CarregarVendas(IEnumerable<Venda> vendas)
    {
        dgvItens.Rows.Clear();
        dgvItemItens.Rows.Clear();

        foreach (var venda in vendas)
            dgvItens.Adicionar(
                venda.Id, 
                venda.Id, 
                venda.Caixa.Usuario.Funcionario.NomeCompleto,
                venda.ValorTotal, 
                venda.Volume, 
                $"{venda.AbertaEm:G}");

        dgvItens.SelecionarUltimaLinha();

        btnSelecionar.Enabled = false;
    }

    private void CarregarPedidos(IEnumerable<Pedido> pedidos)
    {
        dgvItens.Rows.Clear();
        dgvItemItens.Rows.Clear();

        foreach (var pedido in pedidos)
            dgvItens.Adicionar(
                pedido.Id,
                pedido.Id,
                pedido.Funcionario.NomeCompleto,
                pedido.ValorTotal,
                pedido.Volume,
                $"{pedido.AbertoEm:G}");

        dgvItens.SelecionarUltimaLinha();

        btnSelecionar.Enabled = false;
    }

    private void RecarregarVendas()
    {
        try
        {
            var vendas = servicoVendas.ObterVendasEmEspera(
                dtpFiltrarPorDataDe.Value.Date,
                dtpFiltrarPorDataAte.Value.Date);

            CarregarVendas(vendas);
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

    private void ConfigurarTela()
    {
        dtpFiltrarPorDataDe.Value = DateTime.Now.Date;
        dtpFiltrarPorDataAte.Value = DateTime.Now.Date;

        if (tipo == TipoFrenteCaixa.Venda)
        {
            ConfigurarTelaVenda();
            RecarregarVendas();
        }
        else if (tipo == TipoFrenteCaixa.Pedido)
        {
            ConfigurarTelaPedido();
            RecarregarPedidos();
        }
    }

    private void ConfigurarTelaVenda()
    {
        Text = "Vendas em espera";

        gbxTerminalNumero.Text = $"Nº do Terminal: {TerminalId}";
        lbCaixaNumero.Text = $"Nº do Caixa: {caixaId}";
        gbxItens.Text = "Vendas";
        gbxItemItens.Text = "Itens da venda";

        clnOperadorFuncionario.HeaderText = "Operador";

        lbCaixaNumero.Show();
    }

    private void ConfigurarTelaPedido()
    {
        Text = "Pedidos em aberto";

        gbxTerminalNumero.Text = $"Nº do Terminal: {TerminalId}";
        gbxItens.Text = "Pedidos";
        gbxItemItens.Text = "Itens do pedido";

        clnOperadorFuncionario.HeaderText = "Funcionário";

        lbCaixaNumero.Hide();
    }

    private void RecarregarItens()
    {
        if (tipo == TipoFrenteCaixa.Venda)
            RecarregarVendas();
        else if (tipo == TipoFrenteCaixa.Pedido)
            RecarregarPedidos();
    }

    private void FrmFrenteCaixaEmEspera_Load(object sender, EventArgs e)
    {
    }

    private void DtpFiltrarPorData_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (Keys.Return.Comparar(e.KeyChar))
            RecarregarItens();
    }

    private void BtnFiltrarPorData_Click(object sender, EventArgs e)
        => RecarregarItens();

    private void CarregarVenda(long vendaId)
    {
        var venda = servicoVendas.ObterVendaEmEsperaComItens(vendaId) ?? throw new InvalidOperationException("A venda não foi localizada.");

        for (var i = 0; i < venda.Itens.Count; i++)
        {
            var item = venda.Itens.ElementAt(i);

            dgvItemItens.Adicionar(
                i + 1,
                item.CodigoBarrasCodigoReferencia(),
                item.Descricao,
                item.UnidadeMedida.ConverterParaString(true),
                $"{item.ValorUnitario:C2}",
                $"{item.Quantidade:0.000}",
                $"{item.ValorTotal:C2}");
        }

    }

    private void CarregarPedido(long pedidoId)
    {
        var pedido = servicoPedidos.ObterPedidoEmAbertoComItens(pedidoId) ?? throw new InvalidOperationException("O pedido não foi localizado.");

        for (var i = 0; i < pedido.Itens.Count; i++)
        {
            var item = pedido.Itens.ElementAt(i);

            dgvItemItens.Adicionar(
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
                var itemId = dgvItens.Converter<long>(e.RowIndex);

                dgvItemItens.Rows.Clear();

                if (tipo == TipoFrenteCaixa.Venda)
                    CarregarVenda(itemId);
                else if (tipo == TipoFrenteCaixa.Pedido)
                    CarregarPedido(itemId);

                dgvItemItens.SelecionarUltimaLinha();

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
            var itemId = dgvItens.ConverterPrimeiroSelecionado<long>();

            if (tipo == TipoFrenteCaixa.Venda)
                Venda = servicoVendas.RetirarVendaEspera(itemId, caixaId);
            else if (tipo == TipoFrenteCaixa.Pedido)
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
