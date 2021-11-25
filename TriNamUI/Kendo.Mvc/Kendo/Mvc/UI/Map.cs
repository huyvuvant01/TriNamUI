// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Map
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class Map : WidgetBase
  {
    public Map(ViewContext viewContext)
      : base(viewContext)
    {
    }

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (Map), (IDictionary<string, object>) dictionary));
    }

    public double[] Center { get; set; }

    public MapControlsSettings Controls { get; } = new MapControlsSettings();

    public MapLayerDefaultsSettings LayerDefaults { get; } = new MapLayerDefaultsSettings();

    public List<MapLayer> Layers { get; set; } = new List<MapLayer>();

    public MapMarkerDefaultsSettings MarkerDefaults { get; } = new MapMarkerDefaultsSettings();

    public List<MapMarker> Markers { get; set; } = new List<MapMarker>();

    public double? MinZoom { get; set; }

    public double? MaxZoom { get; set; }

    public double? MinSize { get; set; }

    public bool? Pannable { get; set; }

    public bool? Wraparound { get; set; }

    public double? Zoom { get; set; }

    public bool? Zoomable { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      double[] center = this.Center;
      if ((center != null ? (((IEnumerable<double>) center).Any<double>() ? 1 : 0) : 0) != 0)
        dictionary["center"] = (object) this.Center;
      Dictionary<string, object> source1 = this.Controls.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary["controls"] = (object) source1;
      Dictionary<string, object> source2 = this.LayerDefaults.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary["layerDefaults"] = (object) source2;
      IEnumerable<Dictionary<string, object>> source3 = this.Layers.Select<MapLayer, Dictionary<string, object>>((Func<MapLayer, Dictionary<string, object>>) (i => i.Serialize()));
      if (source3.Any<Dictionary<string, object>>())
        dictionary["layers"] = (object) source3;
      Dictionary<string, object> source4 = this.MarkerDefaults.Serialize();
      if (source4.Any<KeyValuePair<string, object>>())
        dictionary["markerDefaults"] = (object) source4;
      IEnumerable<Dictionary<string, object>> source5 = this.Markers.Select<MapMarker, Dictionary<string, object>>((Func<MapMarker, Dictionary<string, object>>) (i => i.Serialize()));
      if (source5.Any<Dictionary<string, object>>())
        dictionary["markers"] = (object) source5;
      double? nullable1 = this.MinZoom;
      if (nullable1.HasValue)
        dictionary["minZoom"] = (object) this.MinZoom;
      nullable1 = this.MaxZoom;
      if (nullable1.HasValue)
        dictionary["maxZoom"] = (object) this.MaxZoom;
      nullable1 = this.MinSize;
      if (nullable1.HasValue)
        dictionary["minSize"] = (object) this.MinSize;
      bool? nullable2 = this.Pannable;
      if (nullable2.HasValue)
        dictionary["pannable"] = (object) this.Pannable;
      nullable2 = this.Wraparound;
      if (nullable2.HasValue)
        dictionary["wraparound"] = (object) this.Wraparound;
      nullable1 = this.Zoom;
      if (nullable1.HasValue)
        dictionary["zoom"] = (object) this.Zoom;
      nullable2 = this.Zoomable;
      if (nullable2.HasValue)
        dictionary["zoomable"] = (object) this.Zoomable;
      return dictionary;
    }
  }
}
