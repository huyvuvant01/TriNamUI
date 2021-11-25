// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.Implementation.Expressions.FilterDescriptorCollectionExpressionBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Linq.Expressions;

namespace Kendo.Mvc.Infrastructure.Implementation.Expressions
{
  public class FilterDescriptorCollectionExpressionBuilder : FilterExpressionBuilder
  {
    private readonly IEnumerable<IFilterDescriptor> filterDescriptors;
    private readonly FilterCompositionLogicalOperator logicalOperator;

    public FilterDescriptorCollectionExpressionBuilder(
      ParameterExpression parameterExpression,
      IEnumerable<IFilterDescriptor> filterDescriptors)
      : this(parameterExpression, filterDescriptors, FilterCompositionLogicalOperator.And)
    {
    }

    public FilterDescriptorCollectionExpressionBuilder(
      ParameterExpression parameterExpression,
      IEnumerable<IFilterDescriptor> filterDescriptors,
      FilterCompositionLogicalOperator logicalOperator)
      : base(parameterExpression)
    {
      this.filterDescriptors = filterDescriptors;
      this.logicalOperator = logicalOperator;
    }

    public override Expression CreateBodyExpression()
    {
      Expression left = (Expression) null;
      foreach (IFilterDescriptor filterDescriptor in this.filterDescriptors)
      {
        this.InitilializeExpressionBuilderOptions(filterDescriptor);
        Expression filterExpression = filterDescriptor.CreateFilterExpression((Expression) this.ParameterExpression);
        left = left != null ? FilterDescriptorCollectionExpressionBuilder.ComposeExpressions(left, filterExpression, this.logicalOperator) : filterExpression;
      }
      return left ?? ExpressionConstants.TrueLiteral;
    }

    private static Expression ComposeExpressions(
      Expression left,
      Expression right,
      FilterCompositionLogicalOperator logicalOperator)
    {
      return logicalOperator != FilterCompositionLogicalOperator.And && logicalOperator == FilterCompositionLogicalOperator.Or ? (Expression) Expression.OrElse(left, right) : (Expression) Expression.AndAlso(left, right);
    }

    private void InitilializeExpressionBuilderOptions(IFilterDescriptor filterDescriptor)
    {
      if (!(filterDescriptor is FilterDescriptorBase filterDescriptorBase))
        return;
      filterDescriptorBase.ExpressionBuilderOptions.CopyFrom(this.Options);
    }
  }
}
