// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TooltipBuilderBase`1
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

namespace Kendo.Mvc.UI.Fluent
{
  public class TooltipBuilderBase<TBuilder> : 
    WidgetBuilderBase<Tooltip, TooltipBuilderBase<TBuilder>>
    where TBuilder : TooltipBuilderBase<TBuilder>
  {
    public TooltipBuilderBase(Tooltip component)
      : base(component)
    {
    }

    public virtual TBuilder For(string selector)
    {
      this.Component.Container = selector;
      return this as TBuilder;
    }

    protected TBuilder Name(string componentName) => base.Name(componentName) as TBuilder;

    public TBuilder LoadContentFrom(RouteValueDictionary routeValues) => routeValues.ApplyTo<TooltipBuilderBase<TBuilder>>(new Func<string, string, RouteValueDictionary, TooltipBuilderBase<TBuilder>>(this.LoadContentFrom)) as TBuilder;

    public TBuilder LoadContentFrom(string actionName, string controllerName) => this.LoadContentFrom(actionName, controllerName, (object) null);

    public TBuilder LoadContentFrom(string actionName, string controllerName, object routeValues) => this.LoadContentFrom(actionName, controllerName, new RouteValueDictionary(routeValues));

    private static IUrlHelper GetUrlHelper(ViewContext context) => context.HttpContext.RequestServices.GetRequiredService<IUrlHelperFactory>().GetUrlHelper((ActionContext) context);

    public TBuilder LoadContentFrom(
      string actionName,
      string controllerName,
      RouteValueDictionary routeValues)
    {
      return this.LoadContentFrom(TooltipBuilderBase<TBuilder>.GetUrlHelper(this.Component.ViewContext).Action(actionName, controllerName, (object) routeValues));
    }

    public TBuilder LoadContentFrom(string value)
    {
      this.Component.ContentUrl = value;
      return this as TBuilder;
    }

    public TBuilder Content(string value)
    {
      this.Component.Content = value;
      return this as TBuilder;
    }

    public TBuilder ContentTemplateId(string value)
    {
      this.Component.ContentTemplateId = value;
      return this as TBuilder;
    }

    public TBuilder ContentHandler(Func<object, object> handler)
    {
      this.Component.ContentHandler.TemplateDelegate = handler;
      return this as TBuilder;
    }

    public TBuilder ContentHandler(string handler)
    {
      this.Component.ContentHandler.HandlerName = handler;
      return this as TBuilder;
    }

    public TBuilder Animation(bool enable)
    {
      this.Component.Animation.Enabled = enable;
      return this as TBuilder;
    }

    public TBuilder Animation(Action<PopupAnimationBuilder> animationAction)
    {
      animationAction(new PopupAnimationBuilder(this.Component.Animation));
      return this as TBuilder;
    }

    public TBuilder AutoHide(bool value)
    {
      this.Container.AutoHide = new bool?(value);
      return this as TBuilder;
    }

    public TBuilder Callout(bool value)
    {
      this.Container.Callout = new bool?(value);
      return this as TBuilder;
    }

    public TBuilder Filter(string value)
    {
      this.Container.Filter = value;
      return this as TBuilder;
    }

    public TBuilder Iframe(bool value)
    {
      this.Container.Iframe = new bool?(value);
      return this as TBuilder;
    }

    public TBuilder Height(double value)
    {
      this.Container.Height = new double?(value);
      return this as TBuilder;
    }

    public TBuilder Width(double value)
    {
      this.Container.Width = new double?(value);
      return this as TBuilder;
    }

    public TBuilder ShowAfter(double value)
    {
      this.Container.ShowAfter = new double?(value);
      return this as TBuilder;
    }

    public TBuilder Position(TooltipPosition value)
    {
      this.Container.Position = new TooltipPosition?(value);
      return this as TBuilder;
    }

    public TBuilder ShowOn(TooltipShowOnEvent value)
    {
      this.Container.ShowOn = new TooltipShowOnEvent?(value);
      return this as TBuilder;
    }

    public TBuilder Events(Action<TooltipEventBuilder> configurator)
    {
      configurator(new TooltipEventBuilder(this.Container.Events));
      return this as TBuilder;
    }
  }
}
