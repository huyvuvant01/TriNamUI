// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ChartPlotAreaSettingsTagHelper
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
  [HtmlTargetElement("plot-area", ParentTag = "kendo-chart", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("border", new string[] {"margin", "padding"})]
  [SuppressTagRendering]
  public class ChartPlotAreaSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ChartTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ChartTagHelper).PlotArea = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Background { get; set; }

    [HtmlAttributeNotBound]
    public ChartPlotAreaBorderSettingsTagHelper Border { get; set; }

    [HtmlAttributeNotBound]
    public ChartPlotAreaMarginSettingsTagHelper Margin { get; set; }

    public double? Opacity { get; set; }

    [HtmlAttributeNotBound]
    public ChartPlotAreaPaddingSettingsTagHelper Padding { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string background = this.Background;
      if ((background != null ? (background.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["background"] = (object) this.Background;
      if ((object) this.Border != null)
      {
        Dictionary<string, object> source = this.Border.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["border"] = (object) source;
      }
      if (this.Margin != null)
      {
        Dictionary<string, object> source = this.Margin.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["margin"] = (object) source;
      }
      if (this.Opacity.HasValue)
        dictionary["opacity"] = (object) this.Opacity;
      if (this.Padding != null)
      {
        Dictionary<string, object> source = this.Padding.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["padding"] = (object) source;
      }
      return dictionary;
    }
  }
}
