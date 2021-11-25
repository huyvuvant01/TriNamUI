// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ChartAxisDefaultsSettingsTagHelper
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
  [HtmlTargetElement("axis-defaults", ParentTag = "kendo-chart", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("crosshair", new string[] {"labels", "line", "major-grid-lines", "major-ticks", "minor-grid-lines", "minor-ticks", "plot-bands", "chart-axis-defaults-title"})]
  [SuppressTagRendering]
  public class ChartAxisDefaultsSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ChartTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ChartTagHelper).AxisDefaults = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Background { get; set; }

    public string Color { get; set; }

    [HtmlAttributeNotBound]
    public ChartAxisDefaultsCrosshairSettingsTagHelper Crosshair { get; set; }

    [HtmlAttributeNotBound]
    public ChartAxisDefaultsLabelsSettingsTagHelper Labels { get; set; }

    [HtmlAttributeNotBound]
    public ChartAxisDefaultsLineSettingsTagHelper Line { get; set; }

    [HtmlAttributeNotBound]
    public ChartAxisDefaultsMajorGridLinesSettingsTagHelper MajorGridLines { get; set; }

    [HtmlAttributeNotBound]
    public ChartAxisDefaultsMajorTicksSettingsTagHelper MajorTicks { get; set; }

    [HtmlAttributeNotBound]
    public ChartAxisDefaultsMinorGridLinesSettingsTagHelper MinorGridLines { get; set; }

    [HtmlAttributeNotBound]
    public ChartAxisDefaultsMinorTicksSettingsTagHelper MinorTicks { get; set; }

    public bool? NarrowRange { get; set; }

    public string Pane { get; set; }

    [HtmlAttributeNotBound]
    public ChartAxisDefaultsSettingsPlotBandsTagHelper PlotBands { get; set; }

    public bool? Reverse { get; set; }

    public double? StartAngle { get; set; }

    [HtmlAttributeNotBound]
    public ChartAxisDefaultsTitleSettingsTagHelper Title { get; set; }

    public bool? Visible { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
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
      if (this.MajorTicks != null)
      {
        Dictionary<string, object> source = this.MajorTicks.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["majorTicks"] = (object) source;
      }
      if (this.MinorGridLines != null)
      {
        Dictionary<string, object> source = this.MinorGridLines.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["minorGridLines"] = (object) source;
      }
      if (this.MinorTicks != null)
      {
        Dictionary<string, object> source = this.MinorTicks.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["minorTicks"] = (object) source;
      }
      bool? nullable = this.NarrowRange;
      if (nullable.HasValue)
        dictionary["narrowRange"] = (object) this.NarrowRange;
      string pane = this.Pane;
      if ((pane != null ? (pane.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["pane"] = (object) this.Pane;
      if (this.PlotBands != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.PlotBands.Select<ChartAxisDefaultsSettingsPlotBandTagHelper, Dictionary<string, object>>((Func<ChartAxisDefaultsSettingsPlotBandTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["plotBands"] = (object) source;
      }
      nullable = this.Reverse;
      if (nullable.HasValue)
        dictionary["reverse"] = (object) this.Reverse;
      if (this.StartAngle.HasValue)
        dictionary["startAngle"] = (object) this.StartAngle;
      if (this.Title != null)
      {
        Dictionary<string, object> source = this.Title.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["title"] = (object) source;
      }
      nullable = this.Visible;
      if (nullable.HasValue)
        dictionary["visible"] = (object) this.Visible;
      return dictionary;
    }
  }
}
