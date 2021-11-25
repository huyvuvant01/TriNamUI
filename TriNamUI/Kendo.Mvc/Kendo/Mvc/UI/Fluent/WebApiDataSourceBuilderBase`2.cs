// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.WebApiDataSourceBuilderBase`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public abstract class WebApiDataSourceBuilderBase<TModel, TDataSourceBuilder> : IHideObjectMembers
    where TModel : class
    where TDataSourceBuilder : WebApiDataSourceBuilderBase<TModel, TDataSourceBuilder>
  {
    protected readonly DataSource dataSource;
    protected readonly IUrlGenerator urlGenerator;
    protected readonly ViewContext viewContext;

    public WebApiDataSourceBuilderBase(
      DataSource dataSource,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
    {
      this.viewContext = viewContext;
      this.urlGenerator = urlGenerator;
      this.dataSource = dataSource;
    }

    public TDataSourceBuilder Events(Action<DataSourceEventBuilder> configurator)
    {
      configurator(new DataSourceEventBuilder(this.dataSource.Events));
      return (TDataSourceBuilder) this;
    }

    public TDataSourceBuilder Read(Action<CrudOperationBuilder> configurator)
    {
      configurator(new CrudOperationBuilder(this.dataSource.Transport.Read, this.viewContext, this.urlGenerator));
      return (TDataSourceBuilder) this;
    }

    public TDataSourceBuilder Read(string url)
    {
      this.dataSource.Transport.Read.Url = url;
      return (TDataSourceBuilder) this;
    }

    public TDataSourceBuilder Read(string actionName, string controllerName, object routeValues)
    {
      this.SetOperationUrl(this.dataSource.Transport.Read, actionName, controllerName, routeValues);
      return (TDataSourceBuilder) this;
    }

    public TDataSourceBuilder Read(string actionName, string controllerName)
    {
      this.SetOperationUrl(this.dataSource.Transport.Read, actionName, controllerName, (object) null);
      return (TDataSourceBuilder) this;
    }

    public TDataSourceBuilder Total(int total)
    {
      this.dataSource.Total = total;
      return (TDataSourceBuilder) this;
    }

    public TDataSourceBuilder PageSize(int pageSize)
    {
      this.dataSource.PageSize = pageSize;
      return (TDataSourceBuilder) this;
    }

    public TDataSourceBuilder OfflineStorage(string key)
    {
      this.dataSource.OfflineStorageKey = key;
      return (TDataSourceBuilder) this;
    }

    public TDataSourceBuilder AccentFoldingFiltering(string culture)
    {
      this.dataSource.AccentFoldingFiltering = culture;
      return (TDataSourceBuilder) this;
    }

    public TDataSourceBuilder OfflineStorage(string getItem, string setItem)
    {
      this.dataSource.OfflineStorage[nameof (getItem)] = (object) new ClientHandlerDescriptor()
      {
        HandlerName = getItem
      };
      this.dataSource.OfflineStorage[nameof (setItem)] = (object) new ClientHandlerDescriptor()
      {
        HandlerName = setItem
      };
      return (TDataSourceBuilder) this;
    }

    public TDataSourceBuilder Culture(string culture)
    {
      this.dataSource.Culture = culture;
      return (TDataSourceBuilder) this;
    }

    public TDataSourceBuilder ServerOperation(bool enabled)
    {
      this.dataSource.ServerPaging = enabled;
      this.dataSource.ServerFiltering = enabled;
      this.dataSource.ServerAggregates = enabled;
      this.dataSource.ServerSorting = enabled;
      this.dataSource.ServerGrouping = enabled;
      return (TDataSourceBuilder) this;
    }

    public virtual TDataSourceBuilder Sort(
      Action<DataSourceSortDescriptorFactory<TModel>> configurator)
    {
      configurator(new DataSourceSortDescriptorFactory<TModel>(this.dataSource.OrderBy));
      return (TDataSourceBuilder) this;
    }

    public virtual TDataSourceBuilder Group(
      Action<DataSourceGroupDescriptorFactory<TModel>> configurator)
    {
      configurator(new DataSourceGroupDescriptorFactory<TModel>(this.dataSource.Groups));
      return (TDataSourceBuilder) this;
    }

    public virtual TDataSourceBuilder Aggregates(
      Action<DataSourceAggregateDescriptorFactory<TModel>> aggregates)
    {
      aggregates(new DataSourceAggregateDescriptorFactory<TModel>(this.dataSource.Aggregates));
      return (TDataSourceBuilder) this;
    }

    public virtual TDataSourceBuilder Filter(
      Action<DataSourceFilterDescriptorFactory<TModel>> configurator)
    {
      configurator(new DataSourceFilterDescriptorFactory<TModel>(this.dataSource.Filters));
      return (TDataSourceBuilder) this;
    }

    public virtual TDataSourceBuilder Model(
      Action<DataSourceModelDescriptorFactory<TModel>> configurator)
    {
      configurator(new DataSourceModelDescriptorFactory<TModel>(this.dataSource.Schema.Model));
      return (TDataSourceBuilder) this;
    }

    protected virtual void SetOperationUrl(
      CrudOperation operation,
      string actionName,
      string controllerName,
      object routeValues)
    {
      operation.Action(actionName, controllerName, routeValues);
      operation.Url = operation.GenerateUrl(this.viewContext, this.urlGenerator);
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
