// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.PivotDataSourceCubeMeasuresTagHelper
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
  [HtmlTargetElement("measures", ParentTag = "cube", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("measure", new string[] {})]
  [SuppressTagRendering]
  public class PivotDataSourceCubeMeasuresTagHelper : 
    TagHelperCollectionBase<
    #nullable disable
    PivotDataSourceCubeMeasureTagHelper>
  {
    [HtmlAttributeNotBound]
    public Dictionary<string, PivotDataSourceCubeMeasureTagHelper> Dimensions { get; set; }

    public PivotDataSourceCubeMeasuresTagHelper()
      : base((IList<PivotDataSourceCubeMeasureTagHelper>) new List<PivotDataSourceCubeMeasureTagHelper>())
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      PivotDataSourceCubeMeasuresTagHelper measuresTagHelper = this;
      context.Items[(object) measuresTagHelper.GetType()] = (object) measuresTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await measuresTagHelper.\u003C\u003En__0(context, output);
      context.Items[(object) measuresTagHelper.GetType()] = (object) null;
    }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (PivotDataSourceSchemaCubeTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      PivotDataSourceSchemaCubeTagHelper schemaCubeTagHelper = context.Items[(object) type] as PivotDataSourceSchemaCubeTagHelper;
      foreach (PivotDataSourceCubeMeasureTagHelper measureTagHelper in (TagHelperCollectionBase<PivotDataSourceCubeMeasureTagHelper>) this)
        schemaCubeTagHelper.Measures.Add(measureTagHelper.Name, measureTagHelper);
    }
  }
}
