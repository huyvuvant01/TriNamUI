// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.TabStripItemsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("items", ParentTag = "kendo-tabstrip")]
  [RestrictChildren("tabstrip-item", new string[] {})]
  [OutputElementHint("ul")]
  public class TabStripItemsTagHelper : TagHelper
  {
    [HtmlAttributeNotBound]
    [ViewContext]
    public 
    #nullable disable
    ViewContext ViewContext { get; set; }

    [HtmlAttributeNotBound]
    public List<string> ContentOutputs { get; set; }

    public TabStripItemsTagHelper() => this.ContentOutputs = new List<string>();

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      TabStripItemsTagHelper stripItemsTagHelper = this;
      context.Items[(object) stripItemsTagHelper.GetType()] = (object) stripItemsTagHelper;
      output.TagName = "ul";
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      TabStripTagHelper tabStripTagHelper = context.Items[(object) typeof (TabStripTagHelper)] as TabStripTagHelper;
      if (tabStripTagHelper.BindTo != null)
      {
        TabStripItemTagHelperFactory factory = new TabStripItemTagHelperFactory(context, stripItemsTagHelper.ViewContext);
        foreach (TabStripItemBase tabStripItemBase in tabStripTagHelper.BindTo)
        {
          await factory.GenerateItemAsync(tabStripItemBase);
          output.Content.AppendHtml((IHtmlContent) factory.Output);
        }
        factory = (TabStripItemTagHelperFactory) null;
      }
      foreach (string contentOutput in stripItemsTagHelper.ContentOutputs)
        output.PostElement.AppendHtml(contentOutput);
    }
  }
}
