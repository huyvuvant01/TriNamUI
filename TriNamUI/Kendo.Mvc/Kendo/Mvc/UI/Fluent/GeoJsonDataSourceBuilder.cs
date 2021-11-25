// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GeoJsonDataSourceBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class GeoJsonDataSourceBuilder
  {
    private DataSource dataSource;
    private ViewContext viewContext;
    private IUrlGenerator urlGenerator;

    public GeoJsonDataSourceBuilder(
      DataSource dataSource,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
    {
      this.dataSource = dataSource;
      this.viewContext = viewContext;
      this.urlGenerator = urlGenerator;
    }

    public GeoJsonDataSourceBuilder Read(
      Action<CrudOperationBuilder> configurator)
    {
      configurator(new CrudOperationBuilder(this.dataSource.Transport.Read, this.viewContext, this.urlGenerator));
      return this;
    }

    public GeoJsonDataSourceBuilder Read(
      string actionName,
      string controllerName,
      object routeValues)
    {
      this.SetOperationUrl(this.dataSource.Transport.Read, actionName, controllerName, routeValues);
      return this;
    }

    public GeoJsonDataSourceBuilder Read(
      string actionName,
      string controllerName)
    {
      this.SetOperationUrl(this.dataSource.Transport.Read, actionName, controllerName, (object) null);
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
  }
}
