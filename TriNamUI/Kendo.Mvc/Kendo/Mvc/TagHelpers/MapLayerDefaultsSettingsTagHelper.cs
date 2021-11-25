// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.MapLayerDefaultsSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("layer-defaults", ParentTag = "kendo-map", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("map-marker", new string[] {"shape", "bubble", "tile", "bing"})]
  [SuppressTagRendering]
  public class MapLayerDefaultsSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (MapTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as MapTagHelper).LayerDefaults = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    [HtmlAttributeNotBound]
    public MapLayerDefaultsMarkerSettingsTagHelper Marker { get; set; }

    [HtmlAttributeNotBound]
    public MapLayerDefaultsShapeSettingsTagHelper Shape { get; set; }

    [HtmlAttributeNotBound]
    public MapLayerDefaultsBubbleSettingsTagHelper Bubble { get; set; }

    public double? TileSize { get; set; }

    [HtmlAttributeNotBound]
    public MapLayerDefaultsTileSettingsTagHelper Tile { get; set; }

    [HtmlAttributeNotBound]
    public MapLayerDefaultsBingSettingsTagHelper Bing { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Marker != null)
      {
        Dictionary<string, object> source = this.Marker.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["marker"] = (object) source;
      }
      if (this.Shape != null)
      {
        Dictionary<string, object> source = this.Shape.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["shape"] = (object) source;
      }
      if (this.Bubble != null)
      {
        Dictionary<string, object> source = this.Bubble.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["bubble"] = (object) source;
      }
      if (this.TileSize.HasValue)
        dictionary["tileSize"] = (object) this.TileSize;
      if (this.Tile != null)
      {
        Dictionary<string, object> source = this.Tile.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["tile"] = (object) source;
      }
      if (this.Bing != null)
      {
        Dictionary<string, object> source = this.Bing.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["bing"] = (object) source;
      }
      return dictionary;
    }
  }
}
