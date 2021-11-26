// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.Implementation.Expressions.EnumerableAggregateFunctionExpressionBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Linq.Expressions;

namespace Kendo.Mvc.Infrastructure.Implementation.Expressions
{
  internal class EnumerableAggregateFunctionExpressionBuilder : 
    AggregateFunctionExpressionBuilderBase
  {
    protected EnumerableAggregateFunction Function => (EnumerableAggregateFunction) base.Function;

    public EnumerableAggregateFunctionExpressionBuilder(
      Expression enumerableExpression,
      EnumerableAggregateFunction function)
      : base(enumerableExpression, (AggregateFunction) function)
    {
    }

    public override Expression CreateAggregateExpression() => (Expression) Expression.Call(this.Function.ExtensionMethodsType, this.Function.AggregateMethodName, new Type[1]
    {
      this.ItemType
    }, this.EnumerableExpression);
  }
}
