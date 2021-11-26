// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ChartSeriesTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("series-item", ParentTag = "series", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("border", new string[] {"connectors", "error-bars", "highlight", "labels", "line", "margin", "markers", "outliers", "extremes", "negative-values", "overlay", "stack", "target", "tooltip", "notes", "aggregate"})]
  [SuppressTagRendering]
  public class ChartSeriesTagHelper : TagHelperCollectionItemBase
  {
    public 
    #nullable disable
    string Visual { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesAggregateSettingsTagHelper Aggregates { get; set; }

    public IEnumerable Data { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      System.Type type = typeof (ChartSeriesTagHelperCollection);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ChartSeriesTagHelperCollection).Add(this);
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.Aggregates != null)
      {
        Dictionary<string, object> source = this.Aggregates.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["aggregate"] = (object) source;
      }
      if (this.Data != null)
        dictionary["data"] = (object) this.Data;
      string visual = this.Visual;
      if ((visual != null ? (visual.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["visual"] = (object) this.CreateHandler(this.Visual);
      return dictionary;
    }

    public bool? AutoFit { get; set; }

    public string Axis { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesBorderSettingsTagHelper Border { get; set; }

    public string CategoryAxis { get; set; }

    public string CategoryField { get; set; }

    public string CloseField { get; set; }

    public string Color { get; set; }

    public string ColorHandler { get; set; }

    public string ColorField { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesConnectorsSettingsTagHelper Connectors { get; set; }

    public string CurrentField { get; set; }

    public Kendo.Mvc.UI.DashType? DashType { get; set; }

    public string DownColor { get; set; }

    public string DownColorHandler { get; set; }

    public string DownColorField { get; set; }

    public double? SegmentSpacing { get; set; }

    public string SummaryField { get; set; }

    public double? NeckRatio { get; set; }

    public bool? DynamicSlope { get; set; }

    public bool? DynamicHeight { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesErrorBarsSettingsTagHelper ErrorBars { get; set; }

    public string ErrorLowField { get; set; }

    public string ErrorHighField { get; set; }

    public string XErrorLowField { get; set; }

    public string XErrorHighField { get; set; }

    public string YErrorLowField { get; set; }

    public string YErrorHighField { get; set; }

    public string ExplodeField { get; set; }

    public string Field { get; set; }

    public string FromField { get; set; }

    public string ToField { get; set; }

    public string NoteTextField { get; set; }

    public string LowerField { get; set; }

    public string Q1Field { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesMedianSettingsTagHelper Median { get; set; }

    public string MedianField { get; set; }

    public string Q3Field { get; set; }

    public string UpperField { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesMeanSettingsTagHelper Mean { get; set; }

    public string MeanField { get; set; }

    public string OutliersField { get; set; }

    public double? Gap { get; set; }

    public string HighField { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesHighlightSettingsTagHelper Highlight { get; set; }

    public double? HoleSize { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesLabelsSettingsTagHelper Labels { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesLineSettingsTagHelper Line { get; set; }

    public string LowField { get; set; }

    public double? Margin { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesMarkersSettingsTagHelper Markers { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesOutliersSettingsTagHelper Outliers { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesExtremesSettingsTagHelper Extremes { get; set; }

    public double? MaxSize { get; set; }

    public double? MinSize { get; set; }

    public string Name { get; set; }

    public string NegativeColor { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesNegativeValuesSettingsTagHelper NegativeValues { get; set; }

    public double? Opacity { get; set; }

    public string OpenField { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesOverlaySettingsTagHelper Overlay { get; set; }

    public double? Padding { get; set; }

    public double? Size { get; set; }

    public string SizeField { get; set; }

    public double? Spacing { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesStackSettingsTagHelper Stack { get; set; }

    public double? StartAngle { get; set; }

    public string TargetField { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesTargetSettingsTagHelper Target { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesTooltipSettingsTagHelper Tooltip { get; set; }

    public bool? Visible { get; set; }

    public bool? VisibleInLegend { get; set; }

    public string VisibleInLegendField { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesWhiskersSettingsTagHelper Whiskers { get; set; }

    public double? Width { get; set; }

    public string XAxis { get; set; }

    public string XField { get; set; }

    public string YAxis { get; set; }

    public string YField { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesNotesSettingsTagHelper Notes { get; set; }

    public double? ZIndex { get; set; }

    public ChartSeriesAggregate? Aggregate { get; set; }

    public string AggregateHandler { get; set; }

    public ChartSeriesMissingValues? MissingValues { get; set; }

    public ChartSeriesStyle? Style { get; set; }

    public ChartSeriesType? Type { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      if (this.AutoFit.HasValue)
        dictionary1["autoFit"] = (object) this.AutoFit;
      string axis = this.Axis;
      if ((axis != null ? (axis.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["axis"] = (object) this.Axis;
      if (this.Border != null)
      {
        Dictionary<string, object> source = this.Border.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["border"] = (object) source;
      }
      string categoryAxis = this.CategoryAxis;
      if ((categoryAxis != null ? (categoryAxis.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["categoryAxis"] = (object) this.CategoryAxis;
      string categoryField = this.CategoryField;
      if ((categoryField != null ? (categoryField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["categoryField"] = (object) this.CategoryField;
      string closeField = this.CloseField;
      if ((closeField != null ? (closeField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["closeField"] = (object) this.CloseField;
      string colorHandler = this.ColorHandler;
      if ((colorHandler != null ? (colorHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["color"] = (object) this.CreateHandler(this.ColorHandler);
      }
      else
      {
        string color = this.Color;
        if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
          dictionary1["color"] = (object) this.Color;
      }
      string colorField = this.ColorField;
      if ((colorField != null ? (colorField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["colorField"] = (object) this.ColorField;
      if (this.Connectors != null)
      {
        Dictionary<string, object> source = this.Connectors.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["connectors"] = (object) source;
      }
      string currentField = this.CurrentField;
      if ((currentField != null ? (currentField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["currentField"] = (object) this.CurrentField;
      if (this.DashType.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        Kendo.Mvc.UI.DashType? dashType = this.DashType;
        ref Kendo.Mvc.UI.DashType? local = ref dashType;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["dashType"] = (object) str;
      }
      string downColorHandler = this.DownColorHandler;
      if ((downColorHandler != null ? (downColorHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["downColor"] = (object) this.CreateHandler(this.DownColorHandler);
      }
      else
      {
        string downColor = this.DownColor;
        if ((downColor != null ? (downColor.HasValue() ? 1 : 0) : 0) != 0)
          dictionary1["downColor"] = (object) this.DownColor;
      }
      string downColorField = this.DownColorField;
      if ((downColorField != null ? (downColorField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["downColorField"] = (object) this.DownColorField;
      if (this.SegmentSpacing.HasValue)
        dictionary1["segmentSpacing"] = (object) this.SegmentSpacing;
      string summaryField = this.SummaryField;
      if ((summaryField != null ? (summaryField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["summaryField"] = (object) this.SummaryField;
      if (this.NeckRatio.HasValue)
        dictionary1["neckRatio"] = (object) this.NeckRatio;
      if (this.DynamicSlope.HasValue)
        dictionary1["dynamicSlope"] = (object) this.DynamicSlope;
      if (this.DynamicHeight.HasValue)
        dictionary1["dynamicHeight"] = (object) this.DynamicHeight;
      if (this.ErrorBars != null)
      {
        Dictionary<string, object> source = this.ErrorBars.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["errorBars"] = (object) source;
      }
      string errorLowField = this.ErrorLowField;
      if ((errorLowField != null ? (errorLowField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["errorLowField"] = (object) this.ErrorLowField;
      string errorHighField = this.ErrorHighField;
      if ((errorHighField != null ? (errorHighField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["errorHighField"] = (object) this.ErrorHighField;
      string xerrorLowField = this.XErrorLowField;
      if ((xerrorLowField != null ? (xerrorLowField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["xErrorLowField"] = (object) this.XErrorLowField;
      string xerrorHighField = this.XErrorHighField;
      if ((xerrorHighField != null ? (xerrorHighField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["xErrorHighField"] = (object) this.XErrorHighField;
      string yerrorLowField = this.YErrorLowField;
      if ((yerrorLowField != null ? (yerrorLowField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["yErrorLowField"] = (object) this.YErrorLowField;
      string yerrorHighField = this.YErrorHighField;
      if ((yerrorHighField != null ? (yerrorHighField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["yErrorHighField"] = (object) this.YErrorHighField;
      string explodeField = this.ExplodeField;
      if ((explodeField != null ? (explodeField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["explodeField"] = (object) this.ExplodeField;
      string field = this.Field;
      if ((field != null ? (field.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["field"] = (object) this.Field;
      string fromField = this.FromField;
      if ((fromField != null ? (fromField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["fromField"] = (object) this.FromField;
      string toField = this.ToField;
      if ((toField != null ? (toField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["toField"] = (object) this.ToField;
      string noteTextField = this.NoteTextField;
      if ((noteTextField != null ? (noteTextField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["noteTextField"] = (object) this.NoteTextField;
      string lowerField = this.LowerField;
      if ((lowerField != null ? (lowerField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["lowerField"] = (object) this.LowerField;
      string q1Field = this.Q1Field;
      if ((q1Field != null ? (q1Field.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["q1Field"] = (object) this.Q1Field;
      if (this.Median != null)
      {
        Dictionary<string, object> source = this.Median.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["median"] = (object) source;
      }
      string medianField = this.MedianField;
      if ((medianField != null ? (medianField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["medianField"] = (object) this.MedianField;
      string q3Field = this.Q3Field;
      if ((q3Field != null ? (q3Field.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["q3Field"] = (object) this.Q3Field;
      string upperField = this.UpperField;
      if ((upperField != null ? (upperField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["upperField"] = (object) this.UpperField;
      if (this.Mean != null)
      {
        Dictionary<string, object> source = this.Mean.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["mean"] = (object) source;
      }
      string meanField = this.MeanField;
      if ((meanField != null ? (meanField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["meanField"] = (object) this.MeanField;
      string outliersField = this.OutliersField;
      if ((outliersField != null ? (outliersField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["outliersField"] = (object) this.OutliersField;
      if (this.Gap.HasValue)
        dictionary1["gap"] = (object) this.Gap;
      string highField = this.HighField;
      if ((highField != null ? (highField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["highField"] = (object) this.HighField;
      if (this.Highlight != null)
      {
        Dictionary<string, object> source = this.Highlight.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["highlight"] = (object) source;
      }
      if (this.HoleSize.HasValue)
        dictionary1["holeSize"] = (object) this.HoleSize;
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
      string lowField = this.LowField;
      if ((lowField != null ? (lowField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["lowField"] = (object) this.LowField;
      if (this.Margin.HasValue)
        dictionary1["margin"] = (object) this.Margin;
      if (this.Markers != null)
      {
        Dictionary<string, object> source = this.Markers.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["markers"] = (object) source;
      }
      if (this.Outliers != null)
      {
        Dictionary<string, object> source = this.Outliers.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["outliers"] = (object) source;
      }
      if (this.Extremes != null)
      {
        Dictionary<string, object> source = this.Extremes.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["extremes"] = (object) source;
      }
      if (this.MaxSize.HasValue)
        dictionary1["maxSize"] = (object) this.MaxSize;
      if (this.MinSize.HasValue)
        dictionary1["minSize"] = (object) this.MinSize;
      string name = this.Name;
      if ((name != null ? (name.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["name"] = (object) this.Name;
      string negativeColor = this.NegativeColor;
      if ((negativeColor != null ? (negativeColor.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["negativeColor"] = (object) this.NegativeColor;
      if (this.NegativeValues != null)
      {
        Dictionary<string, object> source = this.NegativeValues.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["negativeValues"] = (object) source;
      }
      if (this.Opacity.HasValue)
        dictionary1["opacity"] = (object) this.Opacity;
      string openField = this.OpenField;
      if ((openField != null ? (openField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["openField"] = (object) this.OpenField;
      if (this.Overlay != null)
      {
        Dictionary<string, object> source = this.Overlay.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["overlay"] = (object) source;
      }
      if (this.Padding.HasValue)
        dictionary1["padding"] = (object) this.Padding;
      if (this.Size.HasValue)
        dictionary1["size"] = (object) this.Size;
      string sizeField = this.SizeField;
      if ((sizeField != null ? (sizeField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["sizeField"] = (object) this.SizeField;
      if (this.Spacing.HasValue)
        dictionary1["spacing"] = (object) this.Spacing;
      bool? nullable;
      if (this.Stack != null)
      {
        Dictionary<string, object> source = this.Stack.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
        {
          nullable = this.Stack.Enabled;
          if (nullable.HasValue)
          {
            nullable = this.Stack.Enabled;
            if (!nullable.Value)
              goto label_146;
          }
          dictionary1["stack"] = (object) source;
          goto label_149;
        }
label_146:
        nullable = this.Stack.Enabled;
        if (nullable.HasValue)
        {
          nullable = this.Stack.Enabled;
          if (nullable.Value)
            dictionary1["stack"] = (object) this.Stack.Enabled;
        }
      }
label_149:
      if (this.StartAngle.HasValue)
        dictionary1["startAngle"] = (object) this.StartAngle;
      string targetField = this.TargetField;
      if ((targetField != null ? (targetField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["targetField"] = (object) this.TargetField;
      if (this.Target != null)
      {
        Dictionary<string, object> source = this.Target.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["target"] = (object) source;
      }
      if (this.Tooltip != null)
      {
        Dictionary<string, object> source = this.Tooltip.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["tooltip"] = (object) source;
      }
      nullable = this.Visible;
      if (nullable.HasValue)
        dictionary1["visible"] = (object) this.Visible;
      nullable = this.VisibleInLegend;
      if (nullable.HasValue)
        dictionary1["visibleInLegend"] = (object) this.VisibleInLegend;
      string visibleInLegendField = this.VisibleInLegendField;
      if ((visibleInLegendField != null ? (visibleInLegendField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["visibleInLegendField"] = (object) this.VisibleInLegendField;
      if (this.Whiskers != null)
      {
        Dictionary<string, object> source = this.Whiskers.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["whiskers"] = (object) source;
      }
      if (this.Width.HasValue)
        dictionary1["width"] = (object) this.Width;
      string xaxis = this.XAxis;
      if ((xaxis != null ? (xaxis.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["xAxis"] = (object) this.XAxis;
      string xfield = this.XField;
      if ((xfield != null ? (xfield.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["xField"] = (object) this.XField;
      string yaxis = this.YAxis;
      if ((yaxis != null ? (yaxis.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["yAxis"] = (object) this.YAxis;
      string yfield = this.YField;
      if ((yfield != null ? (yfield.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["yField"] = (object) this.YField;
      if (this.Notes != null)
      {
        Dictionary<string, object> source = this.Notes.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["notes"] = (object) source;
      }
      if (this.ZIndex.HasValue)
        dictionary1["zIndex"] = (object) this.ZIndex;
      string aggregateHandler = this.AggregateHandler;
      if ((aggregateHandler != null ? (aggregateHandler.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["aggregate"] = (object) this.CreateHandler(this.AggregateHandler);
      else if (this.Aggregate.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        ChartSeriesAggregate? aggregate = this.Aggregate;
        ref ChartSeriesAggregate? local = ref aggregate;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["aggregate"] = (object) str;
      }
      if (this.MissingValues.HasValue)
      {
        Dictionary<string, object> dictionary4 = dictionary1;
        ChartSeriesMissingValues? missingValues = this.MissingValues;
        ref ChartSeriesMissingValues? local = ref missingValues;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary4["missingValues"] = (object) str;
      }
      if (this.Style.HasValue)
      {
        Dictionary<string, object> dictionary5 = dictionary1;
        ChartSeriesStyle? style = this.Style;
        ref ChartSeriesStyle? local = ref style;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary5["style"] = (object) str;
      }
      if (this.Type.HasValue)
      {
        Dictionary<string, object> dictionary6 = dictionary1;
        ChartSeriesType? type = this.Type;
        ref ChartSeriesType? local = ref type;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary6["type"] = (object) str;
      }
      return dictionary1;
    }
  }
}
