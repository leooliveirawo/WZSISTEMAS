using WZSISTEMAS.Data.Servicos.Interfaces;

namespace WZSISTEMAS.Consultas
{
    public partial class FrmConsultaAvancadaClientes : Form
    {
        private readonly IServicoClientesConsultas servico;
        public long Id { get; protected set; }

        public FrmConsultaAvancadaClientes(IServicoClientesConsultas servico)
        {
            InitializeComponent();

            this.servico = servico ?? throw new ArgumentNullException(nameof(servico));
        }

        private void CarregarCadastros(IEnumerable<Cliente> cadastros)
        {
            foreach (var cadastro in cadastros)
            {
                string tipo;

                if (cadastro.Tipo == Cliente.ClienteTipos.PessoaFisica)
                    tipo = "Pessoa fisica (PF)";
                else
                    tipo = "Pessoa juridica (PJ)";

                dgvCadastros.Rows.Add(cadastro.Id, tipo, cadastro.NomeCompleto_RazaoSocial, cadastro.CPF_CNPJ);
            }
        }

        private void FrmConsultaAvancadaClientes_Load(object sender, EventArgs e)
        {
            txtFiltrarPorNomeCompleto_RazaoSocial.Focus();
            txtFiltrarPorNomeCompleto_RazaoSocial.SelectAll();
        }

        private async void TxtFiltrarPorNomeCompleto_RazaoSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (!string.IsNullOrWhiteSpace(txtFiltrarPorNomeCompleto_RazaoSocial.Text))
                {
                    try
                    {
                        dgvCadastros.Rows.Clear();

                        var cadastros = await servico.ObterPorNomeCompleto_RazaoSocialAsync(txtFiltrarPorNomeCompleto_RazaoSocial.Text);

                        CarregarCadastros(cadastros);
                    }
                    catch (Exception erro)
                    {
                        this.ExibirMensagemErro(erro);

                        txtFiltrarPorNomeCompleto_RazaoSocial.Focus();
                        txtFiltrarPorNomeCompleto_RazaoSocial.SelectAll();
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
