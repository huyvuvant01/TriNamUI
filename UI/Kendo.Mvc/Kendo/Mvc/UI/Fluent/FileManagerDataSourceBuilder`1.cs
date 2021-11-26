// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FileManagerDataSourceBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class FileManagerDataSourceBuilder<TModel> : IHideObjectMembers where TModel : class
  {
    private readonly DataSource dataSource;
    private readonly IUrlGenerator urlGenerator;
    private readonly ViewContext viewContext;

    public FileManagerDataSourceBuilder(
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

    public CustomFileManagerDataSourceBuilder Custom()
    {
      this.dataSource.Type = new DataSourceType?(DataSourceType.Custom);
      this.dataSource.ModelType(typeof (object));
      return new CustomFileManagerDataSourceBuilder(this.dataSource, this.viewContext, this.urlGenerator);
    }

    public FileManagerDataSourceBuilder<TModel> Read(
      Action<CrudOperationBuilder> configurator)
    {
      configurator(new CrudOperationBuilder(this.dataSource.Transport.Read, this.viewContext, this.urlGenerator));
      return this;
    }

    public FileManagerDataSourceBuilder<TModel> Read(
      string actionName,
      string controllerName,
      object routeValues)
    {
      this.SetOperationUrl(this.dataSource.Transport.Read, actionName, controllerName, routeValues);
      return this;
    }

    public FileManagerDataSourceBuilder<TModel> Read(
      string actionName,
      string controllerName)
    {
      this.SetOperationUrl(this.dataSource.Transport.Read, actionName, controllerName, (object) null);
      return this;
    }

    public FileManagerDataSourceBuilder<TModel> Create(
      Action<CrudOperationBuilder> configurator)
    {
      configurator(new CrudOperationBuilder(this.dataSource.Transport.Create, this.viewContext, this.urlGenerator));
      return this;
    }

    public FileManagerDataSourceBuilder<TModel> Create(
      string actionName,
      string controllerName,
      object routeValues)
    {
      this.SetOperationUrl(this.dataSource.Transport.Create, actionName, controllerName, routeValues);
      return this;
    }

    public FileManagerDataSourceBuilder<TModel> Create(
      string actionName,
      string controllerName)
    {
      this.SetOperationUrl(this.dataSource.Transport.Create, actionName, controllerName, (object) null);
      return this;
    }

    public FileManagerDataSourceBuilder<TModel> Update(
      Action<CrudOperationBuilder> configurator)
    {
      configurator(new CrudOperationBuilder(this.dataSource.Transport.Update, this.viewContext, this.urlGenerator));
      return this;
    }

    public FileManagerDataSourceBuilder<TModel> Update(
      string actionName,
      string controllerName,
      object routeValues)
    {
      this.SetOperationUrl(this.dataSource.Transport.Update, actionName, controllerName, routeValues);
      return this;
    }

    public FileManagerDataSourceBuilder<TModel> Update(
      string actionName,
      string controllerName)
    {
      this.SetOperationUrl(this.dataSource.Transport.Update, actionName, controllerName, (object) null);
      return this;
    }

    public FileManagerDataSourceBuilder<TModel> Destroy(
      Action<CrudOperationBuilder> configurator)
    {
      configurator(new CrudOperationBuilder(this.dataSource.Transport.Destroy, this.viewContext, this.urlGenerator));
      return this;
    }

    public FileManagerDataSourceBuilder<TModel> Destroy(
      string actionName,
      string controllerName,
      object routeValues)
    {
      this.SetOperationUrl(this.dataSource.Transport.Destroy, actionName, controllerName, routeValues);
      return this;
    }

    public FileManagerDataSourceBuilder<TModel> Destroy(
      string actionName,
      string controllerName)
    {
      this.SetOperationUrl(this.dataSource.Transport.Destroy, actionName, controllerName, (object) null);
      return this;
    }

    public FileManagerDataSourceBuilder<TModel> Events(
      Action<DataSourceEventBuilder> configurator)
    {
      configurator(new DataSourceEventBuilder(this.dataSource.Events));
      return this;
    }

    public FileManagerDataSourceBuilder<TModel> Model(
      Action<FileManagerModelDescriptorBuilder<object>> configurator)
    {
      configurator(new FileManagerModelDescriptorBuilder<object>(this.dataSource.Schema.Model, this.viewContext, this.urlGenerator));
      return this;
    }

    public FileManagerDataSourceBuilder<TModel> ServerFiltering()
    {
      this.dataSource.ServerFiltering = true;
      return this;
    }

    public FileManagerDataSourceBuilder<TModel> ServerFiltering(
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
