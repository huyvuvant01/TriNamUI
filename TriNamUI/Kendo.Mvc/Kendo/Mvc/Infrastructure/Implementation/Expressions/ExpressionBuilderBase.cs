// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.Implementation.Expressions.ExpressionBuilderBase
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Linq.Expressions;

namespace Kendo.Mvc.Infrastructure.Implementation.Expressions
{
  public abstract class ExpressionBuilderBase
  {
    private readonly ExpressionBuilderOptions options;
    private readonly Type itemType;
    private ParameterExpression parameterExpression;

    protected ExpressionBuilderBase(Type itemType)
    {
      this.itemType = itemType;
      this.options = new ExpressionBuilderOptions();
    }

    public ExpressionBuilderOptions Options => this.options;

    protected internal Type ItemType => this.itemType;

    public ParameterExpression ParameterExpression
    {
      get
      {
        if (this.parameterExpression == null)
          this.parameterExpression = Expression.Parameter(this.ItemType, "item");
        return this.parameterExpression;
      }
      set => this.parameterExpression = value;
    }
  }
}
