// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ChartCategoryAxisTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("category-axis-item", ParentTag = "category-axis", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("auto-base-unit-steps", new string[] {"crosshair", "labels", "line", "major-grid-lines", "major-ticks", "minor-grid-lines", "minor-ticks", "plot-bands", "select", "chart-category-axis-item-title", "notes", "range-labels"})]
  [SuppressTagRendering]
  public class ChartCategoryAxisTagHelper : TagHelperCollectionItemBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      System.Type type = typeof (ChartCategoryAxisTagHelperCollection);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ChartCategoryAxisTagHelperCollection).Add(this);
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    [HtmlAttributeNotBound]
    public ChartCategoryAxisAutoBaseUnitStepsSettingsTagHelper AutoBaseUnitSteps { get; set; }

    public object[] AxisCrossingValue { get; set; }

    public string Background { get; set; }

    public int? BaseUnitStep { get; set; }

    public object[] Categories { get; set; }

    public string Color { get; set; }

    [HtmlAttributeNotBound]
    public ChartCategoryAxisCrosshairSettingsTagHelper Crosshair { get; set; }

    public string Field { get; set; }

    public bool? Justify { get; set; }

    [HtmlAttributeNotBound]
    public ChartCategoryAxisLabelsSettingsTagHelper Labels { get; set; }

    [HtmlAttributeNotBound]
    public ChartCategoryAxisLineSettingsTagHelper Line { get; set; }

    [HtmlAttributeNotBound]
    public ChartCategoryAxisMajorGridLinesSettingsTagHelper MajorGridLines { get; set; }

    [HtmlAttributeNotBound]
    public ChartCategoryAxisMajorTicksSettingsTagHelper MajorTicks { get; set; }

    public object Max { get; set; }

    public double? MaxDateGroups { get; set; }

    public double? MaxDivisions { get; set; }

    public object Min { get; set; }

    [HtmlAttributeNotBound]
    public ChartCategoryAxisMinorGridLinesSettingsTagHelper MinorGridLines { get; set; }

    [HtmlAttributeNotBound]
    public ChartCategoryAxisMinorTicksSettingsTagHelper MinorTicks { get; set; }

    public string Name { get; set; }

    public string Pane { get; set; }

    [HtmlAttributeNotBound]
    public ChartCategoryAxisPlotBandsTagHelper PlotBands { get; set; }

    [HtmlAttributeNotBound]
    public ChartCategoryAxisRangeLabelsSettingsTagHelper RangeLabels { get; set; }

    public bool? Reverse { get; set; }

    public bool? RoundToBaseUnit { get; set; }

    [HtmlAttributeNotBound]
    public ChartCategoryAxisSelectSettingsTagHelper Select { get; set; }

    public double? StartAngle { get; set; }

    [HtmlAttributeNotBound]
    public ChartCategoryAxisTitleSettingsTagHelper Title { get; set; }

    public bool? Visible { get; set; }

    public double? WeekStartDay { get; set; }

    [HtmlAttributeNotBound]
    public ChartCategoryAxisNotesSettingsTagHelper Notes { get; set; }

    public ChartAxisBaseUnit? BaseUnit { get; set; }

    public ChartCategoryAxisType? Type { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      if (this.AutoBaseUnitSteps != null)
      {
        Dictionary<string, object> source = this.AutoBaseUnitSteps.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["autoBaseUnitSteps"] = (object) source;
      }
      object[] axisCrossingValue = this.AxisCrossingValue;
      if ((axisCrossingValue != null ? (((IEnumerable<object>) axisCrossingValue).Any<object>() ? 1 : 0) : 0) != 0)
        dictionary1["axisCrossingValue"] = (object) this.AxisCrossingValue;
      string background = this.Background;
      if ((background != null ? (background.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["background"] = (object) this.Background;
      if (this.BaseUnitStep.HasValue)
        dictionary1["baseUnitStep"] = (object) this.BaseUnitStep;
      object[] categories = this.Categories;
      if ((categories != null ? (((IEnumerable<object>) categories).Any<object>() ? 1 : 0) : 0) != 0)
        dictionary1["categories"] = (object) this.Categories;
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["color"] = (object) this.Color;
      if (this.Crosshair != null)
      {
        Dictionary<string, object> source = this.Crosshair.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["crosshair"] = (object) source;
      }
      string field = this.Field;
      if ((field != null ? (field.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["field"] = (object) this.Field;
      if (this.Justify.HasValue)
        dictionary1["justified"] = (object) this.Justify;
      if (this.Labels != null)
      {
        Dictionary<string, object> source = this.Labels.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["labels"] = (object) source;
      }
      if (this.Line != null)
      {
        Dictionary<string, object> source = this.Line.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["line"] = (object) source;
      }
      if (this.MajorGridLines != null)
      {
        Dictionary<string, object> source = this.MajorGridLines.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["majorGridLines"] = (object) source;
      }
      if (this.MajorTicks != null)
      {
        Dictionary<string, object> source = this.MajorTicks.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["majorTicks"] = (object) source;
      }
      if (this.Max != null)
        dictionary1["max"] = this.Max;
      if (this.MaxDateGroups.HasValue)
        dictionary1["maxDateGroups"] = (object) this.MaxDateGroups;
      if (this.MaxDivisions.HasValue)
        dictionary1["maxDivisions"] = (object) this.MaxDivisions;
      if (this.Min != null)
        dictionary1["min"] = this.Min;
      if (this.MinorGridLines != null)
      {
        Dictionary<string, object> source = this.MinorGridLines.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["minorGridLines"] = (object) source;
      }
      if (this.MinorTicks != null)
      {
        Dictionary<string, object> source = this.MinorTicks.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["minorTicks"] = (object) source;
      }
      string name = this.Name;
      if ((name != null ? (name.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["name"] = (object) this.Name;
      string pane = this.Pane;
      if ((pane != null ? (pane.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["pane"] = (object) this.Pane;
      if (this.PlotBands != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.PlotBands.Select<ChartCategoryAxisPlotBandTagHelper, Dictionary<string, object>>((Func<ChartCategoryAxisPlotBandTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary1["plotBands"] = (object) source;
      }
      if (this.RangeLabels != null)
      {
        Dictionary<string, object> source = this.RangeLabels.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["rangeLabels"] = (object) source;
      }
      if (this.Reverse.HasValue)
        dictionary1["reverse"] = (object) this.Reverse;
      if (this.RoundToBaseUnit.HasValue)
        dictionary1["roundToBaseUnit"] = (object) this.RoundToBaseUnit;
      if (this.Select != null)
      {
        Dictionary<string, object> source = this.Select.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["select"] = (object) source;
      }
      if (this.StartAngle.HasValue)
        dictionary1["startAngle"] = (object) this.StartAngle;
      if (this.Title != null)
      {
        Dictionary<string, object> source = this.Title.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["title"] = (object) source;
      }
      if (this.Visible.HasValue)
        dictionary1["visible"] = (object) this.Visible;
      if (this.WeekStartDay.HasValue)
        dictionary1["weekStartDay"] = (object) this.WeekStartDay;
      if (this.Notes != null)
      {
        Dictionary<string, object> source = this.Notes.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["notes"] = (object) source;
      }
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
