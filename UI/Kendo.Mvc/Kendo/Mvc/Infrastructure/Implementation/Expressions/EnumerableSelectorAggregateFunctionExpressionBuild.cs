// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.Implementation.Expressions.EnumerableSelectorAggregateFunctionExpressionBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;


#nullable enable
namespace Kendo.Mvc.Infrastructure.Implementation.Expressions
{
  internal class EnumerableSelectorAggregateFunctionExpressionBuilder : 
    AggregateFunctionExpressionBuilderBase
  {
    protected 
    #nullable disable
    EnumerableSelectorAggregateFunction Function => (EnumerableSelectorAggregateFunction) base.Function;

    public EnumerableSelectorAggregateFunctionExpressionBuilder(
      Expression enumerableExpression,
      EnumerableSelectorAggregateFunction function)
      : base(enumerableExpression, (AggregateFunction) function)
    {
    }

    public override Expression CreateAggregateExpression() => this.CreateMethodCallExpression(this.CreateMemberSelectorExpression());

    private LambdaExpression CreateMemberSelectorExpression()
    {
      MemberAccessExpressionBuilderBase expressionBuilderBase = ExpressionBuilderFactory.MemberAccess(this.ItemType, (Type) null, this.Function.SourceField);
      expressionBuilderBase.Options.CopyFrom(this.Options);
      return Expression.Lambda(this.ConvertMemberAccessExpression(expressionBuilderBase.CreateMemberAccessExpression()), expressionBuilderBase.ParameterExpression);
    }

    private Expression CreateMethodCallExpression(
      LambdaExpression memberSelectorExpression)
    {
      return (Expression) Expression.Call(this.Function.ExtensionMethodsType, this.Function.AggregateMethodName, this.GetMethodArgumentsTypes(memberSelectorExpression).ToArray<Type>(), this.EnumerableExpression, (Expression) memberSelectorExpression);
    }

    private IEnumerable<Type> GetMethodArgumentsTypes(
      LambdaExpression memberSelectorExpression)
    {
      yield return this.ItemType;
      if (!memberSelectorExpression.Body.Type.IsNumericType())
        yield return memberSelectorExpression.Body.Type;
    }

    private Expression ConvertMemberAccessExpression(Expression memberExpression)
    {
      if (this.ItemType.IsDynamicObject() && this.Function.MemberType != (Type) null)
        memberExpression = (Expression) Expression.Convert(memberExpression, this.Function.MemberType);
      if (this.ItemType == typeof (DataRowView) && this.Function.MemberType != (Type) null)
        memberExpression = (Expression) Expression.Convert(memberExpression, this.Function.MemberType);
      if (EnumerableSelectorAggregateFunctionExpressionBuilder.ShouldConvertTypeToInteger(memberExpression.Type.GetNonNullableType()))
        memberExpression = EnumerableSelectorAggregateFunctionExpressionBuilder.ConvertMemberExpressionToInteger(memberExpression);
      return memberExpression;
    }

    private static Expression ConvertMemberExpressionToInteger(Expression expression)
    {
      Type type = expression.Type.IsNullableType() ? typeof (int?) : typeof (int);
      return (Expression) Expression.Convert(expression, type);
    }

    private static bool ShouldConvertTypeToInteger(Type type) => type == typeof (sbyte) || type == typeof (short) || type == typeof (byte) || type == typeof (ushort);
  }
}
