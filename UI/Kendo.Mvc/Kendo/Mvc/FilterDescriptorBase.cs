// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.FilterDescriptorBase
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Infrastructure.Implementation.Expressions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Kendo.Mvc
{
  public class FilterDescriptorBase : JsonObject, IFilterDescriptor
  {
    private ExpressionBuilderOptions options;

    public virtual Expression CreateFilterExpression(Expression instance) => instance is ParameterExpression parameterExpression ? this.CreateFilterExpression(parameterExpression) : throw new ArgumentException("Parameter should be of type ParameterExpression", nameof (instance));

    protected virtual Expression CreateFilterExpression(
      ParameterExpression parameterExpression)
    {
      return (Expression) parameterExpression;
    }

    internal ExpressionBuilderOptions ExpressionBuilderOptions
    {
      get
      {
        if (this.options == null)
          this.options = new ExpressionBuilderOptions();
        return this.options;
      }
    }

    protected override void Serialize(IDictionary<string, object> json)
    {
    }
  }
}
