// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ChartYAxisLabelsRotationSettingsTagHelper
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
  [HtmlTargetElement("chart-y-axis-labels-rotation", ParentTag = "labels", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class ChartYAxisLabelsRotationSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ChartYAxisLabelsSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ChartYAxisLabelsSettingsTagHelper).Rotation = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Align { get; set; }

    public double? Angle { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string align = this.Align;
      if ((align != null ? (align.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["align"] = (object) this.Align;
      if (this.Angle.HasValue)
        dictionary["angle"] = (object) this.Angle;
      return dictionary;
    }
  }
}
