// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SignalRDataSourceBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class SignalRDataSourceBuilder<TModel> : 
    SignalRDataSourceBuilderBase<SignalRDataSourceBuilder<TModel>>,
    IHideObjectMembers
    where TModel : class
  {
    public SignalRDataSourceBuilder(DataSource dataSource)
      : base(dataSource)
    {
    }

    public SignalRDataSourceBuilder<TModel> Transport(
      Action<SignalRDataSourceTransportBuilder> configurator)
    {
      configurator(new SignalRDataSourceTransportBuilder(this.dataSource.Transport));
      return this;
    }

    public SignalRDataSourceBuilder<TModel> Schema(
      Action<CustomDataSourceSchemaBuilder<TModel>> configurator)
    {
      configurator(new CustomDataSourceSchemaBuilder<TModel>(this.dataSource.Schema));
      return this;
    }

    public virtual SignalRDataSourceBuilder<TModel> Sort(
      Action<DataSourceSortDescriptorFactory<TModel>> configurator)
    {
      configurator(new DataSourceSortDescriptorFactory<TModel>(this.dataSource.OrderBy));
      return this;
    }

    public virtual SignalRDataSourceBuilder<TModel> Group(
      Action<DataSourceGroupDescriptorFactory<TModel>> configurator)
    {
      configurator(new DataSourceGroupDescriptorFactory<TModel>(this.dataSource.Groups));
      return this;
    }

    public virtual SignalRDataSourceBuilder<TModel> Aggregates(
      Action<DataSourceAggregateDescriptorFactory<TModel>> aggregates)
    {
      aggregates(new DataSourceAggregateDescriptorFactory<TModel>(this.dataSource.Aggregates));
      return this;
    }

    public virtual SignalRDataSourceBuilder<TModel> Filter(
      Action<DataSourceFilterDescriptorFactory<TModel>> configurator)
    {
      configurator(new DataSourceFilterDescriptorFactory<TModel>(this.dataSource.Filters));
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
