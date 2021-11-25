// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.NavigationItemBuilder`2
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
  public abstract class NavigationItemBuilder<TItem, TBuilder>
    where TItem : NavigationItem<TItem>
    where TBuilder : NavigationItemBuilder<TItem, TBuilder>
  {
    private readonly NavigationItem<TItem> item;

    protected NavigationItemBuilder(NavigationItem<TItem> item, ViewContext viewContext)
    {
      this.item = item;
      this.ViewContext = viewContext;
    }

    public ViewContext ViewContext { get; set; }

    protected TItem Item => this.item as TItem;

    public TItem ToItem() => this.item as TItem;

    public TBuilder HtmlAttributes(object attributes) => this.HtmlAttributes(attributes.ToDictionary());

    public TBuilder HtmlAttributes(IDictionary<string, object> attributes)
    {
      this.item.HtmlAttributes.Clear();
      DictionaryExtensions.Merge(this.item.HtmlAttributes, attributes);
      return this as TBuilder;
    }

    public TBuilder LinkHtmlAttributes(object attributes) => this.LinkHtmlAttributes(attributes.ToDictionary());

    public TBuilder LinkHtmlAttributes(IDictionary<string, object> attributes)
    {
      this.item.LinkHtmlAttributes.Clear();
      DictionaryExtensions.Merge(this.item.LinkHtmlAttributes, attributes);
      return this as TBuilder;
    }

    public TBuilder Text(string value)
    {
      this.item.Text = value;
      return this as TBuilder;
    }

    public TBuilder Visible(bool value)
    {
      this.item.Visible = value;
      return this as TBuilder;
    }

    public TBuilder Enabled(bool value)
    {
      this.item.Enabled = value;
      return this as TBuilder;
    }

    public TBuilder Selected(bool value)
    {
      this.item.Selected = value;
      return this as TBuilder;
    }

    public TBuilder Route(string routeName, RouteValueDictionary routeValues)
    {
      NavigatableExtensions.Route(this.item, routeName, routeValues);
      this.SetTextIfEmpty(routeName);
      return this as TBuilder;
    }

    public TBuilder Route(string routeName, object routeValues)
    {
      this.item.Route(routeName, routeValues);
      this.SetTextIfEmpty(routeName);
      return this as TBuilder;
    }

    public TBuilder Route(string routeName) => this.Route(routeName, (object) null);

    public TBuilder Action(RouteValueDictionary routeValues)
    {
      this.item.Action(routeValues);
      if (this.item.ActionName.HasValue())
        this.SetTextIfEmpty(this.item.ActionName);
      return this as TBuilder;
    }

    public TBuilder Action(
      string actionName,
      string controllerName,
      RouteValueDictionary routeValues)
    {
      NavigatableExtensions.Action(this.item, actionName, controllerName, routeValues);
      this.SetTextIfEmpty(actionName);
      return this as TBuilder;
    }

    public TBuilder Action(string actionName, string controllerName, object routeValues)
    {
      this.item.Action(actionName, controllerName, routeValues);
      this.SetTextIfEmpty(actionName);
      return this as TBuilder;
    }

    public TBuilder Action(string actionName, string controllerName) => this.Action(actionName, controllerName, (object) null);

    public TBuilder Url(string value)
    {
      this.item.Url(value);
      return this as TBuilder;
    }

    public TBuilder ImageUrl(string value)
    {
      this.item.ImageUrl = value;
      return this as TBuilder;
    }

    public TBuilder ImageHtmlAttributes(object attributes) => this.ImageHtmlAttributes(attributes.ToDictionary());

    public TBuilder ImageHtmlAttributes(IDictionary<string, object> attributes)
    {
      this.item.ImageHtmlAttributes.Clear();
      DictionaryExtensions.Merge(this.item.ImageHtmlAttributes, attributes);
      return this as TBuilder;
    }

    public TBuilder SpriteCssClasses(params string[] cssClasses)
    {
      this.Item.SpriteCssClasses = string.Join(" ", cssClasses);
      return this as TBuilder;
    }

    public TBuilder Content(System.Action value)
    {
      this.Item.Template.Content = value;
      return this as TBuilder;
    }

    public TBuilder Content(Func<object, object> value)
    {
      this.Item.Template.InlineTemplate = value;
      return this as TBuilder;
    }

    public TBuilder Content(string value)
    {
      this.Item.Template.Html = value;
      return this as TBuilder;
    }

    public TBuilder ContentHtmlAttributes(object attributes) => this.ContentHtmlAttributes(attributes.ToDictionary());

    public TBuilder ContentHtmlAttributes(IDictionary<string, object> attributes)
    {
      this.item.ContentHtmlAttributes.Clear();
      DictionaryExtensions.Merge(this.item.ContentHtmlAttributes, attributes);
      return this as TBuilder;
    }

    public TBuilder Action<TController>(Expression<System.Action<TController>> controllerAction) where TController : Controller
    {
      this.item.Action<TController>(controllerAction);
      return this as TBuilder;
    }

    public TBuilder Encoded(bool isEncoded)
    {
      this.item.Encoded = isEncoded;
      return this as TBuilder;
    }

    private void SetTextIfEmpty(string value)
    {
      if (!string.IsNullOrEmpty(this.item.Text))
        return;
      this.item.Text = value;
    }
  }
}
