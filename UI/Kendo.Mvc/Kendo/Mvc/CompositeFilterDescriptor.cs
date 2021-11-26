// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.CompositeFilterDescriptor
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Infrastructure.Implementation;
using Kendo.Mvc.Infrastructure.Implementation.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Kendo.Mvc
{
  public class CompositeFilterDescriptor : FilterDescriptorBase
  {
    private FilterDescriptorCollection filterDescriptors;

    public FilterCompositionLogicalOperator LogicalOperator { get; set; }

    public FilterDescriptorCollection FilterDescriptors
    {
      get
      {
        if (this.filterDescriptors == null)
          this.SetFilterDescriptors(new FilterDescriptorCollection());
        return this.filterDescriptors;
      }
      set
      {
        if (this.filterDescriptors == value)
          return;
        this.SetFilterDescriptors(value);
      }
    }

    protected override Expression CreateFilterExpression(
      ParameterExpression parameterExpression)
    {
      FilterDescriptorCollectionExpressionBuilder expressionBuilder = new FilterDescriptorCollectionExpressionBuilder(parameterExpression, (IEnumerable<IFilterDescriptor>) this.FilterDescriptors, this.LogicalOperator);
      expressionBuilder.Options.CopyFrom(this.ExpressionBuilderOptions);
      return expressionBuilder.CreateBodyExpression();
    }

    private void SetFilterDescriptors(FilterDescriptorCollection value)
    {
      FilterDescriptorCollection filterDescriptors = this.filterDescriptors;
      this.filterDescriptors = value;
    }

    protected override void Serialize(IDictionary<string, object> json)
    {
      base.Serialize(json);
      json["logic"] = (object) this.LogicalOperator.ToString().ToLowerInvariant();
      if (!this.FilterDescriptors.Any<IFilterDescriptor>())
        return;
      json["filters"] = (object) this.FilterDescriptors.OfType<JsonObject>().ToJson();
    }
  }
}
