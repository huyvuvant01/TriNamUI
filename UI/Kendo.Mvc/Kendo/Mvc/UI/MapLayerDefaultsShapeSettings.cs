// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.MapLayerDefaultsShapeSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class MapLayerDefaultsShapeSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Attribution { get; set; }

    public double? Opacity { get; set; }

    public MapLayerDefaultsShapeStyleSettings Style { get; } = new MapLayerDefaultsShapeStyleSettings();

    public Map Map { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string attribution = this.Attribution;
      if ((attribution != null ? (attribution.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["attribution"] = (object) this.Attribution;
      if (this.Opacity.HasValue)
        dictionary["opacity"] = (object) this.Opacity;
      Dictionary<string, object> source = this.Style.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["style"] = (object) source;
      return dictionary;
    }
  }
}
