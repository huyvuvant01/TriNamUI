// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.PivotDataSourceCubeDimensionTagHelper
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
  [HtmlTargetElement("dimension", ParentTag = "dimensions", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class PivotDataSourceCubeDimensionTagHelper : TagHelperCollectionItemBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      PivotDataSourceCubeDimensionTagHelper dimensionTagHelper = this;
      Type type = dimensionTagHelper.GetType();
      context.Items[(object) type] = (object) dimensionTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      dimensionTagHelper.AddSelfToParent(context);
      context.Items[(object) type] = (object) null;
      type = (Type) null;
    }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (PivotDataSourceCubeDimensionsTagHelper);
      (context.Items[(object) type] as PivotDataSourceCubeDimensionsTagHelper).Add(this);
    }

    internal Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string caption = this.Caption;
      if ((caption != null ? (caption.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["caption"] = (object) this.Caption;
      return dictionary;
    }

    public string Caption { get; set; }

    public string Name { get; set; }
  }
}
