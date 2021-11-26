// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.NavigationItem`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public abstract class NavigationItem<T> : 
    LinkedObjectBase<T>,
    INavigatable,
    IHideObjectMembers,
    IHtmlAttributesContainer,
    IContentContainer
    where T : NavigationItem<T>
  {
    private string text;
    private string routeName;
    private string controllerName;
    private string actionName;
    private string url;
    private bool selected;
    private bool enabled;

    protected NavigationItem()
    {
      this.Template = new HtmlTemplate();
      this.HtmlAttributes = (IDictionary<string, object>) new RouteValueDictionary();
      this.ImageHtmlAttributes = (IDictionary<string, object>) new RouteValueDictionary();
      this.LinkHtmlAttributes = (IDictionary<string, object>) new RouteValueDictionary();
      this.RouteValues = new RouteValueDictionary();
      this.ContentHtmlAttributes = (IDictionary<string, object>) new RouteValueDictionary();
      this.Visible = true;
      this.Enabled = true;
      this.Encoded = true;
    }

    public RouteValueDictionary RouteValues { get; set; }

    public IDictionary<string, object> HtmlAttributes { get; private set; }

    public IDictionary<string, object> ImageHtmlAttributes { get; private set; }

    public IDictionary<string, object> LinkHtmlAttributes { get; private set; }

    public IDictionary<string, object> ContentHtmlAttributes { get; private set; }

    public bool Encoded { get; set; }

    public HtmlTemplate Template { get; private set; }

    public Func<T, object> InlineTemplate { get; set; }

    public string Html
    {
      get => this.Template.Html;
      set => this.Template.Html = value;
    }

    public bool Visible { get; set; }

    public string ImageUrl { get; set; }

    public string SpriteCssClasses { get; set; }

    public Action Content
    {
      get => this.Template.Content;
      set => this.Template.Content = value;
    }

    public string Text
    {
      get => this.text;
      set => this.text = value;
    }

    public bool Selected
    {
      get => this.selected;
      set
      {
        this.selected = value;
        if (!this.selected)
          return;
        this.enabled = true;
      }
    }

    public bool Enabled
    {
      get => this.enabled;
      set
      {
        this.enabled = value;
        if (this.enabled)
          return;
        this.selected = false;
      }
    }

    public string ControllerName
    {
      get => this.controllerName;
      set
      {
        this.controllerName = value;
        this.routeName = this.url = (string) null;
      }
    }

    public string ActionName
    {
      get => this.actionName;
      set
      {
        this.actionName = value;
        this.routeName = this.url = (string) null;
      }
    }

    public string RouteName
    {
      get => this.routeName;
      set
      {
        this.routeName = value;
        this.controllerName = this.actionName = this.url = (string) null;
      }
    }

    public string Url
    {
      get => this.url;
      set
      {
        this.url = value;
        this.routeName = this.controllerName = this.actionName = (string) null;
        this.RouteValues.Clear();
      }
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
