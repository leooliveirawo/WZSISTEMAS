namespace WZSISTEMAS.Base.EF.Services.Interfaces;

public interface IServicoConexao
{
    ConfiguracoesConexao? Carregar();
   void Salvar(ConfiguracoesConexao configuracoesConexao);
    bool Verificar();
}
