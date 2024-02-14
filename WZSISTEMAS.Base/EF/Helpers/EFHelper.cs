using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace WZSISTEMAS.Base.EF.Helpers;

public static class EFHelper
{
    public static  List<T> ObterLista<T>(
        this IQueryable<T> query,
        bool usarRastreamento = false)
        where T : class
    {
        var internalQuery = usarRastreamento
            ? query
            : query.AsNoTracking();

        return query.ToList();
    }

    public static  List<T> ObterLista<T>(
        this IQueryable<T> query,
        Expression<Func<T, bool>> filter,
        bool usarRastreamento = false)
        where T : class
    {
        var internalQuery = usarRastreamento
            ? query
            : query.AsNoTracking();

        return query.Where(filter).ToList();
    }

    public static  T? PrimeiroOuPadrao<T>(
        this IQueryable<T> query,
        bool usarRastreamento = false)
        where T : class
    {
        var internalQuery = usarRastreamento
            ? query
            : query.AsNoTracking();

        return query.FirstOrDefault();
    }

    public static  T? PrimeiroOuPadrao<T>(
        this IQueryable<T> query,
        Expression<Func<T, bool>> filter,
        bool usarRastreamento = false)
        where T : class
    {
        var internalQuery = usarRastreamento
            ? query
            : query.AsNoTracking();

        return query.FirstOrDefault(filter);
    }
}