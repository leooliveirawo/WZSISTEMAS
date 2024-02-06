namespace WZSISTEMAS.Base.Valores;

public class ItemLista<T>
{
    public string Descricao { get; set; } = default!;
    public T? Item { get; set; }
}
