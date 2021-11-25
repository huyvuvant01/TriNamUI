// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.Implementation.Expressions.QueryableAggregatesExpressionBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


#nullable enable
namespace Kendo.Mvc.Infrastructure.Implementation.Expressions
{
  public class QueryableAggregatesExpressionBuilder : GroupDescriptorExpressionBuilder
  {
    public QueryableAggregatesExpressionBuilder(

      #nullable disable
      IQueryable queryable,
      IEnumerable<AggregateFunction> aggregateFunctions)
      : base(queryable, QueryableAggregatesExpressionBuilder.CreateDescriptor(aggregateFunctions))
    {
    }

    private static GroupDescriptor CreateDescriptor(
      IEnumerable<AggregateFunction> aggregateFunctions)
    {
      GroupDescriptor groupDescriptor = new GroupDescriptor();
      groupDescriptor.AggregateFunctions.AddRange<AggregateFunction>(aggregateFunctions);
      return groupDescriptor;
    }

    protected override LambdaExpression CreateGroupByExpression() => Expression.Lambda((Expression) Expression.Constant((object) 1), this.ParameterExpression);

    protected override IEnumerable<MemberBinding> CreateMemberBindings()
    {
      QueryableAggregatesExpressionBuilder expressionBuilder = this;
      yield return expressionBuilder.CreateKeyMemberBinding();
      yield return expressionBuilder.CreateCountMemberBinding();
      yield return expressionBuilder.CreateHasSubgroupsMemberBinding();
      if (expressionBuilder.GroupDescriptor.AggregateFunctions.Count > 0)
        yield return expressionBuilder.CreateAggregateFunctionsProjectionMemberBinding();
      yield return expressionBuilder.CreateFieldNameMemberBinding();
    }
  }
}
