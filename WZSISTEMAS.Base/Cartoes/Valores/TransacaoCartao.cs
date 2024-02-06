namespace WZSISTEMAS.Base.Cartoes.Valores;
public class TransacaoCartao
{
    public int MetodoPagamento { get; set; }
    public decimal ValorPago { get; set; }
    public bool Aprovado { get; set; }
    public bool Cancelado { get; set; }
    public string MensagemRetorno { get; set; } = default!;
}
