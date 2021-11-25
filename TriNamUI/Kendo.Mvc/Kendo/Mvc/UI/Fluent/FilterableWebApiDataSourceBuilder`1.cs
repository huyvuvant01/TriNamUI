// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FilterableWebApiDataSourceBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel;

namespace Kendo.Mvc.UI.Fluent
{
  public class FilterableWebApiDataSourceBuilder<TModel> : 
    WebApiDataSourceBuilder<TModel>,
    IHideObjectMembers
    where TModel : class
  {
    public FilterableWebApiDataSourceBuilder(
      DataSource dataSource,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
      : base(dataSource, viewContext, urlGenerator)
    {
    }

    public override WebApiDataSourceBuilder<TModel> Filter(
      Action<DataSourceFilterDescriptorFactory<TModel>> configurator)
    {
      configurator((DataSourceFilterDescriptorFactory<TModel>) new DataSourceSchedulerFilterDescriptorFactory<TModel>(this.dataSource.Filters));
      return (WebApiDataSourceBuilder<TModel>) this;
    }

    public WebApiDataSourceBuilder<TModel> Model(
      Action<DataSourceSchedulerModelDescriptorFactory<TModel>> configurator)
    {
      configurator(new DataSourceSchedulerModelDescriptorFactory<TModel>((SchedulerModelDescriptor) this.dataSource.Schema.Model));
      return (WebApiDataSourceBuilder<TModel>) this;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override WebApiDataSourceBuilder<TModel> Sort(
      Action<DataSourceSortDescriptorFactory<TModel>> configurator)
    {
      throw new MethodAccessException("Sort method is not available for Scheduler DataSource.");
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override WebApiDataSourceBuilder<TModel> Group(
      Action<DataSourceGroupDescriptorFactory<TModel>> configurator)
    {
      throw new MethodAccessException("Group method is not available for Scheduler DataSource.");
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override WebApiDataSourceBuilder<TModel> Aggregates(
      Action<DataSourceAggregateDescriptorFactory<TModel>> aggregates)
    {
      throw new MethodAccessException("Aggregates method is not available for Scheduler DataSource.");
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
