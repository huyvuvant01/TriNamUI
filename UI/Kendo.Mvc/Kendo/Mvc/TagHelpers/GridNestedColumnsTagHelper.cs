// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GridNestedColumnsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("columns", ParentTag = "column")]
  [RestrictChildren("column", new string[] {})]
  [SuppressTagRendering]
  public class GridNestedColumnsTagHelper : GridColumnsTagHelper
  {
    private 
    #nullable disable
    GridNestedColumnsTagHelper PreviousInstance { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      GridNestedColumnsTagHelper columnsTagHelper = this;
      columnsTagHelper.AddSelfToParent(context);
      Type type = columnsTagHelper.GetType();
      if (context.Items.ContainsKey((object) type))
        columnsTagHelper.PreviousInstance = context.Items[(object) type] as GridNestedColumnsTagHelper;
      context.Items[(object) type] = (object) columnsTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      context.Items[(object) type] = (object) columnsTagHelper.PreviousInstance;
      type = (Type) null;
    }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (GridColumnTagHelper);
      (context.Items[(object) type] as GridColumnTagHelper).Columns = this;
    }
  }
}
