namespace WZSISTEMAS.Consultas;

public partial class FrmConsultaAvancadaFuncionarios : Form
{
    private readonly IServicoFuncionarios servicoEntidades;
    public long Id { get; set; }

    public FrmConsultaAvancadaFuncionarios(IServicoFuncionarios servicoEntidades)
    {
        InitializeComponent();

        this.servicoEntidades = servicoEntidades
            ?? throw new ArgumentNullException(nameof(servicoEntidades));
    }

    private void CarregarCadastros(IEnumerable<Funcionario> entidades)
    {
        foreach (var entidade in entidades)
            dgvCadastros.Adicionar(
                entidade.Id,
                entidade.NomeCompleto,
                entidade.CPF);
    }

    private void FrmConsultaAvancadaFuncionarios_Load(object sender, EventArgs e)
        => txtFiltrarPorNomeCompleto.Selecionar();

    private void TxtFiltrarPorNomeCompleto_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (Keys.Return.Comparar(e.KeyChar)
            && !string.IsNullOrWhiteSpace(txtFiltrarPorNomeCompleto.Text))
            {
            try
            {
                dgvCadastros.Rows.Clear();

                CarregarCadastros(
                    servicoEntidades.ListarPorNomeCompleto(txtFiltrarPorNomeCompleto.Text));
            }
            catch (Exception erro)
            {
                this.ExibirMensagemErro(erro);
            }
            finally
            {
                txtFiltrarPorNomeCompleto.Selecionar();
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
