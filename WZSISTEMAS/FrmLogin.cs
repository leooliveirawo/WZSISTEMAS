namespace WZSISTEMAS;

public partial class FrmLogin : Form
{
    private readonly IServicoLogin servicoLogin;

    public FrmLogin(IServicoLogin servicoLogin)
    {
        InitializeComponent();

        this.servicoLogin = servicoLogin ?? throw new ArgumentNullException(nameof(servicoLogin));
    }

    private void Entrar()
    {
        try
        {
            if (chbxAutenticacaoAutomatica.Checked)
                Autenticar(servicoLogin.AutenticarToken(cbbxNomeUsuario.Converter<long>()));
            else
            {
                var credenciais = new UsuarioCredenciais
                {
                    NomeUsuario = txtNomeUsuario.Text,
                    Senha = txtSenha.Text
                };

                if (servicoLogin.Validar(this, credenciais))
                    Autenticar(servicoLogin.AutenticarToken(credenciais));
            }
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
        finally
        {
            UsuarioId = 0;
            FuncionarioId = 0;
            Program.Token = null;

            Show();
        }

        void Autenticar(bool tokenValido)
        {
            if (!tokenValido)
                InformarUsuarioESenhaInvalidos();
            else
                Autenticado();
        }

       void InformarUsuarioESenhaInvalidos()
        {
            this.ExibirMensagem("O nome de usuário ou senha informados não estão corretos.", "Erro de autenticação");

            txtSenha.Clear();

            txtNomeUsuario.Selecionar();
        }

        void Autenticado()
        {
            SalvarCredenciais();
            AbrirFrm();
        }

       void AbrirFrm()
        {
            using var frm = ProvedorServicos.FrmInicio();

            Hide();

            frm.ShowDialog(this);
        }
    }

    private void SalvarCredenciais()
    {
        var credenciais = new Credenciais
        {
            NomeUsuario = txtNomeUsuario.Text,
            Senha = txtSenha.Text,
            Salva = chbxSalvarCredenciais.Checked
        };

        servicoLogin.SalvarCredenciais(credenciais);

        if (credenciais.Salva)
            DesativarCampos();
        else
        {
            AtivarCampos();

            txtSenha.Clear();
        }

       void DesativarCampos()
        {
            txtNomeUsuario.Desativar();
            txtSenha.Desativar();
            chbxMostrarSenha.Desativar();
        }

       void AtivarCampos()
        {
            txtNomeUsuario.Ativar();
            txtSenha.Ativar();
            chbxMostrarSenha.Ativar();
        }
    }

    private void ConfigurarAutenticacaoManual()
    {
        cbbxNomeUsuario.Hide();
        txtNomeUsuario.Show();
        lbSenha.Show();
        txtSenha.Show();
        chbxMostrarSenha.Show();
        chbxSalvarCredenciais.Show();

        cbbxNomeUsuario.DataSource = default;

        VerificarCredenciais();

        void VerificarCredenciais()
        {
            var credenciais = servicoLogin.CarregarCredencais();

            if (credenciais.Salva)
            {
                txtNomeUsuario.Text = credenciais.NomeUsuario;
                txtSenha.Text = credenciais.Senha;

                txtNomeUsuario.Desativar();
                txtSenha.Desativar();
                chbxMostrarSenha.Desativar();

                chbxSalvarCredenciais.Checked = true;
            }
            else
            {
                txtNomeUsuario.Clear();
                txtSenha.Clear();
                btnEntrar.Desativar();
                chbxSalvarCredenciais.Desativar();
            }
        }
    }

    private void AtivarEventos()
    {
        txtNomeUsuario.KeyPress += TxtNomeUsuario_KeyPress;
        txtNomeUsuario.TextChanged += TxtNomeUsuario_TextChanged;

        txtSenha.KeyPress += TxtSenha_KeyPress;
        txtSenha.TextChanged += TxtSenha_TextChanged;

        chbxSalvarCredenciais.CheckedChanged += ChbxSalvarCredenciais_CheckedChanged;
    }

    private void FrmLogin_Load(object sender, EventArgs e)
    {
        try
        {
            VerificarConfiguracoesConexao();
            VerificarSAT();
            VerificarTerminal();
            VerificarUsuarios();
            ConfigurarAutenticacaoManual();

            chbxAutenticacaoAutomatica.Visible = EmDesenvolvimento;
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
        finally
        {
            AtivarEventos();

            if (!chbxAutenticacaoAutomatica.Checked)
                txtNomeUsuario.Selecionar();
            else
                cbbxNomeUsuario.Selecionar();
        }

        void VerificarConfiguracoesConexao()
        {
            if (!servicoLogin.VerificarConfiguracoesConexao())
            {
                this.ExibirMensagemErro("As configurações de conexão com o banco de dados não foram realizadas.");

                Close();
            }
        }
        
        void VerificarTerminal()
        {
            var terminal = servicoLogin.ObterTerminalVinculado();

            if (terminal is not null)
                TerminalId = terminal.Id;
        }

        void VerificarUsuarios()
        {
            while (true)
            {
                if (!servicoLogin.VerificarUsuariosCadastrados())
                {
                    if (this.ExibirMensagemSimNao("O usuário não foi cadastrado. \n\nDeseja cadastrar?", "Sem usuarios"))
                    {
                        using var frm = ProvedorServicos.FrmCadastroFuncionarios();

                        frm.ShowDialog(this);
                    }
                    else
                    {
                        this.ExibirMensagemErro("Não será possivel abrir o sistema pois não existem usuários cadastrados.");

                        Close();

                        return;
                    }
                }
                else
                    break;
            }
        }

        void VerificarSAT()
            => servicoLogin.ImportarDadosSAT();
    }

    private void ChbxMostrarSenha_CheckedChanged(object? sender, EventArgs e)
        => txtSenha.UseSystemPasswordChar = !chbxMostrarSenha.Checked;

    private void BtnEntrar_Click(object? sender, EventArgs e)
        => Entrar();

    private void TxtNomeUsuario_TextChanged(object? sender, EventArgs e)
        => txtSenha.Clear();

    private void TxtNomeUsuario_KeyPress(object? sender, KeyPressEventArgs e)
    {
        if (e.VerificarTeclaEnter())
        {
            txtSenha.Selecionar();
            txtSenha.Clear();
        }
    }

    private void TxtSenha_TextChanged(object? sender, EventArgs e)
    {
        if (chbxSalvarCredenciais.Checked)
            chbxSalvarCredenciais.Desmarcar();

        btnEntrar.Enabled = !string.IsNullOrEmpty(txtSenha.Text);
        chbxSalvarCredenciais.Enabled = btnEntrar.Enabled;
    }

    private void TxtSenha_KeyPress(object? sender, KeyPressEventArgs e)
    {
        if (e.VerificarTeclaEnter())
            Entrar();
    }

    private void ChbxSalvarCredenciais_CheckedChanged(object? sender, EventArgs e)
    {
        try
        {
            SalvarCredenciais();
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void CbbxNomeUsuario_SelectedIndexChanged(object sender, EventArgs e)
        => btnEntrar.Enabled = cbbxNomeUsuario.SelectedValue is not null;

    private void ChbxAutenticacaoAutomatica_CheckedChanged(object sender, EventArgs e)
    {
        try
        {
            DesativarEventos();

            if (chbxAutenticacaoAutomatica.Checked)
                ConfigurarAutenticacaoAutomatica();
            else
                ConfigurarAutenticacaoManual();
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);

            servicoLogin.DescartarAlteracoes();
        }
        finally
        {
            AtivarEventos();

            if (!chbxAutenticacaoAutomatica.Checked)
                txtNomeUsuario.Selecionar();
            else
                cbbxNomeUsuario.Selecionar();
        }

        void ConfigurarAutenticacaoAutomatica()
        {
            cbbxNomeUsuario.Show();
            txtNomeUsuario.Hide();
            lbSenha.Hide();
            txtSenha.Hide();
            chbxMostrarSenha.Hide();
            chbxSalvarCredenciais.Hide();

            txtNomeUsuario.Clear();

            txtSenha.Clear();
            chbxMostrarSenha.Desmarcar();

            cbbxNomeUsuario.Configurar(
                servicoLogin.ObterUsuariosListaItens());
        }

       void DesativarEventos()
        {
            txtNomeUsuario.KeyPress -= TxtNomeUsuario_KeyPress;
            txtNomeUsuario.TextChanged -= TxtNomeUsuario_TextChanged;

            txtSenha.KeyPress -= TxtSenha_KeyPress;
            txtSenha.TextChanged -= TxtSenha_TextChanged;

            chbxSalvarCredenciais.CheckedChanged -= ChbxSalvarCredenciais_CheckedChanged;
        }

    }
}
