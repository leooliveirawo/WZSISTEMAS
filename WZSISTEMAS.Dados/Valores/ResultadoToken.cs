namespace WZSISTEMAS.Dados.Valores;

public class ResultadoToken
{
    public bool Valido { get; set; }
    public string? Token { get; set; }
}

public class ResultadoToken<T> : ResultadoToken
{
    public T? Retorno { get; set; }
}