// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.WindowBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class WindowBuilder : WidgetBuilderBase<Window, WindowBuilder>
  {
    public WindowBuilder(Window component)
      : base(component)
    {
    }

    public WindowBuilder Actions(Action<WindowActionsBuilder> actionsBuilderAction)
    {
      this.Component.Actions.Container.Clear();
      actionsBuilderAction(new WindowActionsBuilder((IWindowButtonsContainer) this.Component.Actions));
      return this;
    }

    public WindowBuilder Draggable(
      Action<WindowDraggableSettingsBuilder> configurator)
    {
      this.Container.DraggableSettings.Enabled = new bool?(true);
      this.Container.DraggableSettings.Window = this.Container;
      configurator(new WindowDraggableSettingsBuilder(this.Container.DraggableSettings));
      return this;
    }

    public WindowBuilder Draggable(bool enabled)
    {
      this.Container.Draggable = enabled;
      return this;
    }

    public WindowBuilder Animation(Action<PopupAnimationBuilder> animationAction)
    {
      animationAction(new PopupAnimationBuilder(this.Component.Animation));
      return this;
    }

    public WindowBuilder Animation(bool enable)
    {
      this.Component.Animation.Enabled = enable;
      return this;
    }

    public WindowBuilder Title(Action<WindowTitleSettingsBuilder> configurator)
    {
      configurator(new WindowTitleSettingsBuilder(this.Component.TitleSettings));
      return this;
    }

    public WindowBuilder Title(bool show)
    {
      this.Component.Title = (object) show;
      return this;
    }

    public WindowBuilder Title(string title)
    {
      this.Component.Title = (object) title;
      return this;
    }

    public WindowBuilder Modal(Action<WindowModalSettingsBuilder> configurator)
    {
      this.Container.ModalSettings.Enabled = new bool?(true);
      this.Container.ModalSettings.Window = this.Container;
      configurator(new WindowModalSettingsBuilder(this.Container.ModalSettings));
      return this;
    }

    public WindowBuilder Modal()
    {
      this.Container.Modal = true;
      return this;
    }

    public WindowBuilder Modal(bool enabled)
    {
      this.Container.Modal = enabled;
      return this;
    }

    public WindowBuilder AppendTo(string selector)
    {
      this.Component.AppendTo = selector;
      return this;
    }

    public WindowBuilder Content(Action value)
    {
      this.Component.ContentAction = value;
      return this;
    }

    public WindowBuilder Content(Func<object, object> value)
    {
      this.Component.Content = value;
      return this;
    }

    public WindowBuilder Content(string value)
    {
      this.Component.Html = value;
      return this;
    }

    public WindowBuilder Draggable()
    {
      this.Draggable(true);
      return this;
    }

    public WindowBuilder LoadContentFrom(RouteValueDictionary routeValues) => routeValues.ApplyTo<WindowBuilder>(new Func<string, string, RouteValueDictionary, WindowBuilder>(this.LoadContentFrom));

    public WindowBuilder LoadContentFrom(string actionName, string controllerName) => this.LoadContentFrom(actionName, controllerName, (object) null);

    public WindowBuilder LoadContentFrom(
      string actionName,
      string controllerName,
      object routeValues)
    {
      return this.LoadContentFrom(actionName, controllerName, new RouteValueDictionary(routeValues));
    }

    public WindowBuilder LoadContentFrom(
      string actionName,
      string controllerName,
      RouteValueDictionary routeValues)
    {
      return this.LoadContentFrom(this.Container.ViewContext.HttpContext.RequestServices.GetRequiredService<IUrlHelperFactory>().GetUrlHelper((ActionContext) this.Container.ViewContext).Action(actionName, controllerName, (object) routeValues));
    }

    public WindowBuilder LoadContentFrom(string value)
    {
      this.Component.ContentUrl = value;
      return this;
    }

    public WindowBuilder Resizable()
    {
      this.Component.ResizingSettings.Enabled = true;
      return this;
    }

    public WindowBuilder Resizable(
      Action<WindowResizingSettingsBuilder> resizingSettingsAction)
    {
      this.Component.ResizingSettings.Enabled = true;
      resizingSettingsAction(new WindowResizingSettingsBuilder(this.Component.ResizingSettings));
      return this;
    }

    public WindowBuilder Height(double value)
    {
      this.Container.Height = value.ToString() + "px";
      return this;
    }

    public WindowBuilder MaxHeight(double value)
    {
      this.Container.MaxHeight = value.ToString() + "px";
      return this;
    }

    public WindowBuilder MaxWidth(double value)
    {
      this.Container.MaxWidth = value.ToString() + "px";
      return this;
    }

    public WindowBuilder MinHeight(double value)
    {
      this.Container.MinHeight = value.ToString() + "px";
      return this;
    }

    public WindowBuilder MinWidth(double value)
    {
      this.Container.MinWidth = value.ToString() + "px";
      return this;
    }

    public WindowBuilder Width(double value)
    {
      this.Container.Width = value.ToString() + "px";
      return this;
    }

    public WindowBuilder Height(string value)
    {
      this.Container.Height = value;
      return this;
    }

    public WindowBuilder MaxHeight(string value)
    {
      this.Container.MaxHeight = value;
      return this;
    }

    public WindowBuilder MaxWidth(string value)
    {
      this.Container.MaxWidth = value;
      return this;
    }

    public WindowBuilder MinHeight(string value)
    {
      this.Container.MinHeight = value;
      return this;
    }

    public WindowBuilder MinWidth(string value)
    {
      this.Container.MinWidth = value;
      return this;
    }

    public WindowBuilder Width(string value)
    {
      this.Container.Width = value;
      return this;
    }

    public WindowBuilder Position(Action<WindowPositionSettingsBuilder> configurator)
    {
      this.Container.Position.Window = this.Container;
      configurator(new WindowPositionSettingsBuilder(this.Container.Position));
      return this;
    }

    public WindowBuilder AutoFocus(bool value)
    {
      this.Container.AutoFocus = new bool?(value);
      return this;
    }

    public WindowBuilder Iframe(bool value)
    {
      this.Container.Iframe = new bool?(value);
      return this;
    }

    public WindowBuilder Pinned(bool value)
    {
      this.Container.Pinned = new bool?(value);
      return this;
    }

    public WindowBuilder Pinned()
    {
      this.Container.Pinned = new bool?(true);
      return this;
    }

    public WindowBuilder Scrollable(bool value)
    {
      this.Container.Scrollable = new bool?(value);
      return this;
    }

    public WindowBuilder Visible(bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public WindowBuilder Size(string value)
    {
      this.Container.Size = value;
      return this;
    }

    public WindowBuilder Events(Action<WindowEventBuilder> configurator)
    {
      configurator(new WindowEventBuilder(this.Container.Events));
      return this;
    }
  }
}
