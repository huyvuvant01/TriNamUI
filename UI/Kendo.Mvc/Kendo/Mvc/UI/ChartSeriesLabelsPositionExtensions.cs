// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartSeriesLabelsPositionExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI
{
  internal static class ChartSeriesLabelsPositionExtensions
  {
    internal static string Serialize(this ChartSeriesLabelsPosition value)
    {
      switch (value)
      {
        case ChartSeriesLabelsPosition.Above:
          return "above";
        case ChartSeriesLabelsPosition.Below:
          return "below";
        case ChartSeriesLabelsPosition.Bottom:
          return "bottom";
        case ChartSeriesLabelsPosition.Center:
          return "center";
        case ChartSeriesLabelsPosition.InsideBase:
          return "insideBase";
        case ChartSeriesLabelsPosition.InsideEnd:
          return "insideEnd";
        case ChartSeriesLabelsPosition.Left:
          return "left";
        case ChartSeriesLabelsPosition.OutsideEnd:
          return "outsideEnd";
        case ChartSeriesLabelsPosition.Right:
          return "right";
        case ChartSeriesLabelsPosition.Top:
          return "top";
        default:
          return value.ToString();
      }
    }
  }
}
