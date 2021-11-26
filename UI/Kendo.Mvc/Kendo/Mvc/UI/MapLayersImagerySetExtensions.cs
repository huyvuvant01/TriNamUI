// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.MapLayersImagerySetExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI
{
  internal static class MapLayersImagerySetExtensions
  {
    internal static string Serialize(this MapLayersImagerySet value)
    {
      switch (value)
      {
        case MapLayersImagerySet.Aerial:
          return "aerial";
        case MapLayersImagerySet.AerialWithLabels:
          return "aerialWithLabels";
        case MapLayersImagerySet.Birdseye:
          return "birdseye";
        case MapLayersImagerySet.BirdseyeWithLabels:
          return "birdseyeWithLabels";
        case MapLayersImagerySet.Road:
          return "road";
        default:
          return value.ToString();
      }
    }
  }
}
