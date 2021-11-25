// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FloatingActionButtonItemBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class FloatingActionButtonItemBuilder
  {
    public FloatingActionButtonItemBuilder(FloatingActionButtonItem container) => this.Container = container;

    protected FloatingActionButtonItem Container { get; private set; }

    public FloatingActionButtonItemBuilder Enabled(bool value)
    {
      this.Container.Enabled = new bool?(value);
      return this;
    }

    public FloatingActionButtonItemBuilder Click(string handler)
    {
      this.Container.Click = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public FloatingActionButtonItemBuilder Click(
      Func<object, object> handler)
    {
      this.Container.Click = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public FloatingActionButtonItemBuilder CssClass(string value)
    {
      this.Container.CssClass = value;
      return this;
    }

    public FloatingActionButtonItemBuilder Icon(string value)
    {
      this.Container.Icon = value;
      return this;
    }

    public FloatingActionButtonItemBuilder Label(string value)
    {
      this.Container.Label = value;
      return this;
    }

    public FloatingActionButtonItemBuilder Template(string value)
    {
      this.Container.Template = value;
      return this;
    }

    public FloatingActionButtonItemBuilder TemplateId(
      string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public FloatingActionButtonItemBuilder Title(string value)
    {
      this.Container.Title = value;
      return this;
    }
  }
}
