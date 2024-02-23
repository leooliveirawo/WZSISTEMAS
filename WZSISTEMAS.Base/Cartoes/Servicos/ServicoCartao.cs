using WZSISTEMAS.Base.Cartoes.Servicos.Interfaces;

namespace WZSISTEMAS.Base.Cartoes.Servicos;

public abstract class ServicoCartao : IServicoCartao
{
    protected ServicoCartao(IDriverCartao driverCartao)
    {
        DriverCartao = driverCartao ?? throw new ArgumentNullException(nameof(driverCartao));

        DriverCartao.Comunicou += DriverCartao_Comunicou;
        DriverCartao.Cancelou += DriverCartao_Cancelou;
        DriverCartao.Finalizou += DriverCartao_Finalizou;
    }

    private void DriverCartao_Comunicou(object sender, TransacaoCartaoEventArgs e)
        => OnComunicou(e);

    public event TransacaoCartaoEventHandler? Iniciou;
    public event TransacaoCartaoEventHandler? Comunicou;
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

    protected virtual void OnComunicou(TransacaoCartaoEventArgs e)
        => Comunicou?.Invoke(this, e);
    private void DriverCartao_Cancelou(object sender, TransacaoCartaoEventArgs e)
        => OnCancelado(e);

    private void DriverCartao_Finalizou(object sender, TransacaoCartaoEventArgs e)
        => OnConcluido(e);
}