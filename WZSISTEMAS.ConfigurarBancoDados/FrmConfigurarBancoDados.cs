using WZSISTEMAS.Dados.Servicos.Interfaces;

namespace WZSISTEMAS.ConfigurarBancoDados;

public partial class FrmConfigurarBancoDados : Form
{
    private readonly IServicoConexao servicoConexao;
    private readonly IServicoDesenvolvedor servicoDesenvolvedor;

    public FrmConfigurarBancoDados(
        IServicoConexao servicoConexao,
        IServicoDesenvolvedor servicoDesenvolvedor)
    {
        InitializeComponent();

        this.servicoConexao = servicoConexao
                              ?? throw new ArgumentNullException(nameof(servicoConexao));
        this.servicoDesenvolvedor = servicoDesenvolvedor
                                    ?? throw new ArgumentNullException(nameof(servicoDesenvolvedor));
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

            if (!EmDesenvolvimento)
                btnPrepararBancoDados.Hide();

            Show();
        }
        catch (FormatException)
        {
            this.ExibirMensagemErro("Os dados de conexão salvos não são válidos.");
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

            this.ExibirMensagemOperacaoConcluida("As alterações foram salvas com sucesso.");
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
                this.ExibirMensagemOperacaoConcluida("A conexão com o banco de dados foi estabelecida com sucesso.");
            else
                this.ExibirMensagemErro(
                    $"Não foi possível estabelecer a conexão com o banco de dados.{Environment.NewLine}{Environment.NewLine}Por favor verifique os dados de conexão.", "Conexão não estabelecida");

            btnTestarConexao.Selecionar();
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }

    private void btnPrepararBancoDados_Click(object sender, EventArgs e)
    {
        try
        {

            if (this.ExibirMensagemSimNao($"Deseja preencher o banco de dados com dados de teste?{Environment.NewLine}{Environment.NewLine}Essa ação não poderá ser desfeita."))
            {
                try
                {
                    servicoDesenvolvedor.PreencherBancoDados();

                    this.ExibirMensagemOperacaoConcluida("O preenchimento de dados de teste no banco de dados foi concluído com sucesso.");
                }
                catch (Exception erro)
                {
                    this.ExibirMensagemErro(erro);
                }
            }
        }
        catch (Exception erro)
        {
            this.ExibirMensagemErro(erro);
        }
    }
}
