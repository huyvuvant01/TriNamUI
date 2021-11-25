// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.StockChartNavigatorPaneTitleSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class StockChartNavigatorPaneTitleSettingsBuilder<T> where T : class
  {
    public StockChartNavigatorPaneTitleSettingsBuilder(
      StockChartNavigatorPaneTitleSettings<T> container)
    {
      this.Container = container;
    }

    protected StockChartNavigatorPaneTitleSettings<T> Container { get; private set; }

    public StockChartNavigatorPaneTitleSettingsBuilder<T> Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public StockChartNavigatorPaneTitleSettingsBuilder<T> Border(
      Action<StockChartNavigatorPaneTitleBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorPaneTitleBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public StockChartNavigatorPaneTitleSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public StockChartNavigatorPaneTitleSettingsBuilder<T> Font(
      string value)
    {
      this.Container.Font = value;
      return this;
    }

    public StockChartNavigatorPaneTitleSettingsBuilder<T> Margin(
      Action<StockChartNavigatorPaneTitleMarginSettingsBuilder<T>> configurator)
    {
      this.Container.Margin.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorPaneTitleMarginSettingsBuilder<T>(this.Container.Margin));
      return this;
    }

    public StockChartNavigatorPaneTitleSettingsBuilder<T> Position(
      string value)
    {
      this.Container.Position = value;
      return this;
    }

    public StockChartNavigatorPaneTitleSettingsBuilder<T> Text(
      string value)
    {
      this.Container.Text = value;
      return this;
    }

    public StockChartNavigatorPaneTitleSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }
  }
}
