namespace WZSISTEMAS.Consultas;

public partial class FrmConsultaAvancadaFornecedores : Form
{
    private readonly IServicoFornecedores servicoEntidades;
    public long Id { get; set; }

    public FrmConsultaAvancadaFornecedores(IServicoFornecedores servicoEntidades)
    {
        InitializeComponent();

        this.servicoEntidades = servicoEntidades 
            ?? throw new ArgumentNullException(nameof(servicoEntidades));
    }

    private void CarregarCadastros(IEnumerable<Fornecedor> entidades)
    {
        foreach (var entidade in entidades)
            dgvCadastros.Adicionar(
                entidade.Id,
                entidade.RazaoSocial,
                entidade.CNPJ);
    }

    private void FrmConsultaAvancadaFornecedores_Load(object sender, EventArgs e) 
        => txtFiltrarPorRazaoSocial.Selecionar();

    private void TxtFiltrarPorRazaoSocial_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.VerificarTeclaEnter()
            && !string.IsNullOrWhiteSpace(txtFiltrarPorRazaoSocial.Text))
        {
            try
            {
                dgvCadastros.Rows.Clear();

                CarregarCadastros(
                    servicoEntidades.ListarPorRazaoSocial(txtFiltrarPorRazaoSocial.Text));
            }
            catch (Exception erro)
            {
                this.ExibirMensagemErro(erro);
            }
            finally
            {
                txtFiltrarPorRazaoSocial.Selecionar();
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
