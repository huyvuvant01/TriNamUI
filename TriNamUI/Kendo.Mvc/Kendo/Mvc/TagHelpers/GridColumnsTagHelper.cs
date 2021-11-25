// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GridColumnsTagHelper
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
  [HtmlTargetElement("columns", ParentTag = "kendo-grid")]
  [RestrictChildren("column", new string[] {"foreign-key-column"})]
  [SuppressTagRendering]
  public class GridColumnsTagHelper : TagHelperCollectionBase<
  #nullable disable
  GridColumnTagHelper>
  {
    public IList<GridColumnTagHelper> Columns => this.InternalRef;

    public GridColumnsTagHelper()
      : base((IList<GridColumnTagHelper>) new List<GridColumnTagHelper>())
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      GridColumnsTagHelper columnsTagHelper = this;
      context.Items[(object) columnsTagHelper.GetType()] = (object) columnsTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      columnsTagHelper.AddSelfToParent(context);
    }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (GridTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as GridTagHelper).Columns = this;
    }
  }
}
