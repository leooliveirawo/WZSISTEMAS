using WZSISTEMAS.Base.Cartoes.Drivers.Interfaces;
using WZSISTEMAS.Base.Cartoes.Eventos;
using WZSISTEMAS.Base.Cartoes.Servicos.Interfaces;

namespace WZSISTEMAS.Base.Cartoes.Servicos;

public abstract class ServicoCartao : IServicoCartao
{
    protected ServicoCartao(IDriverCartao driverCartao)
    {
        DriverCartao = driverCartao ?? throw new ArgumentNullException(nameof(driverCartao));

        DriverCartao.Cancelou += DriverCartaoCancelou;
        DriverCartao.Finalizou += DriverCartaoFinalizou;
    }

    public event TransacaoCartaoEventHandler? Iniciou;
    public event TransacaoCartaoEventHandler? Cancelou;
    public event TransacaoCartaoEventHandler? Finalizou;

    protected virtual IDriverCartao DriverCartao { get; }
 
    public virtual bool FoiCancelado { get; protected set; }

    public virtual void CancelarTransacao()
        => DriverCartao.Cancelar();

    public virtual void IniciarTransacao(decimal valorMonetario)
        => FoiCancelado = false;

    protected virtual void OnIniciou(TransacaoCartaoEventArgs e)
        => Iniciou?.Invoke(this, e);

    protected virtual void OnCancelado(TransacaoCartaoEventArgs e)
        => Cancelou?.Invoke(this, e);

    protected virtual void OnConcluido(TransacaoCartaoEventArgs e)
    {
        if (!FoiCancelado)
            Finalizou?.Invoke(this, e);
    }

    private void DriverCartaoCancelou(object sender, TransacaoCartaoEventArgs e)
        => OnCancelado(e);

    private void DriverCartaoFinalizou(object sender, TransacaoCartaoEventArgs e)
        => OnConcluido(e);
}