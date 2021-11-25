// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartBuilder<T> : WidgetBuilderBase<Chart<T>, ChartBuilder<T>>
    where T : class
  {
    public ChartBuilder(Chart<T> component)
      : base(component)
    {
    }

    public ChartBuilder<T> Title(string title)
    {
      this.Container.Title.Text = title;
      return this;
    }

    public ChartBuilder<T> SeriesDefaults(
      Action<ChartSeriesDefaultsSettingsBuilder<T>> configurator)
    {
      configurator(new ChartSeriesDefaultsSettingsBuilder<T>(this.Container.SeriesDefaults));
      return this;
    }

    public ChartBuilder<T> CategoryAxis(Action<ChartCategoryAxisBuilder<T>> configurator)
    {
      ChartCategoryAxis<T> container = new ChartCategoryAxis<T>()
      {
        Chart = this.Container
      };
      this.Container.CategoryAxis.Add(container);
      configurator(new ChartCategoryAxisBuilder<T>(container));
      return this;
    }

    public ChartBuilder<T> DataSource(
      Action<ReadOnlyAjaxDataSourceBuilder<T>> configurator)
    {
      configurator(new ReadOnlyAjaxDataSourceBuilder<T>(this.Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public ChartBuilder<T> DataSource(string dataSourceId)
    {
      this.Component.DataSourceId = dataSourceId;
      return this;
    }

    public ChartBuilder<T> Legend(bool visible)
    {
      this.Component.Legend.Visible = new bool?(visible);
      return this;
    }

    public ChartBuilder<T> ValueAxis(Action<ChartValueAxisBuilder<T>> configurator)
    {
      ChartValueAxis<T> container = new ChartValueAxis<T>();
      configurator(new ChartValueAxisBuilder<T>(container));
      this.Component.ValueAxis.Add(container);
      return this;
    }

    public ChartBuilder<T> XAxis(Action<ChartXAxisBuilder<T>> configurator)
    {
      configurator(new ChartXAxisFactory<T>(this.Container.XAxis).Add());
      return this;
    }

    public ChartBuilder<T> YAxis(Action<ChartYAxisBuilder<T>> configurator)
    {
      configurator(new ChartYAxisFactory<T>(this.Container.YAxis).Add());
      return this;
    }

    public ChartBuilder<T> AutoBind(bool value)
    {
      this.Container.AutoBind = new bool?(value);
      return this;
    }

    public ChartBuilder<T> AxisDefaults(
      Action<ChartAxisDefaultsSettingsBuilder<T>> configurator)
    {
      this.Container.AxisDefaults.Chart = this.Container;
      configurator(new ChartAxisDefaultsSettingsBuilder<T>(this.Container.AxisDefaults));
      return this;
    }

    public ChartBuilder<T> ChartArea(
      Action<ChartChartAreaSettingsBuilder<T>> configurator)
    {
      this.Container.ChartArea.Chart = this.Container;
      configurator(new ChartChartAreaSettingsBuilder<T>(this.Container.ChartArea));
      return this;
    }

    public ChartBuilder<T> Legend(Action<ChartLegendSettingsBuilder<T>> configurator)
    {
      this.Container.Legend.Chart = this.Container;
      configurator(new ChartLegendSettingsBuilder<T>(this.Container.Legend));
      return this;
    }

    public ChartBuilder<T> PaneDefaults(
      Action<ChartPaneDefaultsSettingsBuilder<T>> configurator)
    {
      this.Container.PaneDefaults.Chart = this.Container;
      configurator(new ChartPaneDefaultsSettingsBuilder<T>(this.Container.PaneDefaults));
      return this;
    }

    public ChartBuilder<T> Panes(Action<ChartPaneFactory<T>> configurator)
    {
      configurator(new ChartPaneFactory<T>(this.Container.Panes)
      {
        Chart = this.Container
      });
      return this;
    }

    public ChartBuilder<T> Pannable(
      Action<ChartPannableSettingsBuilder<T>> configurator)
    {
      this.Container.Pannable.Enabled = new bool?(true);
      this.Container.Pannable.Chart = this.Container;
      configurator(new ChartPannableSettingsBuilder<T>(this.Container.Pannable));
      return this;
    }

    public ChartBuilder<T> Pannable()
    {
      this.Container.Pannable.Enabled = new bool?(true);
      return this;
    }

    public ChartBuilder<T> Pannable(bool enabled)
    {
      this.Container.Pannable.Enabled = new bool?(enabled);
      return this;
    }

    public ChartBuilder<T> Pdf(Action<ChartPdfSettingsBuilder<T>> configurator)
    {
      this.Container.Pdf.Chart = this.Container;
      configurator(new ChartPdfSettingsBuilder<T>(this.Container.Pdf));
      return this;
    }

    public ChartBuilder<T> PersistSeriesVisibility(bool value)
    {
      this.Container.PersistSeriesVisibility = new bool?(value);
      return this;
    }

    public ChartBuilder<T> PersistSeriesVisibility()
    {
      this.Container.PersistSeriesVisibility = new bool?(true);
      return this;
    }

    public ChartBuilder<T> PlotArea(
      Action<ChartPlotAreaSettingsBuilder<T>> configurator)
    {
      this.Container.PlotArea.Chart = this.Container;
      configurator(new ChartPlotAreaSettingsBuilder<T>(this.Container.PlotArea));
      return this;
    }

    public ChartBuilder<T> Series(Action<ChartSeriesFactory<T>> configurator)
    {
      configurator(new ChartSeriesFactory<T>(this.Container.Series)
      {
        Chart = this.Container
      });
      return this;
    }

    public ChartBuilder<T> SeriesColors(params string[] value)
    {
      this.Container.SeriesColors = value;
      return this;
    }

    public ChartBuilder<T> Theme(string value)
    {
      this.Container.Theme = value;
      return this;
    }

    public ChartBuilder<T> Title(Action<ChartTitleSettingsBuilder<T>> configurator)
    {
      this.Container.Title.Chart = this.Container;
      configurator(new ChartTitleSettingsBuilder<T>(this.Container.Title));
      return this;
    }

    public ChartBuilder<T> Tooltip(
      Action<ChartTooltipSettingsBuilder<T>> configurator)
    {
      this.Container.Tooltip.Chart = this.Container;
      configurator(new ChartTooltipSettingsBuilder<T>(this.Container.Tooltip));
      return this;
    }

    public ChartBuilder<T> Transitions(bool value)
    {
      this.Container.Transitions = new bool?(value);
      return this;
    }

    public ChartBuilder<T> Zoomable(
      Action<ChartZoomableSettingsBuilder<T>> configurator)
    {
      this.Container.Zoomable.Enabled = new bool?(true);
      this.Container.Zoomable.Chart = this.Container;
      configurator(new ChartZoomableSettingsBuilder<T>(this.Container.Zoomable));
      return this;
    }

    public ChartBuilder<T> Zoomable()
    {
      this.Container.Zoomable.Enabled = new bool?(true);
      return this;
    }

    public ChartBuilder<T> Zoomable(bool enabled)
    {
      this.Container.Zoomable.Enabled = new bool?(enabled);
      return this;
    }

    public ChartBuilder<T> RenderAs(RenderingMode value)
    {
      this.Container.RenderAs = new RenderingMode?(value);
      return this;
    }

    public ChartBuilder<T> Events(Action<ChartEventBuilder> configurator)
    {
      configurator(new ChartEventBuilder(this.Container.Events));
      return this;
    }
  }
}
