namespace WZSISTEMAS.Base.Cartoes.Drivers;

public abstract class DriverCartao : IDriverCartao
{
    public event TransacaoCartaoEventHandler? Iniciou;
    public event TransacaoCartaoEventHandler? Comunicou;
    public event TransacaoCartaoEventHandler? Cancelou;
    public event TransacaoCartaoEventHandler? Finalizou;

    public EstadoDriverCartao Estado { get; protected set; } = EstadoDriverCartao.OperacaoNaoIniciada;
    protected virtual int MetodoPagamento { get; set; }
    protected virtual decimal ValorPago { get; set; }

    public abstract void Cancelar();

    public abstract void Finalizar();

    public abstract void Iniciar(
        int metodoPagamento,
        decimal valorMonetario);

    protected virtual void OnComunicou(TransacaoCartaoEventArgs e)
        => Comunicou?.Invoke(this, e);

    protected virtual void OnIniciou(TransacaoCartaoEventArgs e)
    {
        Estado = EstadoDriverCartao.OperacaoIniciada;
        MetodoPagamento = e.Transacao.MetodoPagamento;
        ValorPago = e.Transacao.ValorPago;

        Iniciou?.Invoke(this, e);
    }

    protected virtual void OnCancelou(TransacaoCartaoEventArgs e)
    {
        Estado = EstadoDriverCartao.OperacaoCancelada;
        ValorPago = 0;
        MetodoPagamento = 0;

        Cancelou?.Invoke(this, e);
    }

    protected virtual void OnFinalizou(TransacaoCartaoEventArgs e)
    {
        Estado = e.Transacao.Aprovado
            ? EstadoDriverCartao.OperacaoConcluidaComSucesso
            : EstadoDriverCartao.OperacaoConcluidaComErros;

        ValorPago = 0;
        MetodoPagamento = 0;

        Finalizou?.Invoke(this, e);
    }
}