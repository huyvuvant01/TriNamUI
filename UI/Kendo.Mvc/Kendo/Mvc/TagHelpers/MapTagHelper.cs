// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.MapTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-map")]
  [RestrictChildren("controls", new string[] {"layer-defaults", "layers", "marker-defaults", "markers"})]
  public class MapTagHelper : TagHelperBase
  {
    public MapTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      MapTagHelper mapTagHelper = this;
      context.Items[(object) mapTagHelper.GetType()] = (object) mapTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await mapTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "div";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "Map", (IDictionary<string, object>) this.SerializeSettings());

    public string OnBeforeReset { get; set; }

    public string OnClick { get; set; }

    public string OnMarkerActivate { get; set; }

    public string OnMarkerCreated { get; set; }

    public string OnMarkerClick { get; set; }

    public string OnPan { get; set; }

    public string OnPanEnd { get; set; }

    public string OnReset { get; set; }

    public string OnShapeClick { get; set; }

    public string OnShapeCreated { get; set; }

    public string OnShapeFeatureCreated { get; set; }

    public string OnShapeMouseEnter { get; set; }

    public string OnShapeMouseLeave { get; set; }

    public string OnZoomStart { get; set; }

    public string OnZoomEnd { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onBeforeReset = this.OnBeforeReset;
      if ((onBeforeReset != null ? (onBeforeReset.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["beforeReset"] = (object) this.CreateHandler(this.OnBeforeReset);
      string onClick = this.OnClick;
      if ((onClick != null ? (onClick.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["click"] = (object) this.CreateHandler(this.OnClick);
      string onMarkerActivate = this.OnMarkerActivate;
      if ((onMarkerActivate != null ? (onMarkerActivate.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["markerActivate"] = (object) this.CreateHandler(this.OnMarkerActivate);
      string onMarkerCreated = this.OnMarkerCreated;
      if ((onMarkerCreated != null ? (onMarkerCreated.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["markerCreated"] = (object) this.CreateHandler(this.OnMarkerCreated);
      string onMarkerClick = this.OnMarkerClick;
      if ((onMarkerClick != null ? (onMarkerClick.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["markerClick"] = (object) this.CreateHandler(this.OnMarkerClick);
      string onPan = this.OnPan;
      if ((onPan != null ? (onPan.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["pan"] = (object) this.CreateHandler(this.OnPan);
      string onPanEnd = this.OnPanEnd;
      if ((onPanEnd != null ? (onPanEnd.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["panEnd"] = (object) this.CreateHandler(this.OnPanEnd);
      string onReset = this.OnReset;
      if ((onReset != null ? (onReset.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["reset"] = (object) this.CreateHandler(this.OnReset);
      string onShapeClick = this.OnShapeClick;
      if ((onShapeClick != null ? (onShapeClick.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["shapeClick"] = (object) this.CreateHandler(this.OnShapeClick);
      string onShapeCreated = this.OnShapeCreated;
      if ((onShapeCreated != null ? (onShapeCreated.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["shapeCreated"] = (object) this.CreateHandler(this.OnShapeCreated);
      string shapeFeatureCreated = this.OnShapeFeatureCreated;
      if ((shapeFeatureCreated != null ? (shapeFeatureCreated.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["shapeFeatureCreated"] = (object) this.CreateHandler(this.OnShapeFeatureCreated);
      string onShapeMouseEnter = this.OnShapeMouseEnter;
      if ((onShapeMouseEnter != null ? (onShapeMouseEnter.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["shapeMouseEnter"] = (object) this.CreateHandler(this.OnShapeMouseEnter);
      string onShapeMouseLeave = this.OnShapeMouseLeave;
      if ((onShapeMouseLeave != null ? (onShapeMouseLeave.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["shapeMouseLeave"] = (object) this.CreateHandler(this.OnShapeMouseLeave);
      string onZoomStart = this.OnZoomStart;
      if ((onZoomStart != null ? (onZoomStart.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["zoomStart"] = (object) this.CreateHandler(this.OnZoomStart);
      string onZoomEnd = this.OnZoomEnd;
      if ((onZoomEnd != null ? (onZoomEnd.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["zoomEnd"] = (object) this.CreateHandler(this.OnZoomEnd);
      return dictionary;
    }

    public double[] Center { get; set; }

    [HtmlAttributeNotBound]
    public MapControlsSettingsTagHelper Controls { get; set; }

    [HtmlAttributeNotBound]
    public MapLayerDefaultsSettingsTagHelper LayerDefaults { get; set; }

    [HtmlAttributeNotBound]
    public MapLayersTagHelper Layers { get; set; }

    [HtmlAttributeNotBound]
    public MapMarkerDefaultsSettingsTagHelper MarkerDefaults { get; set; }

    [HtmlAttributeNotBound]
    public MapMarkersTagHelper Markers { get; set; }

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
      if (this.Controls != null)
      {
        Dictionary<string, object> source = this.Controls.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["controls"] = (object) source;
      }
      if (this.LayerDefaults != null)
      {
        Dictionary<string, object> source = this.LayerDefaults.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["layerDefaults"] = (object) source;
      }
      if (this.Layers != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Layers.Select<MapLayerTagHelper, Dictionary<string, object>>((Func<MapLayerTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["layers"] = (object) source;
      }
      if (this.MarkerDefaults != null)
      {
        Dictionary<string, object> source = this.MarkerDefaults.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["markerDefaults"] = (object) source;
      }
      if (this.Markers != null)
      {
        IEnumerable<Dictionary<string, object>> source = this.Markers.Select<MapMarkerTagHelper, Dictionary<string, object>>((Func<MapMarkerTagHelper, Dictionary<string, object>>) (i => i.Serialize()));
        if (source.Any<Dictionary<string, object>>())
          dictionary["markers"] = (object) source;
      }
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
