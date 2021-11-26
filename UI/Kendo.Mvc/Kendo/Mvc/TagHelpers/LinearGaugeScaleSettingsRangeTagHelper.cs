// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.LinearGaugeScaleSettingsRangeTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("range", ParentTag = "lineargauge-scale-ranges", TagStructure = TagStructure.NormalOrSelfClosing)]
  [SuppressTagRendering]
  public class LinearGaugeScaleSettingsRangeTagHelper : TagHelperCollectionItemBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (LinearGaugeScaleSettingsRangesTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as LinearGaugeScaleSettingsRangesTagHelper).Add(this);
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public double? From { get; set; }

    public double? To { get; set; }

    public double? Opacity { get; set; }

    public string Color { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.From.HasValue)
        dictionary["from"] = (object) this.From;
      if (this.To.HasValue)
        dictionary["to"] = (object) this.To;
      if (this.Opacity.HasValue)
        dictionary["opacity"] = (object) this.Opacity;
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["color"] = (object) this.Color;
      return dictionary;
    }
  }
}
