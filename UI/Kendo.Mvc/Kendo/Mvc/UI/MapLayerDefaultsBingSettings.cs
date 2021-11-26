// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.MapLayerDefaultsBingSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class MapLayerDefaultsBingSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Attribution { get; set; }

    public double? Opacity { get; set; }

    public string Key { get; set; }

    public string Culture { get; set; }

    public MapLayersImagerySet? ImagerySet { get; set; }

    public Map Map { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      string attribution = this.Attribution;
      if ((attribution != null ? (attribution.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["attribution"] = (object) this.Attribution;
      if (this.Opacity.HasValue)
        dictionary1["opacity"] = (object) this.Opacity;
      string key = this.Key;
      if ((key != null ? (key.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["key"] = (object) this.Key;
      string culture = this.Culture;
      if ((culture != null ? (culture.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["culture"] = (object) this.Culture;
      MapLayersImagerySet? imagerySet = this.ImagerySet;
      if (imagerySet.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        imagerySet = this.ImagerySet;
        ref MapLayersImagerySet? local = ref imagerySet;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["imagerySet"] = (object) str;
      }
      return dictionary1;
    }
  }
}
