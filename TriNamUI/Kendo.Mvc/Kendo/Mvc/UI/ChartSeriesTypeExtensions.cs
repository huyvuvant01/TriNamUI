// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartSeriesTypeExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI
{
  internal static class ChartSeriesTypeExtensions
  {
    internal static string Serialize(this ChartSeriesType value)
    {
      switch (value)
      {
        case ChartSeriesType.Area:
          return "area";
        case ChartSeriesType.Bar:
          return "bar";
        case ChartSeriesType.Bubble:
          return "bubble";
        case ChartSeriesType.Bullet:
          return "bullet";
        case ChartSeriesType.Candlestick:
          return "candlestick";
        case ChartSeriesType.Column:
          return "column";
        case ChartSeriesType.Donut:
          return "donut";
        case ChartSeriesType.Funnel:
          return "funnel";
        case ChartSeriesType.HorizontalWaterfall:
          return "horizontalWaterfall";
        case ChartSeriesType.Line:
          return "line";
        case ChartSeriesType.OHLC:
          return "ohlc";
        case ChartSeriesType.Pie:
          return "pie";
        case ChartSeriesType.PolarArea:
          return "polarArea";
        case ChartSeriesType.PolarLine:
          return "polarLine";
        case ChartSeriesType.PolarScatter:
          return "polarScatter";
        case ChartSeriesType.RadarArea:
          return "radarArea";
        case ChartSeriesType.RadarColumn:
          return "radarColumn";
        case ChartSeriesType.RadarLine:
          return "radarLine";
        case ChartSeriesType.RangeArea:
          return "rangeArea";
        case ChartSeriesType.RangeBar:
          return "rangeBar";
        case ChartSeriesType.RangeColumn:
          return "rangeColumn";
        case ChartSeriesType.Scatter:
          return "scatter";
        case ChartSeriesType.ScatterLine:
          return "scatterLine";
        case ChartSeriesType.VerticalArea:
          return "verticalArea";
        case ChartSeriesType.VerticalBoxPlot:
          return "verticalBoxPlot";
        case ChartSeriesType.VerticalBullet:
          return "verticalBullet";
        case ChartSeriesType.VerticalLine:
          return "verticalLine";
        case ChartSeriesType.VerticalRangeArea:
          return "verticalRangeArea";
        case ChartSeriesType.Waterfall:
          return "waterfall";
        case ChartSeriesType.HeatMap:
          return "heatmap";
        default:
          return value.ToString();
      }
    }
  }
}
