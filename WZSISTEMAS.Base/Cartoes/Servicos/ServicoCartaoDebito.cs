using WZSISTEMAS.Base.Cartoes.Servicos.Interfaces;

namespace WZSISTEMAS.Base.Cartoes.Servicos;

public class ServicoCartaoDebito(IDriverCartao driverCartao) : ServicoCartao(driverCartao), IServicoCartaoDebito
{
    public override void IniciarTransacao(decimal valorMonetario)
    {
        base.IniciarTransacao(valorMonetario);

        DriverCartao.Iniciar(1, valorMonetario);
    }
}
