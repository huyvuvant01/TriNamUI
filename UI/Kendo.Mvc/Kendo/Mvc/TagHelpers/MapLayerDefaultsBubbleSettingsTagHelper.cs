// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.MapLayerDefaultsBubbleSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.TagHelpers.Map;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("bubble", ParentTag = "layer-defaults", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("map-style", new string[] {})]
  [SuppressTagRendering]
  public class MapLayerDefaultsBubbleSettingsTagHelper : 
    TagHelperChildBase,
    IMapStyleParent<
    #nullable disable
    MapStyleSettingsTagHelper>
  {
    public MapStyleSettingsTagHelper Style { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (MapLayerDefaultsSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as MapLayerDefaultsSettingsTagHelper).Bubble = this;
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.Style != null)
      {
        Dictionary<string, object> source = this.Style.SerializeSettings();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["style"] = (object) source;
      }
      return dictionary;
    }

    public string Attribution { get; set; }

    public double? Opacity { get; set; }

    public double? MaxSize { get; set; }

    public double? MinSize { get; set; }

    public MapSymbol? Symbol { get; set; }

    public string SymbolHandler { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      string attribution = this.Attribution;
      if ((attribution != null ? (attribution.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["attribution"] = (object) this.Attribution;
      double? nullable = this.Opacity;
      if (nullable.HasValue)
        dictionary1["opacity"] = (object) this.Opacity;
      nullable = this.MaxSize;
      if (nullable.HasValue)
        dictionary1["maxSize"] = (object) this.MaxSize;
      nullable = this.MinSize;
      if (nullable.HasValue)
        dictionary1["minSize"] = (object) this.MinSize;
      string symbolHandler = this.SymbolHandler;
      if ((symbolHandler != null ? (symbolHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary1["symbol"] = (object) this.CreateHandler(this.SymbolHandler);
      }
      else
      {
        MapSymbol? symbol = this.Symbol;
        if (symbol.HasValue)
        {
          Dictionary<string, object> dictionary2 = dictionary1;
          symbol = this.Symbol;
          ref MapSymbol? local = ref symbol;
          string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
          dictionary2["symbol"] = (object) str;
        }
      }
      return dictionary1;
    }
  }
}
