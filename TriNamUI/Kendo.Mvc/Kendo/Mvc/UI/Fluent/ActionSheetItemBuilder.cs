// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ActionSheetItemBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ActionSheetItemBuilder
  {
    public ActionSheetItemBuilder(ActionSheetItem container) => this.Container = container;

    protected ActionSheetItem Container { get; private set; }

    public ActionSheetItemBuilder Click(string handler)
    {
      this.Container.Click = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ActionSheetItemBuilder Click(Func<object, object> handler)
    {
      this.Container.Click = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public ActionSheetItemBuilder Description(string value)
    {
      this.Container.Description = value;
      return this;
    }

    public ActionSheetItemBuilder Disabled(bool value)
    {
      this.Container.Disabled = new bool?(value);
      return this;
    }

    public ActionSheetItemBuilder Group(string value)
    {
      this.Container.Group = value;
      return this;
    }

    public ActionSheetItemBuilder IconClass(string value)
    {
      this.Container.IconClass = value;
      return this;
    }

    public ActionSheetItemBuilder IconColor(string value)
    {
      this.Container.IconColor = value;
      return this;
    }

    public ActionSheetItemBuilder IconSize(double value)
    {
      this.Container.IconSize = new double?(value);
      return this;
    }

    public ActionSheetItemBuilder Text(string value)
    {
      this.Container.Text = value;
      return this;
    }
  }
}
