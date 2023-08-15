namespace WZSISTEMAS.Data.Auxilares
{
    public static class AuxiliarString
    {
        public static string? ObterStringNula(this string @string)
        {
            if (string.IsNullOrEmpty(@string))
                return default;

            return @string;
        }
    }
}
