namespace WZSISTEMAS.Consultas;

public partial class FrmConsultaAvancadaClientes : Form
{
    private readonly IServicoClientes servicoEntidades;
    public long Id { get; set; }

    public FrmConsultaAvancadaClientes(IServicoClientes servicoEntidades)
    {
        InitializeComponent();

        this.servicoEntidades = servicoEntidades
            ?? throw new ArgumentNullException(nameof(servicoEntidades));
    }

    private void CarregarCadastros(IEnumerable<Cliente> entidades)
    {
        foreach (var entidade in entidades)
            dgvCadastros.Adicionar(
                entidade.Id,
                entidade.Tipo.ConverterParaString(),
                entidade.NomeCompleto_RazaoSocial,
                entidade.CPF_CNPJ);
    }

    private void FrmConsultaAvancadaClientes_Load(object sender, EventArgs e)
        => txtFiltrarPorNomeCompleto_RazaoSocial.Selecionar();

    private void TxtFiltrarPorNomeCompleto_RazaoSocial_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.VerificarTeclaEnter()
            && !string.IsNullOrWhiteSpace(txtFiltrarPorNomeCompleto_RazaoSocial.Text))
            try
            {
                dgvCadastros.Rows.Clear();

                CarregarCadastros(
                    servicoEntidades.ListaPorNomeCompleto_RazaoSocial(txtFiltrarPorNomeCompleto_RazaoSocial.Text));
            }
            catch (Exception erro)
            {
                this.ExibirMensagemErro(erro);
            }
            finally
            {
                txtFiltrarPorNomeCompleto_RazaoSocial.Selecionar();
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
