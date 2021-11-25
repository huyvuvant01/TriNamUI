// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FilterBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class FilterBuilder<T> : WidgetBuilderBase<Filter<T>, FilterBuilder<T>>
    where T : class
  {
    public FilterBuilder(Filter<T> component)
      : base(component)
    {
    }

    public FilterBuilder<T> FilterExpression(
      Action<DataSourceFilterDescriptorFactory<T>> configurator)
    {
      this.Container.Expression = new CompositeFilterDescriptor();
      this.Container.Expression.LogicalOperator = this.Container.MainLogic;
      IList<IFilterDescriptor> filters = (IList<IFilterDescriptor>) new List<IFilterDescriptor>();
      configurator(new DataSourceFilterDescriptorFactory<T>(filters));
      foreach (CompositeFilterDescriptor filterDescriptor in (IEnumerable<IFilterDescriptor>) filters)
      {
        if (filterDescriptor.FilterDescriptors.Count > 1)
          this.Container.Expression.FilterDescriptors.Add((IFilterDescriptor) filterDescriptor);
        else
          this.Container.Expression.FilterDescriptors.Add(filterDescriptor.FilterDescriptors[0]);
      }
      return this;
    }

    public FilterBuilder<T> FilterExpression(CompositeFilterDescriptor value)
    {
      this.Container.Expression = value;
      return this;
    }

    public FilterBuilder<T> Operators(
      Action<FilterOperatorsSettingsBuilder<T>> configurator)
    {
      this.Container.Operators.Filter = this.Container;
      configurator(new FilterOperatorsSettingsBuilder<T>(this.Container.Operators));
      return this;
    }

    public FilterBuilder<T> ApplyButton(bool value)
    {
      this.Container.ApplyButton = new bool?(value);
      return this;
    }

    public FilterBuilder<T> ApplyButton()
    {
      this.Container.ApplyButton = new bool?(true);
      return this;
    }

    public FilterBuilder<T> DataSource(string value)
    {
      this.Container.DataSource = value;
      return this;
    }

    public FilterBuilder<T> ExpressionPreview(bool value)
    {
      this.Container.ExpressionPreview = new bool?(value);
      return this;
    }

    public FilterBuilder<T> ExpressionPreview()
    {
      this.Container.ExpressionPreview = new bool?(true);
      return this;
    }

    public FilterBuilder<T> Fields(Action<FilterFieldFactory<T>> configurator)
    {
      configurator(new FilterFieldFactory<T>(this.Container.Fields)
      {
        Filter = this.Container
      });
      return this;
    }

    public FilterBuilder<T> MainLogic(FilterCompositionLogicalOperator value)
    {
      this.Container.MainLogic = value;
      return this;
    }

    public FilterBuilder<T> Messages(
      Action<FilterMessagesSettingsBuilder<T>> configurator)
    {
      this.Container.Messages.Filter = this.Container;
      configurator(new FilterMessagesSettingsBuilder<T>(this.Container.Messages));
      return this;
    }

    public FilterBuilder<T> Events(Action<FilterEventBuilder> configurator)
    {
      configurator(new FilterEventBuilder(this.Container.Events));
      return this;
    }
  }
}
