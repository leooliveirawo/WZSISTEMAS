using System.Linq.Expressions;
using AutoMapper;

namespace WZSISTEMAS.Base.Helpers;

public static class MapperHelper
{
    public static IMappingExpression<TOrigin, TTarget> Ignore<TOrigin, TTarget, TProperty>(
        this IMappingExpression<TOrigin, TTarget> mapper,
        Expression<Func<TTarget, TProperty>> targetMember)
        => mapper.ForMember(
            targetMember,
            memberOptions
            => memberOptions.Ignore());
}
