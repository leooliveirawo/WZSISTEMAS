namespace WZSISTEMAS.Dados.Entidades;

public class Funcionario : Entidade, IEnderecoCompleto
{
    public Funcionario()
    {
        Pedidos = new HashSet<Pedido>();
    }

    public long CargoId { get; set; }
    public string NomeCompleto { get; set; } = default!;
    public string CPF { get; set; } = default!;
    public string? RG { get; set; }
    public DateTime? DataNascimento { get; set; }
    public string? Referencia { get; set; }

    public Cargo Cargo { get; set; } = default!;

    public Usuario Usuario { get; set; } = default!;

    public ICollection<Pedido> Pedidos { get; set; }

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