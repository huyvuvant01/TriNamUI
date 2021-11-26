// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartValueAxisBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartValueAxisBuilder<T> where T : class
  {
    public ChartValueAxisBuilder(ChartValueAxis<T> container) => this.Container = container;

    protected ChartValueAxis<T> Container { get; private set; }

    public ChartValueAxisBuilder<T> Date()
    {
      this.Container.Type = "date";
      return this;
    }

    public ChartValueAxisBuilder<T> Logarithmic()
    {
      this.Container.Type = "log";
      return this;
    }

    public ChartValueAxisBuilder<T> Numeric() => this.Numeric(string.Empty);

    public virtual ChartValueAxisBuilder<T> Numeric(string name)
    {
      this.Container.Type = "numeric";
      this.Container.Name = name;
      return this;
    }

    public ChartValueAxisBuilder<T> Polar()
    {
      this.Container.Type = "polar";
      return this;
    }

    public ChartValueAxisBuilder<T> Title(string value)
    {
      this.Container.Title.Text = value;
      return this;
    }

    public ChartValueAxisBuilder<T> AxisCrossingValue(params object[] value)
    {
      this.Container.AxisCrossingValue = value;
      return this;
    }

    public ChartValueAxisBuilder<T> Background(string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ChartValueAxisBuilder<T> Color(string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartValueAxisBuilder<T> Crosshair(
      Action<ChartValueAxisCrosshairSettingsBuilder<T>> configurator)
    {
      this.Container.Crosshair.Chart = this.Container.Chart;
      configurator(new ChartValueAxisCrosshairSettingsBuilder<T>(this.Container.Crosshair));
      return this;
    }

    public ChartValueAxisBuilder<T> Labels(
      Action<ChartValueAxisLabelsSettingsBuilder<T>> configurator)
    {
      this.Container.Labels.Chart = this.Container.Chart;
      configurator(new ChartValueAxisLabelsSettingsBuilder<T>(this.Container.Labels));
      return this;
    }

    public ChartValueAxisBuilder<T> Line(
      Action<ChartValueAxisLineSettingsBuilder<T>> configurator)
    {
      this.Container.Line.Chart = this.Container.Chart;
      configurator(new ChartValueAxisLineSettingsBuilder<T>(this.Container.Line));
      return this;
    }

    public ChartValueAxisBuilder<T> MajorGridLines(
      Action<ChartValueAxisMajorGridLinesSettingsBuilder<T>> configurator)
    {
      this.Container.MajorGridLines.Chart = this.Container.Chart;
      configurator(new ChartValueAxisMajorGridLinesSettingsBuilder<T>(this.Container.MajorGridLines));
      return this;
    }

    public ChartValueAxisBuilder<T> MajorUnit(double value)
    {
      this.Container.MajorUnit = new double?(value);
      return this;
    }

    public ChartValueAxisBuilder<T> Max(double value)
    {
      this.Container.Max = new double?(value);
      return this;
    }

    public ChartValueAxisBuilder<T> Min(double value)
    {
      this.Container.Min = new double?(value);
      return this;
    }

    public ChartValueAxisBuilder<T> MinorGridLines(
      Action<ChartValueAxisMinorGridLinesSettingsBuilder<T>> configurator)
    {
      this.Container.MinorGridLines.Chart = this.Container.Chart;
      configurator(new ChartValueAxisMinorGridLinesSettingsBuilder<T>(this.Container.MinorGridLines));
      return this;
    }

    public ChartValueAxisBuilder<T> MajorTicks(
      Action<ChartValueAxisMajorTicksSettingsBuilder<T>> configurator)
    {
      this.Container.MajorTicks.Chart = this.Container.Chart;
      configurator(new ChartValueAxisMajorTicksSettingsBuilder<T>(this.Container.MajorTicks));
      return this;
    }

    public ChartValueAxisBuilder<T> MinorTicks(
      Action<ChartValueAxisMinorTicksSettingsBuilder<T>> configurator)
    {
      this.Container.MinorTicks.Chart = this.Container.Chart;
      configurator(new ChartValueAxisMinorTicksSettingsBuilder<T>(this.Container.MinorTicks));
      return this;
    }

    public ChartValueAxisBuilder<T> MinorUnit(double value)
    {
      this.Container.MinorUnit = new double?(value);
      return this;
    }

    public ChartValueAxisBuilder<T> Name(string value)
    {
      this.Container.Name = value;
      return this;
    }

    public ChartValueAxisBuilder<T> NarrowRange(bool value)
    {
      this.Container.NarrowRange = new bool?(value);
      return this;
    }

    public ChartValueAxisBuilder<T> Pane(string value)
    {
      this.Container.Pane = value;
      return this;
    }

    public ChartValueAxisBuilder<T> PlotBands(
      Action<ChartValueAxisPlotBandFactory<T>> configurator)
    {
      configurator(new ChartValueAxisPlotBandFactory<T>(this.Container.PlotBands)
      {
        Chart = this.Container.Chart
      });
      return this;
    }

    public ChartValueAxisBuilder<T> Reverse(bool value)
    {
      this.Container.Reverse = new bool?(value);
      return this;
    }

    public ChartValueAxisBuilder<T> Reverse()
    {
      this.Container.Reverse = new bool?(true);
      return this;
    }

    public ChartValueAxisBuilder<T> Title(
      Action<ChartValueAxisTitleSettingsBuilder<T>> configurator)
    {
      this.Container.Title.Chart = this.Container.Chart;
      configurator(new ChartValueAxisTitleSettingsBuilder<T>(this.Container.Title));
      return this;
    }

    public ChartValueAxisBuilder<T> Type(string value)
    {
      this.Container.Type = value;
      return this;
    }

    public ChartValueAxisBuilder<T> Visible(bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartValueAxisBuilder<T> Notes(
      Action<ChartValueAxisNotesSettingsBuilder<T>> configurator)
    {
      this.Container.Notes.Chart = this.Container.Chart;
      configurator(new ChartValueAxisNotesSettingsBuilder<T>(this.Container.Notes));
      return this;
    }

    public ChartValueAxisBuilder<T> ZIndex(double value)
    {
      this.Container.ZIndex = new double?(value);
      return this;
    }
  }
}
