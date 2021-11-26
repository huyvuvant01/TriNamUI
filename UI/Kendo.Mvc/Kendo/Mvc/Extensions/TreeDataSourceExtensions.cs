// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Extensions.TreeDataSourceExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Infrastructure;
using Kendo.Mvc.Infrastructure.Implementation.Expressions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;


#nullable enable
namespace Kendo.Mvc.Extensions
{
  public static class TreeDataSourceExtensions
  {
    private static 
    #nullable disable
    MethodInfo anyMethod = ((IEnumerable<MethodInfo>) typeof (Queryable).GetMethods()).First<MethodInfo>((Func<MethodInfo, bool>) (method => method.Name == "Any" && method.GetParameters().Length == 1));

    internal static IEnumerable<AggregateResult> AggregateForLevel<TModel, T1, T2>(
      this IEnumerable data,
      IQueryable allData,
      List<AggregateDescriptor> aggregates,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector)
    {
      ParameterExpression parameterExpression = Expression.Parameter(typeof (TModel), "item");
      return TreeDataSourceExtensions.AggregateForLevel<TModel, T1, T2>(allData.Where((Expression) Expression.Lambda(TreeDataSourceExtensions.CreateOrExpression<TModel, T1>(data, idSelector, (Expression) parameterExpression), parameterExpression)), allData, aggregates, idSelector, parentIDSelector);
    }

    internal static Expression CreateOrExpression<TModel, T1>(
      IEnumerable data,
      Expression<Func<TModel, T1>> idSelector,
      Expression e)
    {
      Func<TModel, T1> func = idSelector.Compile();
      Expression right = (Expression) null;
      Expression left = ExpressionFactory.MakeMemberAccess(e, idSelector.MemberWithoutInstance());
      foreach (TModel model in data)
        right = right == null ? (Expression) Expression.Equal(left, (Expression) Expression.Constant((object) func(model))) : (Expression) Expression.Or((Expression) Expression.Equal(left, (Expression) Expression.Constant((object) func(model))), right);
      return right;
    }

    internal static IEnumerable<AggregateResult> AggregateForLevel<TModel, T1, T2>(
      this IQueryable data,
      IQueryable allData,
      List<AggregateDescriptor> aggregates,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector)
    {
      data = data.ChildrenRecursive<TModel, T1, T2>(allData, idSelector, parentIDSelector);
      return (IEnumerable<AggregateResult>) data.Aggregate(aggregates.SelectMany<AggregateDescriptor, AggregateFunction>((Func<AggregateDescriptor, IEnumerable<AggregateFunction>>) (a => (IEnumerable<AggregateFunction>) a.Aggregates)));
    }

    internal static IQueryable ChildrenRecursive<TModel, T1, T2>(
      this IQueryable roots,
      IQueryable allData,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector)
    {
      IQueryable roots1 = roots.Children<TModel, T1, T2>(allData, idSelector, parentIDSelector);
      return (bool) TreeDataSourceExtensions.AnyMethod(typeof (TModel)).Invoke((object) null, (object[]) new IQueryable[1]
      {
        roots1
      }) ? roots.Union(roots1.ChildrenRecursive<TModel, T1, T2>(allData, idSelector, parentIDSelector)) : roots;
    }

    internal static IQueryable Children<TModel, T1, T2>(
      this IQueryable roots,
      IQueryable allData,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector)
    {
      Type elementType = allData.ElementType;
      ParameterExpression parameterExpression1 = Expression.Parameter(elementType, "allItem");
      ParameterExpression parameterExpression2 = Expression.Parameter(elementType, "rootItem");
      Expression right = ExpressionFactory.MakeMemberAccess((Expression) parameterExpression1, parentIDSelector.MemberWithoutInstance());
      LambdaExpression lambdaExpression1 = Expression.Lambda((Expression) Expression.Equal((Expression) Expression.Convert(ExpressionFactory.MakeMemberAccess((Expression) parameterExpression2, idSelector.MemberWithoutInstance()), right.Type), right), parameterExpression1);
      LambdaExpression lambdaExpression2 = Expression.Lambda(typeof (Func<TModel, IEnumerable<TModel>>), (Expression) Expression.Call(typeof (Queryable), "Where", new Type[1]
      {
        elementType
      }, allData.Expression, (Expression) Expression.Quote((Expression) lambdaExpression1)), parameterExpression2);
      MethodCallExpression methodCallExpression = Expression.Call(typeof (Queryable), "SelectMany", new Type[2]
      {
        elementType,
        elementType
      }, roots.Expression, (Expression) Expression.Quote((Expression) lambdaExpression2));
      return allData.Provider.CreateQuery((Expression) methodCallExpression);
    }

    private static MethodInfo AnyMethod(Type type) => TreeDataSourceExtensions.anyMethod.MakeGenericMethod(type);

    internal static IQueryable ParentsRecursive<TModel>(
      this IQueryable matches,
      IQueryable allData,
      LambdaExpression idSelector,
      LambdaExpression parentIDSelector)
    {
      IQueryable queryable = matches.Parents(allData, idSelector, parentIDSelector);
      if ((bool) TreeDataSourceExtensions.AnyMethod(matches.ElementType).Invoke((object) null, (object[]) new IQueryable[1]
      {
        queryable
      }))
        queryable = queryable.Union(queryable.ParentsRecursive<TModel>(allData, idSelector, parentIDSelector));
      return matches.Union(queryable);
    }

    internal static IQueryable Parents(
      this IQueryable matches,
      IQueryable allData,
      LambdaExpression idSelector,
      LambdaExpression parentIDSelector)
    {
      Type elementType = allData.ElementType;
      ParameterExpression parameterExpression1 = Expression.Parameter(elementType, "allItem");
      ParameterExpression parameterExpression2 = Expression.Parameter(elementType, "matchedItem");
      Expression left = ExpressionFactory.MakeMemberAccess((Expression) parameterExpression2, parentIDSelector.MemberWithoutInstance());
      UnaryExpression unaryExpression = Expression.Convert(ExpressionFactory.MakeMemberAccess((Expression) parameterExpression1, idSelector.MemberWithoutInstance()), left.Type);
      LambdaExpression lambdaExpression1 = Expression.Lambda((Expression) Expression.Equal(left, (Expression) unaryExpression), parameterExpression2);
      LambdaExpression lambdaExpression2 = Expression.Lambda((Expression) Expression.Call(typeof (Queryable), "Any", new Type[1]
      {
        elementType
      }, matches.Expression, (Expression) Expression.Quote((Expression) lambdaExpression1)), parameterExpression1);
      MethodCallExpression methodCallExpression = Expression.Call(typeof (Queryable), "Where", new Type[1]
      {
        elementType
      }, allData.Expression, (Expression) Expression.Quote((Expression) lambdaExpression2));
      return allData.Provider.CreateQuery((Expression) methodCallExpression);
    }
  }
}
