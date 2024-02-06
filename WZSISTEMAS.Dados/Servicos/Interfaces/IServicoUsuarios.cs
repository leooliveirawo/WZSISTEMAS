namespace WZSISTEMAS.Dados.Servicos.Interfaces;

public interface IServicoUsuarios : IServicoEntidades<Usuario>, IServicoValidacaoEntidades<Usuario>, IServicoValidacao<UsuarioCredenciais>
{
    Usuario? ObterPorFuncionarioId(long funcionarioId, bool usarTracking = false);
   void Criar(Usuario entidade, string senha);
   void Editar(Usuario entidade, string senhaAtual);
   void Editar(Usuario entidade, string senhaAtual, string novaSenha);

    Usuario? Autenticar(UsuarioCredenciais credenciais);
    Usuario? ObterPorNomeUsuario(string nomeUsuario);
    bool VerificarNomeUsuarioUsada(string nomeUsuario);

    ResultadoToken AutenticarToken(UsuarioCredenciais credenciais);
    ResultadoToken AutenticarToken(long id);
    ResultadoToken ValidarToken(string token);
    ResultadoToken Desautenticar(string token);
    ResultadoToken<Usuario> ObterUsuarioPorToken(string token);
}