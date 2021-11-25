// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.DropDownTreeNestedItemsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("items", ParentTag = "dropdowntree-item")]
  [RestrictChildren("dropdowntree-item", new string[] {})]
  [SuppressTagRendering]
  public class DropDownTreeNestedItemsTagHelper : DropDownTreeItemsTagHelper
  {
    private 
    #nullable disable
    DropDownTreeNestedItemsTagHelper PreviousInstance { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      DropDownTreeNestedItemsTagHelper nestedItemsTagHelper = this;
      nestedItemsTagHelper.AddSelfToParent(context);
      Type type = nestedItemsTagHelper.GetType();
      if (context.Items.ContainsKey((object) type))
        nestedItemsTagHelper.PreviousInstance = context.Items[(object) type] as DropDownTreeNestedItemsTagHelper;
      context.Items[(object) type] = (object) nestedItemsTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      context.Items[(object) type] = (object) nestedItemsTagHelper.PreviousInstance;
      type = (Type) null;
    }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (DropDownTreeItemTagHelper);
      (context.Items[(object) type] as DropDownTreeItemTagHelper).Items = this;
    }
  }
}
