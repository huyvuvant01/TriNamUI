// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.StockChartNavigatorSeriesHighlightSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class StockChartNavigatorSeriesHighlightSettingsBuilder<T> where T : class
  {
    public StockChartNavigatorSeriesHighlightSettingsBuilder(
      StockChartNavigatorSeriesHighlightSettings<T> container)
    {
      this.Container = container;
    }

    protected StockChartNavigatorSeriesHighlightSettings<T> Container { get; private set; }

    public StockChartNavigatorSeriesHighlightSettingsBuilder<T> Border(
      Action<StockChartNavigatorSeriesHighlightBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorSeriesHighlightBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public StockChartNavigatorSeriesHighlightSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public StockChartNavigatorSeriesHighlightSettingsBuilder<T> Line(
      Action<StockChartNavigatorSeriesHighlightLineSettingsBuilder<T>> configurator)
    {
      this.Container.Line.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorSeriesHighlightLineSettingsBuilder<T>(this.Container.Line));
      return this;
    }

    public StockChartNavigatorSeriesHighlightSettingsBuilder<T> Opacity(
      double value)
    {
      this.Container.Opacity = new double?(value);
      return this;
    }

    public StockChartNavigatorSeriesHighlightSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }
  }
}
