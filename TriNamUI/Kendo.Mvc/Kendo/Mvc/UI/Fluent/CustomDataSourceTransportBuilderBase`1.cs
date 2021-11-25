// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.CustomDataSourceTransportBuilderBase`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public abstract class CustomDataSourceTransportBuilderBase<TTransportBuilder> : IHideObjectMembers
    where TTransportBuilder : CustomDataSourceTransportBuilderBase<TTransportBuilder>
  {
    protected readonly Transport transport;
    protected readonly ViewContext viewContext;
    protected readonly IUrlGenerator urlGenerator;

    public CustomDataSourceTransportBuilderBase(
      Transport transport,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
    {
      this.viewContext = viewContext;
      this.urlGenerator = urlGenerator;
      this.transport = transport;
    }

    public TTransportBuilder ParameterMap(Func<object, object> handler)
    {
      this.transport.ParameterMap.TemplateDelegate = handler;
      return (TTransportBuilder) this;
    }

    public TTransportBuilder ParameterMap(string handler)
    {
      this.transport.ParameterMap.HandlerName = handler;
      return (TTransportBuilder) this;
    }

    public TTransportBuilder Read(Action<CustomCrudOperationBuilder> configurator)
    {
      configurator(new CustomCrudOperationBuilder(this.transport.Read, this.viewContext, this.urlGenerator));
      return (TTransportBuilder) this;
    }

    public TTransportBuilder Read(string actionName, string controllerName, object routeValues)
    {
      this.SetOperationUrl(this.transport.Read, actionName, controllerName, routeValues);
      return (TTransportBuilder) this;
    }

    public TTransportBuilder Read(string actionName, string controllerName)
    {
      this.SetOperationUrl(this.transport.Read, actionName, controllerName, (object) null);
      return (TTransportBuilder) this;
    }

    public TTransportBuilder Read(object settings)
    {
      Dictionary<string, object> instance = new Dictionary<string, object>();
      instance.Merge(settings);
      this.transport.CustomRead = (IDictionary<string, object>) instance;
      return (TTransportBuilder) this;
    }

    public TTransportBuilder Read(string handler)
    {
      this.transport.FunctionRead.HandlerName = handler;
      return (TTransportBuilder) this;
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

    public TTransportBuilder Cache(bool cache)
    {
      this.transport.Cache = new bool?(cache);
      return (TTransportBuilder) this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
