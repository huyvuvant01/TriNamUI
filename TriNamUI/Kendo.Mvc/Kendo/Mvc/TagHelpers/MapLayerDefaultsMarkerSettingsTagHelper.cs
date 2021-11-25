// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.MapLayerDefaultsMarkerSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("map-marker", ParentTag = "layer-defaults", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("tooltip", new string[] {})]
  [SuppressTagRendering]
  public class MapLayerDefaultsMarkerSettingsTagHelper : 
    TagHelperChildBase,
    IMapToolTipParent<
    #nullable disable
    MapTooltipTagHelper>
  {
    public MapTooltipTagHelper Tooltip { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (MapLayerDefaultsSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as MapLayerDefaultsSettingsTagHelper).Marker = this;
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary1 = this.SerializeSettings();
      if (this.Tooltip != null)
      {
        Dictionary<string, object> source = this.Tooltip.SerializeSettings();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["tooltip"] = (object) source;
      }
      if (this.Shape.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        MapMarkersShape? shape = this.Shape;
        ref MapMarkersShape? local = ref shape;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["shape"] = (object) str;
      }
      return dictionary1;
    }

    public double? Opacity { get; set; }

    public MapMarkersShape? Shape { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Opacity.HasValue)
        dictionary["opacity"] = (object) this.Opacity;
      return dictionary;
    }
  }
}
