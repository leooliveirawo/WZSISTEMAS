namespace WZSISTEMAS.Dados.Entidades.Interfaces;

public interface IItem : IImpostoICMS, IImpostoPIS, IImpostoCOFINS
{
    string Descricao { get; set; }
    string CodigoBarras { get; set; }
    string? CodigoReferencia { get; set; }
    UnidadesMedidas UnidadeMedida { get; set; }
    TipoItem TipoItem { get; set; }
    string NCM { get; set; }
    string CFOP { get; set; }
}