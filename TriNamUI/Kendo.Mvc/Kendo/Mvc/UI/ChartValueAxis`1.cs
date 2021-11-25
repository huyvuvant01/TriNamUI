// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartValueAxis`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ChartValueAxis<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public object[] AxisCrossingValue { get; set; }

    public string Background { get; set; }

    public string Color { get; set; }

    public ChartValueAxisCrosshairSettings<T> Crosshair { get; } = new ChartValueAxisCrosshairSettings<T>();

    public ChartValueAxisLabelsSettings<T> Labels { get; } = new ChartValueAxisLabelsSettings<T>();

    public ChartValueAxisLineSettings<T> Line { get; } = new ChartValueAxisLineSettings<T>();

    public ChartValueAxisMajorGridLinesSettings<T> MajorGridLines { get; } = new ChartValueAxisMajorGridLinesSettings<T>();

    public double? MajorUnit { get; set; }

    public double? Max { get; set; }

    public double? Min { get; set; }

    public ChartValueAxisMinorGridLinesSettings<T> MinorGridLines { get; } = new ChartValueAxisMinorGridLinesSettings<T>();

    public ChartValueAxisMajorTicksSettings<T> MajorTicks { get; } = new ChartValueAxisMajorTicksSettings<T>();

    public ChartValueAxisMinorTicksSettings<T> MinorTicks { get; } = new ChartValueAxisMinorTicksSettings<T>();

    public double? MinorUnit { get; set; }

    public string Name { get; set; }

    public bool? NarrowRange { get; set; }

    public string Pane { get; set; }

    public List<ChartValueAxisPlotBand<T>> PlotBands { get; set; } = new List<ChartValueAxisPlotBand<T>>();

    public bool? Reverse { get; set; }

    public ChartValueAxisTitleSettings<T> Title { get; } = new ChartValueAxisTitleSettings<T>();

    public string Type { get; set; }

    public bool? Visible { get; set; }

    public ChartValueAxisNotesSettings<T> Notes { get; } = new ChartValueAxisNotesSettings<T>();

    public double? ZIndex { get; set; }

    public Kendo.Mvc.UI.Chart<T> Chart { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      object[] axisCrossingValue = this.AxisCrossingValue;
      if ((axisCrossingValue != null ? (((IEnumerable<object>) axisCrossingValue).Any<object>() ? 1 : 0) : 0) != 0)
        dictionary["axisCrossingValue"] = (object) this.AxisCrossingValue;
      string background = this.Background;
      if ((background != null ? (background.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["background"] = (object) this.Background;
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["color"] = (object) this.Color;
      Dictionary<string, object> source1 = this.Crosshair.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["crosshair"] = (object) source1;
      Dictionary<string, object> source2 = this.Labels.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["labels"] = (object) source2;
      Dictionary<string, object> source3 = this.Line.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["line"] = (object) source3;
      Dictionary<string, object> source4 = this.MajorGridLines.Serialize();
      if (source4.Any<KeyValuePair<string, object>>())
        dictionary["majorGridLines"] = (object) source4;
      double? nullable1 = this.MajorUnit;
      if (nullable1.HasValue)
        dictionary["majorUnit"] = (object) this.MajorUnit;
      nullable1 = this.Max;
      if (nullable1.HasValue)
        dictionary["max"] = (object) this.Max;
      nullable1 = this.Min;
      if (nullable1.HasValue)
        dictionary["min"] = (object) this.Min;
      Dictionary<string, object> source5 = this.MinorGridLines.Serialize();
      if (source5.Any<KeyValuePair<string, object>>())
        dictionary["minorGridLines"] = (object) source5;
      Dictionary<string, object> source6 = this.MajorTicks.Serialize();
      if (source6.Any<KeyValuePair<string, object>>())
        dictionary["majorTicks"] = (object) source6;
      Dictionary<string, object> source7 = this.MinorTicks.Serialize();
      if (source7.Any<KeyValuePair<string, object>>())
        dictionary["minorTicks"] = (object) source7;
      nullable1 = this.MinorUnit;
      if (nullable1.HasValue)
        dictionary["minorUnit"] = (object) this.MinorUnit;
      string name = this.Name;
      if ((name != null ? (name.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["name"] = (object) this.Name;
      bool? nullable2 = this.NarrowRange;
      if (nullable2.HasValue)
        dictionary["narrowRange"] = (object) this.NarrowRange;
      string pane = this.Pane;
      if ((pane != null ? (pane.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["pane"] = (object) this.Pane;
      IEnumerable<Dictionary<string, object>> source8 = this.PlotBands.Select<ChartValueAxisPlotBand<T>, Dictionary<string, object>>((Func<ChartValueAxisPlotBand<T>, Dictionary<string, object>>) (i => i.Serialize()));
      if (source8.Any<Dictionary<string, object>>())
        dictionary["plotBands"] = (object) source8;
      nullable2 = this.Reverse;
      if (nullable2.HasValue)
        dictionary["reverse"] = (object) this.Reverse;
      Dictionary<string, object> source9 = this.Title.Serialize();
      if (source9.Any<KeyValuePair<string, object>>())
        dictionary["title"] = (object) source9;
      string type = this.Type;
      if ((type != null ? (type.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["type"] = (object) this.Type;
      nullable2 = this.Visible;
      if (nullable2.HasValue)
        dictionary["visible"] = (object) this.Visible;
      Dictionary<string, object> source10 = this.Notes.Serialize();
      if (source10.Any<KeyValuePair<string, object>>())
        dictionary["notes"] = (object) source10;
      nullable1 = this.ZIndex;
      if (nullable1.HasValue)
        dictionary["zIndex"] = (object) this.ZIndex;
      return dictionary;
    }
  }
}
