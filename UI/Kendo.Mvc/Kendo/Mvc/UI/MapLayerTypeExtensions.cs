// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.MapLayerTypeExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI
{
  internal static class MapLayerTypeExtensions
  {
    internal static string Serialize(this MapLayerType value)
    {
      switch (value)
      {
        case MapLayerType.Bing:
          return "bing";
        case MapLayerType.Tile:
          return "tile";
        case MapLayerType.Shape:
          return "shape";
        case MapLayerType.Marker:
          return "marker";
        case MapLayerType.Bubble:
          return "bubble";
        default:
          return value.ToString();
      }
    }
  }
}
