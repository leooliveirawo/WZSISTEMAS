namespace WZSISTEMAS.Base.Servicos;

public class ServicoCredenciais(
    IGerenciadorDiretorios gerenciadorDiretorios,
    IServicoCriptografia servicoCriptografia,
    IServicoJson servicoJson) : IServicoCredenciais
{
    private readonly IGerenciadorDiretorios gerenciadorDiretorios = gerenciadorDiretorios
        ?? throw new ArgumentNullException(nameof(gerenciadorDiretorios));

    private readonly IServicoCriptografia servicoCriptografia = servicoCriptografia
        ?? throw new ArgumentNullException(nameof(servicoCriptografia));

    private readonly IServicoJson servicoJson = servicoJson
        ?? throw new ArgumentNullException(nameof(servicoJson));

    private readonly string iV = "eK_f9*2=9fjUw95_";
    private readonly string key = "eK_f9*2=9fjUw95_o(uJk@c9-dH8&dx6";

    private readonly string nomeArquivo = "Credenciais.wz";

    private void Criptografar(Credenciais credenciais)
    {
        if (credenciais.NomeUsuario is not null)
            credenciais.NomeUsuario = servicoCriptografia.Criptografar(
                iV,
                key,
                credenciais.NomeUsuario);

        if (credenciais.Senha is not null)
            credenciais.Senha = servicoCriptografia.Criptografar(
                iV,
                key,
                credenciais.Senha);
    }

    private void Decrypt(Credenciais credenciais)
    {
        if (credenciais.NomeUsuario is not null)
            credenciais.NomeUsuario = servicoCriptografia.Descriptografar(
                iV,
                key,
                credenciais.NomeUsuario);

        if (credenciais.Senha is not null)
            credenciais.Senha = servicoCriptografia.Descriptografar(
                iV,
                key,
                credenciais.Senha);
    }

    public virtual Credenciais Carregar()
    {
        if (gerenciadorDiretorios.Configuracoes.Verificar(nomeArquivo))
        {
            var credenciaisJson = gerenciadorDiretorios.Configuracoes.Ler(nomeArquivo);

            var credenciais = servicoJson.Deserializar<Credenciais>(credenciaisJson);

            if (credenciais is not null)
            {
                Decrypt(credenciais);

                return credenciais;
            }
        }

        return new();
    }

    public virtual void Salvar(Credenciais credenciais)
    {
        Criptografar(credenciais);

        var credenciaisJson = servicoJson.Serializar(credenciais);

        gerenciadorDiretorios.Configuracoes.Criar();
        gerenciadorDiretorios.Configuracoes.Escrever(
            nomeArquivo,
            credenciaisJson);
    }
}
