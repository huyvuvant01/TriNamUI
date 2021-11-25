// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ResponsivePanelBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ResponsivePanelBuilder : WidgetBuilderBase<ResponsivePanel, ResponsivePanelBuilder>
  {
    public ResponsivePanelBuilder(ResponsivePanel component)
      : base(component)
    {
    }

    public ResponsivePanelBuilder Orientation(string value)
    {
      this.Container.Orientation = new ResponsivePanelOrientation?((ResponsivePanelOrientation) Enum.Parse(typeof (ResponsivePanelOrientation), value, true));
      return this;
    }

    public ResponsivePanelBuilder AutoClose(bool value)
    {
      this.Container.AutoClose = new bool?(value);
      return this;
    }

    public ResponsivePanelBuilder Breakpoint(double value)
    {
      this.Container.Breakpoint = new double?(value);
      return this;
    }

    public ResponsivePanelBuilder ToggleButton(string value)
    {
      this.Container.ToggleButton = value;
      return this;
    }

    public ResponsivePanelBuilder Content(string value)
    {
      this.Container.Content = value;
      return this;
    }

    public ResponsivePanelBuilder Orientation(ResponsivePanelOrientation value)
    {
      this.Container.Orientation = new ResponsivePanelOrientation?(value);
      return this;
    }

    public ResponsivePanelBuilder Events(
      Action<ResponsivePanelEventBuilder> configurator)
    {
      configurator(new ResponsivePanelEventBuilder(this.Container.Events));
      return this;
    }
  }
}
