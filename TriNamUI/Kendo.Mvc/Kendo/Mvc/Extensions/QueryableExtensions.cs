// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Extensions.QueryableExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Infrastructure;
using Kendo.Mvc.Infrastructure.Implementation;
using Kendo.Mvc.Infrastructure.Implementation.Expressions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.Extensions
{
  public static class QueryableExtensions
  {
    private static 
    #nullable disable
    DataSourceResult ToDataSourceResult(
      this DataTableWrapper enumerable,
      DataSourceRequest request)
    {
      List<IFilterDescriptor> filterDescriptorList = new List<IFilterDescriptor>();
      DataTable dataTable = enumerable.Table;
      if (request.Filters != null)
        filterDescriptorList.AddRange((IEnumerable<IFilterDescriptor>) request.Filters);
      if (filterDescriptorList.Any<IFilterDescriptor>())
        filterDescriptorList.SelectMemberDescriptors().Each<FilterDescriptor>((Action<FilterDescriptor>) (f => f.MemberType = QueryableExtensions.GetFieldByTypeFromDataColumn(dataTable, f.Member)));
      List<GroupDescriptor> groupDescriptorList = new List<GroupDescriptor>();
      if (request.Groups != null)
        groupDescriptorList.AddRange((IEnumerable<GroupDescriptor>) request.Groups);
      if (groupDescriptorList.Any<GroupDescriptor>())
        groupDescriptorList.Each<GroupDescriptor>((Action<GroupDescriptor>) (g => g.MemberType = QueryableExtensions.GetFieldByTypeFromDataColumn(dataTable, g.Member)));
      List<AggregateDescriptor> source = new List<AggregateDescriptor>();
      if (request.Aggregates != null)
        source.AddRange((IEnumerable<AggregateDescriptor>) request.Aggregates);
      if (source.Any<AggregateDescriptor>())
      {
        foreach (AggregateDescriptor aggregateDescriptor in source)
          aggregateDescriptor.Aggregates.Each<AggregateFunction>((Action<AggregateFunction>) (g => g.MemberType = QueryableExtensions.GetFieldByTypeFromDataColumn(dataTable, g.SourceField)));
      }
      DataSourceResult dataSourceResult = enumerable.AsEnumerable<DataRowView>().ToDataSourceResult(request);
      dataSourceResult.Data = dataSourceResult.Data.SerializeToDictionary(enumerable.Table);
      return dataSourceResult;
    }

    private static Type GetFieldByTypeFromDataColumn(DataTable dataTable, string memberName) => !dataTable.Columns.Contains(memberName) ? (Type) null : dataTable.Columns[memberName].DataType;

    public static DataSourceResult ToDataSourceResult(
      this DataTable dataTable,
      DataSourceRequest request)
    {
      return QueryableExtensions.ToDataSourceResult(dataTable.WrapAsEnumerable(), request);
    }

    public static Task<DataSourceResult> ToDataSourceResultAsync(
      this DataTable dataTable,
      DataSourceRequest request)
    {
      return QueryableExtensions.CreateDataSourceResultAsync((Func<DataSourceResult>) (() => dataTable.ToDataSourceResult(request)));
    }

    public static Task<DataSourceResult> ToDataSourceResultAsync(
      this DataTable dataTable,
      DataSourceRequest request,
      CancellationToken cancellationToken)
    {
      return QueryableExtensions.CreateDataSourceCancellableResultAsync((Func<DataSourceResult>) (() => dataTable.ToDataSourceResult(request)), cancellationToken);
    }

    public static DataSourceResult ToDataSourceResult(
      this IEnumerable enumerable,
      DataSourceRequest request)
    {
      return QueryableExtensions.ToDataSourceResult(enumerable.AsQueryable(), request);
    }

    public static Task<DataSourceResult> ToDataSourceResultAsync(
      this IEnumerable enumerable,
      DataSourceRequest request)
    {
      return QueryableExtensions.CreateDataSourceResultAsync((Func<DataSourceResult>) (() => enumerable.ToDataSourceResult(request)));
    }

    public static Task<DataSourceResult> ToDataSourceResultAsync(
      this IEnumerable enumerable,
      DataSourceRequest request,
      CancellationToken cancellation)
    {
      return QueryableExtensions.CreateDataSourceCancellableResultAsync((Func<DataSourceResult>) (() => enumerable.ToDataSourceResult(request)), cancellation);
    }

    public static DataSourceResult ToDataSourceResult(
      this IEnumerable enumerable,
      DataSourceRequest request,
      ModelStateDictionary modelState)
    {
      return QueryableExtensions.ToDataSourceResult(enumerable.AsQueryable(), request, modelState);
    }

    public static Task<DataSourceResult> ToDataSourceResultAsync(
      this IEnumerable enumerable,
      DataSourceRequest request,
      ModelStateDictionary modelState)
    {
      return QueryableExtensions.CreateDataSourceResultAsync((Func<DataSourceResult>) (() => enumerable.ToDataSourceResult(request, modelState)));
    }

    public static Task<DataSourceResult> ToDataSourceResultAsync(
      this IEnumerable enumerable,
      DataSourceRequest request,
      ModelStateDictionary modelState,
      CancellationToken cancellation)
    {
      return QueryableExtensions.CreateDataSourceCancellableResultAsync((Func<DataSourceResult>) (() => enumerable.ToDataSourceResult(request, modelState)), cancellation);
    }

    public static DataSourceResult ToDataSourceResult(
      this IQueryable queryable,
      DataSourceRequest request)
    {
      return QueryableExtensions.ToDataSourceResult(queryable, request, (ModelStateDictionary) null);
    }

    public static Task<DataSourceResult> ToDataSourceResultAsync(
      this IQueryable queryable,
      DataSourceRequest request)
    {
      return QueryableExtensions.CreateDataSourceResultAsync((Func<DataSourceResult>) (() => QueryableExtensions.ToDataSourceResult(queryable, request)));
    }

    public static Task<DataSourceResult> ToDataSourceResultAsync(
      this IQueryable queryable,
      DataSourceRequest request,
      CancellationToken cancellationToken)
    {
      return QueryableExtensions.CreateDataSourceCancellableResultAsync((Func<DataSourceResult>) (() => QueryableExtensions.ToDataSourceResult(queryable, request)), cancellationToken);
    }

    public static DataSourceResult ToDataSourceResult<TModel, TResult>(
      this IEnumerable<TModel> enumerable,
      DataSourceRequest request,
      Func<TModel, TResult> selector)
    {
      return enumerable.AsQueryable<TModel>().CreateDataSourceResult<TModel, TResult>(request, (ModelStateDictionary) null, selector);
    }

    public static Task<DataSourceResult> ToDataSourceResultAsync<TModel, TResult>(
      this IEnumerable<TModel> enumerable,
      DataSourceRequest request,
      Func<TModel, TResult> selector)
    {
      return QueryableExtensions.CreateDataSourceResultAsync((Func<DataSourceResult>) (() => enumerable.ToDataSourceResult<TModel, TResult>(request, selector)));
    }

    public static Task<DataSourceResult> ToDataSourceResultAsync<TModel, TResult>(
      this IEnumerable<TModel> enumerable,
      DataSourceRequest request,
      Func<TModel, TResult> selector,
      CancellationToken cancellationToken)
    {
      return QueryableExtensions.CreateDataSourceCancellableResultAsync((Func<DataSourceResult>) (() => enumerable.ToDataSourceResult<TModel, TResult>(request, selector)), cancellationToken);
    }

    public static DataSourceResult ToDataSourceResult<TModel, TResult>(
      this IEnumerable<TModel> enumerable,
      DataSourceRequest request,
      ModelStateDictionary modelState,
      Func<TModel, TResult> selector)
    {
      return enumerable.AsQueryable<TModel>().CreateDataSourceResult<TModel, TResult>(request, modelState, selector);
    }

    public static Task<DataSourceResult> ToDataSourceResultAsync<TModel, TResult>(
      this IEnumerable<TModel> enumerable,
      DataSourceRequest request,
      ModelStateDictionary modelState,
      Func<TModel, TResult> selector)
    {
      return QueryableExtensions.CreateDataSourceResultAsync((Func<DataSourceResult>) (() => enumerable.ToDataSourceResult<TModel, TResult>(request, modelState, selector)));
    }

    public static Task<DataSourceResult> ToDataSourceResultAsync<TModel, TResult>(
      this IEnumerable<TModel> enumerable,
      DataSourceRequest request,
      ModelStateDictionary modelState,
      Func<TModel, TResult> selector,
      CancellationToken cancellationToken)
    {
      return QueryableExtensions.CreateDataSourceCancellableResultAsync((Func<DataSourceResult>) (() => enumerable.ToDataSourceResult<TModel, TResult>(request, modelState, selector)), cancellationToken);
    }

    public static DataSourceResult ToDataSourceResult<TModel, TResult>(
      this IQueryable<TModel> enumerable,
      DataSourceRequest request,
      Func<TModel, TResult> selector)
    {
      return enumerable.CreateDataSourceResult<TModel, TResult>(request, (ModelStateDictionary) null, selector);
    }

    public static Task<DataSourceResult> ToDataSourceResultAsync<TModel, TResult>(
      this IQueryable<TModel> queryable,
      DataSourceRequest request,
      Func<TModel, TResult> selector)
    {
      return QueryableExtensions.CreateDataSourceResultAsync((Func<DataSourceResult>) (() => queryable.ToDataSourceResult<TModel, TResult>(request, selector)));
    }

    public static Task<DataSourceResult> ToDataSourceResultAsync<TModel, TResult>(
      this IQueryable<TModel> queryable,
      DataSourceRequest request,
      Func<TModel, TResult> selector,
      CancellationToken cancellationToken)
    {
      return QueryableExtensions.CreateDataSourceCancellableResultAsync((Func<DataSourceResult>) (() => queryable.ToDataSourceResult<TModel, TResult>(request, selector)), cancellationToken);
    }

    public static DataSourceResult ToDataSourceResult<TModel, TResult>(
      this IQueryable<TModel> enumerable,
      DataSourceRequest request,
      ModelStateDictionary modelState,
      Func<TModel, TResult> selector)
    {
      return enumerable.CreateDataSourceResult<TModel, TResult>(request, modelState, selector);
    }

    public static Task<DataSourceResult> ToDataSourceResultAsync<TModel, TResult>(
      this IQueryable<TModel> queryable,
      DataSourceRequest request,
      ModelStateDictionary modelState,
      Func<TModel, TResult> selector)
    {
      return QueryableExtensions.CreateDataSourceResultAsync((Func<DataSourceResult>) (() => queryable.ToDataSourceResult<TModel, TResult>(request, modelState, selector)));
    }

    public static Task<DataSourceResult> ToDataSourceResultAsync<TModel, TResult>(
      this IQueryable<TModel> queryable,
      DataSourceRequest request,
      ModelStateDictionary modelState,
      Func<TModel, TResult> selector,
      CancellationToken cancellationToken)
    {
      return QueryableExtensions.CreateDataSourceCancellableResultAsync((Func<DataSourceResult>) (() => queryable.ToDataSourceResult<TModel, TResult>(request, modelState, selector)), cancellationToken);
    }

    public static DataSourceResult ToDataSourceResult(
      this IQueryable queryable,
      DataSourceRequest request,
      ModelStateDictionary modelState)
    {
      return queryable.CreateDataSourceResult<object, object>(request, modelState, (Func<object, object>) null);
    }

    public static Task<DataSourceResult> ToDataSourceResultAsync(
      this IQueryable queryable,
      DataSourceRequest request,
      ModelStateDictionary modelState)
    {
      return QueryableExtensions.CreateDataSourceResultAsync((Func<DataSourceResult>) (() => QueryableExtensions.ToDataSourceResult(queryable, request, modelState)));
    }

    public static Task<DataSourceResult> ToDataSourceResultAsync(
      this IQueryable queryable,
      DataSourceRequest request,
      ModelStateDictionary modelState,
      CancellationToken cancellationToken)
    {
      return QueryableExtensions.CreateDataSourceCancellableResultAsync((Func<DataSourceResult>) (() => QueryableExtensions.ToDataSourceResult(queryable, request, modelState)), cancellationToken);
    }

    private static DataSourceResult CreateDataSourceResult<TModel, TResult>(
      this IQueryable queryable,
      DataSourceRequest request,
      ModelStateDictionary modelState,
      Func<TModel, TResult> selector)
    {
      DataSourceResult dataSourceResult = new DataSourceResult();
      IQueryable source1 = queryable;
      List<IFilterDescriptor> source2 = new List<IFilterDescriptor>();
      if (request.Filters != null)
        source2.AddRange((IEnumerable<IFilterDescriptor>) request.Filters);
      if (source2.Any<IFilterDescriptor>())
        source1 = source1.Where((IEnumerable<IFilterDescriptor>) source2);
      List<SortDescriptor> sort = new List<SortDescriptor>();
      if (request.Sorts != null)
        sort.AddRange((IEnumerable<SortDescriptor>) request.Sorts);
      List<SortDescriptor> temporarySortDescriptors = new List<SortDescriptor>();
      IList<GroupDescriptor> groupDescriptorList = (IList<GroupDescriptor>) new List<GroupDescriptor>();
      if (request.Groups != null)
        groupDescriptorList.AddRange<GroupDescriptor>((IEnumerable<GroupDescriptor>) request.Groups);
      List<AggregateDescriptor> aggregates = new List<AggregateDescriptor>();
      if (request.Aggregates != null)
        aggregates.AddRange((IEnumerable<AggregateDescriptor>) request.Aggregates);
      if (aggregates.Any<AggregateDescriptor>() && !request.IncludeSubGroupCount)
      {
        IQueryable source3 = source1.AsQueryable();
        IQueryable source4 = source3;
        if (source2.Any<IFilterDescriptor>())
          source4 = source3.Where((IEnumerable<IFilterDescriptor>) source2);
        dataSourceResult.AggregateResults = (IEnumerable<AggregateResult>) source4.Aggregate(aggregates.SelectMany<AggregateDescriptor, AggregateFunction>((Func<AggregateDescriptor, IEnumerable<AggregateFunction>>) (a => (IEnumerable<AggregateFunction>) a.Aggregates)));
        if (groupDescriptorList.Any<GroupDescriptor>() && aggregates.Any<AggregateDescriptor>())
          groupDescriptorList.Each<GroupDescriptor>((Action<GroupDescriptor>) (g => g.AggregateFunctions.AddRange<AggregateFunction>(aggregates.SelectMany<AggregateDescriptor, AggregateFunction>((Func<AggregateDescriptor, IEnumerable<AggregateFunction>>) (a => (IEnumerable<AggregateFunction>) a.Aggregates)))));
      }
      if (!request.GroupPaging || !request.Groups.Any<GroupDescriptor>())
        dataSourceResult.Total = source1.Count();
      if (!sort.Any<SortDescriptor>() && queryable.Provider.IsEntityFrameworkProvider())
      {
        SortDescriptor sortDescriptor = new SortDescriptor()
        {
          Member = queryable.ElementType.FirstSortableProperty()
        };
        sort.Add(sortDescriptor);
        temporarySortDescriptors.Add(sortDescriptor);
      }
      if (groupDescriptorList.Any<GroupDescriptor>())
        groupDescriptorList.Reverse<GroupDescriptor>().Each<GroupDescriptor>((Action<GroupDescriptor>) (groupDescriptor =>
        {
          SortDescriptor sortDescriptor = new SortDescriptor()
          {
            Member = groupDescriptor.Member,
            SortDirection = groupDescriptor.SortDirection
          };
          sort.Insert(0, sortDescriptor);
          temporarySortDescriptors.Add(sortDescriptor);
        }));
      if (sort.Any<SortDescriptor>())
        source1 = source1.Sort((IEnumerable<SortDescriptor>) sort);
      IQueryable notPagedData = source1;
      if (!request.GroupPaging || !request.Groups.Any<GroupDescriptor>())
        source1 = source1.Page(request.Page - 1, request.PageSize);
      else if (request.GroupPaging && !request.Groups.Any<GroupDescriptor>())
        source1 = source1.Skip(request.Skip).Take(request.Take);
      if (groupDescriptorList.Any<GroupDescriptor>())
      {
        source1 = source1.GroupBy(notPagedData, (IEnumerable<GroupDescriptor>) groupDescriptorList, !request.GroupPaging);
        if (request.GroupPaging)
        {
          dataSourceResult.Total = source1.Count();
          source1 = source1.Skip(request.Skip).Take(request.Take);
        }
      }
      if (!request.IncludeSubGroupCount)
        dataSourceResult.Data = source1.Execute<TModel, TResult>(selector);
      if (modelState != null && !modelState.IsValid)
        dataSourceResult.Errors = modelState.SerializeErrors();
      temporarySortDescriptors.Each<SortDescriptor>((Action<SortDescriptor>) (sortDescriptor => sort.Remove(sortDescriptor)));
      return dataSourceResult;
    }

    private static Task<DataSourceResult> CreateDataSourceResultAsync(
      Func<DataSourceResult> expression)
    {
      return Task.Run<DataSourceResult>(expression);
    }

    private static Task<DataSourceResult> CreateDataSourceCancellableResultAsync(
      Func<DataSourceResult> expression,
      CancellationToken cancellationToken)
    {
      return Task.Run<DataSourceResult>(expression, cancellationToken);
    }

    private static IQueryable CallQueryableMethod(
      this IQueryable source,
      string methodName,
      LambdaExpression selector)
    {
      return source.Provider.CreateQuery((Expression) Expression.Call(typeof (Queryable), methodName, new Type[2]
      {
        source.ElementType,
        selector.Body.Type
      }, source.Expression, (Expression) Expression.Quote((Expression) selector)));
    }

    public static IQueryable Sort(
      this IQueryable source,
      IEnumerable<SortDescriptor> sortDescriptors)
    {
      return new SortDescriptorCollectionExpressionBuilder(source, sortDescriptors).Sort();
    }

    public static IQueryable Page(this IQueryable source, int pageIndex, int pageSize)
    {
      IQueryable source1 = source.Skip(pageIndex * pageSize);
      if (pageSize > 0)
        source1 = source1.Take(pageSize);
      return source1;
    }

    public static IQueryable Select(this IQueryable source, LambdaExpression selector) => source.CallQueryableMethod(nameof (Select), selector);

    public static IQueryable GroupBy(this IQueryable source, LambdaExpression keySelector) => source.CallQueryableMethod(nameof (GroupBy), keySelector);

    public static IQueryable OrderBy(this IQueryable source, LambdaExpression keySelector) => source.CallQueryableMethod(nameof (OrderBy), keySelector);

    public static IQueryable OrderByDescending(
      this IQueryable source,
      LambdaExpression keySelector)
    {
      return source.CallQueryableMethod(nameof (OrderByDescending), keySelector);
    }

    public static IQueryable OrderBy(
      this IQueryable source,
      LambdaExpression keySelector,
      ListSortDirection? sortDirection)
    {
      if (!sortDirection.HasValue)
        return source;
      return sortDirection.Value == ListSortDirection.Ascending ? source.OrderBy(keySelector) : source.OrderByDescending(keySelector);
    }

    public static IQueryable GroupBy(
      this IQueryable source,
      IEnumerable<GroupDescriptor> groupDescriptors,
      bool includeItems)
    {
      return source.GroupBy(source, groupDescriptors, includeItems);
    }

    public static IQueryable GroupBy(
      this IQueryable source,
      IQueryable notPagedData,
      IEnumerable<GroupDescriptor> groupDescriptors,
      bool includeItems)
    {
      GroupDescriptorCollectionExpressionBuilder expressionBuilder = new GroupDescriptorCollectionExpressionBuilder(source, groupDescriptors, notPagedData, includeItems);
      expressionBuilder.Options.LiftMemberAccessToNull = source.Provider.IsLinqToObjectsProvider();
      return expressionBuilder.CreateQuery();
    }

    public static AggregateResultCollection Aggregate(
      this IQueryable source,
      IEnumerable<AggregateFunction> aggregateFunctions)
    {
      List<AggregateFunction> list = aggregateFunctions.ToList<AggregateFunction>();
      if (list.Count > 0)
      {
        QueryableAggregatesExpressionBuilder expressionBuilder = new QueryableAggregatesExpressionBuilder(source, (IEnumerable<AggregateFunction>) list);
        expressionBuilder.Options.LiftMemberAccessToNull = source.Provider.IsLinqToObjectsProvider();
        IEnumerator enumerator = expressionBuilder.CreateQuery().GetEnumerator();
        try
        {
          if (enumerator.MoveNext())
            return ((AggregateFunctionsGroup) enumerator.Current).GetAggregateResults((IEnumerable<AggregateFunction>) list);
        }
        finally
        {
          if (enumerator is IDisposable disposable4)
            disposable4.Dispose();
        }
      }
      return new AggregateResultCollection();
    }

    public static IQueryable Where(this IQueryable source, Expression predicate) => source.Provider.CreateQuery((Expression) Expression.Call(typeof (Queryable), nameof (Where), new Type[1]
    {
      source.ElementType
    }, source.Expression, (Expression) Expression.Quote(predicate)));

    public static IQueryable Where(
      this IQueryable source,
      IEnumerable<IFilterDescriptor> filterDescriptors)
    {
      if (!filterDescriptors.Any<IFilterDescriptor>())
        return source;
      FilterDescriptorCollectionExpressionBuilder expressionBuilder = new FilterDescriptorCollectionExpressionBuilder(Expression.Parameter(source.ElementType, "item"), filterDescriptors);
      expressionBuilder.Options.LiftMemberAccessToNull = source.Provider.IsLinqToObjectsProvider();
      LambdaExpression filterExpression = expressionBuilder.CreateFilterExpression();
      return source.Where((Expression) filterExpression);
    }

    public static IQueryable Take(this IQueryable source, int count)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.Provider.CreateQuery((Expression) Expression.Call(typeof (Queryable), nameof (Take), new Type[1]
      {
        source.ElementType
      }, source.Expression, (Expression) Expression.Constant((object) count)));
    }

    public static IQueryable Skip(this IQueryable source, int count)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.Provider.CreateQuery((Expression) Expression.Call(typeof (Queryable), nameof (Skip), new Type[1]
      {
        source.ElementType
      }, source.Expression, (Expression) Expression.Constant((object) count)));
    }

    public static int Count(this IQueryable source)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      return source.Provider.Execute<int>((Expression) Expression.Call(typeof (Queryable), nameof (Count), new Type[1]
      {
        source.ElementType
      }, source.Expression));
    }

    public static object ElementAt(this IQueryable source, int index)
    {
      if (source == null)
        throw new ArgumentNullException(nameof (source));
      if (index < 0)
        throw new ArgumentOutOfRangeException(nameof (index));
      return source.Provider.Execute((Expression) Expression.Call(typeof (Queryable), nameof (ElementAt), new Type[1]
      {
        source.ElementType
      }, source.Expression, (Expression) Expression.Constant((object) index)));
    }

    public static IQueryable Union(this IQueryable source, IQueryable second) => source.Provider.CreateQuery((Expression) Expression.Call(typeof (Queryable), nameof (Union), new Type[1]
    {
      source.ElementType
    }, source.Expression, second.Expression));

    private static IEnumerable Execute<TModel, TResult>(
      this IQueryable source,
      Func<TModel, TResult> selector)
    {
      Type type = source != null ? source.ElementType : throw new ArgumentNullException(nameof (source));
      if (selector != null)
      {
        List<AggregateFunctionsGroup> aggregateFunctionsGroupList = new List<AggregateFunctionsGroup>();
        if (type == typeof (AggregateFunctionsGroup))
        {
          foreach (AggregateFunctionsGroup aggregateFunctionsGroup in (IEnumerable) source)
          {
            aggregateFunctionsGroup.Items = aggregateFunctionsGroup.Items.AsQueryable().Execute<TModel, TResult>(selector);
            aggregateFunctionsGroupList.Add(aggregateFunctionsGroup);
          }
          return (IEnumerable) aggregateFunctionsGroupList;
        }
        List<TResult> resultList = new List<TResult>();
        foreach (TModel model in (IEnumerable) source)
          resultList.Add(selector(model));
        return (IEnumerable) resultList;
      }
      IList instance = (IList) Activator.CreateInstance(typeof (List<>).MakeGenericType(type));
      foreach (object obj in (IEnumerable) source)
        instance.Add(obj);
      return (IEnumerable) instance;
    }

    public static TreeDataSourceResult ToTreeDataSourceResult(
      this IEnumerable enumerable,
      DataSourceRequest request)
    {
      return enumerable.AsQueryable().ToTreeDataSourceResult(request, (ModelStateDictionary) null);
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync(
      this IEnumerable enumerable,
      DataSourceRequest request)
    {
      return QueryableExtensions.CreateTreeDataSourceResultAsync((Func<TreeDataSourceResult>) (() => enumerable.ToTreeDataSourceResult(request)));
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync(
      this IEnumerable enumerable,
      DataSourceRequest request,
      CancellationToken cancellationToken)
    {
      return QueryableExtensions.CreateTreeDataSourceCancellableResultAsync((Func<TreeDataSourceResult>) (() => enumerable.ToTreeDataSourceResult(request)), cancellationToken);
    }

    public static TreeDataSourceResult ToTreeDataSourceResult(
      this IEnumerable enumerable,
      DataSourceRequest request,
      ModelStateDictionary modelState)
    {
      return enumerable.AsQueryable().CreateTreeDataSourceResult<object, object, object, object>(request, (Expression<Func<object, object>>) null, (Expression<Func<object, object>>) null, modelState, (Func<object, object>) null, (Expression<Func<object, bool>>) null);
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync(
      this IEnumerable enumerable,
      DataSourceRequest request,
      ModelStateDictionary modelState)
    {
      return QueryableExtensions.CreateTreeDataSourceResultAsync((Func<TreeDataSourceResult>) (() => enumerable.ToTreeDataSourceResult(request, modelState)));
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync(
      this IEnumerable enumerable,
      DataSourceRequest request,
      ModelStateDictionary modelState,
      CancellationToken cancellationToken)
    {
      return QueryableExtensions.CreateTreeDataSourceCancellableResultAsync((Func<TreeDataSourceResult>) (() => enumerable.ToTreeDataSourceResult(request, modelState)), cancellationToken);
    }

    public static TreeDataSourceResult ToTreeDataSourceResult<TModel, TResult>(
      this IQueryable<TModel> enumerable,
      DataSourceRequest request,
      Func<TModel, TResult> selector)
    {
      return QueryableExtensions.ToTreeDataSourceResult<TModel, object, object, TResult>(enumerable, request, (Expression<Func<TModel, object>>) null, (Expression<Func<TModel, object>>) null, selector);
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, TResult>(
      this IQueryable<TModel> queryable,
      DataSourceRequest request,
      Func<TModel, TResult> selector)
    {
      return QueryableExtensions.CreateTreeDataSourceResultAsync((Func<TreeDataSourceResult>) (() => queryable.ToTreeDataSourceResult<TModel, TResult>(request, selector)));
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, TResult>(
      this IQueryable<TModel> queryable,
      DataSourceRequest request,
      Func<TModel, TResult> selector,
      CancellationToken cancellationToken)
    {
      return QueryableExtensions.CreateTreeDataSourceCancellableResultAsync((Func<TreeDataSourceResult>) (() => queryable.ToTreeDataSourceResult<TModel, TResult>(request, selector)), cancellationToken);
    }

    public static TreeDataSourceResult ToTreeDataSourceResult<TModel, TResult>(
      this IEnumerable<TModel> enumerable,
      DataSourceRequest request,
      Func<TModel, TResult> selector)
    {
      return enumerable.ToTreeDataSourceResult<TModel, object, object, TResult>(request, (Expression<Func<TModel, object>>) null, (Expression<Func<TModel, object>>) null, selector);
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, TResult>(
      this IEnumerable<TModel> enumerable,
      DataSourceRequest request,
      Func<TModel, TResult> selector)
    {
      return QueryableExtensions.CreateTreeDataSourceResultAsync((Func<TreeDataSourceResult>) (() => enumerable.ToTreeDataSourceResult<TModel, TResult>(request, selector)));
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, TResult>(
      this IEnumerable<TModel> enumerable,
      DataSourceRequest request,
      Func<TModel, TResult> selector,
      CancellationToken cancellationToken)
    {
      return QueryableExtensions.CreateTreeDataSourceCancellableResultAsync((Func<TreeDataSourceResult>) (() => enumerable.ToTreeDataSourceResult<TModel, TResult>(request, selector)), cancellationToken);
    }

    public static TreeDataSourceResult ToTreeDataSourceResult<TModel, T1, T2>(
      this IQueryable<TModel> enumerable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector)
    {
      return enumerable.CreateTreeDataSourceResult<TModel, T1, T2, TModel>(request, idSelector, parentIDSelector, (ModelStateDictionary) null, (Func<TModel, TModel>) null, (Expression<Func<TModel, bool>>) null);
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, T1, T2>(
      this IQueryable<TModel> queryable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector)
    {
      return QueryableExtensions.CreateTreeDataSourceResultAsync((Func<TreeDataSourceResult>) (() => queryable.ToTreeDataSourceResult<TModel, T1, T2>(request, idSelector, parentIDSelector)));
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, T1, T2>(
      this IQueryable<TModel> queryable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      CancellationToken cancellationToken)
    {
      return QueryableExtensions.CreateTreeDataSourceCancellableResultAsync((Func<TreeDataSourceResult>) (() => queryable.ToTreeDataSourceResult<TModel, T1, T2>(request, idSelector, parentIDSelector)), cancellationToken);
    }

    public static TreeDataSourceResult ToTreeDataSourceResult<TModel, T1, T2>(
      this IQueryable<TModel> enumerable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      Expression<Func<TModel, bool>> rootSelector)
    {
      return enumerable.CreateTreeDataSourceResult<TModel, T1, T2, TModel>(request, idSelector, parentIDSelector, (ModelStateDictionary) null, (Func<TModel, TModel>) null, rootSelector);
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, T1, T2>(
      this IQueryable<TModel> queryable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      Expression<Func<TModel, bool>> rootSelector)
    {
      return QueryableExtensions.CreateTreeDataSourceResultAsync((Func<TreeDataSourceResult>) (() => queryable.ToTreeDataSourceResult<TModel, T1, T2>(request, idSelector, parentIDSelector, rootSelector)));
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, T1, T2>(
      this IQueryable<TModel> queryable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      Expression<Func<TModel, bool>> rootSelector,
      CancellationToken cancellationToken)
    {
      return QueryableExtensions.CreateTreeDataSourceCancellableResultAsync((Func<TreeDataSourceResult>) (() => queryable.ToTreeDataSourceResult<TModel, T1, T2>(request, idSelector, parentIDSelector, rootSelector)), cancellationToken);
    }

    public static TreeDataSourceResult ToTreeDataSourceResult<TModel, T1, T2, TResult>(
      this IQueryable<TModel> queryable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      Expression<Func<TModel, bool>> rootSelector,
      Func<TModel, TResult> selector)
    {
      return queryable.CreateTreeDataSourceResult<TModel, T1, T2, TResult>(request, idSelector, parentIDSelector, (ModelStateDictionary) null, selector, rootSelector);
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, T1, T2, TResult>(
      this IQueryable<TModel> queryable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      Expression<Func<TModel, bool>> rootSelector,
      Func<TModel, TResult> selector)
    {
      return QueryableExtensions.CreateTreeDataSourceResultAsync((Func<TreeDataSourceResult>) (() => queryable.ToTreeDataSourceResult<TModel, T1, T2, TResult>(request, idSelector, parentIDSelector, rootSelector, selector)));
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, T1, T2, TResult>(
      this IQueryable<TModel> queryable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      Expression<Func<TModel, bool>> rootSelector,
      Func<TModel, TResult> selector,
      CancellationToken cancellationToken)
    {
      return QueryableExtensions.CreateTreeDataSourceCancellableResultAsync((Func<TreeDataSourceResult>) (() => queryable.ToTreeDataSourceResult<TModel, T1, T2, TResult>(request, idSelector, parentIDSelector, rootSelector, selector)), cancellationToken);
    }

    public static TreeDataSourceResult ToTreeDataSourceResult<TModel, T1, T2>(
      this IQueryable<TModel> queryable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      ModelStateDictionary modelState)
    {
      return QueryableExtensions.ToTreeDataSourceResult<TModel, T1, T2, TModel>(queryable, request, idSelector, parentIDSelector, modelState, (Func<TModel, TModel>) null);
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, T1, T2>(
      this IQueryable<TModel> queryable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      ModelStateDictionary modelState)
    {
      return QueryableExtensions.CreateTreeDataSourceResultAsync((Func<TreeDataSourceResult>) (() => queryable.ToTreeDataSourceResult<TModel, T1, T2>(request, idSelector, parentIDSelector, modelState)));
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, T1, T2>(
      this IQueryable<TModel> queryable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      ModelStateDictionary modelState,
      CancellationToken cancellationToken)
    {
      return QueryableExtensions.CreateTreeDataSourceCancellableResultAsync((Func<TreeDataSourceResult>) (() => queryable.ToTreeDataSourceResult<TModel, T1, T2>(request, idSelector, parentIDSelector, modelState)), cancellationToken);
    }

    public static TreeDataSourceResult ToTreeDataSourceResult<TModel, T1, T2>(
      this IQueryable<TModel> enumerable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      Expression<Func<TModel, bool>> rootSelector,
      ModelStateDictionary modelState)
    {
      return enumerable.CreateTreeDataSourceResult<TModel, T1, T2, TModel>(request, idSelector, parentIDSelector, modelState, (Func<TModel, TModel>) null, rootSelector);
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, T1, T2>(
      this IQueryable<TModel> queryable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      Expression<Func<TModel, bool>> rootSelector,
      ModelStateDictionary modelState)
    {
      return QueryableExtensions.CreateTreeDataSourceResultAsync((Func<TreeDataSourceResult>) (() => queryable.ToTreeDataSourceResult<TModel, T1, T2>(request, idSelector, parentIDSelector, rootSelector, modelState)));
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, T1, T2>(
      this IQueryable<TModel> queryable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      Expression<Func<TModel, bool>> rootSelector,
      ModelStateDictionary modelState,
      CancellationToken cancellationToken)
    {
      return QueryableExtensions.CreateTreeDataSourceCancellableResultAsync((Func<TreeDataSourceResult>) (() => queryable.ToTreeDataSourceResult<TModel, T1, T2>(request, idSelector, parentIDSelector, rootSelector, modelState)), cancellationToken);
    }

    public static TreeDataSourceResult ToTreeDataSourceResult<TModel, T1, T2, TResult>(
      this IQueryable<TModel> queryable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      Func<TModel, TResult> selector)
    {
      return queryable.CreateTreeDataSourceResult<TModel, T1, T2, TResult>(request, idSelector, parentIDSelector, (ModelStateDictionary) null, selector, (Expression<Func<TModel, bool>>) null);
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, T1, T2, TResult>(
      this IQueryable<TModel> queryable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      Func<TModel, TResult> selector)
    {
      return QueryableExtensions.CreateTreeDataSourceResultAsync((Func<TreeDataSourceResult>) (() => queryable.ToTreeDataSourceResult<TModel, T1, T2, TResult>(request, idSelector, parentIDSelector, selector)));
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, T1, T2, TResult>(
      this IQueryable<TModel> queryable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      Func<TModel, TResult> selector,
      CancellationToken cancellationToken)
    {
      return QueryableExtensions.CreateTreeDataSourceCancellableResultAsync((Func<TreeDataSourceResult>) (() => queryable.ToTreeDataSourceResult<TModel, T1, T2, TResult>(request, idSelector, parentIDSelector, selector)), cancellationToken);
    }

    public static TreeDataSourceResult ToTreeDataSourceResult<TModel, T1, T2, TResult>(
      this IQueryable<TModel> queryable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      ModelStateDictionary modelState,
      Func<TModel, TResult> selector)
    {
      return queryable.CreateTreeDataSourceResult<TModel, T1, T2, TResult>(request, idSelector, parentIDSelector, modelState, selector, (Expression<Func<TModel, bool>>) null);
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, T1, T2, TResult>(
      this IQueryable<TModel> queryable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      ModelStateDictionary modelState,
      Func<TModel, TResult> selector)
    {
      return QueryableExtensions.CreateTreeDataSourceResultAsync((Func<TreeDataSourceResult>) (() => queryable.ToTreeDataSourceResult<TModel, T1, T2, TResult>(request, idSelector, parentIDSelector, modelState, selector)));
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, T1, T2, TResult>(
      this IQueryable<TModel> queryable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      ModelStateDictionary modelState,
      Func<TModel, TResult> selector,
      CancellationToken cancellationToken)
    {
      return QueryableExtensions.CreateTreeDataSourceCancellableResultAsync((Func<TreeDataSourceResult>) (() => queryable.ToTreeDataSourceResult<TModel, T1, T2, TResult>(request, idSelector, parentIDSelector, modelState, selector)), cancellationToken);
    }

    public static TreeDataSourceResult ToTreeDataSourceResult<TModel, T1, T2, TResult>(
      this IQueryable<TModel> queryable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      Expression<Func<TModel, bool>> rootSelector,
      ModelStateDictionary modelState,
      Func<TModel, TResult> selector)
    {
      return queryable.CreateTreeDataSourceResult<TModel, T1, T2, TResult>(request, idSelector, parentIDSelector, modelState, selector, rootSelector);
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, T1, T2, TResult>(
      this IQueryable<TModel> queryable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      Expression<Func<TModel, bool>> rootSelector,
      ModelStateDictionary modelState,
      Func<TModel, TResult> selector)
    {
      return QueryableExtensions.CreateTreeDataSourceResultAsync((Func<TreeDataSourceResult>) (() => queryable.ToTreeDataSourceResult<TModel, T1, T2, TResult>(request, idSelector, parentIDSelector, rootSelector, modelState, selector)));
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, T1, T2, TResult>(
      this IQueryable<TModel> queryable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      Expression<Func<TModel, bool>> rootSelector,
      ModelStateDictionary modelState,
      Func<TModel, TResult> selector,
      CancellationToken cancellationToken)
    {
      return QueryableExtensions.CreateTreeDataSourceCancellableResultAsync((Func<TreeDataSourceResult>) (() => queryable.ToTreeDataSourceResult<TModel, T1, T2, TResult>(request, idSelector, parentIDSelector, rootSelector, modelState, selector)), cancellationToken);
    }

    public static TreeDataSourceResult ToTreeDataSourceResult<TModel, T1, T2>(
      this IEnumerable<TModel> enumerable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector)
    {
      return enumerable.AsQueryable<TModel>().CreateTreeDataSourceResult<TModel, T1, T2, TModel>(request, idSelector, parentIDSelector, (ModelStateDictionary) null, (Func<TModel, TModel>) null, (Expression<Func<TModel, bool>>) null);
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, T1, T2>(
      this IEnumerable<TModel> enumerable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector)
    {
      return QueryableExtensions.CreateTreeDataSourceResultAsync((Func<TreeDataSourceResult>) (() => enumerable.ToTreeDataSourceResult<TModel, T1, T2>(request, idSelector, parentIDSelector)));
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, T1, T2>(
      this IEnumerable<TModel> enumerable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      CancellationToken cancellationToken)
    {
      return QueryableExtensions.CreateTreeDataSourceCancellableResultAsync((Func<TreeDataSourceResult>) (() => enumerable.ToTreeDataSourceResult<TModel, T1, T2>(request, idSelector, parentIDSelector)), cancellationToken);
    }

    public static TreeDataSourceResult ToTreeDataSourceResult<TModel, T1, T2>(
      this IEnumerable<TModel> enumerable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      Expression<Func<TModel, bool>> rootSelector)
    {
      return enumerable.AsQueryable<TModel>().CreateTreeDataSourceResult<TModel, T1, T2, TModel>(request, idSelector, parentIDSelector, (ModelStateDictionary) null, (Func<TModel, TModel>) null, rootSelector);
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, T1, T2>(
      this IEnumerable<TModel> enumerable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      Expression<Func<TModel, bool>> rootSelector)
    {
      return QueryableExtensions.CreateTreeDataSourceResultAsync((Func<TreeDataSourceResult>) (() => enumerable.ToTreeDataSourceResult<TModel, T1, T2>(request, idSelector, parentIDSelector, rootSelector)));
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, T1, T2>(
      this IEnumerable<TModel> enumerable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      Expression<Func<TModel, bool>> rootSelector,
      CancellationToken cancellationToken)
    {
      return QueryableExtensions.CreateTreeDataSourceCancellableResultAsync((Func<TreeDataSourceResult>) (() => enumerable.ToTreeDataSourceResult<TModel, T1, T2>(request, idSelector, parentIDSelector, rootSelector)), cancellationToken);
    }

    public static TreeDataSourceResult ToTreeDataSourceResult<TModel, T1, T2, TResult>(
      this IEnumerable<TModel> queryable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      Expression<Func<TModel, bool>> rootSelector,
      Func<TModel, TResult> selector)
    {
      return queryable.AsQueryable<TModel>().CreateTreeDataSourceResult<TModel, T1, T2, TResult>(request, idSelector, parentIDSelector, (ModelStateDictionary) null, selector, rootSelector);
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, T1, T2, TResult>(
      this IEnumerable<TModel> enumerable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      Expression<Func<TModel, bool>> rootSelector,
      Func<TModel, TResult> selector)
    {
      return QueryableExtensions.CreateTreeDataSourceResultAsync((Func<TreeDataSourceResult>) (() => enumerable.ToTreeDataSourceResult<TModel, T1, T2>(request, idSelector, parentIDSelector, rootSelector)));
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, T1, T2, TResult>(
      this IEnumerable<TModel> enumerable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      Expression<Func<TModel, bool>> rootSelector,
      Func<TModel, TResult> selector,
      CancellationToken cancellationToken)
    {
      return QueryableExtensions.CreateTreeDataSourceCancellableResultAsync((Func<TreeDataSourceResult>) (() => enumerable.ToTreeDataSourceResult<TModel, T1, T2>(request, idSelector, parentIDSelector, rootSelector)), cancellationToken);
    }

    public static TreeDataSourceResult ToTreeDataSourceResult<TModel, T1, T2>(
      this IEnumerable<TModel> queryable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      ModelStateDictionary modelState)
    {
      return QueryableExtensions.ToTreeDataSourceResult<TModel, T1, T2, TModel>(queryable.AsQueryable<TModel>(), request, idSelector, parentIDSelector, modelState, (Func<TModel, TModel>) null);
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, T1, T2>(
      this IEnumerable<TModel> enumerable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      ModelStateDictionary modelState)
    {
      return QueryableExtensions.CreateTreeDataSourceResultAsync((Func<TreeDataSourceResult>) (() => enumerable.ToTreeDataSourceResult<TModel, T1, T2>(request, idSelector, parentIDSelector, modelState)));
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, T1, T2>(
      this IEnumerable<TModel> enumerable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      ModelStateDictionary modelState,
      CancellationToken cancellationToken)
    {
      return QueryableExtensions.CreateTreeDataSourceCancellableResultAsync((Func<TreeDataSourceResult>) (() => enumerable.ToTreeDataSourceResult<TModel, T1, T2>(request, idSelector, parentIDSelector, modelState)), cancellationToken);
    }

    public static TreeDataSourceResult ToTreeDataSourceResult<TModel, T1, T2>(
      this IEnumerable<TModel> enumerable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      Expression<Func<TModel, bool>> rootSelector,
      ModelStateDictionary modelState)
    {
      return enumerable.AsQueryable<TModel>().CreateTreeDataSourceResult<TModel, T1, T2, TModel>(request, idSelector, parentIDSelector, modelState, (Func<TModel, TModel>) null, rootSelector);
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, T1, T2>(
      this IEnumerable<TModel> enumerable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      Expression<Func<TModel, bool>> rootSelector,
      ModelStateDictionary modelState)
    {
      return QueryableExtensions.CreateTreeDataSourceResultAsync((Func<TreeDataSourceResult>) (() => enumerable.ToTreeDataSourceResult<TModel, T1, T2>(request, idSelector, parentIDSelector, rootSelector, modelState)));
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, T1, T2>(
      this IEnumerable<TModel> enumerable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      Expression<Func<TModel, bool>> rootSelector,
      ModelStateDictionary modelState,
      CancellationToken cancellationToken)
    {
      return QueryableExtensions.CreateTreeDataSourceCancellableResultAsync((Func<TreeDataSourceResult>) (() => enumerable.ToTreeDataSourceResult<TModel, T1, T2>(request, idSelector, parentIDSelector, rootSelector, modelState)), cancellationToken);
    }

    public static TreeDataSourceResult ToTreeDataSourceResult<TModel, T1, T2, TResult>(
      this IEnumerable<TModel> queryable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      Func<TModel, TResult> selector)
    {
      return queryable.AsQueryable<TModel>().CreateTreeDataSourceResult<TModel, T1, T2, TResult>(request, idSelector, parentIDSelector, (ModelStateDictionary) null, selector, (Expression<Func<TModel, bool>>) null);
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, T1, T2, TResult>(
      this IEnumerable<TModel> enumerable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      Func<TModel, TResult> selector)
    {
      return QueryableExtensions.CreateTreeDataSourceResultAsync((Func<TreeDataSourceResult>) (() => enumerable.ToTreeDataSourceResult<TModel, T1, T2, TResult>(request, idSelector, parentIDSelector, selector)));
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, T1, T2, TResult>(
      this IEnumerable<TModel> enumerable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      Func<TModel, TResult> selector,
      CancellationToken cancellationToken)
    {
      return QueryableExtensions.CreateTreeDataSourceCancellableResultAsync((Func<TreeDataSourceResult>) (() => enumerable.ToTreeDataSourceResult<TModel, T1, T2, TResult>(request, idSelector, parentIDSelector, selector)), cancellationToken);
    }

    public static TreeDataSourceResult ToTreeDataSourceResult<TModel, T1, T2, TResult>(
      this IEnumerable<TModel> queryable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      ModelStateDictionary modelState,
      Func<TModel, TResult> selector)
    {
      return queryable.AsQueryable<TModel>().CreateTreeDataSourceResult<TModel, T1, T2, TResult>(request, idSelector, parentIDSelector, modelState, selector, (Expression<Func<TModel, bool>>) null);
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, T1, T2, TResult>(
      this IEnumerable<TModel> enumerable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      ModelStateDictionary modelState,
      Func<TModel, TResult> selector)
    {
      return QueryableExtensions.CreateTreeDataSourceResultAsync((Func<TreeDataSourceResult>) (() => enumerable.ToTreeDataSourceResult<TModel, T1, T2, TResult>(request, idSelector, parentIDSelector, modelState, selector)));
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, T1, T2, TResult>(
      this IEnumerable<TModel> enumerable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      ModelStateDictionary modelState,
      Func<TModel, TResult> selector,
      CancellationToken cancellationToken)
    {
      return QueryableExtensions.CreateTreeDataSourceCancellableResultAsync((Func<TreeDataSourceResult>) (() => enumerable.ToTreeDataSourceResult<TModel, T1, T2, TResult>(request, idSelector, parentIDSelector, modelState, selector)), cancellationToken);
    }

    public static TreeDataSourceResult ToTreeDataSourceResult<TModel, T1, T2, TResult>(
      this IEnumerable<TModel> queryable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      Expression<Func<TModel, bool>> rootSelector,
      ModelStateDictionary modelState,
      Func<TModel, TResult> selector)
    {
      return queryable.AsQueryable<TModel>().CreateTreeDataSourceResult<TModel, T1, T2, TResult>(request, idSelector, parentIDSelector, modelState, selector, rootSelector);
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, T1, T2, TResult>(
      this IEnumerable<TModel> enumerable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      Expression<Func<TModel, bool>> rootSelector,
      ModelStateDictionary modelState,
      Func<TModel, TResult> selector)
    {
      return QueryableExtensions.CreateTreeDataSourceResultAsync((Func<TreeDataSourceResult>) (() => enumerable.ToTreeDataSourceResult<TModel, T1, T2, TResult>(request, idSelector, parentIDSelector, rootSelector, modelState, selector)));
    }

    public static Task<TreeDataSourceResult> ToTreeDataSourceResultAsync<TModel, T1, T2, TResult>(
      this IEnumerable<TModel> enumerable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      Expression<Func<TModel, bool>> rootSelector,
      ModelStateDictionary modelState,
      Func<TModel, TResult> selector,
      CancellationToken cancellationToken)
    {
      return QueryableExtensions.CreateTreeDataSourceCancellableResultAsync((Func<TreeDataSourceResult>) (() => enumerable.ToTreeDataSourceResult<TModel, T1, T2, TResult>(request, idSelector, parentIDSelector, rootSelector, modelState, selector)), cancellationToken);
    }

    private static Task<TreeDataSourceResult> CreateTreeDataSourceResultAsync(
      Func<TreeDataSourceResult> expression)
    {
      return Task.Run<TreeDataSourceResult>(expression);
    }

    private static Task<TreeDataSourceResult> CreateTreeDataSourceCancellableResultAsync(
      Func<TreeDataSourceResult> expression,
      CancellationToken cancellationToken)
    {
      return Task.Run<TreeDataSourceResult>(expression, cancellationToken);
    }

    private static TreeDataSourceResult CreateTreeDataSourceResult<TModel, T1, T2, TResult>(
      this IQueryable queryable,
      DataSourceRequest request,
      Expression<Func<TModel, T1>> idSelector,
      Expression<Func<TModel, T2>> parentIDSelector,
      ModelStateDictionary modelState,
      Func<TModel, TResult> selector,
      Expression<Func<TModel, bool>> rootSelector)
    {
      TreeDataSourceResult dataSourceResult = new TreeDataSourceResult();
      IQueryable source1 = queryable;
      List<IFilterDescriptor> source2 = new List<IFilterDescriptor>();
      if (request.Filters != null)
        source2.AddRange((IEnumerable<IFilterDescriptor>) request.Filters);
      if (source2.Any<IFilterDescriptor>())
        source1 = source1.Where((IEnumerable<IFilterDescriptor>) source2).ParentsRecursive<TModel>(queryable, (LambdaExpression) idSelector, (LambdaExpression) parentIDSelector);
      IQueryable allData = source1;
      if (rootSelector != null)
        source1 = source1.Where((Expression) rootSelector);
      List<SortDescriptor> source3 = new List<SortDescriptor>();
      if (request.Sorts != null)
        source3.AddRange((IEnumerable<SortDescriptor>) request.Sorts);
      List<AggregateDescriptor> aggregateDescriptorList = new List<AggregateDescriptor>();
      if (request.Aggregates != null)
        aggregateDescriptorList.AddRange((IEnumerable<AggregateDescriptor>) request.Aggregates);
      if (aggregateDescriptorList.Any<AggregateDescriptor>())
      {
        foreach (IGrouping<T2, TModel> data in (IEnumerable) source1.GroupBy((LambdaExpression) parentIDSelector))
          dataSourceResult.AggregateResults.Add(Convert.ToString((object) data.Key), data.AggregateForLevel<TModel, T1, T2>(allData, aggregateDescriptorList, idSelector, parentIDSelector));
      }
      dataSourceResult.Total = source1.Count();
      if (source3.Any<SortDescriptor>())
        source1 = source1.Sort((IEnumerable<SortDescriptor>) source3);
      dataSourceResult.Data = source1.Execute<TModel, TResult>(selector);
      if (modelState != null && !modelState.IsValid)
        dataSourceResult.Errors = modelState.SerializeErrors();
      return dataSourceResult;
    }
  }
}
