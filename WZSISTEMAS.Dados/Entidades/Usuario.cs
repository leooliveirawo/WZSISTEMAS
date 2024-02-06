namespace WZSISTEMAS.Dados.Entidades;

public class Usuario : Entidade
{
    public long FuncionarioId { get; set; }
    public string NomeUsuario { get; set; } = default!;
    public string HashSenha { get; set; } = default!;

    public bool Ativo { get; set; }

    public Funcionario Funcionario { get; set; } = default!;
}