using WZSISTEMAS.Consultas;
using WZSISTEMAS.Data.Servicos.Interfaces;

namespace WZSISTEMAS.Cadastros
{
    public partial class FrmCadastroFornecedores : Form
    {
        private readonly IServicoFornecedores servico;

        private long id;
        private CadastroModos modo;

        public FrmCadastroFornecedores(IServicoFornecedores servico)
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

            txtRazaoSocial.Clear();
            txtCNPJ.Clear();
            txtInscricaoEstadual.Clear();

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

        private void PreencherCadastro(Fornecedor cadastro)
        {
            cadastro.Id = id;

            cadastro.RazaoSocial = txtRazaoSocial.Text;
            cadastro.CNPJ = txtCNPJ.Text;
            cadastro.InscricaoEstadual = txtInscricaoEstadual.Text;

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

        private void PreencherTela(Fornecedor cadastro)
        {
            id = cadastro.Id;

            txtRazaoSocial.Text = cadastro.RazaoSocial;
            txtCNPJ.Text = cadastro.CNPJ;
            txtInscricaoEstadual.Text = cadastro.InscricaoEstadual;

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

        private void FrmCadastroFornecedores_Load(object sender, EventArgs e)
        {
            DefinirModo(CadastroModos.Padrao);
        }

        private async void TxtBuscarCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return
                && !string.IsNullOrWhiteSpace(txtBuscarCNPJ.Text))
            {
                try
                {
                    var cadastro = await servico.ObterPorCNPJAsync(txtBuscarCNPJ.Text);

                    if (cadastro is null)
                    {
                        this.ExibirMensagemPesquisaSemResultados();
                    }
                    else
                    {
                        PreencherTela(cadastro);

                        DefinirModo(CadastroModos.Visualizar);
                    }

                    txtBuscarCNPJ.Focus();
                    txtBuscarCNPJ.SelectAll();
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
                using var frm = new FrmConsultaAvancadaFornecedores(servico);

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

                        txtBuscarCNPJ.Text = cadastro.CNPJ;

                        DefinirModo(CadastroModos.Visualizar);
                    }

                    txtBuscarCNPJ.Focus();
                    txtBuscarCNPJ.SelectAll();
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

                txtBuscarCNPJ.Focus();
                txtBuscarCNPJ.SelectAll();
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
                var cadastro = new Fornecedor();

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

                txtBuscarCNPJ.Focus();
                txtBuscarCNPJ.SelectAll();
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

            txtBuscarCNPJ.Focus();
            txtBuscarCNPJ.SelectAll();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
