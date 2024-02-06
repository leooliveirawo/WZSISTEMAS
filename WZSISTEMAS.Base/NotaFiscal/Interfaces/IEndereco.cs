using WZSISTEMAS.Base.Valores;

namespace WZSISTEMAS.Base.NotaFiscal.Interfaces;

public interface IEndereco
{
    string Logradouro { get; set; }
    string? LogradouroNumero { get; set; }
    string? Complemento { get; set; }
    string Bairro { get; set; }
    string Cidade { get; set; }
    string CEP { get; set; }
    UFs UF { get; set; }
    string? Pais { get; set; }
    string? Telefone { get; set; }
}
