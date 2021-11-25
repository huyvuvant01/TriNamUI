// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartCategoryAxisBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Resources;
using System;
using System.Collections;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartCategoryAxisBuilder<T> where T : class
  {
    public ChartCategoryAxisBuilder(ChartCategoryAxis<T> container) => this.Container = container;

    protected ChartCategoryAxis<T> Container { get; private set; }

    public ChartCategoryAxisBuilder<T> Date()
    {
      this.Container.Type = new ChartCategoryAxisType?(ChartCategoryAxisType.Date);
      return this;
    }

    public ChartCategoryAxisBuilder<T> Categories<TValue>(
      Expression<Func<T, TValue>> expression)
    {
      this.Container.Field = !typeof (T).IsPlainType() || expression.IsBindable() ? expression.MemberWithoutInstance() : throw new InvalidOperationException(Exceptions.MemberExpressionRequired);
      return this;
    }

    public ChartCategoryAxisBuilder<T> Categories(params string[] categories)
    {
      this.Container.Categories = (IEnumerable) categories;
      return this;
    }

    public ChartCategoryAxisBuilder<T> Categories(params DateTime[] value)
    {
      this.Container.Categories = (IEnumerable) value;
      return this;
    }

    public ChartCategoryAxisBuilder<T> Select(object from, object to)
    {
      this.Container.Select.From = from;
      this.Container.Select.To = to;
      return this;
    }

    public ChartCategoryAxisBuilder<T> Title(string value)
    {
      this.Container.Title.Text = value;
      return this;
    }

    public ChartCategoryAxisBuilder<T> AutoBaseUnitSteps(
      Action<ChartCategoryAxisAutoBaseUnitStepsSettingsBuilder<T>> configurator)
    {
      this.Container.AutoBaseUnitSteps.Chart = this.Container.Chart;
      configurator(new ChartCategoryAxisAutoBaseUnitStepsSettingsBuilder<T>(this.Container.AutoBaseUnitSteps));
      return this;
    }

    public ChartCategoryAxisBuilder<T> AxisCrossingValue(
      params object[] value)
    {
      this.Container.AxisCrossingValue = value;
      return this;
    }

    public ChartCategoryAxisBuilder<T> Background(string value)
    {
      this.Container.Background = value;
      return this;
    }

    public ChartCategoryAxisBuilder<T> BaseUnitStep(int value)
    {
      this.Container.BaseUnitStep = new int?(value);
      return this;
    }

    public ChartCategoryAxisBuilder<T> Color(string value)
    {
      this.Container.Color = value;
      return this;
    }

    public ChartCategoryAxisBuilder<T> Crosshair(
      Action<ChartCategoryAxisCrosshairSettingsBuilder<T>> configurator)
    {
      this.Container.Crosshair.Chart = this.Container.Chart;
      configurator(new ChartCategoryAxisCrosshairSettingsBuilder<T>(this.Container.Crosshair));
      return this;
    }

    public ChartCategoryAxisBuilder<T> Field(string value)
    {
      this.Container.Field = value;
      return this;
    }

    public ChartCategoryAxisBuilder<T> Justify(bool value)
    {
      this.Container.Justify = new bool?(value);
      return this;
    }

    public ChartCategoryAxisBuilder<T> Justify()
    {
      this.Container.Justify = new bool?(true);
      return this;
    }

    public ChartCategoryAxisBuilder<T> Labels(
      Action<ChartCategoryAxisLabelsSettingsBuilder<T>> configurator)
    {
      this.Container.Labels.Chart = this.Container.Chart;
      configurator(new ChartCategoryAxisLabelsSettingsBuilder<T>(this.Container.Labels));
      return this;
    }

    public ChartCategoryAxisBuilder<T> Line(
      Action<ChartCategoryAxisLineSettingsBuilder<T>> configurator)
    {
      this.Container.Line.Chart = this.Container.Chart;
      configurator(new ChartCategoryAxisLineSettingsBuilder<T>(this.Container.Line));
      return this;
    }

    public ChartCategoryAxisBuilder<T> MajorGridLines(
      Action<ChartCategoryAxisMajorGridLinesSettingsBuilder<T>> configurator)
    {
      this.Container.MajorGridLines.Chart = this.Container.Chart;
      configurator(new ChartCategoryAxisMajorGridLinesSettingsBuilder<T>(this.Container.MajorGridLines));
      return this;
    }

    public ChartCategoryAxisBuilder<T> MajorTicks(
      Action<ChartCategoryAxisMajorTicksSettingsBuilder<T>> configurator)
    {
      this.Container.MajorTicks.Chart = this.Container.Chart;
      configurator(new ChartCategoryAxisMajorTicksSettingsBuilder<T>(this.Container.MajorTicks));
      return this;
    }

    public ChartCategoryAxisBuilder<T> Max(object value)
    {
      this.Container.Max = value;
      return this;
    }

    public ChartCategoryAxisBuilder<T> MaxDateGroups(double value)
    {
      this.Container.MaxDateGroups = new double?(value);
      return this;
    }

    public ChartCategoryAxisBuilder<T> MaxDivisions(double value)
    {
      this.Container.MaxDivisions = new double?(value);
      return this;
    }

    public ChartCategoryAxisBuilder<T> Min(object value)
    {
      this.Container.Min = value;
      return this;
    }

    public ChartCategoryAxisBuilder<T> MinorGridLines(
      Action<ChartCategoryAxisMinorGridLinesSettingsBuilder<T>> configurator)
    {
      this.Container.MinorGridLines.Chart = this.Container.Chart;
      configurator(new ChartCategoryAxisMinorGridLinesSettingsBuilder<T>(this.Container.MinorGridLines));
      return this;
    }

    public ChartCategoryAxisBuilder<T> MinorTicks(
      Action<ChartCategoryAxisMinorTicksSettingsBuilder<T>> configurator)
    {
      this.Container.MinorTicks.Chart = this.Container.Chart;
      configurator(new ChartCategoryAxisMinorTicksSettingsBuilder<T>(this.Container.MinorTicks));
      return this;
    }

    public ChartCategoryAxisBuilder<T> Name(string value)
    {
      this.Container.Name = value;
      return this;
    }

    public ChartCategoryAxisBuilder<T> Pane(string value)
    {
      this.Container.Pane = value;
      return this;
    }

    public ChartCategoryAxisBuilder<T> PlotBands(
      Action<ChartCategoryAxisPlotBandFactory<T>> configurator)
    {
      configurator(new ChartCategoryAxisPlotBandFactory<T>(this.Container.PlotBands)
      {
        Chart = this.Container.Chart
      });
      return this;
    }

    public ChartCategoryAxisBuilder<T> RangeLabels(
      Action<ChartCategoryAxisRangeLabelsSettingsBuilder<T>> configurator)
    {
      this.Container.RangeLabels.Chart = this.Container.Chart;
      configurator(new ChartCategoryAxisRangeLabelsSettingsBuilder<T>(this.Container.RangeLabels));
      return this;
    }

    public ChartCategoryAxisBuilder<T> Reverse(bool value)
    {
      this.Container.Reverse = new bool?(value);
      return this;
    }

    public ChartCategoryAxisBuilder<T> Reverse()
    {
      this.Container.Reverse = new bool?(true);
      return this;
    }

    public ChartCategoryAxisBuilder<T> RoundToBaseUnit(bool value)
    {
      this.Container.RoundToBaseUnit = new bool?(value);
      return this;
    }

    public ChartCategoryAxisBuilder<T> Select(
      Action<ChartCategoryAxisSelectSettingsBuilder<T>> configurator)
    {
      this.Container.Select.Chart = this.Container.Chart;
      configurator(new ChartCategoryAxisSelectSettingsBuilder<T>(this.Container.Select));
      return this;
    }

    public ChartCategoryAxisBuilder<T> StartAngle(double value)
    {
      this.Container.StartAngle = new double?(value);
      return this;
    }

    public ChartCategoryAxisBuilder<T> Title(
      Action<ChartCategoryAxisTitleSettingsBuilder<T>> configurator)
    {
      this.Container.Title.Chart = this.Container.Chart;
      configurator(new ChartCategoryAxisTitleSettingsBuilder<T>(this.Container.Title));
      return this;
    }

    public ChartCategoryAxisBuilder<T> Visible(bool value)
    {
      this.Container.Visible = new bool?(value);
      return this;
    }

    public ChartCategoryAxisBuilder<T> WeekStartDay(double value)
    {
      this.Container.WeekStartDay = new double?(value);
      return this;
    }

    public ChartCategoryAxisBuilder<T> Notes(
      Action<ChartCategoryAxisNotesSettingsBuilder<T>> configurator)
    {
      this.Container.Notes.Chart = this.Container.Chart;
      configurator(new ChartCategoryAxisNotesSettingsBuilder<T>(this.Container.Notes));
      return this;
    }

    public ChartCategoryAxisBuilder<T> BaseUnit(ChartAxisBaseUnit value)
    {
      this.Container.BaseUnit = new ChartAxisBaseUnit?(value);
      return this;
    }

    public ChartCategoryAxisBuilder<T> Type(ChartCategoryAxisType value)
    {
      this.Container.Type = new ChartCategoryAxisType?(value);
      return this;
    }
  }
}
