// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartPlotAreaSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartPlotAreaSettingsBuilder<T> where T : class
  {
    public ChartPlotAreaSettingsBuilder(ChartPlotAreaSettings<T> container) => this.Container = container;

    protected ChartPlotAreaSettings<T> Container { get; private set; }

    public ChartPlotAreaSettingsBuilder<T> Background(string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ChartPlotAreaSettingsBuilder<T> Border(
      Action<ChartPlotAreaBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.Chart = this.Container.Chart;
      configurator(new ChartPlotAreaBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public ChartPlotAreaSettingsBuilder<T> Margin(
      Action<ChartPlotAreaMarginSettingsBuilder<T>> configurator)
    {
      this.Container.Margin.Chart = this.Container.Chart;
      configurator(new ChartPlotAreaMarginSettingsBuilder<T>(this.Container.Margin));
      return this;
    }

    public ChartPlotAreaSettingsBuilder<T> Opacity(double value)
    {
      this.Container.Opacity = new double?(value);
      return this;
    }

    public ChartPlotAreaSettingsBuilder<T> Padding(
      Action<ChartPlotAreaPaddingSettingsBuilder<T>> configurator)
    {
      this.Container.Padding.Chart = this.Container.Chart;
      configurator(new ChartPlotAreaPaddingSettingsBuilder<T>(this.Container.Padding));
      return this;
    }
  }
}
