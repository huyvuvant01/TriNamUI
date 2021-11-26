// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.StockChartNavigatorPaneSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class StockChartNavigatorPaneSettingsBuilder<T> where T : class
  {
    public StockChartNavigatorPaneSettingsBuilder(StockChartNavigatorPaneSettings<T> container) => this.Container = container;

    protected StockChartNavigatorPaneSettings<T> Container { get; private set; }

    public StockChartNavigatorPaneSettingsBuilder<T> Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public StockChartNavigatorPaneSettingsBuilder<T> Border(
      Action<StockChartNavigatorPaneBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorPaneBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public StockChartNavigatorPaneSettingsBuilder<T> Height(
      double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }

    public StockChartNavigatorPaneSettingsBuilder<T> Margin(
      Action<StockChartNavigatorPaneMarginSettingsBuilder<T>> configurator)
    {
      this.Container.Margin.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorPaneMarginSettingsBuilder<T>(this.Container.Margin));
      return this;
    }

    public StockChartNavigatorPaneSettingsBuilder<T> Name(
      string value)
    {
      this.Container.Name = value;
      return this;
    }

    public StockChartNavigatorPaneSettingsBuilder<T> Padding(
      Action<StockChartNavigatorPanePaddingSettingsBuilder<T>> configurator)
    {
      this.Container.Padding.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorPanePaddingSettingsBuilder<T>(this.Container.Padding));
      return this;
    }

    public StockChartNavigatorPaneSettingsBuilder<T> Title(
      Action<StockChartNavigatorPaneTitleSettingsBuilder<T>> configurator)
    {
      this.Container.Title.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorPaneTitleSettingsBuilder<T>(this.Container.Title));
      return this;
    }
  }
}
