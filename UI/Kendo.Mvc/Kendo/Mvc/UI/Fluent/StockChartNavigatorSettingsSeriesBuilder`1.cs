// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.StockChartNavigatorSettingsSeriesBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class StockChartNavigatorSettingsSeriesBuilder<T> where T : class
  {
    public StockChartNavigatorSettingsSeriesBuilder(StockChartNavigatorSettingsSeries<T> container) => this.Container = container;

    protected StockChartNavigatorSettingsSeries<T> Container { get; private set; }

    public StockChartNavigatorSettingsSeriesBuilder<T> Type(
      string value)
    {
      this.Container.Type = value;
      return this;
    }

    public StockChartNavigatorSettingsSeriesBuilder<T> DashType(
      ChartDashType value)
    {
      this.Container.DashType = new ChartDashType?(value);
      return this;
    }

    public StockChartNavigatorSettingsSeriesBuilder<T> HighField(
      string value)
    {
      this.Container.HighField = value;
      return this;
    }

    public StockChartNavigatorSettingsSeriesBuilder<T> Field(
      string value)
    {
      this.Container.Field = value;
      return this;
    }

    public StockChartNavigatorSettingsSeriesBuilder<T> CategoryField(
      string value)
    {
      this.Container.CategoryField = value;
      return this;
    }

    public StockChartNavigatorSettingsSeriesBuilder<T> Name(
      string value)
    {
      this.Container.Name = value;
      return this;
    }

    public StockChartNavigatorSettingsSeriesBuilder<T> Highlight(
      Action<StockChartNavigatorSeriesHighlightSettingsBuilder<T>> configurator)
    {
      this.Container.Highlight.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorSeriesHighlightSettingsBuilder<T>(this.Container.Highlight));
      return this;
    }

    public StockChartNavigatorSettingsSeriesBuilder<T> Aggregate(
      string value)
    {
      this.Container.AggregateHandler = (ClientHandlerDescriptor) null;
      this.Container.Aggregate = value;
      return this;
    }

    public StockChartNavigatorSettingsSeriesBuilder<T> AggregateHandler(
      string handler)
    {
      this.Container.Aggregate = (string) null;
      this.Container.AggregateHandler = new ClientHandlerDescriptor()
      {
        HandlerName = handler
      };
      return this;
    }

    public StockChartNavigatorSettingsSeriesBuilder<T> AggregateHandler(
      Func<object, object> handler)
    {
      this.Container.Aggregate = (string) null;
      this.Container.AggregateHandler = new ClientHandlerDescriptor()
      {
        TemplateDelegate = handler
      };
      return this;
    }

    public StockChartNavigatorSettingsSeriesBuilder<T> Axis(
      string value)
    {
      this.Container.Axis = value;
      return this;
    }

    public StockChartNavigatorSettingsSeriesBuilder<T> Border(
      Action<StockChartNavigatorSeriesBorderSettingsBuilder<T>> configurator)
    {
      this.Container.Border.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorSeriesBorderSettingsBuilder<T>(this.Container.Border));
      return this;
    }

    public StockChartNavigatorSettingsSeriesBuilder<T> CloseField(
      string value)
    {
      this.Container.CloseField = value;
      return this;
    }

    public StockChartNavigatorSettingsSeriesBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public StockChartNavigatorSettingsSeriesBuilder<T> ColorField(
      string value)
    {
      this.Container.ColorField = value;
      return this;
    }

    public StockChartNavigatorSettingsSeriesBuilder<T> DownColor(
      string value)
    {
      this.Container.DownColor = value;
      return this;
    }

    public StockChartNavigatorSettingsSeriesBuilder<T> DownColorField(
      string value)
    {
      this.Container.DownColorField = value;
      return this;
    }

    public StockChartNavigatorSettingsSeriesBuilder<T> Gap(
      double value)
    {
      this.Container.Gap = new double?(value);
      return this;
    }

    public StockChartNavigatorSettingsSeriesBuilder<T> Labels(
      Action<StockChartNavigatorSeriesLabelsSettingsBuilder<T>> configurator)
    {
      this.Container.Labels.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorSeriesLabelsSettingsBuilder<T>(this.Container.Labels));
      return this;
    }

    public StockChartNavigatorSettingsSeriesBuilder<T> Line(
      Action<StockChartNavigatorSeriesLineSettingsBuilder<T>> configurator)
    {
      this.Container.Line.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorSeriesLineSettingsBuilder<T>(this.Container.Line));
      return this;
    }

    public StockChartNavigatorSettingsSeriesBuilder<T> LowField(
      string value)
    {
      this.Container.LowField = value;
      return this;
    }

    public StockChartNavigatorSettingsSeriesBuilder<T> Markers(
      Action<StockChartNavigatorSeriesMarkersSettingsBuilder<T>> configurator)
    {
      this.Container.Markers.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorSeriesMarkersSettingsBuilder<T>(this.Container.Markers));
      return this;
    }

    public StockChartNavigatorSettingsSeriesBuilder<T> MissingValues(
      string value)
    {
      this.Container.MissingValues = value;
      return this;
    }

    public StockChartNavigatorSettingsSeriesBuilder<T> Style(
      string value)
    {
      this.Container.Style = value;
      return this;
    }

    public StockChartNavigatorSettingsSeriesBuilder<T> Opacity(
      double value)
    {
      this.Container.Opacity = new double?(value);
      return this;
    }

    public StockChartNavigatorSettingsSeriesBuilder<T> OpenField(
      string value)
    {
      this.Container.OpenField = value;
      return this;
    }

    public StockChartNavigatorSettingsSeriesBuilder<T> Overlay(
      Action<StockChartNavigatorSeriesOverlaySettingsBuilder<T>> configurator)
    {
      this.Container.Overlay.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorSeriesOverlaySettingsBuilder<T>(this.Container.Overlay));
      return this;
    }

    public StockChartNavigatorSettingsSeriesBuilder<T> Spacing(
      double value)
    {
      this.Container.Spacing = new double?(value);
      return this;
    }

    public StockChartNavigatorSettingsSeriesBuilder<T> Stack(
      Action<StockChartNavigatorSeriesStackSettingsBuilder<T>> configurator)
    {
      this.Container.Stack.Enabled = new bool?(true);
      this.Container.Stack.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorSeriesStackSettingsBuilder<T>(this.Container.Stack));
      return this;
    }

    public StockChartNavigatorSettingsSeriesBuilder<T> Stack()
    {
      this.Container.Stack.Enabled = new bool?(true);
      return this;
    }

    public StockChartNavigatorSettingsSeriesBuilder<T> Stack(
      bool enabled)
    {
      this.Container.Stack.Enabled = new bool?(enabled);
      return this;
    }

    public StockChartNavigatorSettingsSeriesBuilder<T> Tooltip(
      Action<StockChartNavigatorSeriesTooltipSettingsBuilder<T>> configurator)
    {
      this.Container.Tooltip.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorSeriesTooltipSettingsBuilder<T>(this.Container.Tooltip));
      return this;
    }

    public StockChartNavigatorSettingsSeriesBuilder<T> Width(
      double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }
  }
}
