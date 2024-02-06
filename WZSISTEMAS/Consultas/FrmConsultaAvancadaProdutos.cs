using WZSISTEMAS.Dados.Entidades;
using WZSISTEMAS.Dados.Entidades.Helpers;
using WZSISTEMAS.Dados.Servicos.Interfaces;
using WZSISTEMAS.WinForms.Helpers;

namespace WZSISTEMAS.Consultas;

public partial class FrmConsultaAvancadaItens : Form
{
    private readonly IServicoProdutos servicoEntidades;

    public long Id { get; set; }

    public FrmConsultaAvancadaItens(IServicoProdutos servicoEntidades)
    {
        InitializeComponent();

        this.servicoEntidades = servicoEntidades
            ?? throw new ArgumentNullException(nameof(servicoEntidades));
    }

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
                    servicoEntidades.ListarPorDescricao(txtFiltrarPorDescricao.Text));
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
