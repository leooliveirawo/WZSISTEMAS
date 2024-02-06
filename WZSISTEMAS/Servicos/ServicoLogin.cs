using WZSISTEMAS.Base.EF.Valores;

namespace WZSISTEMAS.Servicos;

public class ServicoLogin(
    IServicoCredenciais servicoCredenciais,
    IServicoConexao servicoConexao,
    IServicoTerminais servicoTerminais,
    IServicoUsuarios servicoUsuarios,
    IServicoSAT servicoSAT,
    IServicoDesenvolvedor desenvolvedor) : IServicoLogin
{
    private readonly IServicoCredenciais servicoCredenciais =
        servicoCredenciais ?? throw new ArgumentNullException(nameof(servicoCredenciais));

    private readonly IServicoConexao servicoConexao =
        servicoConexao ?? throw new ArgumentNullException(nameof(servicoConexao));

    private readonly IServicoTerminais servicoTerminais =
        servicoTerminais ?? throw new ArgumentNullException(nameof(servicoTerminais));

    private readonly IServicoUsuarios servicoUsuarios =
        servicoUsuarios ?? throw new ArgumentNullException(nameof(servicoUsuarios));

    private readonly IServicoSAT servicoSAT =
        servicoSAT ?? throw new ArgumentNullException(nameof(servicoSAT));

    private readonly IServicoDesenvolvedor servicoDesenvolvedor =
        desenvolvedor ?? throw new ArgumentNullException(nameof(desenvolvedor));
    public virtual Credenciais CarregarCredencais()
        => servicoCredenciais.Carregar();

    public virtual void SalvarCredenciais(Credenciais credenciais)
    {
        if (!credenciais.Salva)
        {
            credenciais.NomeUsuario = default;
            credenciais.Senha = default;
        }

        servicoCredenciais.Salvar(credenciais);
    }

    public virtual bool VerificarConfiguracoesConexao()
        => servicoConexao.Verificar();

    public virtual Terminal? ObterTerminalVinculado()
        => servicoTerminais.ObterTerminalVinculado();

    public virtual bool VerificarUsuariosCadastrados()
    {
        if (EmDesenvolvimento)
            return true;

        return servicoUsuarios.Contem();
    }

    public virtual void ImportarDadosSAT()
        => servicoSAT.ImportarDadosSAT();

    public virtual IEnumerable<Usuario> PreencherBancoDados()
    {
        servicoDesenvolvedor.PreencherBancoDados();

        return servicoUsuarios.ObterLista();
    }

    public virtual bool AutenticarToken(long id)
    {
        var resultadoToken = servicoUsuarios.AutenticarToken(id);

        if (resultadoToken is null)
            return false;

        var usuario = servicoUsuarios.ObterPorId(id) ??
                      throw new InvalidOperationException("O usuário não foi encontrado");

        Program.Token = resultadoToken.Token;
        UsuarioId = usuario.Id;
        FuncionarioId = usuario.FuncionarioId;

        return true;
    }
    public virtual bool AutenticarToken(UsuarioCredenciais credenciais)
    {
        var resultadoToken = servicoUsuarios.AutenticarToken(credenciais);

        if (resultadoToken is null)
            return false;

        var usuario = servicoUsuarios.ObterPorNomeUsuario(credenciais.NomeUsuario) ??
                      throw new InvalidOperationException("O usuário não foi encontrado");

        Program.Token = resultadoToken.Token;
        UsuarioId = usuario.Id;
        FuncionarioId = usuario.FuncionarioId;

        return true;
    }

    public virtual bool Validar(FrmLogin frmLogin, UsuarioCredenciais credenciais)
        => frmLogin.Validar(servicoUsuarios, credenciais);

    public virtual IEnumerable<ItemLista<long>> ObterUsuariosListaItens()
        => servicoUsuarios.ObterListaItens();

    public virtual void CarregarConfiguracoesConexao()
    {
        var configuracoesConexao = servicoConexao.Carregar();

        if (configuracoesConexao is not null)
        {
            ConfiguracoesConexao.ConnectionString = configuracoesConexao.Converter();
        }
    }

    public void DescartarAlteracoes()
        => servicoUsuarios.DescartarAlteracoes();
}
