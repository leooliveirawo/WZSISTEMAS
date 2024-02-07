namespace WZSISTEMAS.FrenteCaixa;

public partial class FrmFrenteCaixaEmEspera : Form
{
    private readonly IServicoVendas servicoVendas;

    private long caixaId;

    public Venda? Venda { get; private set; }

    public bool Concluiu { get; private set; }

    public FrmFrenteCaixaEmEspera(IServicoVendas servicoVendas)
    {
        InitializeComponent();

        this.servicoVendas = servicoVendas ?? throw new ArgumentNullException(nameof(servicoVendas));
    }

    public void DefinirCaixaId(long caixaId)
        => this.caixaId = caixaId;

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

    private void RecarregarItens()
        => RecarregarVendas();

    private void FrmFrenteCaixaEmEspera_Load(object sender, EventArgs e)
    {
        dtpFiltrarPorDataDe.Value = DateTime.Now.Date;
        dtpFiltrarPorDataAte.Value = DateTime.Now.Date;

        RecarregarVendas();
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

    private void DgvItens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.LinhaEColunaSelecionada())
        {
            try
            {
                var itemId = dgvItens.Converter<long>(e.RowIndex);

                dgvItemItens.Rows.Clear();
                CarregarVenda(itemId);
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

            Venda = servicoVendas.RetirarVendaEspera(itemId, caixaId);

            Concluiu = true;

            Close();
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }
}
