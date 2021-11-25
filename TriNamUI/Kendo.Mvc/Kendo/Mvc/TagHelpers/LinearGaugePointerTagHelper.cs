// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.LinearGaugePointerTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("pointer", ParentTag = "lineargauge-pointers", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("border", new string[] {"lineargauge-pointer-track"})]
  [SuppressTagRendering]
  public class LinearGaugePointerTagHelper : TagHelperCollectionItemBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (LinearGaugePointersTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as LinearGaugePointersTagHelper).Add(this);
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    [HtmlAttributeNotBound]
    public LinearGaugePointerBorderSettingsTagHelper Border { get; set; }

    public string Color { get; set; }

    public double? Margin { get; set; }

    public double? Opacity { get; set; }

    public GaugeLinearPointerShape? Shape { get; set; }

    public double? Size { get; set; }

    [HtmlAttributeNotBound]
    public LinearGaugePointerTrackSettingsTagHelper Track { get; set; }

    public double? Value { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      if (this.Border != null)
      {
        Dictionary<string, object> source = this.Border.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["border"] = (object) source;
      }
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["color"] = (object) this.Color;
      if (this.Margin.HasValue)
        dictionary1["margin"] = (object) this.Margin;
      if (this.Opacity.HasValue)
        dictionary1["opacity"] = (object) this.Opacity;
      if (this.Shape.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        GaugeLinearPointerShape? shape = this.Shape;
        ref GaugeLinearPointerShape? local = ref shape;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["shape"] = (object) str;
      }
      if (this.Size.HasValue)
        dictionary1["size"] = (object) this.Size;
      if (this.Track != null)
      {
        Dictionary<string, object> source = this.Track.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["track"] = (object) source;
      }
      if (this.Value.HasValue)
        dictionary1["value"] = (object) this.Value;
      return dictionary1;
    }
  }
}
