// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartAxisDefaultsSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartAxisDefaultsSettingsBuilder<T> where T : class
  {
    public ChartAxisDefaultsSettingsBuilder(ChartAxisDefaultsSettings<T> container) => this.Container = container;

    protected ChartAxisDefaultsSettings<T> Container { get; private set; }

    public ChartAxisDefaultsSettingsBuilder<T> Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ChartAxisDefaultsSettingsBuilder<T> Color(string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartAxisDefaultsSettingsBuilder<T> Crosshair(
      Action<ChartAxisDefaultsCrosshairSettingsBuilder<T>> configurator)
    {
      this.Container.Crosshair.Chart = this.Container.Chart;
      configurator(new ChartAxisDefaultsCrosshairSettingsBuilder<T>(this.Container.Crosshair));
      return this;
    }

    public ChartAxisDefaultsSettingsBuilder<T> Labels(
      Action<ChartAxisDefaultsLabelsSettingsBuilder<T>> configurator)
    {
      this.Container.Labels.Chart = this.Container.Chart;
      configurator(new ChartAxisDefaultsLabelsSettingsBuilder<T>(this.Container.Labels));
      return this;
    }

    public ChartAxisDefaultsSettingsBuilder<T> Line(
      Action<ChartAxisDefaultsLineSettingsBuilder<T>> configurator)
    {
      this.Container.Line.Chart = this.Container.Chart;
      configurator(new ChartAxisDefaultsLineSettingsBuilder<T>(this.Container.Line));
      return this;
    }

    public ChartAxisDefaultsSettingsBuilder<T> MajorGridLines(
      Action<ChartAxisDefaultsMajorGridLinesSettingsBuilder<T>> configurator)
    {
      this.Container.MajorGridLines.Chart = this.Container.Chart;
      configurator(new ChartAxisDefaultsMajorGridLinesSettingsBuilder<T>(this.Container.MajorGridLines));
      return this;
    }

    public ChartAxisDefaultsSettingsBuilder<T> MajorTicks(
      Action<ChartAxisDefaultsMajorTicksSettingsBuilder<T>> configurator)
    {
      this.Container.MajorTicks.Chart = this.Container.Chart;
      configurator(new ChartAxisDefaultsMajorTicksSettingsBuilder<T>(this.Container.MajorTicks));
      return this;
    }

    public ChartAxisDefaultsSettingsBuilder<T> MinorGridLines(
      Action<ChartAxisDefaultsMinorGridLinesSettingsBuilder<T>> configurator)
    {
      this.Container.MinorGridLines.Chart = this.Container.Chart;
      configurator(new ChartAxisDefaultsMinorGridLinesSettingsBuilder<T>(this.Container.MinorGridLines));
      return this;
    }

    public ChartAxisDefaultsSettingsBuilder<T> MinorTicks(
      Action<ChartAxisDefaultsMinorTicksSettingsBuilder<T>> configurator)
    {
      this.Container.MinorTicks.Chart = this.Container.Chart;
      configurator(new ChartAxisDefaultsMinorTicksSettingsBuilder<T>(this.Container.MinorTicks));
      return this;
    }

    public ChartAxisDefaultsSettingsBuilder<T> NarrowRange(
      bool value)
    {
      this.Container.NarrowRange = new bool?(value);
      return this;
    }

    public ChartAxisDefaultsSettingsBuilder<T> NarrowRange()
    {
      this.Container.NarrowRange = new bool?(true);
      return this;
    }

    public ChartAxisDefaultsSettingsBuilder<T> Pane(string value)
    {
      this.Container.Pane = value;
      return this;
    }

    public ChartAxisDefaultsSettingsBuilder<T> PlotBands(
      Action<ChartAxisDefaultsSettingsPlotBandFactory<T>> configurator)
    {
      configurator(new ChartAxisDefaultsSettingsPlotBandFactory<T>(this.Container.PlotBands)
      {
        Chart = this.Container.Chart
      });
      return this;
    }

    public ChartAxisDefaultsSettingsBuilder<T> Reverse(bool value)
    {
      this.Container.Reverse = new bool?(value);
      return this;
    }

    public ChartAxisDefaultsSettingsBuilder<T> Reverse()
    {
      this.Container.Reverse = new bool?(true);
      return this;
    }

    public ChartAxisDefaultsSettingsBuilder<T> StartAngle(
      double value)
    {
      this.Container.StartAngle = new double?(value);
      return this;
    }

    public ChartAxisDefaultsSettingsBuilder<T> Title(
      Action<ChartAxisDefaultsTitleSettingsBuilder<T>> configurator)
    {
      this.Container.Title.Chart = this.Container.Chart;
      configurator(new ChartAxisDefaultsTitleSettingsBuilder<T>(this.Container.Title));
      return this;
    }

    public ChartAxisDefaultsSettingsBuilder<T> Visible(bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }
  }
}
