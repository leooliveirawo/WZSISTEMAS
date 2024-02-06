namespace WZSISTEMAS.Servicos.Interfaces;
public interface IServicoLogin
{
    Credenciais CarregarCredencais();

   void SalvarCredenciais(Credenciais credenciais);

    bool VerificarConfiguracoesConexao();

    Terminal? ObterTerminalVinculado();
    bool VerificarUsuariosCadastrados();

   void ImportarDadosSAT();

    IEnumerable<Usuario> PreencherBancoDados();
    bool AutenticarToken(long id);
    bool AutenticarToken(UsuarioCredenciais credenciais);
    bool Validar(FrmLogin frmLogin, UsuarioCredenciais credenciais);

    IEnumerable<ItemLista<long>> ObterUsuariosListaItens();

   void CarregarConfiguracoesConexao();
   void DescartarAlteracoes();

}
