// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.Implementation.Expressions.AggregateFunctionExpressionBuilderBase
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Kendo.Mvc.Infrastructure.Implementation.Expressions
{
  internal abstract class AggregateFunctionExpressionBuilderBase : ExpressionBuilderBase
  {
    private readonly AggregateFunction function;
    private readonly Expression enumerableExpression;

    protected AggregateFunction Function => this.function;

    protected Expression EnumerableExpression => this.enumerableExpression;

    protected AggregateFunctionExpressionBuilderBase(
      Expression enumerableExpression,
      AggregateFunction function)
      : base(AggregateFunctionExpressionBuilderBase.ExtractItemTypeFromEnumerableType(enumerableExpression.Type))
    {
      this.enumerableExpression = enumerableExpression;
      this.function = function;
    }

    public abstract Expression CreateAggregateExpression();

    private static Type ExtractItemTypeFromEnumerableType(Type type)
    {
      Type genericType = type.FindGenericType(typeof (IEnumerable<>));
      return !(genericType == (Type) null) ? ((IEnumerable<Type>) genericType.GenericTypeArguments).First<Type>() : throw new ArgumentException("Provided type is not IEnumerable<>", nameof (type));
    }
  }
}
