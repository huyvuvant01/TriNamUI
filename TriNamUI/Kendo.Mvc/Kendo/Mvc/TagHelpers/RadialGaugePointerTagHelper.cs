// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.RadialGaugePointerTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("pointer", ParentTag = "radialgauge-pointers", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("cap", new string[] {})]
  [SuppressTagRendering]
  public class RadialGaugePointerTagHelper : TagHelperCollectionItemBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (RadialGaugePointersTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as RadialGaugePointersTagHelper).Add(this);
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    [HtmlAttributeNotBound]
    public RadialGaugePointerCapSettingsTagHelper Cap { get; set; }

    public string Color { get; set; }

    public double? Length { get; set; }

    public double? Value { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Cap != null)
      {
        Dictionary<string, object> source = this.Cap.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["cap"] = (object) source;
      }
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["color"] = (object) this.Color;
      if (this.Length.HasValue)
        dictionary["length"] = (object) this.Length;
      if (this.Value.HasValue)
        dictionary["value"] = (object) this.Value;
      return dictionary;
    }
  }
}
