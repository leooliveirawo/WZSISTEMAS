using WZSISTEMAS.Consultas;
using WZSISTEMAS.Data.Servicos.Interfaces;

namespace WZSISTEMAS.Cadastros
{
    public partial class FrmCadastroClientes : Form
    {
        private readonly IServicoClientes servico;

        private long id;

        private CadastroModos modo;

        public FrmCadastroClientes(IServicoClientes servico)
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
            gbxBusca.Enabled = habilitar;
        }

        private void DefinirCampos(bool habilitar)
        {
            gbxDados.Enabled = habilitar;
        }

        private void RedefinirCampos()
        {
            id = 0;

            cbbxTipo.SelectedIndex = 0;

            txtNomeCompleto_RazaoSocial.Clear();
            txtCPF_CNPJ.Clear();
            txtRG_InscricaoEstadual.Clear();
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

        private void PreencherCadastro(Cliente cadastro)
        {
            cadastro.Id = id;

            cadastro.Tipo = (Cliente.Tipos)cbbxTipo.SelectedIndex;

            cadastro.NomeCompleto_RazaoSocial = txtNomeCompleto_RazaoSocial.Text;
            cadastro.CPF_CNPJ = txtCPF_CNPJ.Text;
            cadastro.RG_InscricaoEstadual = txtRG_InscricaoEstadual.ObterStringNula();

            cadastro.DataNascimento = dtpDataNascimento.ObterDateTimeNulo(true, chbxNaoInformarDataNascimento.Checked);

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

        private void PreencherTela(Cliente cadastro)
        {
            id = cadastro.Id;

            cbbxTipo.SelectedIndex = (int)cadastro.Tipo;
            txtNomeCompleto_RazaoSocial.Text = cadastro.NomeCompleto_RazaoSocial;
            txtCPF_CNPJ.Text = cadastro.CPF_CNPJ;
            txtRG_InscricaoEstadual.Text = cadastro.RG_InscricaoEstadual;

            if (cadastro.DataNascimento.HasValue)
            {
                chbxNaoInformarDataNascimento.Enabled = true;
                chbxNaoInformarDataNascimento.Checked = false;

                dtpDataNascimento.Value = cadastro.DataNascimento.Value.ToLocalTime();
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

        private void FrmCadastroClientes_Load(object sender, EventArgs e)
        {
            DefinirModo(CadastroModos.Padrao);
        }

        private async void TxtBuscarCPF_CNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return
                && !string.IsNullOrWhiteSpace(txtBuscarCPF_CNPJ.Text))
            {
                try
                {
                    var cadastro = await servico.ObterPorCPF_CNPJAsync(txtBuscarCPF_CNPJ.Text);

                    if (cadastro is null)
                    {
                        this.ExibirMensagemPesquisaSemResultados();
                    }
                    else
                    {
                        PreencherTela(cadastro);

                        DefinirModo(CadastroModos.Visualizar);
                    }

                    txtBuscarCPF_CNPJ.Focus();
                    txtBuscarCPF_CNPJ.SelectAll();
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
                using var frm = new FrmConsultaAvancadaClientes(servico);

                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    var cadastro = await servico.ObterPorIdAsync(frm.Id);

                    if (cadastro is null)
                    {
                        this.ExibirMensagemPesquisaSemResultados();
                    }
                    else
                    {
                        PreencherTela(cadastro);

                        txtBuscarCPF_CNPJ.Text = cadastro.CPF_CNPJ;

                        DefinirModo(CadastroModos.Visualizar);
                    }

                    txtBuscarCPF_CNPJ.Focus();
                    txtBuscarCPF_CNPJ.SelectAll();
                }
            }
            catch (Exception erro)
            {
                this.ExibirMensagemErro(erro);
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

                txtBuscarCPF_CNPJ.Focus();
                txtBuscarCPF_CNPJ.SelectAll();
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
                var cadastro = new Cliente();

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

                txtBuscarCPF_CNPJ.Focus();
                txtBuscarCPF_CNPJ.SelectAll();
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

            txtBuscarCPF_CNPJ.Focus();
            txtBuscarCPF_CNPJ.SelectAll();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChbxNaoInformarDataNascimento_CheckedChanged(object sender, EventArgs e)
        {
            dtpDataNascimento.Value = DateTime.Now;
            dtpDataNascimento.Enabled = !chbxNaoInformarDataNascimento.Checked;
        }

        private void CbbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbxTipo.SelectedIndex == 1)
            {
                dtpDataNascimento.Enabled = false;

                chbxNaoInformarDataNascimento.Checked = false;
                chbxNaoInformarDataNascimento.Enabled = false;
            }
            else
            {
                dtpDataNascimento.Enabled = true;
                chbxNaoInformarDataNascimento.Enabled = true;
            }
        }
    }
}
