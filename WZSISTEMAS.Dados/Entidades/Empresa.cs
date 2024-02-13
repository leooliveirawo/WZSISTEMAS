namespace WZSISTEMAS.Dados.Entidades;

public class Empresa : Entidade, IEnderecoCompleto
{
    public Empresa()
    {
        Terminais = new HashSet<Terminal>();
        Entradas = new HashSet<Entrada>();
    }

    public string RazaoSocial { get; set; } = default!;
    public string? CodigoReferencia { get; set; }
    public string CNPJ { get; set; } = default!;
    public string InscricaoEstadual { get; set; } = default!;
    public string? Referencia { get; set; }

    public ICollection<Terminal> Terminais { get; set; }

    public ICollection<Entrada> Entradas { get; set; }

    public string Logradouro { get; set; } = default!;
    public string? LogradouroNumero { get; set; }
    public string? Complemento { get; set; }

    public string CEP { get; set; } = default!;
    public string Bairro { get; set; } = default!;
    public string Cidade { get; set; } = default!;
    public UFs UF { get; set; } = default!;
    public string? Pais { get; set; }

    public string? Telefone { get; set; }
    public string? Telefone2 { get; set; }
    public string? Telefone3 { get; set; }

    public string? Email { get; set; }
}