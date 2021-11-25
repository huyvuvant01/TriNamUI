// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.Implementation.Expressions.FilterDescriptionExpressionBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Kendo.Mvc.Infrastructure.Implementation.Expressions
{
  public class FilterDescriptionExpressionBuilder : FilterExpressionBuilder
  {
    private readonly FilterDescription filterDescription;

    public FilterDescription FilterDescription => this.filterDescription;

    public FilterDescriptionExpressionBuilder(
      ParameterExpression parameterExpression,
      FilterDescription filterDescription)
      : base(parameterExpression)
    {
      this.filterDescription = filterDescription;
    }

    public override Expression CreateBodyExpression() => this.filterDescription.IsActive ? this.CreateActiveFilterExpression() : ExpressionConstants.TrueLiteral;

    protected virtual Expression CreateActiveFilterExpression() => (Expression) this.CreateSatisfiesFilterExpression();

    private MethodCallExpression CreateSatisfiesFilterExpression()
    {
      Expression expression = (Expression) this.ParameterExpression;
      if (expression.Type.IsValueType())
        expression = (Expression) Expression.Convert(expression, typeof (object));
      return Expression.Call(this.FilterDescriptionExpression, this.SatisfiesFilterMethodInfo, expression);
    }

    private Expression FilterDescriptionExpression => (Expression) Expression.Constant((object) this.filterDescription);

    private MethodInfo SatisfiesFilterMethodInfo => this.filterDescription.GetType().GetMethod("SatisfiesFilter", new Type[1]
    {
      typeof (object)
    });
  }
}
