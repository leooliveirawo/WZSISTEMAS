using WZSISTEMAS.Base.Cartoes.Eventos;

namespace WZSISTEMAS.Base.Cartoes.Drivers.Interfaces;
public interface IDriverCartaoVirtual : IDriverCartao
{
   void Aprovado();
   void NaoAprovado();
}
