// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SparklineBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections;

namespace Kendo.Mvc.UI.Fluent
{
  public class SparklineBuilder<T> : WidgetBuilderBase<Sparkline<T>, SparklineBuilder<T>>
    where T : class
  {
    public SparklineBuilder(Sparkline<T> component)
      : base(component)
    {
    }

    public virtual SparklineBuilder<T> Data(IEnumerable data)
    {
      this.Component.SeriesData = data;
      return this;
    }

    public virtual SparklineBuilder<T> Data(double data)
    {
      this.Component.SeriesData = (IEnumerable) new double[1]
      {
        data
      };
      return this;
    }

    public SparklineBuilder<T> Type(SparklineType type)
    {
      this.Component.Type = new SparklineType?(type);
      return this;
    }

    public SparklineBuilder<T> CategoryAxis(
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

    public SparklineBuilder<T> DataSource(
      Action<ReadOnlyAjaxDataSourceBuilder<T>> configurator)
    {
      configurator(new ReadOnlyAjaxDataSourceBuilder<T>(this.Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public SparklineBuilder<T> SeriesDefaults(
      Action<ChartSeriesDefaultsSettingsBuilder<T>> configurator)
    {
      configurator(new ChartSeriesDefaultsSettingsBuilder<T>(this.Container.SeriesDefaults));
      return this;
    }

    public SparklineBuilder<T> ValueAxis(
      Action<ChartValueAxisBuilder<T>> configurator)
    {
      ChartValueAxis<T> container = new ChartValueAxis<T>();
      configurator(new ChartValueAxisBuilder<T>(container));
      this.Component.ValueAxis.Add(container);
      return this;
    }

    public SparklineBuilder<T> XAxis(Action<ChartXAxisBuilder<T>> configurator)
    {
      configurator(new ChartXAxisFactory<T>(this.Container.XAxis).Add());
      return this;
    }

    public SparklineBuilder<T> AutoBind(bool value)
    {
      this.Container.AutoBind = new bool?(value);
      return this;
    }

    public SparklineBuilder<T> AxisDefaults(
      Action<ChartAxisDefaultsSettingsBuilder<T>> configurator)
    {
      this.Container.AxisDefaults.Chart = (Chart<T>) this.Container;
      configurator(new ChartAxisDefaultsSettingsBuilder<T>(this.Container.AxisDefaults));
      return this;
    }

    public SparklineBuilder<T> ChartArea(
      Action<ChartChartAreaSettingsBuilder<T>> configurator)
    {
      this.Container.ChartArea.Chart = (Chart<T>) this.Container;
      configurator(new ChartChartAreaSettingsBuilder<T>(this.Container.ChartArea));
      return this;
    }

    public SparklineBuilder<T> Legend(
      Action<ChartLegendSettingsBuilder<T>> configurator)
    {
      this.Container.Legend.Chart = (Chart<T>) this.Container;
      configurator(new ChartLegendSettingsBuilder<T>(this.Container.Legend));
      return this;
    }

    public SparklineBuilder<T> Legend(bool visible)
    {
      this.Component.Legend.Visible = new bool?(visible);
      return this;
    }

    public SparklineBuilder<T> Panes(Action<ChartPaneFactory<T>> configurator)
    {
      configurator(new ChartPaneFactory<T>(this.Container.Panes)
      {
        Chart = (Chart<T>) this.Container
      });
      return this;
    }

    public SparklineBuilder<T> Pdf(Action<ChartPdfSettingsBuilder<T>> configurator)
    {
      this.Container.Pdf.Chart = (Chart<T>) this.Container;
      configurator(new ChartPdfSettingsBuilder<T>(this.Container.Pdf));
      return this;
    }

    public SparklineBuilder<T> PlotArea(
      Action<ChartPlotAreaSettingsBuilder<T>> configurator)
    {
      this.Container.PlotArea.Chart = (Chart<T>) this.Container;
      configurator(new ChartPlotAreaSettingsBuilder<T>(this.Container.PlotArea));
      return this;
    }

    public SparklineBuilder<T> Series(Action<ChartSeriesFactory<T>> configurator)
    {
      configurator(new ChartSeriesFactory<T>(this.Container.Series)
      {
        Chart = (Chart<T>) this.Container
      });
      return this;
    }

    public SparklineBuilder<T> SeriesColors(params string[] value)
    {
      this.Container.SeriesColors = value;
      return this;
    }

    public SparklineBuilder<T> Theme(string value)
    {
      this.Container.Theme = value;
      return this;
    }

    public SparklineBuilder<T> Title(
      Action<ChartTitleSettingsBuilder<T>> configurator)
    {
      this.Container.Title.Chart = (Chart<T>) this.Container;
      configurator(new ChartTitleSettingsBuilder<T>(this.Container.Title));
      return this;
    }

    public SparklineBuilder<T> Title(string title)
    {
      this.Container.Title.Text = title;
      return this;
    }

    public SparklineBuilder<T> Tooltip(
      Action<ChartTooltipSettingsBuilder<T>> configurator)
    {
      this.Container.Tooltip.Chart = (Chart<T>) this.Container;
      configurator(new ChartTooltipSettingsBuilder<T>(this.Container.Tooltip));
      return this;
    }

    public SparklineBuilder<T> Tooltip(bool visible)
    {
      this.Component.Tooltip.Visible = new bool?(visible);
      return this;
    }

    public SparklineBuilder<T> Transitions(bool value)
    {
      this.Container.Transitions = new bool?(value);
      return this;
    }

    public SparklineBuilder<T> RenderAs(RenderingMode value)
    {
      this.Container.RenderAs = new RenderingMode?(value);
      return this;
    }

    public SparklineBuilder<T> Events(Action<ChartEventBuilder> configurator)
    {
      configurator(new ChartEventBuilder(this.Container.Events));
      return this;
    }

    public SparklineBuilder<T> PointWidth(double value)
    {
      this.Container.PointWidth = new double?(value);
      return this;
    }

    public SparklineBuilder<T> Events(Action<SparklineEventBuilder> configurator)
    {
      configurator(new SparklineEventBuilder(this.Container.Events));
      return this;
    }
  }
}
