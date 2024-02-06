using WZSISTEMAS.Base.Cartoes.Drivers.Interfaces;
using WZSISTEMAS.Base.Cartoes.Servicos.Interfaces;

namespace WZSISTEMAS.Base.Cartoes.Servicos;

public class ServicoCartaoLoja(
    IDriverCartao driverCartao) : ServicoCartao(driverCartao), IServicoCartaoLoja
{
    public override void IniciarTransacao(decimal valorMonetario)
    {
        base.IniciarTransacao(valorMonetario);

        DriverCartao.Iniciar(4, valorMonetario);
    }
}
