// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SplitterPaneBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Kendo.Mvc.UI.Fluent
{
  public class SplitterPaneBuilder
  {
    private readonly Regex sizeValueRegex = new Regex("^\\d+(px|%)$", RegexOptions.IgnoreCase);

    public SplitterPaneBuilder(SplitterPane container) => this.Container = container;

    protected SplitterPane Container { get; private set; }

    public SplitterPaneBuilder MinSize(string size)
    {
      this.Container.MinSize = this.sizeValueRegex.IsMatch(size) ? size : throw new ArgumentException("MinSize should be in pixels or percentages", nameof (size));
      return this;
    }

    public SplitterPaneBuilder MaxSize(string size)
    {
      this.Container.MaxSize = this.sizeValueRegex.IsMatch(size) ? size : throw new ArgumentException("MaxSize should be in pixels or percentages", nameof (size));
      return this;
    }

    public SplitterPaneBuilder HtmlAttributes(object attributes) => this.HtmlAttributes(attributes.ToDictionary());

    public SplitterPaneBuilder HtmlAttributes(
      IDictionary<string, object> attributes)
    {
      this.Container.HtmlAttributes.Clear();
      DictionaryExtensions.Merge(this.Container.HtmlAttributes, attributes);
      return this;
    }

    public SplitterPaneBuilder Content(Action content)
    {
      this.Container.TemplateAction = content;
      return this;
    }

    public SplitterPaneBuilder Content(Func<object, object> content)
    {
      this.Container.Template = content;
      return this;
    }

    public SplitterPaneBuilder Content(string content)
    {
      this.Container.Html = content;
      return this;
    }

    public SplitterPaneBuilder LoadContentFrom(RouteValueDictionary routeValues) => routeValues.ApplyTo<SplitterPaneBuilder>(new Func<string, string, RouteValueDictionary, SplitterPaneBuilder>(this.LoadContentFrom));

    public SplitterPaneBuilder LoadContentFrom(
      string actionName,
      string controllerName)
    {
      return this.LoadContentFrom(actionName, controllerName, (object) null);
    }

    public SplitterPaneBuilder LoadContentFrom(
      string actionName,
      string controllerName,
      object routeValues)
    {
      return this.LoadContentFrom(actionName, controllerName, new RouteValueDictionary(routeValues));
    }

    public SplitterPaneBuilder LoadContentFrom(
      string actionName,
      string controllerName,
      RouteValueDictionary routeValues)
    {
      return this.LoadContentFrom(SplitterPaneBuilder.GetUrlHelper(this.Container.Splitter.ViewContext).Action(actionName, controllerName, (object) routeValues));
    }

    public SplitterPaneBuilder LoadContentFrom(string value)
    {
      this.Container.ContentUrl = value;
      return this;
    }

    public SplitterPaneBuilder Label(string label)
    {
      this.Container.Label = label;
      return this;
    }

    public SplitterPaneBuilder LabelId(string labelId)
    {
      this.Container.LabelId = labelId;
      return this;
    }

    private static IUrlHelper GetUrlHelper(ViewContext context) => context.HttpContext.RequestServices.GetRequiredService<IUrlHelperFactory>().GetUrlHelper((ActionContext) context);

    public SplitterPaneBuilder Collapsed(bool value)
    {
      this.Container.Collapsed = new bool?(value);
      return this;
    }

    public SplitterPaneBuilder CollapsedSize(string value)
    {
      this.Container.CollapsedSize = value;
      return this;
    }

    public SplitterPaneBuilder Collapsible(bool value)
    {
      this.Container.Collapsible = new bool?(value);
      return this;
    }

    public SplitterPaneBuilder Resizable(bool value)
    {
      this.Container.Resizable = new bool?(value);
      return this;
    }

    public SplitterPaneBuilder Scrollable(bool value)
    {
      this.Container.Scrollable = new bool?(value);
      return this;
    }

    public SplitterPaneBuilder Size(string value)
    {
      this.Container.Size = value;
      return this;
    }
  }
}
