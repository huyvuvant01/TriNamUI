// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.StockChartNavigatorCategoryAxisSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class StockChartNavigatorCategoryAxisSettingsBuilder<T> where T : class
  {
    public StockChartNavigatorCategoryAxisSettingsBuilder(
      StockChartNavigatorCategoryAxisSettings<T> container)
    {
      this.Container = container;
    }

    protected StockChartNavigatorCategoryAxisSettings<T> Container { get; private set; }

    public StockChartNavigatorCategoryAxisSettingsBuilder<T> AutoBaseUnitSteps(
      Action<StockChartNavigatorCategoryAxisAutoBaseUnitStepsSettingsBuilder<T>> configurator)
    {
      this.Container.AutoBaseUnitSteps.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorCategoryAxisAutoBaseUnitStepsSettingsBuilder<T>(this.Container.AutoBaseUnitSteps));
      return this;
    }

    public StockChartNavigatorCategoryAxisSettingsBuilder<T> AxisCrossingValue(
      params object[] value)
    {
      this.Container.AxisCrossingValue = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisSettingsBuilder<T> Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisSettingsBuilder<T> BaseUnitStep(
      int value)
    {
      this.Container.BaseUnitStep = new int?(value);
      return this;
    }

    public StockChartNavigatorCategoryAxisSettingsBuilder<T> Categories(
      params object[] value)
    {
      this.Container.Categories = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisSettingsBuilder<T> Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisSettingsBuilder<T> Crosshair(
      Action<StockChartNavigatorCategoryAxisCrosshairSettingsBuilder<T>> configurator)
    {
      this.Container.Crosshair.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorCategoryAxisCrosshairSettingsBuilder<T>(this.Container.Crosshair));
      return this;
    }

    public StockChartNavigatorCategoryAxisSettingsBuilder<T> Field(
      string value)
    {
      this.Container.Field = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisSettingsBuilder<T> Justified(
      bool value)
    {
      this.Container.Justified = new bool?(value);
      return this;
    }

    public StockChartNavigatorCategoryAxisSettingsBuilder<T> Justified()
    {
      this.Container.Justified = new bool?(true);
      return this;
    }

    public StockChartNavigatorCategoryAxisSettingsBuilder<T> Labels(
      Action<StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T>> configurator)
    {
      this.Container.Labels.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T>(this.Container.Labels));
      return this;
    }

    public StockChartNavigatorCategoryAxisSettingsBuilder<T> Line(
      Action<StockChartNavigatorCategoryAxisLineSettingsBuilder<T>> configurator)
    {
      this.Container.Line.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorCategoryAxisLineSettingsBuilder<T>(this.Container.Line));
      return this;
    }

    public StockChartNavigatorCategoryAxisSettingsBuilder<T> MajorGridLines(
      Action<StockChartNavigatorCategoryAxisMajorGridLinesSettingsBuilder<T>> configurator)
    {
      this.Container.MajorGridLines.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorCategoryAxisMajorGridLinesSettingsBuilder<T>(this.Container.MajorGridLines));
      return this;
    }

    public StockChartNavigatorCategoryAxisSettingsBuilder<T> MajorTicks(
      Action<StockChartNavigatorCategoryAxisMajorTicksSettingsBuilder<T>> configurator)
    {
      this.Container.MajorTicks.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorCategoryAxisMajorTicksSettingsBuilder<T>(this.Container.MajorTicks));
      return this;
    }

    public StockChartNavigatorCategoryAxisSettingsBuilder<T> Max(
      object value)
    {
      this.Container.Max = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisSettingsBuilder<T> MaxDateGroups(
      double value)
    {
      this.Container.MaxDateGroups = new double?(value);
      return this;
    }

    public StockChartNavigatorCategoryAxisSettingsBuilder<T> MaxDivisions(
      double value)
    {
      this.Container.MaxDivisions = new double?(value);
      return this;
    }

    public StockChartNavigatorCategoryAxisSettingsBuilder<T> Min(
      object value)
    {
      this.Container.Min = value;
      return this;
    }

    public StockChartNavigatorCategoryAxisSettingsBuilder<T> MinorGridLines(
      Action<StockChartNavigatorCategoryAxisMinorGridLinesSettingsBuilder<T>> configurator)
    {
      this.Container.MinorGridLines.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorCategoryAxisMinorGridLinesSettingsBuilder<T>(this.Container.MinorGridLines));
      return this;
    }

    public StockChartNavigatorCategoryAxisSettingsBuilder<T> MinorTicks(
      Action<StockChartNavigatorCategoryAxisMinorTicksSettingsBuilder<T>> configurator)
    {
      this.Container.MinorTicks.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorCategoryAxisMinorTicksSettingsBuilder<T>(this.Container.MinorTicks));
      return this;
    }

    public StockChartNavigatorCategoryAxisSettingsBuilder<T> PlotBands(
      Action<StockChartNavigatorCategoryAxisSettingsPlotBandFactory<T>> configurator)
    {
      configurator(new StockChartNavigatorCategoryAxisSettingsPlotBandFactory<T>(this.Container.PlotBands)
      {
        StockChart = this.Container.StockChart
      });
      return this;
    }

    public StockChartNavigatorCategoryAxisSettingsBuilder<T> Reverse(
      bool value)
    {
      this.Container.Reverse = new bool?(value);
      return this;
    }

    public StockChartNavigatorCategoryAxisSettingsBuilder<T> Reverse()
    {
      this.Container.Reverse = new bool?(true);
      return this;
    }

    public StockChartNavigatorCategoryAxisSettingsBuilder<T> RoundToBaseUnit(
      bool value)
    {
      this.Container.RoundToBaseUnit = new bool?(value);
      return this;
    }

    public StockChartNavigatorCategoryAxisSettingsBuilder<T> Title(
      Action<StockChartNavigatorCategoryAxisTitleSettingsBuilder<T>> configurator)
    {
      this.Container.Title.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorCategoryAxisTitleSettingsBuilder<T>(this.Container.Title));
      return this;
    }

    public StockChartNavigatorCategoryAxisSettingsBuilder<T> Visible(
      bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public StockChartNavigatorCategoryAxisSettingsBuilder<T> WeekStartDay(
      double value)
    {
      this.Container.WeekStartDay = new double?(value);
      return this;
    }

    public StockChartNavigatorCategoryAxisSettingsBuilder<T> Notes(
      Action<StockChartNavigatorCategoryAxisNotesSettingsBuilder<T>> configurator)
    {
      this.Container.Notes.StockChart = this.Container.StockChart;
      configurator(new StockChartNavigatorCategoryAxisNotesSettingsBuilder<T>(this.Container.Notes));
      return this;
    }

    public StockChartNavigatorCategoryAxisSettingsBuilder<T> BaseUnit(
      ChartAxisBaseUnit value)
    {
      this.Container.BaseUnit = new ChartAxisBaseUnit?(value);
      return this;
    }

    public StockChartNavigatorCategoryAxisSettingsBuilder<T> Type(
      ChartCategoryAxisType value)
    {
      this.Container.Type = new ChartCategoryAxisType?(value);
      return this;
    }
  }
}
