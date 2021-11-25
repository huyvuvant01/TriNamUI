// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.MapLayerDefaultsSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class MapLayerDefaultsSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public MapLayerDefaultsMarkerSettings Marker { get; } = new MapLayerDefaultsMarkerSettings();

    public MapLayerDefaultsShapeSettings Shape { get; } = new MapLayerDefaultsShapeSettings();

    public MapLayerDefaultsBubbleSettings Bubble { get; } = new MapLayerDefaultsBubbleSettings();

    public double? TileSize { get; set; }

    public MapLayerDefaultsTileSettings Tile { get; } = new MapLayerDefaultsTileSettings();

    public MapLayerDefaultsBingSettings Bing { get; } = new MapLayerDefaultsBingSettings();

    public Map Map { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      Dictionary<string, object> source1 = this.Marker.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["marker"] = (object) source1;
      Dictionary<string, object> source2 = this.Shape.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["shape"] = (object) source2;
      Dictionary<string, object> source3 = this.Bubble.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary["bubble"] = (object) source3;
      if (this.TileSize.HasValue)
        dictionary["tileSize"] = (object) this.TileSize;
      Dictionary<string, object> source4 = this.Tile.Serialize();
      if (source4.Any<KeyValuePair<string, object>>())
        dictionary["tile"] = (object) source4;
      Dictionary<string, object> source5 = this.Bing.Serialize();
      if (source5.Any<KeyValuePair<string, object>>())
        dictionary["bing"] = (object) source5;
      return dictionary;
    }
  }
}
