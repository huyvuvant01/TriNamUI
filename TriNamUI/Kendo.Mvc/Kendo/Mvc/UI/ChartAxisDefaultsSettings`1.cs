// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartAxisDefaultsSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ChartAxisDefaultsSettings<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Background { get; set; }

    public string Color { get; set; }

    public ChartAxisDefaultsCrosshairSettings<T> Crosshair { get; } = new ChartAxisDefaultsCrosshairSettings<T>();

    public ChartAxisDefaultsLabelsSettings<T> Labels { get; } = new ChartAxisDefaultsLabelsSettings<T>();

    public ChartAxisDefaultsLineSettings<T> Line { get; } = new ChartAxisDefaultsLineSettings<T>();

    public ChartAxisDefaultsMajorGridLinesSettings<T> MajorGridLines { get; } = new ChartAxisDefaultsMajorGridLinesSettings<T>();

    public ChartAxisDefaultsMajorTicksSettings<T> MajorTicks { get; } = new ChartAxisDefaultsMajorTicksSettings<T>();

    public ChartAxisDefaultsMinorGridLinesSettings<T> MinorGridLines { get; } = new ChartAxisDefaultsMinorGridLinesSettings<T>();

    public ChartAxisDefaultsMinorTicksSettings<T> MinorTicks { get; } = new ChartAxisDefaultsMinorTicksSettings<T>();

    public bool? NarrowRange { get; set; }

    public string Pane { get; set; }

    public List<ChartAxisDefaultsSettingsPlotBand<T>> PlotBands { get; set; } = new List<ChartAxisDefaultsSettingsPlotBand<T>>();

    public bool? Reverse { get; set; }

    public double? StartAngle { get; set; }

    public ChartAxisDefaultsTitleSettings<T> Title { get; } = new ChartAxisDefaultsTitleSettings<T>();

    public bool? Visible { get; set; }

    public Kendo.Mvc.UI.Chart<T> Chart { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
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
      Dictionary<string, object> source5 = this.MajorTicks.Serialize();
      if (source5.Any<KeyValuePair<string, object>>())
        dictionary["majorTicks"] = (object) source5;
      Dictionary<string, object> source6 = this.MinorGridLines.Serialize();
      if (source6.Any<KeyValuePair<string, object>>())
        dictionary["minorGridLines"] = (object) source6;
      Dictionary<string, object> source7 = this.MinorTicks.Serialize();
      if (source7.Any<KeyValuePair<string, object>>())
        dictionary["minorTicks"] = (object) source7;
      bool? nullable = this.NarrowRange;
      if (nullable.HasValue)
        dictionary["narrowRange"] = (object) this.NarrowRange;
      string pane = this.Pane;
      if ((pane != null ? (pane.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["pane"] = (object) this.Pane;
      IEnumerable<Dictionary<string, object>> source8 = this.PlotBands.Select<ChartAxisDefaultsSettingsPlotBand<T>, Dictionary<string, object>>((Func<ChartAxisDefaultsSettingsPlotBand<T>, Dictionary<string, object>>) (i => i.Serialize()));
      if (source8.Any<Dictionary<string, object>>())
        dictionary["plotBands"] = (object) source8;
      nullable = this.Reverse;
      if (nullable.HasValue)
        dictionary["reverse"] = (object) this.Reverse;
      if (this.StartAngle.HasValue)
        dictionary["startAngle"] = (object) this.StartAngle;
      Dictionary<string, object> source9 = this.Title.Serialize();
      if (source9.Any<KeyValuePair<string, object>>())
        dictionary["title"] = (object) source9;
      nullable = this.Visible;
      if (nullable.HasValue)
        dictionary["visible"] = (object) this.Visible;
      return dictionary;
    }
  }
}
