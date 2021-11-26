// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ScrollViewItemTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("scrollview-item", ParentTag = "items", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("content", new string[] {})]
  [SuppressTagRendering]
  [OutputElementHint("div")]
  public class ScrollViewItemTagHelper : TagHelper
  {
    [HtmlAttributeNotBound]
    public 
    #nullable disable
    object ContentHtmlAttributes { get; set; }

    [HtmlAttributeNotBound]
    public string Content { get; set; }

    private ScrollViewItemTagHelper PreviousInstance { get; set; }

    [HtmlAttributeNotBound]
    public IEnumerable<ScrollViewItemBase> Items { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      await base.ProcessAsync(context, output);
      (await output.GetChildContentAsync()).GetContent();
      output.TagName = "div";
      output.Attributes.SetAttribute("data-role", (object) "page");
      output.TagMode = TagMode.StartTagAndEndTag;
    }
  }
}
