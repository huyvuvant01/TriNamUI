// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GridToolbarTagHelper
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
  [HtmlTargetElement("toolbar", ParentTag = "kendo-grid")]
  [RestrictChildren("toolbar-button", new string[] {})]
  [SuppressTagRendering]
  public class GridToolbarTagHelper : TagHelperCollectionBase<
  #nullable disable
  GridToolbarButtonTagHelper>
  {
    public IList<GridToolbarButtonTagHelper> Buttons => this.InternalRef;

    public GridToolbarTagHelper()
      : base((IList<GridToolbarButtonTagHelper>) new List<GridToolbarButtonTagHelper>())
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      GridToolbarTagHelper toolbarTagHelper = this;
      context.Items[(object) toolbarTagHelper.GetType()] = (object) toolbarTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await toolbarTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (GridTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as GridTagHelper).Toolbar = this;
    }
  }
}
