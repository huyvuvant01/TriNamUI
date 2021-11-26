// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FilterableCustomDataSourceBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel;

namespace Kendo.Mvc.UI.Fluent
{
  public class FilterableCustomDataSourceBuilder<TModel> : CustomDataSourceBuilder<TModel>
    where TModel : class
  {
    public FilterableCustomDataSourceBuilder(
      DataSource dataSource,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
      : base(dataSource, viewContext, urlGenerator)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override CustomDataSourceBuilder<TModel> Sort(
      Action<DataSourceSortDescriptorFactory<TModel>> configurator)
    {
      throw new MethodAccessException("Sort method is not available for Scheduler DataSource.");
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override CustomDataSourceBuilder<TModel> Group(
      Action<DataSourceGroupDescriptorFactory<TModel>> configurator)
    {
      throw new MethodAccessException("Group method is not available for Scheduler DataSource.");
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override CustomDataSourceBuilder<TModel> Aggregates(
      Action<DataSourceAggregateDescriptorFactory<TModel>> aggregates)
    {
      throw new MethodAccessException("Aggregates method is not available for Scheduler DataSource.");
    }
  }
}
