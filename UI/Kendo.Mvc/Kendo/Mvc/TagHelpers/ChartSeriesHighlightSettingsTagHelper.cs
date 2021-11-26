// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ChartSeriesHighlightSettingsTagHelper
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
  [HtmlTargetElement("highlight", ParentTag = "series-item", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("border", new string[] {"line"})]
  [SuppressTagRendering]
  public class ChartSeriesHighlightSettingsTagHelper : TagHelperChildBase
  {
    public 
    #nullable disable
    string Toggle { get; set; }

    public string Visual { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ChartSeriesTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ChartSeriesTagHelper).Highlight = this;
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      string toggle = this.Toggle;
      if ((toggle != null ? (toggle.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["toggle"] = (object) this.CreateHandler(this.Toggle);
      string visual = this.Visual;
      if ((visual != null ? (visual.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["visual"] = (object) this.CreateHandler(this.Visual);
      return dictionary;
    }

    [HtmlAttributeNotBound]
    public ChartSeriesHighlightBorderSettingsTagHelper Border { get; set; }

    public string Color { get; set; }

    public double? InactiveOpacity { get; set; }

    [HtmlAttributeNotBound]
    public ChartSeriesHighlightLineSettingsTagHelper Line { get; set; }

    public double? Opacity { get; set; }

    public bool? Visible { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Border != null)
      {
        Dictionary<string, object> source = this.Border.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["border"] = (object) source;
      }
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["color"] = (object) this.Color;
      if (this.InactiveOpacity.HasValue)
        dictionary["inactiveOpacity"] = (object) this.InactiveOpacity;
      if (this.Line != null)
      {
        Dictionary<string, object> source = this.Line.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["line"] = (object) source;
      }
      if (this.Opacity.HasValue)
        dictionary["opacity"] = (object) this.Opacity;
      if (this.Visible.HasValue)
        dictionary["visible"] = (object) this.Visible;
      return dictionary;
    }
  }
}
