using WZSISTEMAS.Base.Valores;

namespace WZSISTEMAS.Base.Servicos.Interfaces;

public interface IServicoCredenciais
{
    Credenciais Carregar();
   void Salvar(Credenciais credenciais);
}