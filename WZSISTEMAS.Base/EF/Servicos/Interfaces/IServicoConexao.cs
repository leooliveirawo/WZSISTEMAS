namespace WZSISTEMAS.Base.EF.Servicos.Interfaces;

public interface IServicoConexao
{
    ConfiguracoesConexao? Carregar();
   void Salvar(ConfiguracoesConexao configuracoesConexao);
    bool Verificar();
}
