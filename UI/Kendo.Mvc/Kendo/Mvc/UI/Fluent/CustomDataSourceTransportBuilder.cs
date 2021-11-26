// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.CustomDataSourceTransportBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class CustomDataSourceTransportBuilder : 
    CustomDataSourceTransportBuilderBase<CustomDataSourceTransportBuilder>,
    IHideObjectMembers
  {
    public CustomDataSourceTransportBuilder(
      Transport transport,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
      : base(transport, viewContext, urlGenerator)
    {
    }

    public CustomDataSourceTransportBuilder Update(
      Action<CustomCrudOperationBuilder> configurator)
    {
      configurator(new CustomCrudOperationBuilder(this.transport.Update, this.viewContext, this.urlGenerator));
      return this;
    }

    public CustomDataSourceTransportBuilder Update(
      string actionName,
      string controllerName)
    {
      this.SetOperationUrl(this.transport.Update, actionName, controllerName, (object) null);
      return this;
    }

    public CustomDataSourceTransportBuilder Update(
      string actionName,
      string controllerName,
      object routeValues)
    {
      this.SetOperationUrl(this.transport.Update, actionName, controllerName, routeValues);
      return this;
    }

    public CustomDataSourceTransportBuilder Update(object settings)
    {
      Dictionary<string, object> instance = new Dictionary<string, object>();
      instance.Merge(settings);
      this.transport.CustomUpdate = (IDictionary<string, object>) instance;
      return this;
    }

    public CustomDataSourceTransportBuilder Update(string handler)
    {
      this.transport.FunctionUpdate.HandlerName = handler;
      return this;
    }

    public CustomDataSourceTransportBuilder Create(
      Action<CustomCrudOperationBuilder> configurator)
    {
      configurator(new CustomCrudOperationBuilder(this.transport.Create, this.viewContext, this.urlGenerator));
      return this;
    }

    public CustomDataSourceTransportBuilder Create(
      string actionName,
      string controllerName)
    {
      this.SetOperationUrl(this.transport.Create, actionName, controllerName, (object) null);
      return this;
    }

    public CustomDataSourceTransportBuilder Create(
      string actionName,
      string controllerName,
      object routeValues)
    {
      this.SetOperationUrl(this.transport.Create, actionName, controllerName, routeValues);
      return this;
    }

    public CustomDataSourceTransportBuilder Create(object settings)
    {
      Dictionary<string, object> instance = new Dictionary<string, object>();
      instance.Merge(settings);
      this.transport.CustomCreate = (IDictionary<string, object>) instance;
      return this;
    }

    public CustomDataSourceTransportBuilder Create(string handler)
    {
      this.transport.FunctionCreate.HandlerName = handler;
      return this;
    }

    public CustomDataSourceTransportBuilder Destroy(
      Action<CustomCrudOperationBuilder> configurator)
    {
      configurator(new CustomCrudOperationBuilder(this.transport.Destroy, this.viewContext, this.urlGenerator));
      return this;
    }

    public CustomDataSourceTransportBuilder Destroy(
      string actionName,
      string controllerName)
    {
      this.SetOperationUrl(this.transport.Destroy, actionName, controllerName, (object) null);
      return this;
    }

    public CustomDataSourceTransportBuilder Destroy(
      string actionName,
      string controllerName,
      object routeValues)
    {
      this.SetOperationUrl(this.transport.Destroy, actionName, controllerName, routeValues);
      return this;
    }

    public CustomDataSourceTransportBuilder Destroy(object settings)
    {
      Dictionary<string, object> instance = new Dictionary<string, object>();
      instance.Merge(settings);
      this.transport.CustomDestroy = (IDictionary<string, object>) instance;
      return this;
    }

    public CustomDataSourceTransportBuilder Destroy(string handler)
    {
      this.transport.FunctionDestroy.HandlerName = handler;
      return this;
    }

    public CustomDataSourceTransportBuilder Submit(string handler)
    {
      this.transport.FunctionSubmit.HandlerName = handler;
      return this;
    }

    public CustomDataSourceTransportBuilder Batch(object settings)
    {
      Dictionary<string, object> instance = new Dictionary<string, object>();
      instance.Merge(settings);
      this.transport.CustomBatch = (IDictionary<string, object>) instance;
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
