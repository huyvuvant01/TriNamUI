// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PivotAjaxDataSourceTransportBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class PivotAjaxDataSourceTransportBuilder
  {
    protected readonly PivotTransport transport;
    protected readonly ViewContext viewContext;
    protected readonly IUrlGenerator urlGenerator;

    public PivotAjaxDataSourceTransportBuilder(
      PivotTransport transport,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
    {
      this.viewContext = viewContext;
      this.urlGenerator = urlGenerator;
      this.transport = transport;
    }

    public PivotAjaxDataSourceTransportBuilder Read(
      Action<CrudOperationBuilder> configurator)
    {
      configurator(new CrudOperationBuilder(this.transport.Read, this.viewContext, this.urlGenerator));
      return this;
    }

    public PivotAjaxDataSourceTransportBuilder Read(
      string actionName,
      string controllerName,
      object routeValues)
    {
      this.SetOperationUrl(this.transport.Read, actionName, controllerName, routeValues);
      return this;
    }

    public PivotAjaxDataSourceTransportBuilder Read(
      string actionName,
      string controllerName)
    {
      this.SetOperationUrl(this.transport.Read, actionName, controllerName, (object) null);
      return this;
    }

    public PivotAjaxDataSourceTransportBuilder Discover(
      Action<CrudOperationBuilder> configurator)
    {
      configurator(new CrudOperationBuilder(this.transport.Discover, this.viewContext, this.urlGenerator));
      return this;
    }

    public PivotAjaxDataSourceTransportBuilder Discover(
      string actionName,
      string controllerName,
      object routeValues)
    {
      this.SetOperationUrl(this.transport.Discover, actionName, controllerName, routeValues);
      return this;
    }

    public PivotAjaxDataSourceTransportBuilder Discover(
      string actionName,
      string controllerName)
    {
      this.SetOperationUrl(this.transport.Discover, actionName, controllerName, (object) null);
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
