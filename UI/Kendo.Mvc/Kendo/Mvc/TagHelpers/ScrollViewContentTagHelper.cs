// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ScrollViewContentTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("content", ParentTag = "scrollview-item")]
  [OutputElementHint("div")]
  public class ScrollViewContentTagHelper : TagHelper
  {
    public override void Process(TagHelperContext context, TagHelperOutput output) => output.TagName = "div";
  }
}
