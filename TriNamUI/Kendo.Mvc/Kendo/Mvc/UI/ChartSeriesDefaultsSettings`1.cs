// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartSeriesDefaultsSettings`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ChartSeriesDefaultsSettings<T> where T : class
  {
    public ChartSeries<T> Area { get; } = new ChartSeries<T>();

    public ChartSeries<T> Bar { get; } = new ChartSeries<T>();

    public ChartSeries<T> BoxPlot { get; } = new ChartSeries<T>();

    public ChartSeries<T> Bubble { get; } = new ChartSeries<T>();

    public ChartSeries<T> Bullet { get; } = new ChartSeries<T>();

    public ChartSeries<T> Candlestick { get; } = new ChartSeries<T>();

    public ChartSeries<T> Column { get; } = new ChartSeries<T>();

    public ChartSeries<T> Donut { get; } = new ChartSeries<T>();

    public ChartSeries<T> Funnel { get; } = new ChartSeries<T>();

    public ChartSeries<T> HorizontalWaterfall { get; } = new ChartSeries<T>();

    public ChartSeries<T> Line { get; } = new ChartSeries<T>();

    public ChartSeries<T> OHLC { get; } = new ChartSeries<T>();

    public ChartSeries<T> Pie { get; } = new ChartSeries<T>();

    public ChartSeries<T> PolarArea { get; } = new ChartSeries<T>();

    public ChartSeries<T> PolarLine { get; } = new ChartSeries<T>();

    public ChartSeries<T> PolarScatter { get; } = new ChartSeries<T>();

    public ChartSeries<T> RadarArea { get; } = new ChartSeries<T>();

    public ChartSeries<T> RadarColumn { get; } = new ChartSeries<T>();

    public ChartSeries<T> RadarLine { get; } = new ChartSeries<T>();

    public ChartSeries<T> RangeArea { get; } = new ChartSeries<T>();

    public ChartSeries<T> RangeBar { get; } = new ChartSeries<T>();

    public ChartSeries<T> RangeColumn { get; } = new ChartSeries<T>();

    public ChartSeries<T> Scatter { get; } = new ChartSeries<T>();

    public ChartSeries<T> ScatterLine { get; } = new ChartSeries<T>();

    public ChartSeries<T> VerticalArea { get; } = new ChartSeries<T>();

    public ChartSeries<T> VerticalBoxPlot { get; } = new ChartSeries<T>();

    public ChartSeries<T> VerticalBullet { get; } = new ChartSeries<T>();

    public ChartSeries<T> VerticalLine { get; } = new ChartSeries<T>();

    public ChartSeries<T> VerticalRangeArea { get; } = new ChartSeries<T>();

    public ChartSeries<T> Waterfall { get; } = new ChartSeries<T>();

    public ChartSeries<T> HeatMap { get; } = new ChartSeries<T>();

    public IDictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      Dictionary<string, object> source1 = this.Area.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["area"] = (object) source1;
      Dictionary<string, object> source2 = this.Bar.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["bar"] = (object) source2;
      Dictionary<string, object> source3 = this.BoxPlot.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["boxPlot"] = (object) source3;
      Dictionary<string, object> source4 = this.Bubble.Serialize();
      if (source4.Any<KeyValuePair<string, object>>())
        dictionary["bubble"] = (object) source4;
      Dictionary<string, object> source5 = this.Bullet.Serialize();
      if (source5.Any<KeyValuePair<string, object>>())
        dictionary["bullet"] = (object) source5;
      Dictionary<string, object> source6 = this.Candlestick.Serialize();
      if (source6.Any<KeyValuePair<string, object>>())
        dictionary["candlestick"] = (object) source6;
      Dictionary<string, object> source7 = this.Column.Serialize();
      if (source7.Any<KeyValuePair<string, object>>())
        dictionary["column"] = (object) source7;
      Dictionary<string, object> source8 = this.Donut.Serialize();
      if (source8.Any<KeyValuePair<string, object>>())
        dictionary["donut"] = (object) source8;
      Dictionary<string, object> source9 = this.Funnel.Serialize();
      if (source9.Any<KeyValuePair<string, object>>())
        dictionary["funnel"] = (object) source9;
      Dictionary<string, object> source10 = this.HorizontalWaterfall.Serialize();
      if (source10.Any<KeyValuePair<string, object>>())
        dictionary["horizontalWaterfall"] = (object) source10;
      Dictionary<string, object> source11 = this.Line.Serialize();
      if (source11.Any<KeyValuePair<string, object>>())
        dictionary["line"] = (object) source11;
      Dictionary<string, object> source12 = this.OHLC.Serialize();
      if (source12.Any<KeyValuePair<string, object>>())
        dictionary["ohlc"] = (object) source12;
      Dictionary<string, object> source13 = this.Pie.Serialize();
      if (source13.Any<KeyValuePair<string, object>>())
        dictionary["pie"] = (object) source13;
      Dictionary<string, object> source14 = this.PolarArea.Serialize();
      if (source14.Any<KeyValuePair<string, object>>())
        dictionary["polarArea"] = (object) source14;
      Dictionary<string, object> source15 = this.PolarLine.Serialize();
      if (source15.Any<KeyValuePair<string, object>>())
        dictionary["polarLine"] = (object) source15;
      Dictionary<string, object> source16 = this.PolarScatter.Serialize();
      if (source16.Any<KeyValuePair<string, object>>())
        dictionary["polarScatter"] = (object) source16;
      Dictionary<string, object> source17 = this.RadarArea.Serialize();
      if (source17.Any<KeyValuePair<string, object>>())
        dictionary["radarArea"] = (object) source17;
      Dictionary<string, object> source18 = this.RadarColumn.Serialize();
      if (source18.Any<KeyValuePair<string, object>>())
        dictionary["radarColumn"] = (object) source18;
      Dictionary<string, object> source19 = this.RadarLine.Serialize();
      if (source19.Any<KeyValuePair<string, object>>())
        dictionary["radarLine"] = (object) source19;
      Dictionary<string, object> source20 = this.RangeArea.Serialize();
      if (source20.Any<KeyValuePair<string, object>>())
        dictionary["rangeArea"] = (object) source20;
      Dictionary<string, object> source21 = this.RangeBar.Serialize();
      if (source21.Any<KeyValuePair<string, object>>())
        dictionary["rangeBar"] = (object) source21;
      Dictionary<string, object> source22 = this.RangeColumn.Serialize();
      if (source22.Any<KeyValuePair<string, object>>())
        dictionary["rangeColumn"] = (object) source22;
      Dictionary<string, object> source23 = this.Scatter.Serialize();
      if (source23.Any<KeyValuePair<string, object>>())
        dictionary["scatter"] = (object) source23;
      Dictionary<string, object> source24 = this.ScatterLine.Serialize();
      if (source24.Any<KeyValuePair<string, object>>())
        dictionary["scatterLine"] = (object) source24;
      Dictionary<string, object> source25 = this.VerticalArea.Serialize();
      if (source25.Any<KeyValuePair<string, object>>())
        dictionary["verticalArea"] = (object) source25;
      Dictionary<string, object> source26 = this.VerticalBoxPlot.Serialize();
      if (source26.Any<KeyValuePair<string, object>>())
        dictionary["verticalBoxPlot"] = (object) source26;
      Dictionary<string, object> source27 = this.VerticalBullet.Serialize();
      if (source27.Any<KeyValuePair<string, object>>())
        dictionary["verticalBullet"] = (object) source27;
      Dictionary<string, object> source28 = this.VerticalLine.Serialize();
      if (source28.Any<KeyValuePair<string, object>>())
        dictionary["verticalLine"] = (object) source28;
      Dictionary<string, object> source29 = this.VerticalRangeArea.Serialize();
      if (source29.Any<KeyValuePair<string, object>>())
        dictionary["verticalRangeArea"] = (object) source29;
      Dictionary<string, object> source30 = this.Waterfall.Serialize();
      if (source30.Any<KeyValuePair<string, object>>())
        dictionary["waterfall"] = (object) source30;
      Dictionary<string, object> source31 = this.HeatMap.Serialize();
      if (source31.Any<KeyValuePair<string, object>>())
        dictionary["heatMap"] = (object) source31;
      return (IDictionary<string, object>) dictionary;
    }
  }
}
