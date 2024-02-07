namespace WZSISTEMAS.FrenteCaixa;

public partial class FrmFrenteCaixaManutencao : Form
{
    private readonly IServicoVendas servicoVendas;

    private long caixaId;
    private long funcionarioId;

    public FrmFrenteCaixaManutencao(IServicoVendas servicoVendas)
    {
        InitializeComponent();

        this.servicoVendas = servicoVendas 
            ?? throw new ArgumentNullException(nameof(servicoVendas));
    }

    public void DefinirCaixaId(long caixaId)
        => this.caixaId = caixaId;

    public void DefinirFuncionarioId(long funcionarioId)
        => this.funcionarioId = funcionarioId;

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

    private void PreencherVendas(long id)
    {
        var itens = servicoVendas.ObterVendaFrenteCaixaManutencao(id)
                    ?? throw new InvalidOperationException("A venda não foi localizada.");

        for (var i = 0; i < itens.Itens.Count(); i++)
        {
            var item = itens.Itens.ElementAt(i);

            AdicionarItemVenda(item, i);
        }
    }
    
    private void AdicionarItemVenda(VendaItem item, int index)
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

    private void CancelarVenda()
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
            RecarregarVendas();
    }

    private void RbtnVendas_CheckedChanged(object sender, EventArgs e)
    {
        if (sender is RadioButton rbtn
            && rbtn.Checked)
            RecarregarVendas();
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

                PreencherVendas(id);

                dgvItemItens.SelecionarUltimaLinha();

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
            CancelarVenda();
        }
        catch (Exception erro)
        {
            servicoVendas.DescartarAlteracoes();

            this.ExibirMensagemErro(erro);
        }
    }
}
