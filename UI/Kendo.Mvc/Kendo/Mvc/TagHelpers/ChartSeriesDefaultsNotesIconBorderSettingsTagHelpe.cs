// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ChartSeriesDefaultsNotesIconBorderSettingsTagHelper
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
  [HtmlTargetElement("border", ParentTag = "chart-series-defaults-notes-icon", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class ChartSeriesDefaultsNotesIconBorderSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ChartSeriesDefaultsNotesIconSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ChartSeriesDefaultsNotesIconSettingsTagHelper).Border = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Color { get; set; }

    public double? Width { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["color"] = (object) this.Color;
      if (this.Width.HasValue)
        dictionary["width"] = (object) this.Width;
      return dictionary;
    }
  }
}
