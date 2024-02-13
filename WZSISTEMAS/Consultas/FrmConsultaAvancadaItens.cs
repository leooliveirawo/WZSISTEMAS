namespace WZSISTEMAS.Consultas;

public partial class FrmConsultaAvancadaItens : Form
{
    private readonly IServicoItens servicoEntidades;

    public long Id { get; set; }

    private TipoConsultaItens tipo;

    public FrmConsultaAvancadaItens(IServicoItens servicoEntidades)
    {
        InitializeComponent();

        this.servicoEntidades = servicoEntidades
            ?? throw new ArgumentNullException(nameof(servicoEntidades));

        tipo = TipoConsultaItens.Padrao;
    }

    public void DefinirTipo(TipoConsultaItens tipo)
        => this.tipo = tipo;

    private void CarregarCadastros(IEnumerable<Item> entidades)
    {
        foreach (var entidade in entidades)
            dgvCadastros.Adicionar(
                entidade.Id,
                entidade.CodigoBarrasCodigoReferencia(),
                entidade.Descricao,
                $"{entidade.PrecoFinal:C2}");
    }

    private void FrmConsultaAvancadaProdutos_Load(object sender, EventArgs e)
        => txtFiltrarPorDescricao.Selecionar();

    private void TxtFiltrarPorDescricao_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (Keys.Return.Comparar(e.KeyChar)
            && !string.IsNullOrWhiteSpace(txtFiltrarPorDescricao.Text))
        {
            try
            {
                dgvCadastros.Rows.Clear();

                CarregarCadastros(
                    servicoEntidades.ListarPorIdCodigoBarrasCodigoReferenciaDescricao(
                        txtFiltrarPorDescricao.Text,
                        tipo));
            }
            catch (Exception erro)
            {
                this.ExibirMensagemErro(erro);
            }
            finally
            {
                txtFiltrarPorDescricao.Selecionar();
            }
        }
    }

    private void DgvCadastros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.LinhaEColunaSelecionada())
        {
            Id = dgvCadastros.Converter<long>(e.RowIndex);

            DialogResult = DialogResult.OK;
        }
    }
}
