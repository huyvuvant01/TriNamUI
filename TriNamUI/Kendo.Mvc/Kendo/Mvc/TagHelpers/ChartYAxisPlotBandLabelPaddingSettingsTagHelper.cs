// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ChartYAxisPlotBandLabelPaddingSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("padding", ParentTag = "label", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class ChartYAxisPlotBandLabelPaddingSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ChartYAxisPlotBandLabelSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ChartYAxisPlotBandLabelSettingsTagHelper).Padding = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public double? Bottom { get; set; }

    public double? Left { get; set; }

    public double? Right { get; set; }

    public double? Top { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Bottom.HasValue)
        dictionary["bottom"] = (object) this.Bottom;
      if (this.Left.HasValue)
        dictionary["left"] = (object) this.Left;
      if (this.Right.HasValue)
        dictionary["right"] = (object) this.Right;
      if (this.Top.HasValue)
        dictionary["top"] = (object) this.Top;
      return dictionary;
    }
  }
}
