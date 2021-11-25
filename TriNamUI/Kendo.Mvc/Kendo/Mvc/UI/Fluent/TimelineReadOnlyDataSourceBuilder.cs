// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TimelineReadOnlyDataSourceBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class TimelineReadOnlyDataSourceBuilder : IHideObjectMembers
  {
    private readonly DataSource dataSource;
    private readonly IUrlGenerator urlGenerator;
    private readonly ViewContext viewContext;

    public TimelineReadOnlyDataSourceBuilder(
      DataSource dataSource,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
    {
      this.viewContext = viewContext;
      this.urlGenerator = urlGenerator;
      this.dataSource = dataSource;
      dataSource.Schema.Data = "";
      dataSource.Schema.Total = "";
      dataSource.Schema.Errors = "";
    }

    public TimelineReadOnlyDataSourceBuilder Read(
      Action<CrudOperationBuilder> configurator)
    {
      configurator(new CrudOperationBuilder(this.dataSource.Transport.Read, this.viewContext, this.urlGenerator));
      return this;
    }

    public TimelineReadOnlyDataSourceBuilder Read(
      string actionName,
      string controllerName,
      object routeValues)
    {
      this.SetOperationUrl(this.dataSource.Transport.Read, actionName, controllerName, routeValues);
      return this;
    }

    public TimelineReadOnlyDataSourceBuilder Read(
      string actionName,
      string controllerName)
    {
      this.SetOperationUrl(this.dataSource.Transport.Read, actionName, controllerName, (object) null);
      return this;
    }

    public TimelineReadOnlyDataSourceBuilder Events(
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
