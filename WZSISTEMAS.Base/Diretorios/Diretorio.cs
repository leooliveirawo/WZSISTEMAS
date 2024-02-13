namespace WZSISTEMAS.Base.Diretorios;

public abstract class Diretorio : IDiretorio
{
    public abstract string Caminho { get; }

    public virtual string CaminhoAppData =>
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "WZSISTEMAS");

    public virtual void Criar()
        => Directory.CreateDirectory(Caminho);

    public string Ler(string nomeArquivo)
        => File.ReadAllText(Path.Combine(Caminho, nomeArquivo));

    public virtual bool Excluir(string nomeArquivo)
    {
        if (Verificar(nomeArquivo))
        {
            File.Delete(Path.Combine(Caminho, nomeArquivo));
            return true;
        }

        return false;
    }

    public virtual bool Verificar(string nomeArquivo)
        => File.Exists(Path.Combine(Caminho, nomeArquivo));

    public virtual void Escrever(
        string nomeArquivo,
        string? dados)
        => File.WriteAllText(Path.Combine(Caminho, nomeArquivo), dados);
}