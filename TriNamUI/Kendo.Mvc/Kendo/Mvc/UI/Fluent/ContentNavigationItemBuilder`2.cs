// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ContentNavigationItemBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ContentNavigationItemBuilder<TItem, TBuilder> : NavigationItemBuilder<TItem, TBuilder>
    where TItem : NavigationItem<TItem>, IAsyncContentContainer
    where TBuilder : NavigationItemBuilder<TItem, TBuilder>
  {
    public ContentNavigationItemBuilder(TItem item, ViewContext viewContext)
      : base((NavigationItem<TItem>) item, viewContext)
    {
      this.ViewContext = viewContext;
    }

    public TBuilder LoadContentFrom(RouteValueDictionary routeValues) => routeValues.ApplyTo<TBuilder>(new Func<string, string, RouteValueDictionary, TBuilder>(this.LoadContentFrom));

    public TBuilder LoadContentFrom(string actionName, string controllerName) => this.LoadContentFrom(actionName, controllerName, (object) null);

    public TBuilder LoadContentFrom(string actionName, string controllerName, object routeValues) => this.LoadContentFrom(actionName, controllerName, new RouteValueDictionary(routeValues));

    public TBuilder LoadContentFrom(
      string actionName,
      string controllerName,
      RouteValueDictionary routeValues)
    {
      return this.LoadContentFrom(NavigatableExtensions.GetUrlHelper((ActionContext) this.ViewContext).Action(actionName, controllerName, (object) routeValues));
    }

    public TBuilder LoadContentFrom(string value)
    {
      this.Item.ContentUrl = value;
      return this as TBuilder;
    }
  }
}
