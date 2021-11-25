// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ChartTitleSettingsTagHelper
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
  [HtmlTargetElement("chart-title", ParentTag = "kendo-chart", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("border", new string[] {"margin", "padding"})]
  [SuppressTagRendering]
  public class ChartTitleSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ChartTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ChartTagHelper).Title = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Background { get; set; }

    [HtmlAttributeNotBound]
    public ChartTitleBorderSettingsTagHelper Border { get; set; }

    public string Color { get; set; }

    public string Font { get; set; }

    [HtmlAttributeNotBound]
    public ChartTitleMarginSettingsTagHelper Margin { get; set; }

    [HtmlAttributeNotBound]
    public ChartTitlePaddingSettingsTagHelper Padding { get; set; }

    public string Text { get; set; }

    public bool? Visible { get; set; }

    public ChartTextAlignment? Align { get; set; }

    public ChartTitlePosition? Position { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      string background = this.Background;
      if ((background != null ? (background.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["background"] = (object) this.Background;
      if (this.Border != null)
      {
        Dictionary<string, object> source = this.Border.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["border"] = (object) source;
      }
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["color"] = (object) this.Color;
      string font = this.Font;
      if ((font != null ? (font.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["font"] = (object) this.Font;
      if (this.Margin != null)
      {
        Dictionary<string, object> source = this.Margin.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["margin"] = (object) source;
      }
      if (this.Padding != null)
      {
        Dictionary<string, object> source = this.Padding.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["padding"] = (object) source;
      }
      string text = this.Text;
      if ((text != null ? (text.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["text"] = (object) this.Text;
      if (this.Visible.HasValue)
        dictionary1["visible"] = (object) this.Visible;
      ChartTextAlignment? align = this.Align;
      if (align.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        align = this.Align;
        ref ChartTextAlignment? local = ref align;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["align"] = (object) str;
      }
      ChartTitlePosition? position = this.Position;
      if (position.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        position = this.Position;
        ref ChartTitlePosition? local = ref position;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["position"] = (object) str;
      }
      return dictionary1;
    }
  }
}
