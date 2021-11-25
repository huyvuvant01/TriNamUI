// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.MenuItemSubItemsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("sub-items", ParentTag = "menu-item")]
  [RestrictChildren("menu-item", new string[] {})]
  [OutputElementHint("ul")]
  public class MenuItemSubItemsTagHelper : TagHelper
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => output.TagName = "ul";
  }
}
