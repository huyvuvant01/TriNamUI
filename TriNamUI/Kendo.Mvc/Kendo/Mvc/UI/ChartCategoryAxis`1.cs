// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartCategoryAxis`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ChartCategoryAxis<T> where T : class
  {
    public IEnumerable Categories { get; set; }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.Categories != null)
        dictionary["categories"] = (object) this.Categories;
      return dictionary;
    }

    public ChartCategoryAxisAutoBaseUnitStepsSettings<T> AutoBaseUnitSteps { get; } = new ChartCategoryAxisAutoBaseUnitStepsSettings<T>();

    public object[] AxisCrossingValue { get; set; }

    public string Background { get; set; }

    public int? BaseUnitStep { get; set; }

    public string Color { get; set; }

    public ChartCategoryAxisCrosshairSettings<T> Crosshair { get; } = new ChartCategoryAxisCrosshairSettings<T>();

    public string Field { get; set; }

    public bool? Justify { get; set; }

    public ChartCategoryAxisLabelsSettings<T> Labels { get; } = new ChartCategoryAxisLabelsSettings<T>();

    public ChartCategoryAxisLineSettings<T> Line { get; } = new ChartCategoryAxisLineSettings<T>();

    public ChartCategoryAxisMajorGridLinesSettings<T> MajorGridLines { get; } = new ChartCategoryAxisMajorGridLinesSettings<T>();

    public ChartCategoryAxisMajorTicksSettings<T> MajorTicks { get; } = new ChartCategoryAxisMajorTicksSettings<T>();

    public object Max { get; set; }

    public double? MaxDateGroups { get; set; }

    public double? MaxDivisions { get; set; }

    public object Min { get; set; }

    public ChartCategoryAxisMinorGridLinesSettings<T> MinorGridLines { get; } = new ChartCategoryAxisMinorGridLinesSettings<T>();

    public ChartCategoryAxisMinorTicksSettings<T> MinorTicks { get; } = new ChartCategoryAxisMinorTicksSettings<T>();

    public string Name { get; set; }

    public string Pane { get; set; }

    public List<ChartCategoryAxisPlotBand<T>> PlotBands { get; set; } = new List<ChartCategoryAxisPlotBand<T>>();

    public ChartCategoryAxisRangeLabelsSettings<T> RangeLabels { get; } = new ChartCategoryAxisRangeLabelsSettings<T>();

    public bool? Reverse { get; set; }

    public bool? RoundToBaseUnit { get; set; }

    public ChartCategoryAxisSelectSettings<T> Select { get; } = new ChartCategoryAxisSelectSettings<T>();

    public double? StartAngle { get; set; }

    public ChartCategoryAxisTitleSettings<T> Title { get; } = new ChartCategoryAxisTitleSettings<T>();

    public bool? Visible { get; set; }

    public double? WeekStartDay { get; set; }

    public ChartCategoryAxisNotesSettings<T> Notes { get; } = new ChartCategoryAxisNotesSettings<T>();

    public ChartAxisBaseUnit? BaseUnit { get; set; }

    public ChartCategoryAxisType? Type { get; set; }

    public Kendo.Mvc.UI.Chart<T> Chart { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      Dictionary<string, object> source1 = this.AutoBaseUnitSteps.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary1["autoBaseUnitSteps"] = (object) source1;
      object[] axisCrossingValue = this.AxisCrossingValue;
      if ((axisCrossingValue != null ? (((IEnumerable<object>) axisCrossingValue).Any<object>() ? 1 : 0) : 0) != 0)
        dictionary1["axisCrossingValue"] = (object) this.AxisCrossingValue;
      string background = this.Background;
      if ((background != null ? (background.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["background"] = (object) this.Background;
      if (this.BaseUnitStep.HasValue)
        dictionary1["baseUnitStep"] = (object) this.BaseUnitStep;
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["color"] = (object) this.Color;
      Dictionary<string, object> source2 = this.Crosshair.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary1["crosshair"] = (object) source2;
      string field = this.Field;
      if ((field != null ? (field.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["field"] = (object) this.Field;
      if (this.Justify.HasValue)
        dictionary1["justified"] = (object) this.Justify;
      Dictionary<string, object> source3 = this.Labels.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary1["labels"] = (object) source3;
      Dictionary<string, object> source4 = this.Line.Serialize();
      if (source4.Any<KeyValuePair<string, object>>())
        dictionary1["line"] = (object) source4;
      Dictionary<string, object> source5 = this.MajorGridLines.Serialize();
      if (source5.Any<KeyValuePair<string, object>>())
        dictionary1["majorGridLines"] = (object) source5;
      Dictionary<string, object> source6 = this.MajorTicks.Serialize();
      if (source6.Any<KeyValuePair<string, object>>())
        dictionary1["majorTicks"] = (object) source6;
      if (this.Max != null)
        dictionary1["max"] = this.Max;
      if (this.MaxDateGroups.HasValue)
        dictionary1["maxDateGroups"] = (object) this.MaxDateGroups;
      if (this.MaxDivisions.HasValue)
        dictionary1["maxDivisions"] = (object) this.MaxDivisions;
      if (this.Min != null)
        dictionary1["min"] = this.Min;
      Dictionary<string, object> source7 = this.MinorGridLines.Serialize();
      if (source7.Any<KeyValuePair<string, object>>())
        dictionary1["minorGridLines"] = (object) source7;
      Dictionary<string, object> source8 = this.MinorTicks.Serialize();
      if (source8.Any<KeyValuePair<string, object>>())
        dictionary1["minorTicks"] = (object) source8;
      string name = this.Name;
      if ((name != null ? (name.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["name"] = (object) this.Name;
      string pane = this.Pane;
      if ((pane != null ? (pane.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["pane"] = (object) this.Pane;
      IEnumerable<Dictionary<string, object>> source9 = this.PlotBands.Select<ChartCategoryAxisPlotBand<T>, Dictionary<string, object>>((Func<ChartCategoryAxisPlotBand<T>, Dictionary<string, object>>) (i => i.Serialize()));
      if (source9.Any<Dictionary<string, object>>())
        dictionary1["plotBands"] = (object) source9;
      Dictionary<string, object> source10 = this.RangeLabels.Serialize();
      if (source10.Any<KeyValuePair<string, object>>())
        dictionary1["rangeLabels"] = (object) source10;
      if (this.Reverse.HasValue)
        dictionary1["reverse"] = (object) this.Reverse;
      if (this.RoundToBaseUnit.HasValue)
        dictionary1["roundToBaseUnit"] = (object) this.RoundToBaseUnit;
      Dictionary<string, object> source11 = this.Select.Serialize();
      if (source11.Any<KeyValuePair<string, object>>())
        dictionary1["select"] = (object) source11;
      if (this.StartAngle.HasValue)
        dictionary1["startAngle"] = (object) this.StartAngle;
      Dictionary<string, object> source12 = this.Title.Serialize();
      if (source12.Any<KeyValuePair<string, object>>())
        dictionary1["title"] = (object) source12;
      if (this.Visible.HasValue)
        dictionary1["visible"] = (object) this.Visible;
      if (this.WeekStartDay.HasValue)
        dictionary1["weekStartDay"] = (object) this.WeekStartDay;
      Dictionary<string, object> source13 = this.Notes.Serialize();
      if (source13.Any<KeyValuePair<string, object>>())
        dictionary1["notes"] = (object) source13;
      if (this.BaseUnit.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        ChartAxisBaseUnit? baseUnit = this.BaseUnit;
        ref ChartAxisBaseUnit? local = ref baseUnit;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["baseUnit"] = (object) str;
      }
      if (this.Type.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        ChartCategoryAxisType? type = this.Type;
        ref ChartCategoryAxisType? local = ref type;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["type"] = (object) str;
      }
      return dictionary1;
    }
  }
}
