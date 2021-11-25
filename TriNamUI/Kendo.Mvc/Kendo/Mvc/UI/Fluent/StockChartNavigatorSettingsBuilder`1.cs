// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.StockChartNavigatorSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class StockChartNavigatorSettingsBuilder<T> where T : class
  {
    public StockChartNavigatorSettingsBuilder(StockChartNavigatorSettings<T> container) => this.Container = container;

    protected StockChartNavigatorSettings<T> Container { get; private set; }

    public StockChartNavigatorSettingsBuilder<T> DataSource(
      Action<ReadOnlyAjaxDataSourceBuilder<T>> configurator)
    {
      configurator(new ReadOnlyAjaxDataSourceBuilder<T>(this.Container.DataSource, this.Container.ViewContext, this.Container.UrlGenerator));
      return this;
    }

    public StockChartNavigatorSettingsBuilder<T> Select(
      DateTime? from,
      DateTime? to)
    {
      this.Container.Select.From = from;
      this.Container.Select.To = to;
      return this;
    }

    public StockChartNavigatorSettingsBuilder<T> Series(
      Action<ChartSeriesFactory<T>> configurator)
    {
      configurator(new ChartSeriesFactory<T>(this.Container.Series)
      {
        Chart = (Chart<T>) this.Container.StockChart
      });
      return this;
    }

    public StockChartNavigatorSettingsBuilder<T> CategoryAxis(
      Action<StockChartNavigatorCategoryAxisSettingsBuilder<T>> configurator)
    {
      this.Container.CategoryAxis.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorCategoryAxisSettingsBuilder<T>(this.Container.CategoryAxis));
      return this;
    }

    public StockChartNavigatorSettingsBuilder<T> AutoBind(
      bool value)
    {
      this.Container.AutoBind = new bool?(value);
      return this;
    }

    public StockChartNavigatorSettingsBuilder<T> DateField(
      string value)
    {
      this.Container.DateField = value;
      return this;
    }

    public StockChartNavigatorSettingsBuilder<T> Pane(
      Action<StockChartNavigatorPaneSettingsBuilder<T>> configurator)
    {
      this.Container.Pane.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorPaneSettingsBuilder<T>(this.Container.Pane));
      return this;
    }

    public StockChartNavigatorSettingsBuilder<T> Select(
      Action<StockChartNavigatorSelectSettingsBuilder<T>> configurator)
    {
      this.Container.Select.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorSelectSettingsBuilder<T>(this.Container.Select));
      return this;
    }

    public StockChartNavigatorSettingsBuilder<T> Hint(
      Action<StockChartNavigatorHintSettingsBuilder<T>> configurator)
    {
      this.Container.Hint.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorHintSettingsBuilder<T>(this.Container.Hint));
      return this;
    }

    public StockChartNavigatorSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }
  }
}
