// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ChartSeriesDefaultsSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("series-defaults", ParentTag = "kendo-chart", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("border", new string[] {"labels", "overlay", "stack", "tooltip", "notes"})]
  [SuppressTagRendering]
  public class ChartSeriesDefaultsSettingsTagHelper : TagHelperChildBase
  {
    public 
    #nullable disable
    string Visual { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      System.Type type = typeof (ChartTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ChartTagHelper).SeriesDefaults = this;
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      string visual = this.Visual;
      if ((visual != null ? (visual.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["visual"] = (object) this.CreateHandler(this.Visual);
      return dictionary;
    }

    [HtmlAttributeNotBound]
    public ChartSeriesDefaultsBorderSettingsTagHelper Border { get; set; }

    public double? Gap { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesDefaultsLabelsSettingsTagHelper Labels { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesDefaultsOverlaySettingsTagHelper Overlay { get; set; }

    public double? Spacing { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesDefaultsStackSettingsTagHelper Stack { get; set; }

    public double? StartAngle { get; set; }

    public ChartSeriesType? Type { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesDefaultsTooltipSettingsTagHelper Tooltip { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesDefaultsNotesSettingsTagHelper Notes { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      if (this.Border != null)
      {
        Dictionary<string, object> source = this.Border.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["border"] = (object) source;
      }
      if (this.Gap.HasValue)
        dictionary1["gap"] = (object) this.Gap;
      if (this.Labels != null)
      {
        Dictionary<string, object> source = this.Labels.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["labels"] = (object) source;
      }
      if (this.Overlay != null)
      {
        Dictionary<string, object> source = this.Overlay.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["overlay"] = (object) source;
      }
      if (this.Spacing.HasValue)
        dictionary1["spacing"] = (object) this.Spacing;
      if (this.Stack != null)
      {
        Dictionary<string, object> source = this.Stack.Serialize();
        bool? enabled;
        if (source.Any<KeyValuePair<string, object>>())
        {
          enabled = this.Stack.Enabled;
          if (enabled.HasValue)
          {
            enabled = this.Stack.Enabled;
            if (!enabled.Value)
              goto label_18;
          }
          dictionary1["stack"] = (object) source;
          goto label_21;
        }
label_18:
        enabled = this.Stack.Enabled;
        if (enabled.HasValue)
        {
          enabled = this.Stack.Enabled;
          if (enabled.Value)
            dictionary1["stack"] = (object) this.Stack.Enabled;
        }
      }
label_21:
      if (this.StartAngle.HasValue)
        dictionary1["startAngle"] = (object) this.StartAngle;
      if (this.Type.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        ChartSeriesType? type = this.Type;
        ref ChartSeriesType? local = ref type;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["type"] = (object) str;
      }
      if (this.Tooltip != null)
      {
        Dictionary<string, object> source = this.Tooltip.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["tooltip"] = (object) source;
      }
      if (this.Notes != null)
      {
        Dictionary<string, object> source = this.Notes.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["notes"] = (object) source;
      }
      return dictionary1;
    }

    public ChartSeriesTagHelper Area { get; } = new ChartSeriesTagHelper();

    public ChartSeriesTagHelper Bar { get; } = new ChartSeriesTagHelper();

    public ChartSeriesTagHelper BoxPlot { get; } = new ChartSeriesTagHelper();

    public ChartSeriesTagHelper Bubble { get; } = new ChartSeriesTagHelper();

    public ChartSeriesTagHelper Bullet { get; } = new ChartSeriesTagHelper();

    public ChartSeriesTagHelper Candlestick { get; } = new ChartSeriesTagHelper();

    public ChartSeriesTagHelper Column { get; } = new ChartSeriesTagHelper();

    public ChartSeriesTagHelper Donut { get; } = new ChartSeriesTagHelper();

    public ChartSeriesTagHelper Funnel { get; } = new ChartSeriesTagHelper();

    public ChartSeriesTagHelper HorizontalWaterfall { get; } = new ChartSeriesTagHelper();

    public ChartSeriesTagHelper Line { get; } = new ChartSeriesTagHelper();

    public ChartSeriesTagHelper OHLC { get; } = new ChartSeriesTagHelper();

    public ChartSeriesTagHelper Pie { get; } = new ChartSeriesTagHelper();

    public ChartSeriesTagHelper PolarArea { get; } = new ChartSeriesTagHelper();

    public ChartSeriesTagHelper PolarLine { get; } = new ChartSeriesTagHelper();

    public ChartSeriesTagHelper PolarScatter { get; } = new ChartSeriesTagHelper();

    public ChartSeriesTagHelper RadarArea { get; } = new ChartSeriesTagHelper();

    public ChartSeriesTagHelper RadarColumn { get; } = new ChartSeriesTagHelper();

    public ChartSeriesTagHelper RadarLine { get; } = new ChartSeriesTagHelper();

    public ChartSeriesTagHelper RangeArea { get; } = new ChartSeriesTagHelper();

    public ChartSeriesTagHelper RangeBar { get; } = new ChartSeriesTagHelper();

    public ChartSeriesTagHelper RangeColumn { get; } = new ChartSeriesTagHelper();

    public ChartSeriesTagHelper Scatter { get; } = new ChartSeriesTagHelper();

    public ChartSeriesTagHelper ScatterLine { get; } = new ChartSeriesTagHelper();

    public ChartSeriesTagHelper VerticalArea { get; } = new ChartSeriesTagHelper();

    public ChartSeriesTagHelper VerticalBoxPlot { get; } = new ChartSeriesTagHelper();

    public ChartSeriesTagHelper VerticalBullet { get; } = new ChartSeriesTagHelper();

    public ChartSeriesTagHelper VerticalLine { get; } = new ChartSeriesTagHelper();

    public ChartSeriesTagHelper VerticalRangeArea { get; } = new ChartSeriesTagHelper();

    public ChartSeriesTagHelper Waterfall { get; } = new ChartSeriesTagHelper();

    public ChartSeriesTagHelper HeatMap { get; } = new ChartSeriesTagHelper();

    private Dictionary<string, object> SerializeSeries(Dictionary<string, object> settings)
    {
      Dictionary<string, object> source1 = this.Area.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        settings["area"] = (object) source1;
      Dictionary<string, object> source2 = this.Bar.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        settings["bar"] = (object) source2;
      Dictionary<string, object> source3 = this.BoxPlot.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        settings["boxPlot"] = (object) source3;
      Dictionary<string, object> source4 = this.Bubble.Serialize();
      if (source4.Any<KeyValuePair<string, object>>())
        settings["bubble"] = (object) source4;
      Dictionary<string, object> source5 = this.Bullet.Serialize();
      if (source5.Any<KeyValuePair<string, object>>())
        settings["bullet"] = (object) source5;
      Dictionary<string, object> source6 = this.Candlestick.Serialize();
      if (source6.Any<KeyValuePair<string, object>>())
        settings["candlestick"] = (object) source6;
      Dictionary<string, object> source7 = this.Column.Serialize();
      if (source7.Any<KeyValuePair<string, object>>())
        settings["column"] = (object) source7;
      Dictionary<string, object> source8 = this.Donut.Serialize();
      if (source8.Any<KeyValuePair<string, object>>())
        settings["donut"] = (object) source8;
      Dictionary<string, object> source9 = this.Funnel.Serialize();
      if (source9.Any<KeyValuePair<string, object>>())
        settings["funnel"] = (object) source9;
      Dictionary<string, object> source10 = this.HorizontalWaterfall.Serialize();
      if (source10.Any<KeyValuePair<string, object>>())
        settings["horizontalWaterfall"] = (object) source10;
      Dictionary<string, object> source11 = this.Line.Serialize();
      if (source11.Any<KeyValuePair<string, object>>())
        settings["line"] = (object) source11;
      Dictionary<string, object> source12 = this.OHLC.Serialize();
      if (source12.Any<KeyValuePair<string, object>>())
        settings["ohlc"] = (object) source12;
      Dictionary<string, object> source13 = this.Pie.Serialize();
      if (source13.Any<KeyValuePair<string, object>>())
        settings["pie"] = (object) source13;
      Dictionary<string, object> source14 = this.PolarArea.Serialize();
      if (source14.Any<KeyValuePair<string, object>>())
        settings["polarArea"] = (object) source14;
      Dictionary<string, object> source15 = this.PolarLine.Serialize();
      if (source15.Any<KeyValuePair<string, object>>())
        settings["polarLine"] = (object) source15;
      Dictionary<string, object> source16 = this.PolarScatter.Serialize();
      if (source16.Any<KeyValuePair<string, object>>())
        settings["polarScatter"] = (object) source16;
      Dictionary<string, object> source17 = this.RadarArea.Serialize();
      if (source17.Any<KeyValuePair<string, object>>())
        settings["radarArea"] = (object) source17;
      Dictionary<string, object> source18 = this.RadarColumn.Serialize();
      if (source18.Any<KeyValuePair<string, object>>())
        settings["radarColumn"] = (object) source18;
      Dictionary<string, object> source19 = this.RadarLine.Serialize();
      if (source19.Any<KeyValuePair<string, object>>())
        settings["radarLine"] = (object) source19;
      Dictionary<string, object> source20 = this.RangeArea.Serialize();
      if (source20.Any<KeyValuePair<string, object>>())
        settings["rangeArea"] = (object) source20;
      Dictionary<string, object> source21 = this.RangeBar.Serialize();
      if (source21.Any<KeyValuePair<string, object>>())
        settings["rangeBar"] = (object) source21;
      Dictionary<string, object> source22 = this.RangeColumn.Serialize();
      if (source22.Any<KeyValuePair<string, object>>())
        settings["rangeColumn"] = (object) source22;
      Dictionary<string, object> source23 = this.Scatter.Serialize();
      if (source23.Any<KeyValuePair<string, object>>())
        settings["scatter"] = (object) source23;
      Dictionary<string, object> source24 = this.ScatterLine.Serialize();
      if (source24.Any<KeyValuePair<string, object>>())
        settings["scatterLine"] = (object) source24;
      Dictionary<string, object> source25 = this.VerticalArea.Serialize();
      if (source25.Any<KeyValuePair<string, object>>())
        settings["verticalArea"] = (object) source25;
      Dictionary<string, object> source26 = this.VerticalBoxPlot.Serialize();
      if (source26.Any<KeyValuePair<string, object>>())
        settings["verticalBoxPlot"] = (object) source26;
      Dictionary<string, object> source27 = this.VerticalBullet.Serialize();
      if (source27.Any<KeyValuePair<string, object>>())
        settings["verticalBullet"] = (object) source27;
      Dictionary<string, object> source28 = this.VerticalLine.Serialize();
      if (source28.Any<KeyValuePair<string, object>>())
        settings["verticalLine"] = (object) source28;
      Dictionary<string, object> source29 = this.VerticalRangeArea.Serialize();
      if (source29.Any<KeyValuePair<string, object>>())
        settings["verticalRangeArea"] = (object) source29;
      Dictionary<string, object> source30 = this.Waterfall.Serialize();
      if (source30.Any<KeyValuePair<string, object>>())
        settings["waterfall"] = (object) source30;
      Dictionary<string, object> source31 = this.HeatMap.Serialize();
      if (source31.Any<KeyValuePair<string, object>>())
        settings["heatMap"] = (object) source31;
      return settings;
    }
  }
}
