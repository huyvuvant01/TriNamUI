// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.CustomDataSourceBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class CustomDataSourceBuilder<TModel> : 
    CustomDataSourceBuilderBase<CustomDataSourceBuilder<TModel>>,
    IHideObjectMembers
    where TModel : class
  {
    public CustomDataSourceBuilder(
      DataSource dataSource,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
      : base(dataSource, viewContext, urlGenerator)
    {
    }

    public CustomDataSourceBuilder<TModel> Transport(
      Action<CustomDataSourceTransportBuilder> configurator)
    {
      configurator(new CustomDataSourceTransportBuilder(this.dataSource.Transport, this.viewContext, this.urlGenerator));
      return this;
    }

    public CustomDataSourceBuilder<TModel> Schema(
      Action<CustomDataSourceSchemaBuilder<TModel>> configurator)
    {
      configurator(new CustomDataSourceSchemaBuilder<TModel>(this.dataSource.Schema));
      return this;
    }

    public virtual CustomDataSourceBuilder<TModel> Sort(
      Action<DataSourceSortDescriptorFactory<TModel>> configurator)
    {
      configurator(new DataSourceSortDescriptorFactory<TModel>(this.dataSource.OrderBy));
      return this;
    }

    public virtual CustomDataSourceBuilder<TModel> Group(
      Action<DataSourceGroupDescriptorFactory<TModel>> configurator)
    {
      configurator(new DataSourceGroupDescriptorFactory<TModel>(this.dataSource.Groups));
      return this;
    }

    public virtual CustomDataSourceBuilder<TModel> Aggregates(
      Action<DataSourceAggregateDescriptorFactory<TModel>> aggregates)
    {
      aggregates(new DataSourceAggregateDescriptorFactory<TModel>(this.dataSource.Aggregates));
      return this;
    }

    public virtual CustomDataSourceBuilder<TModel> Filter(
      Action<DataSourceFilterDescriptorFactory<TModel>> configurator)
    {
      configurator(new DataSourceFilterDescriptorFactory<TModel>(this.dataSource.Filters));
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
