// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PopoverBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class PopoverBuilder : WidgetBuilderBase<Popover, PopoverBuilder>
  {
    public PopoverBuilder(Popover component)
      : base(component)
    {
    }

    public PopoverBuilder Animation(bool enable)
    {
      this.Component.Animation.Enabled = enable;
      return this;
    }

    public PopoverBuilder Animation(Action<PopupAnimationBuilder> animationAction)
    {
      animationAction(new PopupAnimationBuilder(this.Component.Animation));
      return this;
    }

    public virtual PopoverBuilder For(string selector)
    {
      this.Component.Container = selector;
      return this;
    }

    public PopoverBuilder Actions(Action<PopoverActionFactory> configurator)
    {
      configurator(new PopoverActionFactory(this.Container.Actions)
      {
        Popover = this.Container
      });
      return this;
    }

    public PopoverBuilder Body(string value)
    {
      this.Container.BodyHandler = (ClientHandlerDescriptor) null;
      this.Container.Body = value;
      return this;
    }

    public PopoverBuilder BodyHandler(string handler)
    {
      this.Container.Body = (string) null;
      this.Container.BodyHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public PopoverBuilder BodyHandler(Func<object, object> handler)
    {
      this.Container.Body = (string) null;
      this.Container.BodyHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public PopoverBuilder Filter(string value)
    {
      this.Container.Filter = value;
      return this;
    }

    public PopoverBuilder Header(string value)
    {
      this.Container.HeaderHandler = (ClientHandlerDescriptor) null;
      this.Container.Header = value;
      return this;
    }

    public PopoverBuilder HeaderHandler(string handler)
    {
      this.Container.Header = (string) null;
      this.Container.HeaderHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public PopoverBuilder HeaderHandler(Func<object, object> handler)
    {
      this.Container.Header = (string) null;
      this.Container.HeaderHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public PopoverBuilder Height(double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }

    public PopoverBuilder ToggleOnClick(bool value)
    {
      this.Container.ToggleOnClick = new bool?(value);
      return this;
    }

    public PopoverBuilder ToggleOnClick()
    {
      this.Container.ToggleOnClick = new bool?(true);
      return this;
    }

    public PopoverBuilder Width(double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }

    public PopoverBuilder Offset(double value)
    {
      this.Container.Offset = new double?(value);
      return this;
    }

    public PopoverBuilder ActionsLayout(PopoverActionsLayout value)
    {
      this.Container.ActionsLayout = new PopoverActionsLayout?(value);
      return this;
    }

    public PopoverBuilder Position(PopoverPosition value)
    {
      this.Container.Position = new PopoverPosition?(value);
      return this;
    }

    public PopoverBuilder ShowOn(PopoverShowOn value)
    {
      this.Container.ShowOn = new PopoverShowOn?(value);
      return this;
    }

    public PopoverBuilder Events(Action<PopoverEventBuilder> configurator)
    {
      configurator(new PopoverEventBuilder(this.Container.Events));
      return this;
    }
  }
}
