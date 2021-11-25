// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartLegendPositionExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI
{
  internal static class ChartLegendPositionExtensions
  {
    internal static string Serialize(this ChartLegendPosition value)
    {
      switch (value)
      {
        case ChartLegendPosition.Top:
          return "top";
        case ChartLegendPosition.Bottom:
          return "bottom";
        case ChartLegendPosition.Left:
          return "left";
        case ChartLegendPosition.Right:
          return "right";
        case ChartLegendPosition.Custom:
          return "custom";
        default:
          return value.ToString();
      }
    }
  }
}
