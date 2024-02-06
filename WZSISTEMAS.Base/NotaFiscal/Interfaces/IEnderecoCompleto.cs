namespace WZSISTEMAS.Base.NotaFiscal.Interfaces;

public interface IEnderecoCompleto : IEndereco
{
    string? Telefone2 { get; set; }
    string? Telefone3 { get; set; }
    string? Email { get; set; }
}