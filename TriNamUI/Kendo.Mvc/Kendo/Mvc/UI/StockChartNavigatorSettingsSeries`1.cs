// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.StockChartNavigatorSettingsSeries`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class StockChartNavigatorSettingsSeries<T> where T : class
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Type { get; set; }

    public ChartDashType? DashType { get; set; }

    public string HighField { get; set; }

    public string Field { get; set; }

    public string CategoryField { get; set; }

    public string Name { get; set; }

    public StockChartNavigatorSeriesHighlightSettings<T> Highlight { get; } = new StockChartNavigatorSeriesHighlightSettings<T>();

    public string Aggregate { get; set; }

    public ClientHandlerDescriptor AggregateHandler { get; set; }

    public string Axis { get; set; }

    public StockChartNavigatorSeriesBorderSettings<T> Border { get; } = new StockChartNavigatorSeriesBorderSettings<T>();

    public string CloseField { get; set; }

    public string Color { get; set; }

    public string ColorField { get; set; }

    public string DownColor { get; set; }

    public string DownColorField { get; set; }

    public double? Gap { get; set; }

    public StockChartNavigatorSeriesLabelsSettings<T> Labels { get; } = new StockChartNavigatorSeriesLabelsSettings<T>();

    public StockChartNavigatorSeriesLineSettings<T> Line { get; } = new StockChartNavigatorSeriesLineSettings<T>();

    public string LowField { get; set; }

    public StockChartNavigatorSeriesMarkersSettings<T> Markers { get; } = new StockChartNavigatorSeriesMarkersSettings<T>();

    public string MissingValues { get; set; }

    public string Style { get; set; }

    public double? Opacity { get; set; }

    public string OpenField { get; set; }

    public StockChartNavigatorSeriesOverlaySettings<T> Overlay { get; } = new StockChartNavigatorSeriesOverlaySettings<T>();

    public double? Spacing { get; set; }

    public StockChartNavigatorSeriesStackSettings<T> Stack { get; } = new StockChartNavigatorSeriesStackSettings<T>();

    public StockChartNavigatorSeriesTooltipSettings<T> Tooltip { get; } = new StockChartNavigatorSeriesTooltipSettings<T>();

    public double? Width { get; set; }

    public Kendo.Mvc.UI.StockChart<T> StockChart { get; set; }

    protected Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      string type = this.Type;
      if ((type != null ? (type.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["type"] = (object) this.Type;
      ChartDashType? dashType = this.DashType;
      if (dashType.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        dashType = this.DashType;
        ref ChartDashType? local = ref dashType;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["dashType"] = (object) str;
      }
      string highField = this.HighField;
      if ((highField != null ? (highField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["highField"] = (object) this.HighField;
      string field = this.Field;
      if ((field != null ? (field.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["field"] = (object) this.Field;
      string categoryField = this.CategoryField;
      if ((categoryField != null ? (categoryField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["categoryField"] = (object) this.CategoryField;
      string name = this.Name;
      if ((name != null ? (name.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["name"] = (object) this.Name;
      Dictionary<string, object> source1 = this.Highlight.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary1["highlight"] = (object) source1;
      ClientHandlerDescriptor aggregateHandler = this.AggregateHandler;
      if ((aggregateHandler != null ? (aggregateHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["aggregate"] = (object) this.AggregateHandler;
      }
      else
      {
        string aggregate = this.Aggregate;
        if ((aggregate != null ? (aggregate.HasValue() ? 1 : 0) : 0) != 0)
          dictionary1["aggregate"] = (object) this.Aggregate;
      }
      string axis = this.Axis;
      if ((axis != null ? (axis.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["axis"] = (object) this.Axis;
      Dictionary<string, object> source2 = this.Border.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary1["border"] = (object) source2;
      string closeField = this.CloseField;
      if ((closeField != null ? (closeField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["closeField"] = (object) this.CloseField;
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["color"] = (object) this.Color;
      string colorField = this.ColorField;
      if ((colorField != null ? (colorField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["colorField"] = (object) this.ColorField;
      string downColor = this.DownColor;
      if ((downColor != null ? (downColor.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["downColor"] = (object) this.DownColor;
      string downColorField = this.DownColorField;
      if ((downColorField != null ? (downColorField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["downColorField"] = (object) this.DownColorField;
      double? nullable = this.Gap;
      if (nullable.HasValue)
        dictionary1["gap"] = (object) this.Gap;
      Dictionary<string, object> source3 = this.Labels.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary1["labels"] = (object) source3;
      Dictionary<string, object> source4 = this.Line.Serialize();
      if (source4.Any<KeyValuePair<string, object>>())
        dictionary1["line"] = (object) source4;
      string lowField = this.LowField;
      if ((lowField != null ? (lowField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["lowField"] = (object) this.LowField;
      Dictionary<string, object> source5 = this.Markers.Serialize();
      if (source5.Any<KeyValuePair<string, object>>())
        dictionary1["markers"] = (object) source5;
      string missingValues = this.MissingValues;
      if ((missingValues != null ? (missingValues.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["missingValues"] = (object) this.MissingValues;
      string style = this.Style;
      if ((style != null ? (style.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["style"] = (object) this.Style;
      nullable = this.Opacity;
      if (nullable.HasValue)
        dictionary1["opacity"] = (object) this.Opacity;
      string openField = this.OpenField;
      if ((openField != null ? (openField.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["openField"] = (object) this.OpenField;
      Dictionary<string, object> source6 = this.Overlay.Serialize();
      if (source6.Any<KeyValuePair<string, object>>())
        dictionary1["overlay"] = (object) source6;
      nullable = this.Spacing;
      if (nullable.HasValue)
        dictionary1["spacing"] = (object) this.Spacing;
      Dictionary<string, object> source7 = this.Stack.Serialize();
      if (source7.Any<KeyValuePair<string, object>>())
        dictionary1["stack"] = (object) source7;
      else if (this.Stack.Enabled.HasValue)
        dictionary1["stack"] = (object) this.Stack.Enabled;
      Dictionary<string, object> source8 = this.Tooltip.Serialize();
      if (source8.Any<KeyValuePair<string, object>>())
        dictionary1["tooltip"] = (object) source8;
      nullable = this.Width;
      if (nullable.HasValue)
        dictionary1["width"] = (object) this.Width;
      return dictionary1;
    }
  }
}
