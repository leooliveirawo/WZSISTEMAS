namespace WZSISTEMAS.Base.Valores;

public class Token
{
    public string Valor { get; set; } = default!;
    public DateTime ExpiraEm { get; set; }
    public bool Cancelado { get; set; }
    public string Chave { get; set; } = default!;
}
