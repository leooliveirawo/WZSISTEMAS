using Microsoft.EntityFrameworkCore;

namespace WZSISTEMAS.Dados.EF.Helpers;
public static class EFHelper
{
    public static IQueryable<TEntidade> FiltrarIdsIgnorados<TEntidade>(
        this IQueryable<TEntidade> query,
        IEnumerable<long>? idsIgnorados)
        where TEntidade : Entidade
    {
        var queryInterna = query;

        if (idsIgnorados is not null)
            foreach (var idIgnorado in idsIgnorados)
                queryInterna = queryInterna.Where(entidade => entidade.Id != idIgnorado);

        return queryInterna;
    }
}
