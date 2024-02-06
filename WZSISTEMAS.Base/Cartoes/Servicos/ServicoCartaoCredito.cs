using WZSISTEMAS.Base.Cartoes.Drivers.Interfaces;
using WZSISTEMAS.Base.Cartoes.Servicos.Interfaces;

namespace WZSISTEMAS.Base.Cartoes.Servicos;

public class ServicoCartaoCredito(IDriverCartao driverCartao) : ServicoCartao(driverCartao), IServicoCartaoCredito
{
    public override void IniciarTransacao(decimal valorMonetario)
    {
        base.IniciarTransacao(valorMonetario);

        DriverCartao.Iniciar(2, valorMonetario);
    }
}
