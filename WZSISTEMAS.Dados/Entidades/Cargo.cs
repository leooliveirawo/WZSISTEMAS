namespace WZSISTEMAS.Dados.Entidades;

public class Cargo : Entidade
{
    public Cargo()
    {
        Funcionarios = new HashSet<Funcionario>();
    }

    public string Nome { get; set; } = default!;
    public string? Descricao { get; set; }

    public ICollection<Funcionario> Funcionarios { get; set; }
}