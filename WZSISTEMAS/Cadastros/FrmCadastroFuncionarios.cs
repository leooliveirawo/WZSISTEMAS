using WZSISTEMAS.Consultas;
using WZSISTEMAS.Data.Servicos.Interfaces;

namespace WZSISTEMAS.Cadastros
{
    public partial class FrmCadastroFuncionarios : Form
    {
        private readonly IServicoFuncionarios servico;
        private readonly IServicoCargos servicoCargos;

        private long id;

        private CadastroModos modo;

        public FrmCadastroFuncionarios(IServicoFuncionarios servico, IServicoCargos servicoCargos)
        {
            InitializeComponent();

            this.servico = servico ?? throw new ArgumentNullException(nameof(servico));
            this.servicoCargos = servicoCargos ?? throw new ArgumentNullException(nameof(servicoCargos));
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
            gbxBusca.Enabled = habilitar;
        }

        private void DefinirCampos(bool habilitar)
        {
            gbxDados.Enabled = habilitar;
        }

        private void RedefinirCampos()
        {
            id = 0;

            cbbxCargo.DataSource = default;

            txtNomeCompleto.Clear();
            txtCPF.Clear();
            txtRG.Clear();
            dtpDataNascimento.Clear(DateTime.Now);
            chbxNaoInformarDataNascimento.Clear();

            txtLogradouro.Clear();
            txtLogradouroNumero.Clear();
            txtComplemento.Clear();
            txtReferencia.Clear();
            txtCEP.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstadoUF.Clear();

            txtTelefone1.Clear();
            txtTelefone2.Clear();
            txtTelefone3.Clear();

            txtEmail.Clear();
        }

        private void PreencherCadastro(Funcionario cadastro)
        {
            if (cbbxCargo.SelectedValue is null)
                throw new InvalidOperationException("O cargo não foi informaado");

            cadastro.Id = id;

            cadastro.CargoId = (long)cbbxCargo.SelectedValue;

            cadastro.NomeCompleto = txtNomeCompleto.Text;
            cadastro.CPF = txtCPF.Text;
            cadastro.RG = txtRG.ObterStringNula();

            cadastro.DataNascimento = dtpDataNascimento.ObterDateTimeSoDataNulo(chbxNaoInformarDataNascimento.Checked);

            cadastro.Logradouro = txtLogradouro.Text;
            cadastro.LogradourNumero = txtLogradouroNumero.ObterStringNula();
            cadastro.Complemento = txtComplemento.ObterStringNula();
            cadastro.Referencia = txtReferencia.ObterStringNula();

            cadastro.CEP = txtCEP.Text;
            cadastro.Bairro = txtBairro.Text;
            cadastro.Cidade = txtCidade.Text;
            cadastro.Estado_UF = txtEstadoUF.Text;

            cadastro.Telefone1 = txtTelefone1.Text;
            cadastro.Telefone2 = txtTelefone2.Text;
            cadastro.Telefone3 = txtTelefone3.Text;

            cadastro.Email = txtEmail.Text;
        }

        private async Task PreencherTela(Funcionario cadastro)
        {
            await PreencherCargos();

            id = cadastro.Id;

            txtNomeCompleto.Text = cadastro.NomeCompleto;
            txtCPF.Text = cadastro.CPF;
            txtRG.Text = cadastro.RG;

            cbbxCargo.SelectedValue = cadastro.CargoId;

            if (cadastro.DataNascimento.HasValue)
            {
                chbxNaoInformarDataNascimento.Enabled = true;
                chbxNaoInformarDataNascimento.Checked = false;

                dtpDataNascimento.Value = cadastro.DataNascimento.Value;
            }
            else
            {
                chbxNaoInformarDataNascimento.Enabled = false;
                chbxNaoInformarDataNascimento.Checked = false;
            }

            txtLogradouro.Text = cadastro.Logradouro;
            txtLogradouroNumero.Text = cadastro.LogradourNumero;
            txtComplemento.Text = cadastro.Complemento;
            txtReferencia.Text = cadastro.Referencia;
            txtCEP.Text = cadastro.CEP;
            txtBairro.Text = cadastro.Bairro;
            txtCidade.Text = cadastro.Cidade;
            txtEstadoUF.Text = cadastro.Estado_UF;

            txtTelefone1.Text = cadastro.Telefone1;
            txtTelefone2.Text = cadastro.Telefone2;
            txtTelefone3.Text = cadastro.Telefone3;

            txtEmail.Text = cadastro.Email;
        }

        private async Task PreencherCargos()
        {
            cbbxCargo.ValueMember = nameof(Cargo.Id);
            cbbxCargo.DisplayMember = nameof(Cargo.Nome);
            cbbxCargo.DataSource = await servicoCargos.ListarAsync();
        }

        private void FrmCadastroClientes_Load(object sender, EventArgs e)
        {
            DefinirModo(CadastroModos.Padrao);
        }

        private async void TxtBuscarCPF_CNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return
                && !string.IsNullOrWhiteSpace(txtBuscarCPF.Text))
            {
                try
                {
                    var cadastro = await servico.ObterPorCPFAsync(txtBuscarCPF.Text);

                    if (cadastro is null)
                    {
                        this.ExibirMensagemPesquisaSemResultados();
                    }
                    else
                    {
                        await PreencherTela(cadastro);

                        DefinirModo(CadastroModos.Visualizar);
                    }

                    txtBuscarCPF.Focus();
                    txtBuscarCPF.SelectAll();
                }
                catch (Exception erro)
                {
                    this.ExibirMensagemErro(erro);
                }
            }
        }

        private void FrmCadastroFuncionarios_Load(object sender, EventArgs e)
        {
            DefinirModo(CadastroModos.Padrao);
        }

        private async void TxtBuscarCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return
                && !string.IsNullOrWhiteSpace(txtBuscarCPF.Text))
            {
                try
                {
                    var cadastro = await servico.ObterPorCPFAsync(txtBuscarCPF.Text);

                    if (cadastro is null)
                    {
                        this.ExibirMensagemPesquisaSemResultados();
                    }
                    else
                    {
                        await PreencherTela(cadastro);

                        DefinirModo(CadastroModos.Visualizar);
                    }

                    txtBuscarCPF.Focus();
                    txtBuscarCPF.SelectAll();
                }
                catch (Exception erro)
                {
                    this.ExibirMensagemErro(erro);
                }
            }
        }

        private async void BtnBuscarConsultaAvancada_Click(object sender, EventArgs e)
        {
            try
            {
                using var frm = new FrmConsultaAvancadaFuncionarios(servico);

                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    var cadastro = await servico.ObterPorIdAsync(frm.Id);

                    if (cadastro is null)
                    {
                        this.ExibirMensagemPesquisaSemResultados();
                    }
                    else
                    {
                        await PreencherTela(cadastro);

                        txtBuscarCPF.Text = cadastro.CPF;

                        DefinirModo(CadastroModos.Visualizar);
                    }

                    txtBuscarCPF.Focus();
                    txtBuscarCPF.SelectAll();
                }
            }
            catch (Exception erro)
            {
                this.ExibirMensagemErro(erro);
            }
        }

        private async void BtnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                await PreencherCargos();

                DefinirModo(CadastroModos.Novo);
            }
            catch (Exception erro)
            {
                this.ExibirMensagemErro(erro);
            }
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

                txtBuscarCPF.Focus();
                txtBuscarCPF.SelectAll();
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
                var cadastro = new Funcionario();

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

                txtBuscarCPF.Focus();
                txtBuscarCPF.SelectAll();
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
                    await PreencherTela(cadastro);

                    DefinirModo(CadastroModos.Visualizar);
                }
            }
            else if (modo == CadastroModos.Visualizar)
            {
                DefinirModo(CadastroModos.Padrao);
            }

            txtBuscarCPF.Focus();
            txtBuscarCPF.SelectAll();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
