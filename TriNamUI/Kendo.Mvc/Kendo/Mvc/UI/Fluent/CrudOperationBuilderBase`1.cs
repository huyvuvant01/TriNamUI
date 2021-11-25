// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.CrudOperationBuilderBase`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
  public abstract class CrudOperationBuilderBase<TCrudOperationBuilder> : IHideObjectMembers
    where TCrudOperationBuilder : CrudOperationBuilderBase<TCrudOperationBuilder>
  {
    protected readonly CrudOperation operation;
    protected readonly ViewContext viewContext;
    protected readonly IUrlGenerator urlGenerator;

    public CrudOperationBuilderBase(
      CrudOperation operation,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
    {
      this.viewContext = viewContext;
      this.urlGenerator = urlGenerator;
      this.operation = operation;
    }

    public TCrudOperationBuilder Route(RouteValueDictionary routeValues)
    {
      this.operation.Action(routeValues);
      this.SetUrl();
      return (TCrudOperationBuilder) this;
    }

    public TCrudOperationBuilder Action(
      string actionName,
      string controllerName,
      object routeValues)
    {
      this.operation.Action(actionName, controllerName, routeValues);
      this.SetUrl();
      return (TCrudOperationBuilder) this;
    }

    public TCrudOperationBuilder Action(
      string actionName,
      string controllerName,
      RouteValueDictionary routeValues)
    {
      NavigatableExtensions.Action(this.operation, actionName, controllerName, routeValues);
      this.SetUrl();
      return (TCrudOperationBuilder) this;
    }

    public TCrudOperationBuilder Action(string actionName, string controllerName) => this.Action(actionName, controllerName, (object) null);

    public TCrudOperationBuilder Route(string routeName, RouteValueDictionary routeValues)
    {
      NavigatableExtensions.Route(this.operation, routeName, routeValues);
      this.SetUrl();
      return (TCrudOperationBuilder) this;
    }

    public TCrudOperationBuilder Route(string routeName, object routeValues)
    {
      this.operation.Route(routeName, routeValues);
      this.SetUrl();
      return (TCrudOperationBuilder) this;
    }

    public TCrudOperationBuilder Route(string routeName)
    {
      this.operation.Route(routeName, (object) null);
      this.SetUrl();
      return (TCrudOperationBuilder) this;
    }

    public TCrudOperationBuilder Action<TController>(
      Expression<System.Action<TController>> controllerAction)
      where TController : Controller
    {
      this.operation.Action<TController>(controllerAction);
      this.SetUrl();
      return (TCrudOperationBuilder) this;
    }

    public TCrudOperationBuilder Data(Func<object, object> handler)
    {
      this.operation.Data.TemplateDelegate = handler;
      return (TCrudOperationBuilder) this;
    }

    public TCrudOperationBuilder Data(string handler)
    {
      this.operation.Data.HandlerName = handler;
      return (TCrudOperationBuilder) this;
    }

    public TCrudOperationBuilder Url(string url)
    {
      this.operation.Url = url;
      return (TCrudOperationBuilder) this;
    }

    public TCrudOperationBuilder Type(HttpVerbs verb)
    {
      this.operation.Type = verb.ToString().ToUpperInvariant();
      return (TCrudOperationBuilder) this;
    }

    public TCrudOperationBuilder Headers(object headers)
    {
      this.operation.Headers = headers.ToStringDictionary();
      return (TCrudOperationBuilder) this;
    }

    public TCrudOperationBuilder Headers(IDictionary<string, string> headers)
    {
      this.operation.Headers = headers;
      return (TCrudOperationBuilder) this;
    }

    private void SetUrl() => this.operation.Url = this.operation.GenerateUrl(this.viewContext, this.urlGenerator);

    System.Type IHideObjectMembers.GetType() => this.GetType();
  }
}
