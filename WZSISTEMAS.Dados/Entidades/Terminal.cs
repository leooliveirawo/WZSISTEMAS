namespace WZSISTEMAS.Dados.Entidades;

public class Terminal : Entidade
{
    public Terminal()
    {
        Caixas = new HashSet<Caixa>();
        Entradas = new HashSet<Entrada>();
    }

    public long EmpresaId { get; set; }
    public string Nome { get; set; } = default!;

    public Empresa Empresa { get; set; } = default!;

    public ICollection<Caixa> Caixas { get; set; }

    public ICollection<Entrada> Entradas { get; set; }
}