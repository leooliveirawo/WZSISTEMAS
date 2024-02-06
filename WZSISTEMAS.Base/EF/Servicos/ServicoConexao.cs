namespace WZSISTEMAS.Base.EF.Services;
public class ServicoConexao(
    IGerenciadorDiretorios gerenciadorDiretorios,
    IServicoJson servicoJson,
    IServicoCriptografia servicoCriptografia) : IServicoConexao
{
    private readonly IGerenciadorDiretorios gerenciadorDiretorios =
        gerenciadorDiretorios ?? throw new InvalidOperationException(nameof(gerenciadorDiretorios));

    private readonly IServicoJson servicoJson = servicoJson ?? throw new InvalidOperationException(nameof(servicoJson));

    private readonly IServicoCriptografia servicoCriptografia =
        servicoCriptografia ?? throw new InvalidOperationException(nameof(servicoCriptografia));

    private readonly string iV = "eK_f9*2=9fjUw95_";
    private readonly string key = "eK_f9*2=9fjUw95_o(uJk@c9-dH8&dx6";

    private readonly string nomeArquivo = "ConfiguracoesConexao.wz";

    public virtual ConfiguracoesConexao? Carregar()
    {
        if (gerenciadorDiretorios.Configuracoes.Verificar(nomeArquivo))
        {
            var configuracoesConexaoJson = gerenciadorDiretorios.Configuracoes.Ler(nomeArquivo);

            if (configuracoesConexaoJson is null)
                return default;

            configuracoesConexaoJson =
                servicoCriptografia.Descriptografar(iV, key, configuracoesConexaoJson);

            var configuracoesConexao = servicoJson.Deserializar<ConfiguracoesConexao>(configuracoesConexaoJson);

            if (configuracoesConexao is not null)
                return configuracoesConexao;
        }

        return default;
    }

    public virtual void Salvar(ConfiguracoesConexao configuracoesConexao)
    {
        gerenciadorDiretorios.Configuracoes.Criar();
        
        var configuracoesConexaoJson = servicoJson.Serializar(configuracoesConexao);

        configuracoesConexaoJson = servicoCriptografia.Criptografar(iV, key, configuracoesConexaoJson);

        gerenciadorDiretorios.Configuracoes.Escrever(nomeArquivo, configuracoesConexaoJson);
    }

    public bool Verificar()
    {
        return gerenciadorDiretorios.Configuracoes.Verificar(nomeArquivo);
    }
}
