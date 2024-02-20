using WZSISTEMAS.Dados.Entidades.Interfaces;

namespace WZSISTEMAS.Dados.Entidades.Helpers;

public static class ItemHelper
{
    public static string CodigoBarrasCodigoReferencia(this IItem item)
    {
        var codBarrasCodRef = item.CodigoBarras;

        if (!string.IsNullOrWhiteSpace(item.CodigoReferencia))
            codBarrasCodRef += $" ({item.CodigoReferencia})";

        return codBarrasCodRef;
    }
}