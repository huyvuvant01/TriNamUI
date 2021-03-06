// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ChartSeriesHighlightLineSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("line", ParentTag = "highlight", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class ChartSeriesHighlightLineSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ChartSeriesHighlightSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ChartSeriesHighlightSettingsTagHelper).Line = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public Kendo.Mvc.UI.DashType? DashType { get; set; }

    public string Color { get; set; }

    public double? Opacity { get; set; }

    public double? Width { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      if (this.DashType.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        Kendo.Mvc.UI.DashType? dashType = this.DashType;
        ref Kendo.Mvc.UI.DashType? local = ref dashType;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["dashType"] = (object) str;
      }
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["color"] = (object) this.Color;
      if (this.Opacity.HasValue)
        dictionary1["opacity"] = (object) this.Opacity;
      if (this.Width.HasValue)
        dictionary1["width"] = (object) this.Width;
      return dictionary1;
    }
  }
}
