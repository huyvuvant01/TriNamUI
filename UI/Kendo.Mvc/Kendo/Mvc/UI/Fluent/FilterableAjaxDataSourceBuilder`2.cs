// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FilterableAjaxDataSourceBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel;

namespace Kendo.Mvc.UI.Fluent
{
  public class FilterableAjaxDataSourceBuilder<TModel, TDataSourceBuilder> : 
    AjaxDataSourceBuilderBase<TModel, TDataSourceBuilder>,
    IHideObjectMembers
    where TModel : class
    where TDataSourceBuilder : FilterableAjaxDataSourceBuilder<TModel, TDataSourceBuilder>
  {
    public FilterableAjaxDataSourceBuilder(
      DataSource dataSource,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
      : base(dataSource, viewContext, urlGenerator)
    {
    }

    public FilterableWebApiDataSourceBuilder<TModel> WebApi()
    {
      this.dataSource.Type = new DataSourceType?(DataSourceType.WebApi);
      return new FilterableWebApiDataSourceBuilder<TModel>(this.dataSource, this.viewContext, this.urlGenerator);
    }

    public FilterableCustomDataSourceBuilder<TModel> Custom()
    {
      this.dataSource.Type = new DataSourceType?(DataSourceType.Custom);
      this.dataSource.Schema.Model = new ModelDescriptor(typeof (TModel), this.dataSource.ModelMetaDataProvider);
      return new FilterableCustomDataSourceBuilder<TModel>(this.dataSource, this.viewContext, this.urlGenerator);
    }

    public FilterableSignalRDataSourceBuilder<TModel> SignalR()
    {
      this.dataSource.Type = new DataSourceType?(DataSourceType.Custom);
      this.dataSource.Schema.Model = new ModelDescriptor(typeof (TModel), this.dataSource.ModelMetaDataProvider);
      return new FilterableSignalRDataSourceBuilder<TModel>(this.dataSource);
    }

    public override TDataSourceBuilder Filter(
      Action<DataSourceFilterDescriptorFactory<TModel>> configurator)
    {
      configurator((DataSourceFilterDescriptorFactory<TModel>) new DataSourceSchedulerFilterDescriptorFactory<TModel>(this.dataSource.Filters));
      return (TDataSourceBuilder) this;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override TDataSourceBuilder Sort(
      Action<DataSourceSortDescriptorFactory<TModel>> configurator)
    {
      throw new MethodAccessException("Sort method is not available for Scheduler DataSource.");
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override TDataSourceBuilder Group(
      Action<DataSourceGroupDescriptorFactory<TModel>> configurator)
    {
      throw new MethodAccessException("Group method is not available for Scheduler DataSource.");
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public override TDataSourceBuilder Aggregates(
      Action<DataSourceAggregateDescriptorFactory<TModel>> aggregates)
    {
      throw new MethodAccessException("Aggregates method is not available for Scheduler DataSource.");
    }

    public TDataSourceBuilder Update(Action<CrudOperationBuilder> configurator)
    {
      configurator(new CrudOperationBuilder(this.dataSource.Transport.Update, this.viewContext, this.urlGenerator));
      return (TDataSourceBuilder) this;
    }

    public TDataSourceBuilder Update(string actionName, string controllerName)
    {
      this.SetOperationUrl(this.dataSource.Transport.Update, actionName, controllerName, (object) null);
      return (TDataSourceBuilder) this;
    }

    public TDataSourceBuilder Update(string actionName, string controllerName, object routeValues)
    {
      this.SetOperationUrl(this.dataSource.Transport.Update, actionName, controllerName, routeValues);
      return (TDataSourceBuilder) this;
    }

    public TDataSourceBuilder Create(Action<CrudOperationBuilder> configurator)
    {
      configurator(new CrudOperationBuilder(this.dataSource.Transport.Create, this.viewContext, this.urlGenerator));
      return (TDataSourceBuilder) this;
    }

    public TDataSourceBuilder Create(string actionName, string controllerName)
    {
      this.SetOperationUrl(this.dataSource.Transport.Create, actionName, controllerName, (object) null);
      return (TDataSourceBuilder) this;
    }

    public TDataSourceBuilder Create(string actionName, string controllerName, object routeValues)
    {
      this.SetOperationUrl(this.dataSource.Transport.Create, actionName, controllerName, routeValues);
      return (TDataSourceBuilder) this;
    }

    public TDataSourceBuilder Destroy(Action<CrudOperationBuilder> configurator)
    {
      configurator(new CrudOperationBuilder(this.dataSource.Transport.Destroy, this.viewContext, this.urlGenerator));
      return (TDataSourceBuilder) this;
    }

    public TDataSourceBuilder Destroy(string actionName, string controllerName)
    {
      this.SetOperationUrl(this.dataSource.Transport.Destroy, actionName, controllerName, (object) null);
      return (TDataSourceBuilder) this;
    }

    public TDataSourceBuilder Destroy(string actionName, string controllerName, object routeValues)
    {
      this.SetOperationUrl(this.dataSource.Transport.Destroy, actionName, controllerName, routeValues);
      return (TDataSourceBuilder) this;
    }

    public TDataSourceBuilder Batch(bool enabled)
    {
      this.dataSource.Batch = enabled;
      return (TDataSourceBuilder) this;
    }

    public TDataSourceBuilder AutoSync(bool enabled)
    {
      this.dataSource.AutoSync = enabled;
      return (TDataSourceBuilder) this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
