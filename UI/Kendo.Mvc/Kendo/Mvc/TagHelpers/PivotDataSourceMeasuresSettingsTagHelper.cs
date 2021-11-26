// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.PivotDataSourceMeasuresSettingsTagHelper
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
  [HtmlTargetElement("measures", ParentTag = "kendo-pivotdatasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [HtmlTargetElement("measures", ParentTag = "pivot-datasource", TagStructure = TagStructure.NormalOrSelfClosing)]
  [SuppressTagRendering]
  public class PivotDataSourceMeasuresSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (PivotDataSourceTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as PivotDataSourceTagHelper).Measures = this;
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string[] values = this.Values;
      if ((values != null ? (((IEnumerable<string>) values).Any<string>() ? 1 : 0) : 0) != 0)
        dictionary["values"] = (object) this.Values;
      string axis = this.Axis;
      if ((axis != null ? (axis.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["axis"] = (object) this.Axis;
      return dictionary;
    }

    public string[] Values { get; set; }

    public string Axis { get; set; }
  }
}
