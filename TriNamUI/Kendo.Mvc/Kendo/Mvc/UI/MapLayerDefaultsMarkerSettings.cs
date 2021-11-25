// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.MapLayerDefaultsMarkerSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class MapLayerDefaultsMarkerSettings : MapBaseLayerSettings, IMapMarkersShapeSettings
  {
    public string ShapeName { get; set; }

    protected override ViewContext ViewContext => this.Map?.ViewContext;

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> settings = this.SerializeSettings();
      this.SerializeTooltip((IDictionary<string, object>) settings);
      this.SerializeShape(settings);
      return settings;
    }

    public double? Opacity { get; set; }

    public MapMarkersShape? Shape { get; set; }

    public Map Map { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Opacity.HasValue)
        dictionary["opacity"] = (object) this.Opacity;
      return dictionary;
    }
  }
}
