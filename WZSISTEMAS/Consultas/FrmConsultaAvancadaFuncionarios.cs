using WZSISTEMAS.Data.Servicos.Interfaces;

namespace WZSISTEMAS.Consultas
{
    public partial class FrmConsultaAvancadaFuncionarios : Form
    {
        private readonly IServicoFuncionariosConsultas servico;
        public long Id { get; protected set; }

        public FrmConsultaAvancadaFuncionarios(IServicoFuncionariosConsultas servico)
        {
            InitializeComponent();

            this.servico = servico ?? throw new ArgumentNullException(nameof(servico));
        }

        private void CarregarCadastros(IEnumerable<Funcionario> cadastros)
        {
            foreach (var cadastro in cadastros)
            {
                dgvCadastros.Rows.Add(cadastro.Id, cadastro.NomeCompleto, cadastro.CPF);
            }
        }

        private void FrmConsultaAvancadaFuncionarios_Load(object sender, EventArgs e)
        {
            txtFiltrarPorNomeCompleto.Focus();
            txtFiltrarPorNomeCompleto.SelectAll();
        }

        private async void TxtFiltrarPorNomeCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (!string.IsNullOrWhiteSpace(txtFiltrarPorNomeCompleto.Text))
                {
                    try
                    {
                        dgvCadastros.Rows.Clear();

                        var cadastros = await servico.ObterPorNomeCompletoAsync(txtFiltrarPorNomeCompleto.Text);

                        CarregarCadastros(cadastros);
                    }
                    catch (Exception erro)
                    {
                        this.ExibirMensagemErro(erro);

                        txtFiltrarPorNomeCompleto.Focus();
                        txtFiltrarPorNomeCompleto.SelectAll();
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
