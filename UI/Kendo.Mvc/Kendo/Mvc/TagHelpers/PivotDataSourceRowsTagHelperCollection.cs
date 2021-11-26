// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.PivotDataSourceRowsTagHelperCollection
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
  [HtmlTargetElement("rows", ParentTag = "kendo-pivotdatasource")]
  [HtmlTargetElement("rows", ParentTag = "pivot-datasource")]
  [RestrictChildren("row", new string[] {})]
  [SuppressTagRendering]
  public class PivotDataSourceRowsTagHelperCollection : 
    TagHelperCollectionBase<
    #nullable disable
    PivotDataSourceRowTagHelper>
  {
    public IList<PivotDataSourceRowTagHelper> Rows => this.InternalRef;

    public PivotDataSourceRowsTagHelperCollection()
      : base((IList<PivotDataSourceRowTagHelper>) new List<PivotDataSourceRowTagHelper>())
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      PivotDataSourceRowsTagHelperCollection helperCollection = this;
      context.Items[(object) helperCollection.GetType()] = (object) helperCollection;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      helperCollection.AddSelfToParent(context);
    }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (PivotDataSourceTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as PivotDataSourceTagHelper).Rows = this;
    }
  }
}
