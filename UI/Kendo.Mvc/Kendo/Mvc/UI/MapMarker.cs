// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.MapMarker
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class MapMarker : MapBaseLayerSettings, IMapMarkersShapeSettings
  {
    public IDictionary<string, object> HtmlAttributes { get; private set; } = (IDictionary<string, object>) new Dictionary<string, object>();

    public string ShapeName { get; set; }

    protected override ViewContext ViewContext => this.Map?.ViewContext;

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> settings = this.SerializeSettings();
      if (this.HtmlAttributes.Any<KeyValuePair<string, object>>())
        settings["attributes"] = (object) this.HtmlAttributes;
      this.SerializeTooltip((IDictionary<string, object>) settings);
      this.SerializeShape(settings);
      return settings;
    }

    public double[] Location { get; set; }

    public string Title { get; set; }

    public MapMarkersShape? Shape { get; set; }

    public Map Map { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      double[] location = this.Location;
      if ((location != null ? (((IEnumerable<double>) location).Any<double>() ? 1 : 0) : 0) != 0)
        dictionary["location"] = (object) this.Location;
      string title = this.Title;
      if ((title != null ? (title.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["title"] = (object) this.Title;
      return dictionary;
    }
  }
}
