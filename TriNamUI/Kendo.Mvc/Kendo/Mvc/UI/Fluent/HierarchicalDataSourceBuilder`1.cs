// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.HierarchicalDataSourceBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class HierarchicalDataSourceBuilder<TModel> : IHideObjectMembers where TModel : class
  {
    private readonly DataSource dataSource;
    private readonly IUrlGenerator urlGenerator;
    private readonly ViewContext viewContext;

    public HierarchicalDataSourceBuilder(
      DataSource dataSource,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
    {
      this.dataSource = dataSource;
      this.urlGenerator = urlGenerator;
      this.viewContext = viewContext;
      this.dataSource.ServerPaging = false;
      this.dataSource.ServerSorting = false;
      this.dataSource.ServerGrouping = false;
      this.dataSource.ServerFiltering = false;
      this.dataSource.ServerAggregates = false;
      this.dataSource.Schema.Data = "";
      this.dataSource.Schema.Total = "";
      this.dataSource.Schema.Errors = "";
      this.dataSource.Transport.SerializeEmptyPrefix = false;
    }

    public CustomHierarchicalDataSourceBuilder Custom()
    {
      this.dataSource.Type = new DataSourceType?(DataSourceType.Custom);
      return new CustomHierarchicalDataSourceBuilder(this.dataSource, this.viewContext, this.urlGenerator);
    }

    public HierarchicalDataSourceBuilder<TModel> Read(
      Action<CrudOperationBuilder> configurator)
    {
      configurator(new CrudOperationBuilder(this.dataSource.Transport.Read, this.viewContext, this.urlGenerator));
      return this;
    }

    public HierarchicalDataSourceBuilder<TModel> Read(
      string actionName,
      string controllerName,
      object routeValues)
    {
      this.SetOperationUrl(this.dataSource.Transport.Read, actionName, controllerName, routeValues);
      return this;
    }

    public HierarchicalDataSourceBuilder<TModel> Read(
      string actionName,
      string controllerName)
    {
      this.SetOperationUrl(this.dataSource.Transport.Read, actionName, controllerName, (object) null);
      return this;
    }

    public HierarchicalDataSourceBuilder<TModel> Events(
      Action<DataSourceEventBuilder> configurator)
    {
      configurator(new DataSourceEventBuilder(this.dataSource.Events));
      return this;
    }

    public HierarchicalDataSourceBuilder<TModel> Model(
      Action<HierarchicalModelDescriptorBuilder<object>> configurator)
    {
      configurator(new HierarchicalModelDescriptorBuilder<object>(this.dataSource.Schema.Model, this.viewContext, this.urlGenerator));
      return this;
    }

    public HierarchicalDataSourceBuilder<TModel> ServerFiltering()
    {
      this.dataSource.ServerFiltering = true;
      return this;
    }

    public HierarchicalDataSourceBuilder<TModel> ServerFiltering(
      bool enabled)
    {
      this.dataSource.ServerFiltering = enabled;
      return this;
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
