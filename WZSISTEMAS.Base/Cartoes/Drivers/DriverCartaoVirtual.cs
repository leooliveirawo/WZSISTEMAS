namespace WZSISTEMAS.Base.Cartoes.Drivers;

public class DriverCartaoVirtual : DriverCartao, IDriverCartaoVirtual
{
    public virtual void Aprovado()
        => Finalizar();

    public override void Cancelar()
    {
        if (Estado != EstadoDriverCartao.OperacaoIniciada)
            throw new InvalidOperationException("Nenhuma transação foi realizada");

        OnCancelou(
            new(
                DateTime.Now,
                new()
                {
                    Aprovado = false,
                    Cancelado = true,
                    MensagemRetorno = "CANCELAMENTO MANUAL",
                    MetodoPagamento = MetodoPagamento,
                    ValorPago = ValorPago
                }));
    }

    public override void Finalizar()
    {
        if (Estado != EstadoDriverCartao.OperacaoIniciada)
            throw new InvalidOperationException("Nenhuma transação foi realizada");

        OnFinalizou(
            new(
                DateTime.Now,
                new()
                {
                    Aprovado = true,
                    Cancelado = false,
                    MensagemRetorno = "APROVADO",
                    MetodoPagamento = MetodoPagamento,
                    ValorPago = ValorPago
                }));
    }

    public override void Iniciar(int metodoPagamento, decimal valorMonetario)
    {
        if (Estado == EstadoDriverCartao.OperacaoIniciada)
            throw new InvalidOperationException("Há uma transação pendente");

        OnIniciou(new TransacaoCartaoEventArgs(
            DateTime.Now,
            new TransacaoCartao
            {
                Aprovado = false,
                Cancelado = false,
                MensagemRetorno = "AGUARDANDO...",
                MetodoPagamento = metodoPagamento,
                ValorPago = valorMonetario,
            }));
    }

    public void NaoAprovado()
    {
        if (Estado != EstadoDriverCartao.OperacaoIniciada)
            throw new InvalidOperationException("Nenhuma transação foi realizada");

        OnFinalizou(
            new(
                DateTime.Now,
                new()
                {
                    Aprovado = false,
                    Cancelado = false,
                    MensagemRetorno = "NÃO APROVADO",
                    MetodoPagamento = MetodoPagamento,
                    ValorPago = ValorPago
                }));
    }

    public void Comunicar(string mensagem)
    {
        if (Estado != EstadoDriverCartao.OperacaoIniciada)
            throw new InvalidOperationException("Nenhuma transação foi realizada");

        OnComunicou(
            new(
                DateTime.Now,
                new()
                {
                    Aprovado = false,
                    Cancelado = false,
                    MensagemRetorno = mensagem,
                    MetodoPagamento = MetodoPagamento,
                    ValorPago = ValorPago
                }));
    }
}
