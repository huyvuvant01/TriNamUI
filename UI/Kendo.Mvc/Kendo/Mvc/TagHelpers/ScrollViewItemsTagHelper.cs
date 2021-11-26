// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ScrollViewItemsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("items", ParentTag = "kendo-scrollview")]
  [RestrictChildren("scrollview-item", new string[] {})]
  [SuppressTagRendering]
  public class ScrollViewItemsTagHelper : TagHelper
  {
    [HtmlAttributeNotBound]
    public 
    #nullable disable
    List<string> ContentOutputs { get; set; }

    public ScrollViewItemsTagHelper() => this.ContentOutputs = new List<string>();

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      ScrollViewItemsTagHelper viewItemsTagHelper = this;
      context.Items[(object) viewItemsTagHelper.GetType()] = (object) viewItemsTagHelper;
      output.TagName = "div";
      output.Attributes.SetAttribute("class", (object) "k-scrollview-wrap");
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      object obj = context.Items[(object) typeof (ScrollViewTagHelper)];
      foreach (string contentOutput in viewItemsTagHelper.ContentOutputs)
        output.PostElement.AppendHtml(contentOutput);
    }
  }
}
