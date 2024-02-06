using WZSISTEMAS.Base.Cartoes.Drivers.Interfaces;
using WZSISTEMAS.Base.Cartoes.Servicos.Interfaces;

namespace WZSISTEMAS.Base.Cartoes.Servicos;

public class ServicoCartaoVoucher(IDriverCartao driverCartao) : ServicoCartao(driverCartao), IServicoCartaoVoucher
{
    public override void IniciarTransacao(decimal valorMonetario)
    {
        base.IniciarTransacao(valorMonetario);

        DriverCartao.Iniciar(3, valorMonetario);
    }
}
