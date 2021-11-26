// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartYAxisBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartYAxisBuilder<T> where T : class
  {
    public ChartYAxisBuilder(ChartYAxis<T> container) => this.Container = container;

    protected ChartYAxis<T> Container { get; private set; }

    public ChartYAxisBuilder<T> Date()
    {
      this.Container.Type = "date";
      return this;
    }

    public ChartYAxisBuilder<T> Logarithmic()
    {
      this.Container.Type = "log";
      return this;
    }

    public ChartYAxisBuilder<T> Numeric() => this.Numeric(string.Empty);

    public ChartYAxisBuilder<T> Numeric(string name)
    {
      this.Container.Type = "numeric";
      this.Container.Name = name;
      return this;
    }

    public ChartYAxisBuilder<T> Polar()
    {
      this.Container.Type = "polar";
      return this;
    }

    public ChartYAxisBuilder<T> Title(string value)
    {
      this.Container.Title.Text = value;
      return this;
    }

    public ChartYAxisBuilder<T> AxisCrossingValue(params object[] value)
    {
      this.Container.AxisCrossingValue = value;
      return this;
    }

    public ChartYAxisBuilder<T> Background(string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ChartYAxisBuilder<T> BaseUnit(string value)
    {
      this.Container.BaseUnit = value;
      return this;
    }

    public ChartYAxisBuilder<T> Categories(params object[] value)
    {
      this.Container.Categories = value;
      return this;
    }

    public ChartYAxisBuilder<T> Color(string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartYAxisBuilder<T> Crosshair(
      Action<ChartYAxisCrosshairSettingsBuilder<T>> configurator)
    {
      this.Container.Crosshair.Chart = this.Container.Chart;
      configurator(new ChartYAxisCrosshairSettingsBuilder<T>(this.Container.Crosshair));
      return this;
    }

    public ChartYAxisBuilder<T> Labels(
      Action<ChartYAxisLabelsSettingsBuilder<T>> configurator)
    {
      this.Container.Labels.Chart = this.Container.Chart;
      configurator(new ChartYAxisLabelsSettingsBuilder<T>(this.Container.Labels));
      return this;
    }

    public ChartYAxisBuilder<T> Line(
      Action<ChartYAxisLineSettingsBuilder<T>> configurator)
    {
      this.Container.Line.Chart = this.Container.Chart;
      configurator(new ChartYAxisLineSettingsBuilder<T>(this.Container.Line));
      return this;
    }

    public ChartYAxisBuilder<T> MajorGridLines(
      Action<ChartYAxisMajorGridLinesSettingsBuilder<T>> configurator)
    {
      this.Container.MajorGridLines.Chart = this.Container.Chart;
      configurator(new ChartYAxisMajorGridLinesSettingsBuilder<T>(this.Container.MajorGridLines));
      return this;
    }

    public ChartYAxisBuilder<T> MinorGridLines(
      Action<ChartYAxisMinorGridLinesSettingsBuilder<T>> configurator)
    {
      this.Container.MinorGridLines.Chart = this.Container.Chart;
      configurator(new ChartYAxisMinorGridLinesSettingsBuilder<T>(this.Container.MinorGridLines));
      return this;
    }

    public ChartYAxisBuilder<T> MinorTicks(
      Action<ChartYAxisMinorTicksSettingsBuilder<T>> configurator)
    {
      this.Container.MinorTicks.Chart = this.Container.Chart;
      configurator(new ChartYAxisMinorTicksSettingsBuilder<T>(this.Container.MinorTicks));
      return this;
    }

    public ChartYAxisBuilder<T> MajorTicks(
      Action<ChartYAxisMajorTicksSettingsBuilder<T>> configurator)
    {
      this.Container.MajorTicks.Chart = this.Container.Chart;
      configurator(new ChartYAxisMajorTicksSettingsBuilder<T>(this.Container.MajorTicks));
      return this;
    }

    public ChartYAxisBuilder<T> MajorUnit(double value)
    {
      this.Container.MajorUnit = new double?(value);
      return this;
    }

    public ChartYAxisBuilder<T> Max(object value)
    {
      this.Container.Max = value;
      return this;
    }

    public ChartYAxisBuilder<T> Min(object value)
    {
      this.Container.Min = value;
      return this;
    }

    public ChartYAxisBuilder<T> MinorUnit(double value)
    {
      this.Container.MinorUnit = new double?(value);
      return this;
    }

    public ChartYAxisBuilder<T> Name(string value)
    {
      this.Container.Name = value;
      return this;
    }

    public ChartYAxisBuilder<T> NarrowRange(bool value)
    {
      this.Container.NarrowRange = new bool?(value);
      return this;
    }

    public ChartYAxisBuilder<T> NarrowRange()
    {
      this.Container.NarrowRange = new bool?(true);
      return this;
    }

    public ChartYAxisBuilder<T> Pane(string value)
    {
      this.Container.Pane = value;
      return this;
    }

    public ChartYAxisBuilder<T> PlotBands(
      Action<ChartYAxisPlotBandFactory<T>> configurator)
    {
      configurator(new ChartYAxisPlotBandFactory<T>(this.Container.PlotBands)
      {
        Chart = this.Container.Chart
      });
      return this;
    }

    public ChartYAxisBuilder<T> Reverse(bool value)
    {
      this.Container.Reverse = new bool?(value);
      return this;
    }

    public ChartYAxisBuilder<T> Reverse()
    {
      this.Container.Reverse = new bool?(true);
      return this;
    }

    public ChartYAxisBuilder<T> Title(
      Action<ChartYAxisTitleSettingsBuilder<T>> configurator)
    {
      this.Container.Title.Chart = this.Container.Chart;
      configurator(new ChartYAxisTitleSettingsBuilder<T>(this.Container.Title));
      return this;
    }

    public ChartYAxisBuilder<T> Type(string value)
    {
      this.Container.Type = value;
      return this;
    }

    public ChartYAxisBuilder<T> Visible(bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartYAxisBuilder<T> Notes(
      Action<ChartYAxisNotesSettingsBuilder<T>> configurator)
    {
      this.Container.Notes.Chart = this.Container.Chart;
      configurator(new ChartYAxisNotesSettingsBuilder<T>(this.Container.Notes));
      return this;
    }
  }
}
