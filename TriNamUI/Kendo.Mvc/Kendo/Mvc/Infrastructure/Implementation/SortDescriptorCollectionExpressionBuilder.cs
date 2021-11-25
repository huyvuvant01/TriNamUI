// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.Implementation.SortDescriptorCollectionExpressionBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Infrastructure.Implementation.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Kendo.Mvc.Infrastructure.Implementation
{
  internal class SortDescriptorCollectionExpressionBuilder
  {
    private readonly IEnumerable<SortDescriptor> sortDescriptors;
    private readonly IQueryable queryable;

    public SortDescriptorCollectionExpressionBuilder(
      IQueryable queryable,
      IEnumerable<SortDescriptor> sortDescriptors)
    {
      this.queryable = queryable;
      this.sortDescriptors = sortDescriptors;
    }

    public IQueryable Sort()
    {
      IQueryable queryable = this.queryable;
      bool flag = true;
      foreach (SortDescriptor sortDescriptor in this.sortDescriptors)
      {
        LambdaExpression lambdaExpression = ExpressionBuilderFactory.MemberAccess(this.queryable, typeof (object), sortDescriptor.Member).CreateLambdaExpression();
        string methodName;
        if (flag)
        {
          methodName = sortDescriptor.SortDirection == ListSortDirection.Ascending ? "OrderBy" : "OrderByDescending";
          flag = false;
        }
        else
          methodName = sortDescriptor.SortDirection == ListSortDirection.Ascending ? "ThenBy" : "ThenByDescending";
        queryable = queryable.Provider.CreateQuery((Expression) Expression.Call(typeof (Queryable), methodName, new Type[2]
        {
          queryable.ElementType,
          lambdaExpression.Body.Type
        }, queryable.Expression, (Expression) Expression.Quote((Expression) lambdaExpression)));
      }
      return queryable;
    }
  }
}
