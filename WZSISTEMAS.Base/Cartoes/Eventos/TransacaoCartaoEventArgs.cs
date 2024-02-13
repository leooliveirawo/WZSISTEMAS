namespace WZSISTEMAS.Base.Cartoes.Eventos;

public class TransacaoCartaoEventArgs(
    DateTime data,
    TransacaoCartao transacao) : EventArgs
{
    public DateTime Data { get; } = data;
    public TransacaoCartao Transacao { get; } = transacao;
}
