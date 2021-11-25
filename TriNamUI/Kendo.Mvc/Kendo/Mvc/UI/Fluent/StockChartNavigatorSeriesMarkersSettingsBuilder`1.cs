// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.StockChartNavigatorSeriesMarkersSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class StockChartNavigatorSeriesMarkersSettingsBuilder<T> where T : class
  {
    public StockChartNavigatorSeriesMarkersSettingsBuilder(
      StockChartNavigatorSeriesMarkersSettings<T> container)
    {
      this.Container = container;
    }

    protected StockChartNavigatorSeriesMarkersSettings<T> Container { get; private set; }

    public StockChartNavigatorSeriesMarkersSettingsBuilder<T> Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public StockChartNavigatorSeriesMarkersSettingsBuilder<T> Border(
      Action<StockChartNavigatorSeriesMarkersBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorSeriesMarkersBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public StockChartNavigatorSeriesMarkersSettingsBuilder<T> Rotation(
      double value)
    {
      this.Container.Rotation = new double?(value);
      return this;
    }

    public StockChartNavigatorSeriesMarkersSettingsBuilder<T> Size(
      double value)
    {
      this.Container.Size = new double?(value);
      return this;
    }

    public StockChartNavigatorSeriesMarkersSettingsBuilder<T> Type(
      string value)
    {
      this.Container.Type = value;
      return this;
    }

    public StockChartNavigatorSeriesMarkersSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public StockChartNavigatorSeriesMarkersSettingsBuilder<T> Visible()
    {
      this.Container.Visible = new bool?(true);
      return this;
    }
  }
}
