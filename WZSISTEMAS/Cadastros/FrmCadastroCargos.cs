using WZSISTEMAS.Data.Servicos.Interfaces;

namespace WZSISTEMAS.Cadastros
{
    public partial class FrmCadastroCargos : Form
    {
        private readonly IServicoCargos servico;

        private long id;

        private CadastroModos modo;

        public FrmCadastroCargos(IServicoCargos servico)
        {
            InitializeComponent();

            this.servico = servico ?? throw new ArgumentNullException(nameof(servico));
        }

        private void DefinirModo(CadastroModos modo)
        {
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;

            if (modo == CadastroModos.Padrao)
            {
                DefinirBusca(true);
                DefinirCampos(false);

                RedefinirCampos();

                btnNovo.Enabled = true;
            }
            else if (modo == CadastroModos.Editar)
            {
                DefinirBusca(false);
                DefinirCampos(true);

                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            else if (modo == CadastroModos.Novo)
            {
                DefinirBusca(false);
                DefinirCampos(true);

                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            else if (modo == CadastroModos.Visualizar)
            {
                DefinirBusca(true);
                DefinirCampos(false);

                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }

            this.modo = modo;
        }

        private void DefinirBusca(bool habilitar)
        {
            gbxConsulta.Enabled = habilitar;
            gbxCadastros.Enabled = habilitar;
        }

        private void DefinirCampos(bool habilitar)
        {
            gbxDados.Enabled = habilitar;
        }

        private void RedefinirCampos()
        {
            id = 0;

            txtNome.Clear();
            txtDescricao.Clear();
        }

        private void PreencherCadastro(Cargo cadastro)
        {
            cadastro.Id = id;

            cadastro.Nome = txtNome.Text;
            cadastro.Descricao = txtDescricao.Text;
        }

        private void PreencherTela(Cargo cadastro)
        {
            id = cadastro.Id;

            txtNome.Text = cadastro.Nome;
            txtDescricao.Text = cadastro.Descricao;
        }

        private void PreencherCadastros(IEnumerable<Cargo> cadastros)
        {
            foreach (var cadastro in cadastros)
                dgvCadastros.Rows.Add(cadastro.Id, cadastro.Nome);
        }

        private void FrmCadastroCargos_Load(object sender, EventArgs e)
        {
            DefinirModo(CadastroModos.Padrao);
        }

        private async void TxtBuscarPorNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return
                && !string.IsNullOrWhiteSpace(txtBuscarPorNome.Text))
            {
                try
                {
                    dgvCadastros.Rows.Clear();

                    var cadastro = await servico.ObterPorNomeAsync(txtBuscarPorNome.Text);

                    if (cadastro is null)
                    {
                        this.ExibirMensagemPesquisaSemResultados();
                    }
                    else
                    {
                        PreencherCadastros(cadastro);

                        DefinirModo(CadastroModos.Visualizar);
                    }

                    txtBuscarPorNome.Focus();
                    txtBuscarPorNome.SelectAll();
                }
                catch (Exception erro)
                {
                    this.ExibirMensagemErro(erro);
                }
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            DefinirModo(CadastroModos.Novo);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            DefinirModo(CadastroModos.Editar);
        }

        private async void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ExibirMensagemExcluirCadastroConfirmar())
                {
                    await servico.ExcluirAsync(id);

                    DefinirModo(CadastroModos.Padrao);

                    this.ExibirMensagemCadastroExcluido();
                }

                txtBuscarPorNome.Focus();
                txtBuscarPorNome.SelectAll();
            }
            catch (Exception erro)
            {
                this.ExibirMensagemErro(erro);
            }
        }

        private async void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var cadastro = new Cargo();

                PreencherCadastro(cadastro);

                if (modo == CadastroModos.Novo)
                {
                    await servico.CriarAsync(cadastro);

                    DefinirModo(CadastroModos.Padrao);

                    this.ExibirMensagemCadastroSalvo();
                }
                else
                {
                    await servico.EditarAsync(cadastro);

                    DefinirModo(CadastroModos.Visualizar);

                    this.ExibirMensagemCadastroSalvo();
                }

                txtBuscarPorNome.Focus();
                txtBuscarPorNome.SelectAll();
            }
            catch (Exception erro)
            {
                this.ExibirMensagemErro(erro);
            }
        }

        private async void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (modo == CadastroModos.Novo)
            {
                DefinirModo(CadastroModos.Padrao);
            }
            else if (modo == CadastroModos.Editar)
            {
                var cadastro = await servico.ObterPorIdAsync(id);

                if (cadastro is null)
                {
                    this.ExibirMensagemPesquisaSemResultados();
                }
                else
                {
                    PreencherTela(cadastro);

                    DefinirModo(CadastroModos.Visualizar);
                }
            }
            else if (modo == CadastroModos.Visualizar)
            {
                DefinirModo(CadastroModos.Padrao);
            }

            txtBuscarPorNome.Focus();
            txtBuscarPorNome.SelectAll();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void DgvCadastros_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvCadastros.SelectedRows.Count > 0)
                {
                    var id = (long)dgvCadastros.SelectedRows[0].Cells[0].Value;

                    var cadastro = await servico.ObterPorIdAsync(id);

                    PreencherTela(cadastro);

                    DefinirModo(CadastroModos.Visualizar);
                }
                else if (modo == CadastroModos.Visualizar)
                {
                    RedefinirCampos();
                    DefinirModo(CadastroModos.Padrao);
                }
            }
            catch (Exception erro)
            {
                this.ExibirMensagemErro(erro);
            }
        }
    }
}
