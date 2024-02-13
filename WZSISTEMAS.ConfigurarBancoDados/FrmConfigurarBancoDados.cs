using WZSISTEMAS.Base.EF.Servicos.Interfaces;
using WZSISTEMAS.Base.EF.Valores;
using WZSISTEMAS.WinForms.Helpers;

namespace WZSISTEMAS.ConfigurarBancoDados;

public partial class FrmConfigurarBancoDados : Form
{
    private readonly IServicoConexao servicoConexao;

    public FrmConfigurarBancoDados(IServicoConexao servicoConexao)
    {
        InitializeComponent();

        this.servicoConexao = servicoConexao ?? throw new ArgumentNullException(nameof(servicoConexao));
    }

    private void FrmConfigurarBancoDados_Load(object sender, EventArgs e)
    {
        try
        {
            Hide();

            var configuracoesConexao = servicoConexao.Carregar();

            if (configuracoesConexao is not null)
            {
                Carregar(configuracoesConexao);
            }

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

    private void Carregar(ConfiguracoesConexao configuracoesConexao)
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

    private void BtnSalvar_Click(object sender, EventArgs e)
    {
        try
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

            servicoConexao.Salvar(configuracoesConexao);

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
            Carregar(
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
}
