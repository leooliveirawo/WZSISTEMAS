using WZSISTEMAS.Base.Cartoes.Eventos;

namespace WZSISTEMAS.Base.Cartoes.Drivers.Interfaces;

public interface IDriverCartao
{
    event TransacaoCartaoEventHandler? Iniciou;
    event TransacaoCartaoEventHandler? Cancelou;
    event TransacaoCartaoEventHandler? Finalizou;

    EstadoDriverCartao Estado { get; }

   void Iniciar(int metodoPagamento, decimal valorMonetario);
   void Finalizar();
   void Cancelar();
}
