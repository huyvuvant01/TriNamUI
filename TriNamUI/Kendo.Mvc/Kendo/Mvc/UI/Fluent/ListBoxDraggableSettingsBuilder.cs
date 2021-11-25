// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ListBoxDraggableSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ListBoxDraggableSettingsBuilder
  {
    public ListBoxDraggableSettingsBuilder(ListBoxDraggableSettings container) => this.Container = container;

    protected ListBoxDraggableSettings Container { get; private set; }

    public ListBoxDraggableSettingsBuilder Enabled(bool value)
    {
      this.Container.Enabled = new bool?(value);
      return this;
    }

    public ListBoxDraggableSettingsBuilder Hint(string handler)
    {
      this.Container.Hint = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ListBoxDraggableSettingsBuilder Hint(
      Func<object, object> handler)
    {
      this.Container.Hint = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ListBoxDraggableSettingsBuilder Placeholder(string handler)
    {
      this.Container.Placeholder = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ListBoxDraggableSettingsBuilder Placeholder(
      Func<object, object> handler)
    {
      this.Container.Placeholder = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }
  }
}
