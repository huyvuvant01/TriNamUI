﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ReadOnlyDataSourceBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ReadOnlyDataSourceBuilder : IHideObjectMembers
  {
    private readonly DataSource dataSource;
    private readonly IUrlGenerator urlGenerator;
    private readonly ViewContext viewContext;

    public ReadOnlyDataSourceBuilder(
      DataSource dataSource,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
    {
      this.viewContext = viewContext;
      this.urlGenerator = urlGenerator;
      this.dataSource = dataSource;
      dataSource.Schema.Data = "";
      dataSource.Schema.Total = "";
    }

    public ReadOnlyDataSourceBuilder Read(
      Action<CrudOperationBuilder> configurator)
    {
      configurator(new CrudOperationBuilder(this.dataSource.Transport.Read, this.viewContext, this.urlGenerator));
      return this;
    }

    public ReadOnlyDataSourceBuilder Read(
      string actionName,
      string controllerName,
      object routeValues)
    {
      this.SetOperationUrl(this.dataSource.Transport.Read, actionName, controllerName, routeValues);
      return this;
    }

    public ReadOnlyDataSourceBuilder Read(
      string actionName,
      string controllerName)
    {
      this.SetOperationUrl(this.dataSource.Transport.Read, actionName, controllerName, (object) null);
      return this;
    }

    public ReadOnlyDataSourceBuilder ServerFiltering()
    {
      this.dataSource.ServerFiltering = true;
      return this;
    }

    public ReadOnlyDataSourceBuilder ServerFiltering(bool enabled)
    {
      this.dataSource.ServerFiltering = enabled;
      return this;
    }

    public ReadOnlyDataSourceBuilder Events(
      Action<DataSourceEventBuilder> configurator)
    {
      configurator(new DataSourceEventBuilder(this.dataSource.Events));
      return this;
    }

    public ReadOnlyCustomDataSourceBuilder Custom()
    {
      this.dataSource.Type = new DataSourceType?(DataSourceType.Custom);
      return new ReadOnlyCustomDataSourceBuilder(this.dataSource, this.viewContext, this.urlGenerator);
    }

    public ReadOnlyAjaxDataSourceBuilder<object> Ajax()
    {
      this.dataSource.Type = new DataSourceType?(DataSourceType.Ajax);
      this.dataSource.Schema.Data = "Data";
      this.dataSource.Schema.Total = "Total";
      return new ReadOnlyAjaxDataSourceBuilder<object>(this.dataSource, this.viewContext, this.urlGenerator).ServerOperation(true);
    }

    public SignalRDataSourceBuilder<object> SignalR()
    {
      this.dataSource.Type = new DataSourceType?(DataSourceType.Custom);
      return new SignalRDataSourceBuilder<object>(this.dataSource);
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
