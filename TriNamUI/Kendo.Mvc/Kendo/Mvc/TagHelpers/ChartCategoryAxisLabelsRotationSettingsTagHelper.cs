// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ChartCategoryAxisLabelsRotationSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("chart-category-axis-labels-rotation", ParentTag = "labels", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class ChartCategoryAxisLabelsRotationSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (ChartCategoryAxisLabelsSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as ChartCategoryAxisLabelsSettingsTagHelper).Rotation = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public object Angle { get; set; }

    public ChartAxisLabelRotationAlignment? Align { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      if (this.Angle != null)
        dictionary1["angle"] = this.Angle;
      if (this.Align.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        ChartAxisLabelRotationAlignment? align = this.Align;
        ref ChartAxisLabelRotationAlignment? local = ref align;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["align"] = (object) str;
      }
      return dictionary1;
    }
  }
}
