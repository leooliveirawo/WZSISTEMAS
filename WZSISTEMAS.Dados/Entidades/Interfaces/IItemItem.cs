namespace WZSISTEMAS.Dados.Entidades.Interfaces;

public interface IItemItem : IItem
{
    long ItemId { get; set; }
    DateTime? CanceladoEm { get; set; }

    decimal ValorUnitario { get; set; }
    decimal? ValorUnitarioDesconto { get; set; }

    decimal Quantidade { get; set; }

    decimal ValorTotal { get; set; }
    decimal? ValorTotalDesconto { get; set; }
}