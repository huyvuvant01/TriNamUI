// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartSeries`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ChartSeries<T> where T : class
  {
    public ChartSeriesAggregateSettings<T> Aggregates { get; } = new ChartSeriesAggregateSettings<T>();

    [Obsolete("This property is obsolete. Please use the CloseField property instead.")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string CloseMember
    {
      get => this.CloseField;
      set => this.CloseField = value;
    }

    public IEnumerable Data { get; set; }

    [Obsolete("This property is obsolete. Please use the HighField property instead.")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string HighMember
    {
      get => this.HighField;
      set => this.HighField = value;
    }

    [Obsolete("This property is obsolete. Please use the LowField property instead.")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string LowMember
    {
      get => this.LowField;
      set => this.LowField = value;
    }

    [Obsolete("This property is obsolete. Please use the OpenField property instead.")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public string OpenMember
    {
      get => this.OpenField;
      set => this.OpenField = value;
    }

    public string Type { get; set; }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      Dictionary<string, object> source = this.Aggregates.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["aggregate"] = (object) source;
      if (this.Data != null)
        dictionary["data"] = (object) this.Data;
      string type = this.Type;
      if ((type != null ? (type.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["type"] = (object) this.Type;
      return dictionary;
    }

    public bool? AutoFit { get; set; }

    public string Axis { get; set; }

    public ChartSeriesBorderSettings<T> Border { get; } = new ChartSeriesBorderSettings<T>();

    public string CategoryAxis { get; set; }

    public string CategoryField { get; set; }

    public string CloseField { get; set; }

    public string Color { get; set; }

    public ClientHandlerDescriptor ColorHandler { get; set; }

    public string ColorField { get; set; }

    public ChartSeriesConnectorsSettings<T> Connectors { get; } = new ChartSeriesConnectorsSettings<T>();

    public string CurrentField { get; set; }

    public ChartDashType? DashType { get; set; }

    public string DownColor { get; set; }

    public ClientHandlerDescriptor DownColorHandler { get; set; }

    public string DownColorField { get; set; }

    public double? SegmentSpacing { get; set; }

    public string SummaryField { get; set; }

    public double? NeckRatio { get; set; }

    public bool? DynamicSlope { get; set; }

    public bool? DynamicHeight { get; set; }

    public ChartSeriesErrorBarsSettings<T> ErrorBars { get; } = new ChartSeriesErrorBarsSettings<T>();

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

    public ChartSeriesMedianSettings<T> Median { get; } = new ChartSeriesMedianSettings<T>();

    public string MedianField { get; set; }

    public string Q3Field { get; set; }

    public string UpperField { get; set; }

    public ChartSeriesMeanSettings<T> Mean { get; } = new ChartSeriesMeanSettings<T>();

    public string MeanField { get; set; }

    public string OutliersField { get; set; }

    public double? Gap { get; set; }

    public string HighField { get; set; }

    public ChartSeriesHighlightSettings<T> Highlight { get; } = new ChartSeriesHighlightSettings<T>();

    public double? HoleSize { get; set; }

    public ChartSeriesLabelsSettings<T> Labels { get; } = new ChartSeriesLabelsSettings<T>();

    public ChartSeriesLineSettings<T> Line { get; } = new ChartSeriesLineSettings<T>();

    public string LowField { get; set; }

    public double? Margin { get; set; }

    public ChartSeriesMarkersSettings<T> Markers { get; } = new ChartSeriesMarkersSettings<T>();

    public ChartSeriesOutliersSettings<T> Outliers { get; } = new ChartSeriesOutliersSettings<T>();

    public ChartSeriesExtremesSettings<T> Extremes { get; } = new ChartSeriesExtremesSettings<T>();

    public double? MaxSize { get; set; }

    public double? MinSize { get; set; }

    public string Name { get; set; }

    public string NegativeColor { get; set; }

    public ChartSeriesNegativeValuesSettings<T> NegativeValues { get; } = new ChartSeriesNegativeValuesSettings<T>();

    public double? Opacity { get; set; }

    public string OpenField { get; set; }

    public ChartSeriesOverlaySettings<T> Overlay { get; } = new ChartSeriesOverlaySettings<T>();

    public double? Padding { get; set; }

    public double? Size { get; set; }

    public string SizeField { get; set; }

    public double? Spacing { get; set; }

    public ChartSeriesStackSettings<T> Stack { get; } = new ChartSeriesStackSettings<T>();

    public double? StartAngle { get; set; }

    public string TargetField { get; set; }

    public ChartSeriesTargetSettings<T> Target { get; } = new ChartSeriesTargetSettings<T>();

    public ChartSeriesTooltipSettings<T> Tooltip { get; } = new ChartSeriesTooltipSettings<T>();

    public bool? Visible { get; set; }

    public bool? VisibleInLegend { get; set; }

    public string VisibleInLegendField { get; set; }

    public ClientHandlerDescriptor Visual { get; set; }

    public ChartSeriesWhiskersSettings<T> Whiskers { get; } = new ChartSeriesWhiskersSettings<T>();

    public double? Width { get; set; }

    public string XAxis { get; set; }

    public string XField { get; set; }

    public string YAxis { get; set; }

    public string YField { get; set; }

    public ChartSeriesNotesSettings<T> Notes { get; } = new ChartSeriesNotesSettings<T>();

    public double? ZIndex { get; set; }

    public ChartSeriesAggregate? Aggregate { get; set; }

    public ClientHandlerDescriptor AggregateHandler { get; set; }

    public ChartSeriesMissingValues? MissingValues { get; set; }

    public ChartSeriesStyle? Style { get; set; }

    public Kendo.Mvc.UI.Chart<T> Chart { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      if (this.AutoFit.HasValue)
        dictionary1["autoFit"] = (object) this.AutoFit;
      string axis = this.Axis;
      if ((axis != null ? (axis.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["axis"] = (object) this.Axis;
      Dictionary<string, object> source1 = this.Border.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary1["border"] = (object) source1;
      string categoryAxis = this.CategoryAxis;
      if ((categoryAxis != null ? (categoryAxis.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["categoryAxis"] = (object) this.CategoryAxis;
      string categoryField = this.CategoryField;
      if ((categoryField != null ? (categoryField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["categoryField"] = (object) this.CategoryField;
      string closeField = this.CloseField;
      if ((closeField != null ? (closeField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["closeField"] = (object) this.CloseField;
      ClientHandlerDescriptor colorHandler = this.ColorHandler;
      if ((colorHandler != null ? (colorHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["color"] = (object) this.ColorHandler;
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
      Dictionary<string, object> source2 = this.Connectors.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary1["connectors"] = (object) source2;
      string currentField = this.CurrentField;
      if ((currentField != null ? (currentField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["currentField"] = (object) this.CurrentField;
      if (this.DashType.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        ChartDashType? dashType = this.DashType;
        ref ChartDashType? local = ref dashType;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["dashType"] = (object) str;
      }
      ClientHandlerDescriptor downColorHandler = this.DownColorHandler;
      if ((downColorHandler != null ? (downColorHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["downColor"] = (object) this.DownColorHandler;
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
      Dictionary<string, object> source3 = this.ErrorBars.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary1["errorBars"] = (object) source3;
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
      Dictionary<string, object> source4 = this.Median.Serialize();
      if (source4.Any<KeyValuePair<string, object>>())
        dictionary1["median"] = (object) source4;
      string medianField = this.MedianField;
      if ((medianField != null ? (medianField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["medianField"] = (object) this.MedianField;
      string q3Field = this.Q3Field;
      if ((q3Field != null ? (q3Field.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["q3Field"] = (object) this.Q3Field;
      string upperField = this.UpperField;
      if ((upperField != null ? (upperField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["upperField"] = (object) this.UpperField;
      Dictionary<string, object> source5 = this.Mean.Serialize();
      if (source5.Any<KeyValuePair<string, object>>())
        dictionary1["mean"] = (object) source5;
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
      Dictionary<string, object> source6 = this.Highlight.Serialize();
      if (source6.Any<KeyValuePair<string, object>>())
        dictionary1["highlight"] = (object) source6;
      if (this.HoleSize.HasValue)
        dictionary1["holeSize"] = (object) this.HoleSize;
      Dictionary<string, object> source7 = this.Labels.Serialize();
      if (source7.Any<KeyValuePair<string, object>>())
        dictionary1["labels"] = (object) source7;
      Dictionary<string, object> source8 = this.Line.Serialize();
      if (source8.Any<KeyValuePair<string, object>>())
        dictionary1["line"] = (object) source8;
      string lowField = this.LowField;
      if ((lowField != null ? (lowField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["lowField"] = (object) this.LowField;
      if (this.Margin.HasValue)
        dictionary1["margin"] = (object) this.Margin;
      Dictionary<string, object> source9 = this.Markers.Serialize();
      if (source9.Any<KeyValuePair<string, object>>())
        dictionary1["markers"] = (object) source9;
      Dictionary<string, object> source10 = this.Outliers.Serialize();
      if (source10.Any<KeyValuePair<string, object>>())
        dictionary1["outliers"] = (object) source10;
      Dictionary<string, object> source11 = this.Extremes.Serialize();
      if (source11.Any<KeyValuePair<string, object>>())
        dictionary1["extremes"] = (object) source11;
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
      Dictionary<string, object> source12 = this.NegativeValues.Serialize();
      if (source12.Any<KeyValuePair<string, object>>())
        dictionary1["negativeValues"] = (object) source12;
      if (this.Opacity.HasValue)
        dictionary1["opacity"] = (object) this.Opacity;
      string openField = this.OpenField;
      if ((openField != null ? (openField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["openField"] = (object) this.OpenField;
      Dictionary<string, object> source13 = this.Overlay.Serialize();
      if (source13.Any<KeyValuePair<string, object>>())
        dictionary1["overlay"] = (object) source13;
      if (this.Padding.HasValue)
        dictionary1["padding"] = (object) this.Padding;
      if (this.Size.HasValue)
        dictionary1["size"] = (object) this.Size;
      string sizeField = this.SizeField;
      if ((sizeField != null ? (sizeField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["sizeField"] = (object) this.SizeField;
      if (this.Spacing.HasValue)
        dictionary1["spacing"] = (object) this.Spacing;
      Dictionary<string, object> source14 = this.Stack.Serialize();
      bool? nullable;
      if (source14.Any<KeyValuePair<string, object>>())
      {
        dictionary1["stack"] = (object) source14;
      }
      else
      {
        nullable = this.Stack.Enabled;
        if (nullable.HasValue)
          dictionary1["stack"] = (object) this.Stack.Enabled;
      }
      if (this.StartAngle.HasValue)
        dictionary1["startAngle"] = (object) this.StartAngle;
      string targetField = this.TargetField;
      if ((targetField != null ? (targetField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["targetField"] = (object) this.TargetField;
      Dictionary<string, object> source15 = this.Target.Serialize();
      if (source15.Any<KeyValuePair<string, object>>())
        dictionary1["target"] = (object) source15;
      Dictionary<string, object> source16 = this.Tooltip.Serialize();
      if (source16.Any<KeyValuePair<string, object>>())
        dictionary1["tooltip"] = (object) source16;
      nullable = this.Visible;
      if (nullable.HasValue)
        dictionary1["visible"] = (object) this.Visible;
      nullable = this.VisibleInLegend;
      if (nullable.HasValue)
        dictionary1["visibleInLegend"] = (object) this.VisibleInLegend;
      string visibleInLegendField = this.VisibleInLegendField;
      if ((visibleInLegendField != null ? (visibleInLegendField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["visibleInLegendField"] = (object) this.VisibleInLegendField;
      ClientHandlerDescriptor visual = this.Visual;
      if ((visual != null ? (visual.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["visual"] = (object) this.Visual;
      Dictionary<string, object> source17 = this.Whiskers.Serialize();
      if (source17.Any<KeyValuePair<string, object>>())
        dictionary1["whiskers"] = (object) source17;
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
      Dictionary<string, object> source18 = this.Notes.Serialize();
      if (source18.Any<KeyValuePair<string, object>>())
        dictionary1["notes"] = (object) source18;
      if (this.ZIndex.HasValue)
        dictionary1["zIndex"] = (object) this.ZIndex;
      ClientHandlerDescriptor aggregateHandler = this.AggregateHandler;
      if ((aggregateHandler != null ? (aggregateHandler.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["aggregate"] = (object) this.AggregateHandler;
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
      return dictionary1;
    }
  }
}
