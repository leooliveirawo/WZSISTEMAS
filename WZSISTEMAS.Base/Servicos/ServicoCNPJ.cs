namespace WZSISTEMAS.Base.Servicos;

public class ServicoCNPJ(
    IServicoRandomico servicoRandomico) : IServicoCNPJ
{
    private readonly IServicoRandomico servicoRandomico = servicoRandomico
        ?? throw new ArgumentNullException(nameof(servicoRandomico));

    protected virtual IEnumerable<DigitoMultiplicador> DigitosMultiplicadoresPrimeiroDigitoVerificador()
        => DigitoMultiplicador.GerarDigitosMultiplicadores(
            5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2);

    protected virtual IEnumerable<DigitoMultiplicador> DigitosMultiplicadoresSegundoDigitoVerificador()
        => DigitoMultiplicador.GerarDigitosMultiplicadores(
            6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2);

    public virtual string Gerar()
        => GerarDigitosVerificadores(
            servicoRandomico.GerarRandomicamente(12));

    public virtual string GerarDigitosVerificadores(string cNPJParcial)
    {
        // 01.234.567/8901-23

        var digitos = cNPJParcial
            .Select(x => Convert.ToInt32(x.ToString()))
            .ToList();

        var cNPJ = string.Empty;

        digitos.Add(
            DigitosMultiplicadoresHelper.GerarDigitoVerificador(
                [.. digitos],
                DigitosMultiplicadoresPrimeiroDigitoVerificador()));

        digitos.Add(
            DigitosMultiplicadoresHelper.GerarDigitoVerificador(
                [.. digitos],
                DigitosMultiplicadoresSegundoDigitoVerificador()));

        digitos.ForEach(digito => cNPJ += digito.ToString());

        return cNPJ;
    }

    public bool Validar(string cNPJ)
    {
        // 01.234.567/8901-23

        if (cNPJ.Length != 14
            || cNPJ.All(x => x == cNPJ.ElementAt(0)))
            return false;

        var digitos = cNPJ
            .Select(digito => Convert.ToInt32(digito.ToString()))
            .ToArray();

        return DigitosMultiplicadoresHelper.GerarDigitoVerificador(
                [.. digitos],
                DigitosMultiplicadoresPrimeiroDigitoVerificador()) == digitos[12]
            && DigitosMultiplicadoresHelper.GerarDigitoVerificador(
                [.. digitos],
                DigitosMultiplicadoresSegundoDigitoVerificador()) == digitos[13];
    }
}
