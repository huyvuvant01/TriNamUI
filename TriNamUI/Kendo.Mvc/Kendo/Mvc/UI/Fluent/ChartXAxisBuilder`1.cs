// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartXAxisBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartXAxisBuilder<T> where T : class
  {
    public ChartXAxisBuilder(ChartXAxis<T> container) => this.Container = container;

    protected ChartXAxis<T> Container { get; private set; }

    public ChartXAxisBuilder<T> Date()
    {
      this.Container.Type = "date";
      return this;
    }

    public ChartXAxisBuilder<T> Logarithmic()
    {
      this.Container.Type = "log";
      return this;
    }

    public ChartXAxisBuilder<T> Numeric()
    {
      this.Container.Type = "numeric";
      return this;
    }

    public ChartXAxisBuilder<T> Polar()
    {
      this.Container.Type = "polar";
      return this;
    }

    public ChartXAxisBuilder<T> Title(string value)
    {
      this.Container.Title.Text = value;
      return this;
    }

    public ChartXAxisBuilder<T> AxisCrossingValue(params object[] value)
    {
      this.Container.AxisCrossingValue = value;
      return this;
    }

    public ChartXAxisBuilder<T> Background(string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ChartXAxisBuilder<T> BaseUnit(string value)
    {
      this.Container.BaseUnit = value;
      return this;
    }

    public ChartXAxisBuilder<T> Categories(params object[] value)
    {
      this.Container.Categories = value;
      return this;
    }

    public ChartXAxisBuilder<T> Color(string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartXAxisBuilder<T> Crosshair(
      Action<ChartXAxisCrosshairSettingsBuilder<T>> configurator)
    {
      this.Container.Crosshair.Chart = this.Container.Chart;
      configurator(new ChartXAxisCrosshairSettingsBuilder<T>(this.Container.Crosshair));
      return this;
    }

    public ChartXAxisBuilder<T> Labels(
      Action<ChartXAxisLabelsSettingsBuilder<T>> configurator)
    {
      this.Container.Labels.Chart = this.Container.Chart;
      configurator(new ChartXAxisLabelsSettingsBuilder<T>(this.Container.Labels));
      return this;
    }

    public ChartXAxisBuilder<T> Line(
      Action<ChartXAxisLineSettingsBuilder<T>> configurator)
    {
      this.Container.Line.Chart = this.Container.Chart;
      configurator(new ChartXAxisLineSettingsBuilder<T>(this.Container.Line));
      return this;
    }

    public ChartXAxisBuilder<T> MajorGridLines(
      Action<ChartXAxisMajorGridLinesSettingsBuilder<T>> configurator)
    {
      this.Container.MajorGridLines.Chart = this.Container.Chart;
      configurator(new ChartXAxisMajorGridLinesSettingsBuilder<T>(this.Container.MajorGridLines));
      return this;
    }

    public ChartXAxisBuilder<T> MinorGridLines(
      Action<ChartXAxisMinorGridLinesSettingsBuilder<T>> configurator)
    {
      this.Container.MinorGridLines.Chart = this.Container.Chart;
      configurator(new ChartXAxisMinorGridLinesSettingsBuilder<T>(this.Container.MinorGridLines));
      return this;
    }

    public ChartXAxisBuilder<T> MinorTicks(
      Action<ChartXAxisMinorTicksSettingsBuilder<T>> configurator)
    {
      this.Container.MinorTicks.Chart = this.Container.Chart;
      configurator(new ChartXAxisMinorTicksSettingsBuilder<T>(this.Container.MinorTicks));
      return this;
    }

    public ChartXAxisBuilder<T> MajorTicks(
      Action<ChartXAxisMajorTicksSettingsBuilder<T>> configurator)
    {
      this.Container.MajorTicks.Chart = this.Container.Chart;
      configurator(new ChartXAxisMajorTicksSettingsBuilder<T>(this.Container.MajorTicks));
      return this;
    }

    public ChartXAxisBuilder<T> MajorUnit(double value)
    {
      this.Container.MajorUnit = new double?(value);
      return this;
    }

    public ChartXAxisBuilder<T> Max(object value)
    {
      this.Container.Max = value;
      return this;
    }

    public ChartXAxisBuilder<T> Min(object value)
    {
      this.Container.Min = value;
      return this;
    }

    public ChartXAxisBuilder<T> MinorUnit(double value)
    {
      this.Container.MinorUnit = new double?(value);
      return this;
    }

    public ChartXAxisBuilder<T> Name(string value)
    {
      this.Container.Name = value;
      return this;
    }

    public ChartXAxisBuilder<T> NarrowRange(bool value)
    {
      this.Container.NarrowRange = new bool?(value);
      return this;
    }

    public ChartXAxisBuilder<T> NarrowRange()
    {
      this.Container.NarrowRange = new bool?(true);
      return this;
    }

    public ChartXAxisBuilder<T> Pane(string value)
    {
      this.Container.Pane = value;
      return this;
    }

    public ChartXAxisBuilder<T> PlotBands(
      Action<ChartXAxisPlotBandFactory<T>> configurator)
    {
      configurator(new ChartXAxisPlotBandFactory<T>(this.Container.PlotBands)
      {
        Chart = this.Container.Chart
      });
      return this;
    }

    public ChartXAxisBuilder<T> Reverse(bool value)
    {
      this.Container.Reverse = new bool?(value);
      return this;
    }

    public ChartXAxisBuilder<T> Reverse()
    {
      this.Container.Reverse = new bool?(true);
      return this;
    }

    public ChartXAxisBuilder<T> StartAngle(double value)
    {
      this.Container.StartAngle = new double?(value);
      return this;
    }

    public ChartXAxisBuilder<T> Title(
      Action<ChartXAxisTitleSettingsBuilder<T>> configurator)
    {
      this.Container.Title.Chart = this.Container.Chart;
      configurator(new ChartXAxisTitleSettingsBuilder<T>(this.Container.Title));
      return this;
    }

    public ChartXAxisBuilder<T> Type(string value)
    {
      this.Container.Type = value;
      return this;
    }

    public ChartXAxisBuilder<T> Visible(bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartXAxisBuilder<T> Notes(
      Action<ChartXAxisNotesSettingsBuilder<T>> configurator)
    {
      this.Container.Notes.Chart = this.Container.Chart;
      configurator(new ChartXAxisNotesSettingsBuilder<T>(this.Container.Notes));
      return this;
    }
  }
}
