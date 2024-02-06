namespace WZSISTEMAS.Base.Servicos;

public class ServicoRandomico : IServicoRandomico
{
    private readonly Random random = new();

    public virtual int GerarRandomicamente()
        => random.Next();

    public virtual string GerarRandomicamente(int numeroCaracteres)
    {
        var numbers = string.Empty;

        for (var i = 0; i < numeroCaracteres; i++)
            numbers += random.Next(0, 9).ToString();

        return numbers;
    }

    public virtual int GerarRandomicamente(int numeroMinimo, int numeroMaximo)
        => random.Next(numeroMinimo, numeroMaximo);
}
