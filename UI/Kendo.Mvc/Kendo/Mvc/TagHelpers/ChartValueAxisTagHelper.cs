// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ChartValueAxisTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("value-axis-item", ParentTag = "value-axis", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("crosshair", new string[] {"labels", "line", "major-grid-lines", "minor-grid-lines", "major-ticks", "minor-ticks", "plot-bands", "chart-value-axis-item-title", "notes"})]
  [SuppressTagRendering]
  public class ChartValueAxisTagHelper : TagHelperCollectionItemBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      System.Type type = typeof (ChartValueAxisTagHelperCollection);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ChartValueAxisTagHelperCollection).Add(this);
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public object[] AxisCrossingValue { get; set; }

    public string Background { get; set; }

    public string Color { get; set; }

    [HtmlAttributeNotBound]
    public ChartValueAxisCrosshairSettingsTagHelper Crosshair { get; set; }

    [HtmlAttributeNotBound]
    public ChartValueAxisLabelsSettingsTagHelper Labels { get; set; }

    [HtmlAttributeNotBound]
    public ChartValueAxisLineSettingsTagHelper Line { get; set; }

    [HtmlAttributeNotBound]
    public ChartValueAxisMajorGridLinesSettingsTagHelper MajorGridLines { get; set; }

    public double? MajorUnit { get; set; }

    public double? Max { get; set; }

    public double? Min { get; set; }

    [HtmlAttributeNotBound]
    public ChartValueAxisMinorGridLinesSettingsTagHelper MinorGridLines { get; set; }

    [HtmlAttributeNotBound]
    public ChartValueAxisMajorTicksSettingsTagHelper MajorTicks { get; set; }

    [HtmlAttributeNotBound]
    public ChartValueAxisMinorTicksSettingsTagHelper MinorTicks { get; set; }

    public double? MinorUnit { get; set; }

    public string Name { get; set; }

    public bool? NarrowRange { get; set; }

    public string Pane { get; set; }

    [HtmlAttributeNotBound]
    public ChartValueAxisPlotBandsTagHelper PlotBands { get; set; }

    public bool? Reverse { get; set; }

    [HtmlAttributeNotBound]
    public ChartValueAxisTitleSettingsTagHelper Title { get; set; }

    public string Type { get; set; }

    public bool? Visible { get; set; }

    [HtmlAttributeNotBound]
    public ChartValueAxisNotesSettingsTagHelper Notes { get; set; }

    public double? ZIndex { get; set; }

    internal Dictionary<string, object> SerializeSettings()
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
      if (this.Crosshair != null)
      {
        Dictionary<string, object> source = this.Crosshair.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["crosshair"] = (object) source;
      }
      if (this.Labels != null)
      {
        Dictionary<string, object> source = this.Labels.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["labels"] = (object) source;
      }
      if (this.Line != null)
      {
        Dictionary<string, object> source = this.Line.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["line"] = (object) source;
      }
      if (this.MajorGridLines != null)
      {
        Dictionary<string, object> source = this.MajorGridLines.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["majorGridLines"] = (object) source;
      }
      double? nullable1 = this.MajorUnit;
      if (nullable1.HasValue)
        dictionary["majorUnit"] = (object) this.MajorUnit;
      nullable1 = this.Max;
      if (nullable1.HasValue)
        dictionary["max"] = (object) this.Max;
      nullable1 = this.Min;
      if (nullable1.HasValue)
        dictionary["min"] = (object) this.Min;
      if (this.MinorGridLines != null)
      {
        Dictionary<string, object> source = this.MinorGridLines.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["minorGridLines"] = (object) source;
      }
      if (this.MajorTicks != null)
      {
        Dictionary<string, object> source = this.MajorTicks.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["majorTicks"] = (object) source;
      }
      if (this.MinorTicks != null)
      {
        Dictionary<string, object> source = this.MinorTicks.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["minorTicks"] = (object) source;
      }
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
      if (this.PlotBands != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.PlotBands.Select<ChartValueAxisPlotBandTagHelper, Dictionary<string, object>>((Func<ChartValueAxisPlotBandTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["plotBands"] = (object) source;
      }
      nullable2 = this.Reverse;
      if (nullable2.HasValue)
        dictionary["reverse"] = (object) this.Reverse;
      if (this.Title != null)
      {
        Dictionary<string, object> source = this.Title.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["title"] = (object) source;
      }
      string type = this.Type;
      if ((type != null ? (type.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["type"] = (object) this.Type;
      nullable2 = this.Visible;
      if (nullable2.HasValue)
        dictionary["visible"] = (object) this.Visible;
      if (this.Notes != null)
      {
        Dictionary<string, object> source = this.Notes.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["notes"] = (object) source;
      }
      nullable1 = this.ZIndex;
      if (nullable1.HasValue)
        dictionary["zIndex"] = (object) this.ZIndex;
      return dictionary;
    }
  }
}
