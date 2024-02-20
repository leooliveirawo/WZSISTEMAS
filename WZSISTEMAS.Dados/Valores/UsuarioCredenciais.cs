namespace WZSISTEMAS.Dados.Valores;

public class UsuarioCredenciais
{
    public string NomeUsuario { get; set; } = default!;
    public string Senha { get; set; } = default!;

    public string GerarHash(IServicoHash servicoHash)
        => servicoHash.GerarHash(Senha);

    public bool CompararHash(IServicoHash servicoHash, string senhaInformada)
        => servicoHash.CompararHash(Senha, servicoHash.GerarHash(senhaInformada));
}
