// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.PivotDataSourceCubeDimensionsTagHelper
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
  [HtmlTargetElement("dimensions", ParentTag = "cube", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("dimension", new string[] {})]
  [SuppressTagRendering]
  public class PivotDataSourceCubeDimensionsTagHelper : 
    TagHelperCollectionBase<
    #nullable disable
    PivotDataSourceCubeDimensionTagHelper>
  {
    [HtmlAttributeNotBound]
    public Dictionary<string, PivotDataSourceCubeDimensionTagHelper> Dimensions { get; set; }

    public PivotDataSourceCubeDimensionsTagHelper()
      : base((IList<PivotDataSourceCubeDimensionTagHelper>) new List<PivotDataSourceCubeDimensionTagHelper>())
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      PivotDataSourceCubeDimensionsTagHelper dimensionsTagHelper = this;
      context.Items[(object) dimensionsTagHelper.GetType()] = (object) dimensionsTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await dimensionsTagHelper.\u003C\u003En__0(context, output);
      context.Items[(object) dimensionsTagHelper.GetType()] = (object) null;
    }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (PivotDataSourceSchemaCubeTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      PivotDataSourceSchemaCubeTagHelper schemaCubeTagHelper = context.Items[(object) type] as PivotDataSourceSchemaCubeTagHelper;
      foreach (PivotDataSourceCubeDimensionTagHelper dimensionTagHelper in (TagHelperCollectionBase<PivotDataSourceCubeDimensionTagHelper>) this)
        schemaCubeTagHelper.Dimensions.Add(dimensionTagHelper.Name, dimensionTagHelper);
    }
  }
}
