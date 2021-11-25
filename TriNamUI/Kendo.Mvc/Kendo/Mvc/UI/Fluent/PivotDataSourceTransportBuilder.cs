// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PivotDataSourceTransportBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class PivotDataSourceTransportBuilder : IHideObjectMembers
  {
    protected readonly PivotTransport transport;
    protected readonly ViewContext viewContext;
    protected readonly IUrlGenerator urlGenerator;

    public PivotDataSourceTransportBuilder(
      PivotTransport transport,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
    {
      this.viewContext = viewContext;
      this.urlGenerator = urlGenerator;
      this.transport = transport;
    }

    public PivotDataSourceTransportBuilder Read(
      Action<CustomCrudOperationBuilder> configurator)
    {
      configurator(new CustomCrudOperationBuilder(this.transport.Read, this.viewContext, this.urlGenerator));
      return this;
    }

    public PivotDataSourceTransportBuilder Connection(
      Action<PivotDataSourceTransportConnectionBuilder> configurator)
    {
      configurator(new PivotDataSourceTransportConnectionBuilder(this.transport.Connection));
      return this;
    }

    public PivotDataSourceTransportBuilder Discover(
      Action<CustomCrudOperationBuilder> configurator)
    {
      configurator(new CustomCrudOperationBuilder(this.transport.Discover, this.viewContext, this.urlGenerator));
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
