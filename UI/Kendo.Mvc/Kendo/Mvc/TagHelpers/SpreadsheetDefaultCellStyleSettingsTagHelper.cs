// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.SpreadsheetDefaultCellStyleSettingsTagHelper
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
  [HtmlTargetElement("default-cell-style", ParentTag = "kendo-spreadsheet", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class SpreadsheetDefaultCellStyleSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (SpreadsheetTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as SpreadsheetTagHelper).DefaultCellStyle = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Background { get; set; }

    public string Color { get; set; }

    public string FontFamily { get; set; }

    public string FontSize { get; set; }

    public bool? Italic { get; set; }

    public bool? Bold { get; set; }

    public bool? Underline { get; set; }

    public bool? Wrap { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string background = this.Background;
      if ((background != null ? (background.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["background"] = (object) this.Background;
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["color"] = (object) this.Color;
      string fontFamily = this.FontFamily;
      if ((fontFamily != null ? (fontFamily.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["fontFamily"] = (object) this.FontFamily;
      string fontSize = this.FontSize;
      if ((fontSize != null ? (fontSize.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["fontSize"] = (object) this.FontSize;
      bool? nullable = this.Italic;
      if (nullable.HasValue)
        dictionary["italic"] = (object) this.Italic;
      nullable = this.Bold;
      if (nullable.HasValue)
        dictionary["bold"] = (object) this.Bold;
      nullable = this.Underline;
      if (nullable.HasValue)
        dictionary["underline"] = (object) this.Underline;
      nullable = this.Wrap;
      if (nullable.HasValue)
        dictionary["wrap"] = (object) this.Wrap;
      return dictionary;
    }
  }
}
