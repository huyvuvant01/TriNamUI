// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.MenuItemContentTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("content", ParentTag = "menu-item")]
  [OutputElementHint("div")]
  public class MenuItemContentTagHelper : TagHelper
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      string content = (await output.GetChildContentAsync()).GetContent();
      output.TagName = "ul";
      TagBuilder tagBuilder1 = new TagBuilder("div");
      tagBuilder1.MergeAttributes<string, object>((IDictionary<string, object>) output.Attributes.ToDictionary<TagHelperAttribute, string, object>((Func<TagHelperAttribute, string>) (attr => attr.Name), (Func<TagHelperAttribute, object>) (attr => attr.Value)));
      output.Attributes.Clear();
      tagBuilder1.InnerHtml.AppendHtml(content);
      TagBuilder tagBuilder2 = new TagBuilder("li");
      tagBuilder2.InnerHtml.AppendHtml((IHtmlContent) tagBuilder1);
      output.Content.SetHtmlContent((IHtmlContent) tagBuilder2);
    }
  }
}
