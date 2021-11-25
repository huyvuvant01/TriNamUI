// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.ExpressionBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Infrastructure.Implementation.Expressions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Kendo.Mvc
{
  public static class ExpressionBuilder
  {
    public static System.Linq.Expressions.Expression<Func<TModel, TValue>> Expression<TModel, TValue>(
      string memberName)
    {
      return (System.Linq.Expressions.Expression<Func<TModel, TValue>>) ExpressionBuilder.Lambda<TModel>(memberName);
    }

    public static LambdaExpression Lambda<T>(string memberName) => ExpressionBuilder.Lambda<T>(memberName, false);

    public static LambdaExpression Lambda<T>(
      Type memberType,
      string memberName,
      bool checkForNull)
    {
      return ExpressionBuilderFactory.MemberAccess(typeof (T), memberType, memberName, checkForNull).CreateLambdaExpression();
    }

    public static LambdaExpression Lambda<T>(string memberName, bool checkForNull) => ExpressionBuilderFactory.MemberAccess(typeof (T), memberName, checkForNull).CreateLambdaExpression();

    public static System.Linq.Expressions.Expression<Func<T, bool>> Expression<T>(
      IList<IFilterDescriptor> filterDescriptors)
    {
      return ExpressionBuilder.Expression<T>(filterDescriptors, true);
    }

    public static System.Linq.Expressions.Expression<Func<T, bool>> Expression<T>(
      IList<IFilterDescriptor> filterDescriptors,
      bool checkForNull)
    {
      FilterDescriptorCollectionExpressionBuilder expressionBuilder = new FilterDescriptorCollectionExpressionBuilder(System.Linq.Expressions.Expression.Parameter(typeof (T), "item"), (IEnumerable<IFilterDescriptor>) filterDescriptors);
      expressionBuilder.Options.LiftMemberAccessToNull = checkForNull;
      return (System.Linq.Expressions.Expression<Func<T, bool>>) expressionBuilder.CreateFilterExpression();
    }
  }
}
