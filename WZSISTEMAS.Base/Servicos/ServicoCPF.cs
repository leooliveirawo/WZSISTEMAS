namespace WZSISTEMAS.Base.Servicos;

public class ServicoCPF(
    IServicoRandomico servicoRandomico) : IServicoCPF
{
    private readonly IServicoRandomico servicoRandomico = servicoRandomico 
        ?? throw new ArgumentNullException(nameof(servicoRandomico));

    protected virtual IEnumerable<DigitoMultiplicador> DigitosMultiplicadoresPrimeiroDigitoVerificador()
        => DigitoMultiplicador.GerarDigitosMultiplicadores(
            10, 9, 8, 7, 6, 5, 4, 3, 2);

    protected virtual IEnumerable<DigitoMultiplicador> DigitosMultiplicadoresSegundoDigitoVerificador()
        => DigitoMultiplicador.GerarDigitosMultiplicadores(
            11, 10, 9, 8, 7, 6, 5, 4, 3, 2);

    public virtual string Gerar()
        => GerarDigitoVerificador(
            servicoRandomico.GerarRandomicamente(9));

    public virtual string GerarDigitoVerificador(string cPFParcial)
    {
        // 012.345.698.90

        var digitos = cPFParcial
            .Select(digito => Convert.ToInt32(digito.ToString()))
            .ToList();

        var cPF = string.Empty;

        digitos.Add(
            DigitosMultiplicadoresHelper.GerarDigitoVerificador(
                [.. digitos],
                DigitosMultiplicadoresPrimeiroDigitoVerificador()
                ));

        digitos.Add(
            DigitosMultiplicadoresHelper.GerarDigitoVerificador(
                [.. digitos],
                DigitosMultiplicadoresSegundoDigitoVerificador()));

        digitos.ForEach(digito => cPF += digito.ToString());

        return cPF;        
    }

    public virtual bool Validar(string cPF)
    {
        // 012.345.698.90

        if (cPF.Length != 11
            || cPF.All(x => x == cPF.ElementAt(0)))
            return false;

        var digitos = cPF
            .Select(x => Convert.ToInt32(x.ToString()))
            .ToArray();

        return DigitosMultiplicadoresHelper.GerarDigitoVerificador([.. digitos], DigitosMultiplicadoresPrimeiroDigitoVerificador()) == digitos[9]
               && DigitosMultiplicadoresHelper.GerarDigitoVerificador([.. digitos], DigitosMultiplicadoresSegundoDigitoVerificador()) == digitos[10];

    }
}
