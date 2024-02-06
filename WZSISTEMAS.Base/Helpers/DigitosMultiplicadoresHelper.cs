using WZSISTEMAS.Base.Valores;

namespace WZSISTEMAS.Base.Helpers;
public static class DigitosMultiplicadoresHelper
{
    public static int GerarDigitoVerificador(
        int[] digitos,
        IEnumerable<DigitoMultiplicador> digitosMultiplicadores)
    {
        var total = 0;
        var index = 0;

        digitosMultiplicadores.ToList().ForEach(digitoMultiplicador =>
        {
            digitoMultiplicador.Digito = digitos.ElementAt(index);
            total += digitoMultiplicador.Total;

            index++;
        });

        var resto = total % 11;

        return resto < 2 ? 0 : 11 - resto;
    }
}
