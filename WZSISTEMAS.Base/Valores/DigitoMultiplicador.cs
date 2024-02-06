namespace WZSISTEMAS.Base.Valores;

public class DigitoMultiplicador
{
    public int Digito { get; set; }
    public int Multiplicador { get; private set; }

    private DigitoMultiplicador()
    {
    }

    public DigitoMultiplicador(int multiplicador) : this()
    {
        Multiplicador = multiplicador;
    }

    public override string ToString()
    {
        return $"Digito: {Digito}; Multiplicador: {Multiplicador}; Total: {Total}";
    }

    public int Total 
        => Multiplicador * Digito;

    public static IEnumerable<DigitoMultiplicador> GerarDigitosMultiplicadores(
        params int[] multiplicadores)
    {
        var digitosMultiplicadores 
            = new List<DigitoMultiplicador>(multiplicadores.Length);

        digitosMultiplicadores.AddRange(
            multiplicadores.Select(
                multiplicador => new DigitoMultiplicador(multiplicador)));

        return digitosMultiplicadores;
    }
}
