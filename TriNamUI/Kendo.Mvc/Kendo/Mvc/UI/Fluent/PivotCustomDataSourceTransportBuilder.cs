// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PivotCustomDataSourceTransportBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class PivotCustomDataSourceTransportBuilder
  {
    protected readonly PivotTransport transport;
    protected readonly ViewContext viewContext;
    protected readonly IUrlGenerator urlGenerator;

    public PivotCustomDataSourceTransportBuilder(
      PivotTransport transport,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
    {
      this.viewContext = viewContext;
      this.urlGenerator = urlGenerator;
      this.transport = transport;
    }

    public PivotCustomDataSourceTransportBuilder Read(
      Action<CustomCrudOperationBuilder> configurator)
    {
      configurator(new CustomCrudOperationBuilder(this.transport.Read, this.viewContext, this.urlGenerator));
      return this;
    }

    public PivotCustomDataSourceTransportBuilder Read(
      object settings)
    {
      Dictionary<string, object> instance = new Dictionary<string, object>();
      instance.Merge(settings);
      this.transport.CustomRead = (IDictionary<string, object>) instance;
      return this;
    }

    public PivotCustomDataSourceTransportBuilder Read(
      string handler)
    {
      this.transport.FunctionRead.HandlerName = handler;
      return this;
    }

    public PivotCustomDataSourceTransportBuilder Connection(
      Action<PivotDataSourceTransportConnectionBuilder> configurator)
    {
      configurator(new PivotDataSourceTransportConnectionBuilder(this.transport.Connection));
      return this;
    }

    public PivotCustomDataSourceTransportBuilder Discover(
      Action<CustomCrudOperationBuilder> configurator)
    {
      configurator(new CustomCrudOperationBuilder(this.transport.Discover, this.viewContext, this.urlGenerator));
      return this;
    }

    public PivotCustomDataSourceTransportBuilder Discover(
      object settings)
    {
      Dictionary<string, object> instance = new Dictionary<string, object>();
      instance.Merge(settings);
      this.transport.CustomDiscover = (IDictionary<string, object>) instance;
      return this;
    }

    public PivotCustomDataSourceTransportBuilder Discover(
      string handler)
    {
      this.transport.FunctionDiscover.HandlerName = handler;
      return this;
    }

    public PivotCustomDataSourceTransportBuilder ParameterMap(
      Func<object, object> handler)
    {
      this.transport.ParameterMap.TemplateDelegate = handler;
      return this;
    }

    public PivotCustomDataSourceTransportBuilder ParameterMap(
      string handler)
    {
      this.transport.ParameterMap.HandlerName = handler;
      return this;
    }
  }
}
