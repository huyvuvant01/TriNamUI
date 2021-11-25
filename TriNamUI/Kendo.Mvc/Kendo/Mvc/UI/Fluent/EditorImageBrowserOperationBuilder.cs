// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.EditorImageBrowserOperationBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class EditorImageBrowserOperationBuilder : IHideObjectMembers
  {
    private readonly EditorImageBrowserOperation operation;
    private readonly ViewContext viewContext;
    private readonly IUrlGenerator urlGenerator;

    public EditorImageBrowserOperationBuilder(
      EditorImageBrowserOperation operation,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
    {
      this.viewContext = viewContext;
      this.urlGenerator = urlGenerator;
      this.operation = operation;
    }

    public EditorImageBrowserOperationBuilder Action(
      string actionName,
      string controllerName,
      object routeValues)
    {
      this.operation.Action(actionName, controllerName, routeValues);
      this.SetUrl();
      return this;
    }

    public EditorImageBrowserOperationBuilder Action(
      string actionName,
      string controllerName,
      RouteValueDictionary routeValues)
    {
      NavigatableExtensions.Action(this.operation, actionName, controllerName, routeValues);
      this.SetUrl();
      return this;
    }

    public EditorImageBrowserOperationBuilder Action(
      string actionName,
      string controllerName)
    {
      return this.Action(actionName, controllerName, (object) null);
    }

    public EditorImageBrowserOperationBuilder Route(
      RouteValueDictionary routeValues)
    {
      this.operation.Action(routeValues);
      this.SetUrl();
      return this;
    }

    public EditorImageBrowserOperationBuilder Route(
      string routeName)
    {
      this.operation.Route(routeName, (object) null);
      this.SetUrl();
      return this;
    }

    public EditorImageBrowserOperationBuilder Route(
      string routeName,
      RouteValueDictionary routeValues)
    {
      NavigatableExtensions.Route(this.operation, routeName, routeValues);
      this.SetUrl();
      return this;
    }

    public EditorImageBrowserOperationBuilder Route(
      string routeName,
      object routeValues)
    {
      this.operation.Route(routeName, routeValues);
      this.SetUrl();
      return this;
    }

    public EditorImageBrowserOperationBuilder Url(string url)
    {
      this.operation.Url = this.urlGenerator.Generate((ActionContext) this.viewContext, url);
      return this;
    }

    private void SetUrl() => this.operation.Url = this.operation.GenerateUrl(this.viewContext, this.urlGenerator);

    public EditorImageBrowserOperationBuilder Data(string handler)
    {
      this.operation.Data.HandlerName = handler;
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
