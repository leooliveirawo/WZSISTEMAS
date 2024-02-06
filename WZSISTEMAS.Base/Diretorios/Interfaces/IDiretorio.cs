namespace WZSISTEMAS.Base.Diretorios.Interfaces;
public interface IDiretorio
{
    string Caminho { get; }

   void Criar();
   void Escrever(string nomeArquivo, string? dados);
    string Ler(string nomeArquivo);
    bool Excluir(string nomeArquivo);
    bool Verificar(string nomeArquivo);
}
