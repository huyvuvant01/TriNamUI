// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartMarkerShapeExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI
{
  internal static class ChartMarkerShapeExtensions
  {
    internal static string Serialize(this ChartMarkerShape value)
    {
      switch (value)
      {
        case ChartMarkerShape.Circle:
          return "circle";
        case ChartMarkerShape.Cross:
          return "cross";
        case ChartMarkerShape.Square:
          return "square";
        case ChartMarkerShape.Triangle:
          return "triangle";
        case ChartMarkerShape.Rect:
          return "rect";
        case ChartMarkerShape.RoundedRect:
          return "roundedRect";
        default:
          return value.ToString();
      }
    }
  }
}
