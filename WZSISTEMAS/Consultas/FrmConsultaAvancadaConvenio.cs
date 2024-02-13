namespace WZSISTEMAS.Consultas;

public partial class FrmConsultaAvancadaConvenio : Form
{
    private readonly IServicoClientes servicoEntidades;
    public long Id { get; set; }

    public FrmConsultaAvancadaConvenio(IServicoClientes servicoEntidades)
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
                entidade.CPF_CNPJ,
                $"{ entidade.ConvenioLimite:C2}");
    }

    private void FrmConsultaAvancadaClientes_Load(object sender, EventArgs e)
        => txtFiltrarPorCPF_CNPJ_NomeCompleto_RazaoSocial.Selecionar();

    private void TxtFiltrarPorCPF_CNPJ_NomeCompleto_RazaoSocial_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (Keys.Return.Comparar(e.KeyChar)
            && !string.IsNullOrWhiteSpace(txtFiltrarPorCPF_CNPJ_NomeCompleto_RazaoSocial.Text))
            try
            {
                dgvCadastros.Rows.Clear();

                CarregarCadastros(
                    servicoEntidades.ListaConvenioPorCPF_CNPJ_NomeCompleto_RazaoSocial(txtFiltrarPorCPF_CNPJ_NomeCompleto_RazaoSocial.Text));
            }
            catch (Exception erro)
            {
                this.ExibirMensagemErro(erro);
            }
            finally
            {
                txtFiltrarPorCPF_CNPJ_NomeCompleto_RazaoSocial.Selecionar();
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
