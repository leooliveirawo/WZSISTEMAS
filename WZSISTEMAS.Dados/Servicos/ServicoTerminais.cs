using Microsoft.EntityFrameworkCore;

namespace WZSISTEMAS.Dados.Servicos;

public class ServicoTerminais(
    DbContext dbContext,
    IServicoJson servicoJson,
    IServicoEmpresas servicoEmpresas, 
    IGerenciadorDiretorios gerenciadorDiretorios)
    : ServicoEntidades<Terminal>(dbContext), IServicoTerminais
{
    private readonly IServicoEmpresas servicoEmpresas =
        servicoEmpresas ?? throw new ArgumentNullException(nameof(servicoEmpresas));

    private readonly IServicoJson servicoJson = servicoJson ?? throw new ArgumentNullException(nameof(servicoJson));

    private readonly IGerenciadorDiretorios gerenciadorDiretorios = gerenciadorDiretorios ?? throw new ArgumentNullException(nameof(gerenciadorDiretorios));

    private const string nomeArquivo = "Terminal.wz";

    public  Terminal? ObterTerminalVinculado(bool usarTracking = false)
    {
        if (gerenciadorDiretorios.Configuracoes.Verificar(nomeArquivo))
        {
            var terminalDadosJson = gerenciadorDiretorios.Configuracoes.Ler(nomeArquivo);

            var terminalDados = servicoJson.Deserializar<TerminalDados>(terminalDadosJson) ??
                                throw new InvalidOperationException("");

            return ObterPorId(terminalDados.TerminalId, usarTracking);
        }

        return default;
    }

    public  Terminal VincularTerminal(long empresaId)
    {
        var terminal = new Terminal
        {
            Nome = "Terminal",
            EmpresaId = empresaId
        };

        Criar(terminal);

        SalvarAlteracoes();

        var empresa = DbContext.Set<Empresa>()
            .Where(x => x.Id == empresaId)
            .Select(x =>
                new Empresa
                {
                    RazaoSocial = x.RazaoSocial,
                    CNPJ = x.CNPJ
                })
            .First();

        terminal.Nome = $"Terminal {terminal.Id} - {empresa.RazaoSocial} ({empresa.CNPJ})";

        Editar(terminal);
        SalvarAlteracoes();

        var terminalDados = new TerminalDados
        {
            TerminalId = terminal.Id
        };

        var terminalDadosJson = servicoJson.Serializar(terminalDados);

         gerenciadorDiretorios.Configuracoes.Criar();
         gerenciadorDiretorios.Configuracoes.Escrever(nomeArquivo, terminalDadosJson);

         return terminal;
    }

    private class TerminalDados
    {
        public long TerminalId { get; set; }
    }
}