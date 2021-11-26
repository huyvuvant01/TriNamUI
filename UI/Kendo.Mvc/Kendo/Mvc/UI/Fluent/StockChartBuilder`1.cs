// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.StockChartBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class StockChartBuilder<T> : WidgetBuilderBase<StockChart<T>, StockChartBuilder<T>>
    where T : class
  {
    public StockChartBuilder(StockChart<T> component)
      : base(component)
    {
    }

    public StockChartBuilder<T> CategoryAxis(
      Action<ChartCategoryAxisBuilder<T>> configurator)
    {
      ChartCategoryAxis<T> container = new ChartCategoryAxis<T>()
      {
        Chart = (Chart<T>) this.Container
      };
      this.Container.CategoryAxis.Add(container);
      configurator(new ChartCategoryAxisBuilder<T>(container));
      return this;
    }

    public StockChartBuilder<T> DataSource(
      Action<ReadOnlyAjaxDataSourceBuilder<T>> configurator)
    {
      configurator(new ReadOnlyAjaxDataSourceBuilder<T>(this.Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public StockChartBuilder<T> SeriesDefaults(
      Action<ChartSeriesDefaultsSettingsBuilder<T>> configurator)
    {
      configurator(new ChartSeriesDefaultsSettingsBuilder<T>(this.Container.SeriesDefaults));
      return this;
    }

    public StockChartBuilder<T> ValueAxis(
      Action<ChartValueAxisBuilder<T>> configurator)
    {
      ChartValueAxis<T> container = new ChartValueAxis<T>();
      configurator(new ChartValueAxisBuilder<T>(container));
      this.Component.ValueAxis.Add(container);
      return this;
    }

    public StockChartBuilder<T> XAxis(Action<ChartXAxisBuilder<T>> configurator)
    {
      configurator(new ChartXAxisFactory<T>(this.Container.XAxis).Add());
      return this;
    }

    public StockChartBuilder<T> AutoBind(bool value)
    {
      this.Container.AutoBind = new bool?(value);
      return this;
    }

    public StockChartBuilder<T> AxisDefaults(
      Action<ChartAxisDefaultsSettingsBuilder<T>> configurator)
    {
      this.Container.AxisDefaults.Chart = (Chart<T>) this.Container;
      configurator(new ChartAxisDefaultsSettingsBuilder<T>(this.Container.AxisDefaults));
      return this;
    }

    public StockChartBuilder<T> ChartArea(
      Action<ChartChartAreaSettingsBuilder<T>> configurator)
    {
      this.Container.ChartArea.Chart = (Chart<T>) this.Container;
      configurator(new ChartChartAreaSettingsBuilder<T>(this.Container.ChartArea));
      return this;
    }

    public StockChartBuilder<T> Legend(
      Action<ChartLegendSettingsBuilder<T>> configurator)
    {
      this.Container.Legend.Chart = (Chart<T>) this.Container;
      configurator(new ChartLegendSettingsBuilder<T>(this.Container.Legend));
      return this;
    }

    public StockChartBuilder<T> Legend(bool visible)
    {
      this.Component.Legend.Visible = new bool?(visible);
      return this;
    }

    public StockChartBuilder<T> Panes(Action<ChartPaneFactory<T>> configurator)
    {
      configurator(new ChartPaneFactory<T>(this.Container.Panes)
      {
        Chart = (Chart<T>) this.Container
      });
      return this;
    }

    public StockChartBuilder<T> Pannable(
      Action<ChartPannableSettingsBuilder<T>> configurator)
    {
      this.Container.Pannable.Enabled = new bool?(true);
      this.Container.Pannable.Chart = (Chart<T>) this.Container;
      configurator(new ChartPannableSettingsBuilder<T>(this.Container.Pannable));
      return this;
    }

    public StockChartBuilder<T> Pannable()
    {
      this.Container.Pannable.Enabled = new bool?(true);
      return this;
    }

    public StockChartBuilder<T> Pannable(bool enabled)
    {
      this.Container.Pannable.Enabled = new bool?(enabled);
      return this;
    }

    public StockChartBuilder<T> Pdf(Action<ChartPdfSettingsBuilder<T>> configurator)
    {
      this.Container.Pdf.Chart = (Chart<T>) this.Container;
      configurator(new ChartPdfSettingsBuilder<T>(this.Container.Pdf));
      return this;
    }

    public StockChartBuilder<T> PlotArea(
      Action<ChartPlotAreaSettingsBuilder<T>> configurator)
    {
      this.Container.PlotArea.Chart = (Chart<T>) this.Container;
      configurator(new ChartPlotAreaSettingsBuilder<T>(this.Container.PlotArea));
      return this;
    }

    public StockChartBuilder<T> Series(Action<ChartSeriesFactory<T>> configurator)
    {
      configurator(new ChartSeriesFactory<T>(this.Container.Series)
      {
        Chart = (Chart<T>) this.Container
      });
      return this;
    }

    public StockChartBuilder<T> SeriesColors(params string[] value)
    {
      this.Container.SeriesColors = value;
      return this;
    }

    public StockChartBuilder<T> Theme(string value)
    {
      this.Container.Theme = value;
      return this;
    }

    public StockChartBuilder<T> Title(
      Action<ChartTitleSettingsBuilder<T>> configurator)
    {
      this.Container.Title.Chart = (Chart<T>) this.Container;
      configurator(new ChartTitleSettingsBuilder<T>(this.Container.Title));
      return this;
    }

    public StockChartBuilder<T> Title(string title)
    {
      this.Container.Title.Text = title;
      return this;
    }

    public StockChartBuilder<T> Tooltip(
      Action<ChartTooltipSettingsBuilder<T>> configurator)
    {
      this.Container.Tooltip.Chart = (Chart<T>) this.Container;
      configurator(new ChartTooltipSettingsBuilder<T>(this.Container.Tooltip));
      return this;
    }

    public StockChartBuilder<T> Tooltip(bool visible)
    {
      this.Component.Tooltip.Visible = new bool?(visible);
      return this;
    }

    public StockChartBuilder<T> Transitions(bool value)
    {
      this.Container.Transitions = new bool?(value);
      return this;
    }

    public StockChartBuilder<T> Zoomable(
      Action<ChartZoomableSettingsBuilder<T>> configurator)
    {
      this.Container.Zoomable.Enabled = new bool?(true);
      this.Container.Zoomable.Chart = (Chart<T>) this.Container;
      configurator(new ChartZoomableSettingsBuilder<T>(this.Container.Zoomable));
      return this;
    }

    public StockChartBuilder<T> Zoomable()
    {
      this.Container.Zoomable.Enabled = new bool?(true);
      return this;
    }

    public StockChartBuilder<T> Zoomable(bool enabled)
    {
      this.Container.Zoomable.Enabled = new bool?(enabled);
      return this;
    }

    public StockChartBuilder<T> RenderAs(RenderingMode value)
    {
      this.Container.RenderAs = new RenderingMode?(value);
      return this;
    }

    public StockChartBuilder<T> Events(Action<ChartEventBuilder> configurator)
    {
      configurator(new ChartEventBuilder(this.Container.Events));
      return this;
    }

    public StockChartBuilder<T> DateField(string value)
    {
      this.Container.DateField = value;
      return this;
    }

    public StockChartBuilder<T> Navigator(
      Action<StockChartNavigatorSettingsBuilder<T>> configurator)
    {
      this.Container.Navigator.StockChart = this.Container;
      configurator(new StockChartNavigatorSettingsBuilder<T>(this.Container.Navigator));
      return this;
    }

    public StockChartBuilder<T> PersistSeriesVisibility(bool value)
    {
      this.Container.PersistSeriesVisibility = new bool?(value);
      return this;
    }

    public StockChartBuilder<T> Events(Action<StockChartEventBuilder> configurator)
    {
      configurator(new StockChartEventBuilder(this.Container.Events));
      return this;
    }
  }
}
