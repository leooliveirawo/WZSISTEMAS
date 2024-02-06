using System.Runtime.InteropServices;
using WZSISTEMAS.Base.Diretorios.Interfaces;
using WZSISTEMAS.Base.NotaFiscal.Servicos.Interfaces;
using WZSISTEMAS.Base.NotaFiscal.Valores;
using WZSISTEMAS.Base.NotaFiscal.Valores.SAT;
using WZSISTEMAS.Base.Servicos.Interfaces;
using static System.IO.Directory;

namespace WZSISTEMAS.Base.NotaFiscal.Servicos;

public class ServicoSAT(
    IGerenciadorDiretorios gerenciadorDiretorios,
    IServicoXml servicoXml,
    IServicoJson servicoJson) : IServicoSAT
{
    private readonly IGerenciadorDiretorios gerenciadorDiretorios = gerenciadorDiretorios ?? throw new ArgumentNullException(nameof(gerenciadorDiretorios));

    private readonly IServicoXml servicoXml = servicoXml ?? throw new ArgumentNullException(nameof(servicoXml));

    private readonly IServicoJson servicoJson = servicoJson ?? throw new ArgumentNullException(nameof(servicoJson));

    private const string nomeArquivo = "DadosSAT.wz";
    private const string nomeArquivoImportacao = "DadosSAT.xml";

    [DllImport("SAT.DLL", CharSet = CharSet.Unicode)]
    private static extern string EnviarDadosVenda(string dados);

    public virtual void Cancelar(CFe cFe)
    {

    }

    public virtual void Cancelar(string nCFe)
    {

    }

    public virtual void Criar(
        DadosSAT dadosSAT,
        CFe cFe)
    {
        cFe.InformacoesCFe.Identificacao.NumeroSerieSAT = dadosSAT.NumeroSeguranca;

        var xmlCFe = servicoXml.ConverterParaString((cFe));
        //var dados = $"{dadosSAT.NumeroSerieSAT}|{dadosSAT.CodigoAtivacao}|{xmlCFe}";
        //EnviarDadosVenda(dados);
    }

    public virtual DadosSAT? CarregarDadosLocalmente()
    {
        if (gerenciadorDiretorios.Configuracoes.Verificar(nomeArquivo))
        {
            var dadosSATJson = gerenciadorDiretorios.Configuracoes.Ler(nomeArquivo);

            return servicoJson.Deserializar<DadosSAT>(dadosSATJson);
        }
        
        return ImportarDadosSAT() ?? new DadosSAT();
    }

    public virtual void SalvarDadosLocalmente(DadosSAT dadosSAT)
    {
        var dadosSATJson = servicoJson.Serializar(dadosSAT);

        gerenciadorDiretorios.Configuracoes.Escrever(nomeArquivo, dadosSATJson);
    }

    public virtual DadosSAT? ImportarDadosSAT()
    {

        if (gerenciadorDiretorios.Configuracoes.Verificar(nomeArquivoImportacao))
        {
            var dadosSATXml = gerenciadorDiretorios.Configuracoes.Ler(nomeArquivoImportacao);

            var dadosSAT = servicoXml.ConverterDeString<DadosSAT>(dadosSATXml) ?? default!;

            SalvarDadosLocalmente(dadosSAT);

            gerenciadorDiretorios.Configuracoes.Excluir(nomeArquivoImportacao);

            return dadosSAT;
        }
        else
            return default;
    }
}
