using System.Linq.Expressions;

namespace ToDoList.Domain.Extensions;

public static class QueryExtensions
{
    public static IQueryable<T> WhereIf<T>(this IQueryable<T> sourse, bool condition,
        Expression<Func<T, bool>> predicate)
    {
        if (condition)
            return sourse.Where(predicate);
        return sourse;
    }
}