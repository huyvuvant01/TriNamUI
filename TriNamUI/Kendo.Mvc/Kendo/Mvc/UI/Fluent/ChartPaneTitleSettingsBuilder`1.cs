// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartPaneTitleSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartPaneTitleSettingsBuilder<T> where T : class
  {
    public ChartPaneTitleSettingsBuilder(ChartPaneTitleSettings<T> container) => this.Container = container;

    protected ChartPaneTitleSettings<T> Container { get; private set; }

    public ChartPaneTitleSettingsBuilder<T> Background(string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ChartPaneTitleSettingsBuilder<T> Border(
      Action<ChartPaneTitleBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartPaneTitleBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartPaneTitleSettingsBuilder<T> Color(string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartPaneTitleSettingsBuilder<T> Font(string value)
    {
      this.Container.Font = value;
      return this;
    }

    public ChartPaneTitleSettingsBuilder<T> Margin(
      Action<ChartPaneTitleMarginSettingsBuilder<T>> configurator)
    {
      this.Container.Margin.Chart = this.Container.Chart;
      configurator(new ChartPaneTitleMarginSettingsBuilder<T>(this.Container.Margin));
      return this;
    }

    public ChartPaneTitleSettingsBuilder<T> Position(string value)
    {
      this.Container.Position = value;
      return this;
    }

    public ChartPaneTitleSettingsBuilder<T> Text(string value)
    {
      this.Container.Text = value;
      return this;
    }

    public ChartPaneTitleSettingsBuilder<T> Visible(bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartPaneTitleSettingsBuilder<T> Visual(string handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public ChartPaneTitleSettingsBuilder<T> Visual(
      Func<object, object> handler)
    {
      this.Container.Visual = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }
  }
}
