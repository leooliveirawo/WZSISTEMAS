namespace WZSISTEMAS.ConfigurarBancoDados;

public partial class FrmConfigurarBancoDados : Form
{
    private readonly IServicoConexao servicoConexao;

    public FrmConfigurarBancoDados(IServicoConexao servicoConexao)
    {
        InitializeComponent();

        this.servicoConexao = servicoConexao 
                              ?? throw new ArgumentNullException(nameof(servicoConexao));
    }

    private ConfiguracoesConexao CriarConfiguracoesConexao()
    {
        var configuracoesConexao = new ConfiguracoesConexao();

        configuracoesConexao.TipoConexao =
            rbtnAutenticacaoWindows.Checked
                ? TipoConexao.AutenticacaoWindows
                : TipoConexao.AutenticacaoSQL;

        if (configuracoesConexao.TipoConexao == configuracoesConexao.TipoConexao)
        {
            configuracoesConexao.NomeUsuario = txtNomeUsuario.Text;
            configuracoesConexao.Senha = txtSenha.Text;
        }

        configuracoesConexao.ModoConexao = rbtnModoSomenteLeitura.Checked
            ? ModoConexao.SomenteLeitura
            : ModoConexao.LeituraEEscrita;

        configuracoesConexao.Criptografado = chbxUsarCriptografia.Checked;
        configuracoesConexao.PossuiCertificado = chbxPossuiCertificado.Checked;

        configuracoesConexao.Servidor = txtServidor.Text;
        configuracoesConexao.BancoDados = txtBancoDados.Text;

        return configuracoesConexao;
    }

    private void PreencherTela(ConfiguracoesConexao configuracoesConexao)
    {
        if (configuracoesConexao.TipoConexao == TipoConexao.AutenticacaoWindows)
            rbtnAutenticacaoWindows.Marcar();
        else
            rbtnAutenticacaoSQLServer.Marcar();

        txtNomeUsuario.Text = configuracoesConexao.NomeUsuario;
        txtSenha.Text = configuracoesConexao.Senha;

        if (configuracoesConexao.ModoConexao == ModoConexao.SomenteLeitura)
            rbtnModoSomenteLeitura.Marcar();
        else
            rbtnModoLeituraEEscrita.Marcar();

        chbxPossuiCertificado.Checked = configuracoesConexao.PossuiCertificado;

        chbxUsarCriptografia.Checked = configuracoesConexao.Criptografado;

        txtServidor.Text = configuracoesConexao.Servidor;
        txtBancoDados.Text = configuracoesConexao.BancoDados;
    }

    private void FrmConfigurarBancoDados_Load(object sender, EventArgs e)
    {
        try
        {
            Hide();

            var configuracoesConexao = servicoConexao.Carregar();

            if (configuracoesConexao is not null)
                PreencherTela(configuracoesConexao);

            Show();
        }
        catch (FormatException)
        {
            this.ExibirMensagemErro("Os dados de conex�o salvos n�o s�o v�lidos.");
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void BtnSalvar_Click(object sender, EventArgs e)
    {
        try
        {
            servicoConexao.Salvar(
                CriarConfiguracoesConexao());

            this.ExibirMensagemOperacaoConcluida("As altera��es foram salvas com sucesso.");
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }

    }

    private void BtnImportar_Click(object sender, EventArgs e)
    {
        try
        {
            PreencherTela(
                ConfiguracoesConexao.Criar(
                    Clipboard.GetText()));
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void RbtnAutenticacaoWindows_CheckedChanged(object sender, EventArgs e)
    {
        txtNomeUsuario.Enabled = !rbtnAutenticacaoWindows.Checked;
        txtSenha.Enabled = txtNomeUsuario.Enabled;

        txtNomeUsuario.Clear();
        txtSenha.Clear();
    }

    private void btnTestarConexao_Click(object sender, EventArgs e)
    {
        try
        {
            var configuracoesConexao = CriarConfiguracoesConexao();

            if (servicoConexao.TestarConexao(configuracoesConexao))
                this.ExibirMensagemOperacaoConcluida("A conex�o com o banco de dados foi estabelecida com sucesso.");
            else
                this.ExibirMensagemErro(
                    $"N�o foi poss�vel estabelecer a conex�o com o banco de dados.{Environment.NewLine}{Environment.NewLine}Por favor verifique os dados de conex�o.", "Conex�o n�o estabelecida");

            btnTestarConexao.Selecionar();
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }
}
