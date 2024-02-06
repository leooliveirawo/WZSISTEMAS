namespace WZSISTEMAS.Base.Valores;

public class Credenciais
{
    public string? NomeUsuario { get; set; }
    public string? Senha { get; set; }
    public bool Salva { get; set; }

    public override string ToString()
        => $@"Nome de usuário: {NomeUsuario}";
}
