using WZSISTEMAS.Data.Servicos.Interfaces;

namespace WZSISTEMAS.Consultas
{
    public partial class FrmConsultaAvancadaFornecedores : Form
    {
        private readonly IServicoFornecedoresConsultas servico;
        public long Id { get; protected set; }

        public FrmConsultaAvancadaFornecedores(IServicoFornecedoresConsultas servico)
        {
            InitializeComponent();

            this.servico = servico ?? throw new ArgumentNullException(nameof(servico));
        }

        private void CarregarCadastros(IEnumerable<Fornecedor> cadastros)
        {
            foreach (var cadastro in cadastros)
                dgvCadastros.Rows.Add(cadastro.Id, cadastro.RazaoSocial, cadastro.CNPJ);
        }

        private void FrmConsultaAvancadaFornecedores_Load(object sender, EventArgs e)
        {
            txtFiltrarPorRazaoSocial.Focus();
            txtFiltrarPorRazaoSocial.SelectAll();
        }

        private async void TxtFiltrarPorRazaoSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (!string.IsNullOrWhiteSpace(txtFiltrarPorRazaoSocial.Text))
                {
                    try
                    {
                        dgvCadastros.Rows.Clear();

                        var cadastros = await servico.ObterPorRazaoSocialAsync(txtFiltrarPorRazaoSocial.Text);

                        CarregarCadastros(cadastros);
                    }
                    catch (Exception erro)
                    {
                        this.ExibirMensagemErro(erro);

                        txtFiltrarPorRazaoSocial.Focus();
                        txtFiltrarPorRazaoSocial.SelectAll();
                    }
                }
            }
        }

        private void DgvCadastros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Id = (long)dgvCadastros[0, e.RowIndex].Value;

                DialogResult = DialogResult.OK;
            }
        }
    }
}
