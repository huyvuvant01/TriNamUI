// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PopoverActionBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class PopoverActionBuilder
  {
    public PopoverActionBuilder(PopoverAction container) => this.Container = container;

    protected PopoverAction Container { get; private set; }

    public PopoverActionBuilder Click(string handler)
    {
      this.Container.Click = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public PopoverActionBuilder Click(Func<object, object> handler)
    {
      this.Container.Click = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public PopoverActionBuilder IconClass(string handler)
    {
      this.Container.IconClass = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public PopoverActionBuilder IconClass(Func<object, object> handler)
    {
      this.Container.IconClass = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public PopoverActionBuilder Text(string value)
    {
      this.Container.Text = value;
      return this;
    }
  }
}
