namespace WZSISTEMAS.Dados.Valores;

public class UsuarioCredenciais
{
    public string NomeUsuario { get; set; }
    public string Senha { get; set; }

    public string GerarHash(IServicoHash servicoHash)
        => servicoHash.GerarHash(Senha);

    public bool CompararHash(IServicoHash servicoHash, string senhaInformada)
        => servicoHash.CompararHash(Senha, servicoHash.GerarHash(senhaInformada));
}
