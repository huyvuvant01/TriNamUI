// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SortableBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class SortableBuilder : WidgetBuilderBase<Sortable, SortableBuilder>
  {
    public SortableBuilder(Sortable component)
      : base(component)
    {
    }

    public virtual SortableBuilder For(string selector)
    {
      this.Component.SortableContainer = selector;
      this.Component.Name = selector;
      return this;
    }

    public virtual SortableBuilder ContainerSelector(string selector)
    {
      this.Component.ContainerSelector = selector;
      return this;
    }

    public virtual SortableBuilder HintHandler(Func<object, object> handler)
    {
      this.Container.HintHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public virtual SortableBuilder HintHandler(string handler)
    {
      this.Container.HintHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public virtual SortableBuilder Hint(string content)
    {
      this.Container.Hint = content;
      return this;
    }

    public virtual SortableBuilder PlaceholderHandler(Func<object, object> handler)
    {
      this.Container.PlaceholderHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public virtual SortableBuilder PlaceholderHandler(string handler)
    {
      this.Container.PlaceholderHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public virtual SortableBuilder Placeholder(string content)
    {
      this.Container.Placeholder = content;
      return this;
    }

    public SortableBuilder AutoScroll(bool value)
    {
      this.Container.AutoScroll = new bool?(value);
      return this;
    }

    public SortableBuilder AutoScroll()
    {
      this.Container.AutoScroll = new bool?(true);
      return this;
    }

    public SortableBuilder ConnectWith(string value)
    {
      this.Container.ConnectWith = value;
      return this;
    }

    public SortableBuilder Cursor(string value)
    {
      this.Container.Cursor = value;
      return this;
    }

    public SortableBuilder CursorOffset(
      Action<SortableCursorOffsetSettingsBuilder> configurator)
    {
      this.Container.CursorOffset.Sortable = this.Container;
      configurator(new SortableCursorOffsetSettingsBuilder(this.Container.CursorOffset));
      return this;
    }

    public SortableBuilder Disabled(string value)
    {
      this.Container.Disabled = value;
      return this;
    }

    public SortableBuilder Filter(string value)
    {
      this.Container.Filter = value;
      return this;
    }

    public SortableBuilder Handler(string value)
    {
      this.Container.Handler = value;
      return this;
    }

    public SortableBuilder HoldToDrag(bool value)
    {
      this.Container.HoldToDrag = new bool?(value);
      return this;
    }

    public SortableBuilder HoldToDrag()
    {
      this.Container.HoldToDrag = new bool?(true);
      return this;
    }

    public SortableBuilder Ignore(string value)
    {
      this.Container.Ignore = value;
      return this;
    }

    public SortableBuilder Axis(SortableAxis value)
    {
      this.Container.Axis = new SortableAxis?(value);
      return this;
    }

    public SortableBuilder Events(Action<SortableEventBuilder> configurator)
    {
      configurator(new SortableEventBuilder(this.Container.Events));
      return this;
    }
  }
}
