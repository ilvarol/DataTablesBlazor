using System;
using System.Linq;
using System.Linq.Expressions;

public static class IQueryableExtensions
{
    public static IQueryable<T> OrderBy<T>(this IQueryable<T> source, string propertyName, string methodName)
    {
        if (String.IsNullOrEmpty(propertyName) || String.IsNullOrEmpty(methodName))
            return source;

        methodName = methodName == "desc" ? "OrderByDescending" : "OrderBy";

        var typeOfT = typeof(T);
        var parameter = Expression.Parameter(typeOfT, "parameter");
        var propertyType = typeOfT.GetProperty(propertyName).PropertyType;
        var propertyAccess = Expression.PropertyOrField(parameter, propertyName);
        var orderExpression = Expression.Lambda(propertyAccess, parameter);
        var expression = Expression.Call(typeof(Queryable), methodName, new Type[] { typeOfT, propertyType }, source.Expression, Expression.Quote(orderExpression));

        return source.Provider.CreateQuery<T>(expression);
    }

    public static IQueryable<T> Contains<T>(this IQueryable<T> source, string columnName, string keyword)
    {
        if (String.IsNullOrEmpty(columnName) || String.IsNullOrEmpty(keyword))
            return source;

        var methodToString = typeof(string).GetMethod("ToString", Type.EmptyTypes);
        var methodContains = typeof(string).GetMethod("Contains", new[] { typeof(string) });

        var parameter = Expression.Parameter(typeof(T), "parameter");
        var property = Expression.Property(parameter, columnName);

        var constant = Expression.Constant(keyword);

        var toStringCall = Expression.Call(property, methodToString);
        var containsCall = Expression.Call(toStringCall, methodContains, constant);

        var filterLambda = Expression.Lambda<Func<T, bool>>(containsCall, parameter);

        return source.Where(filterLambda);
    }
}