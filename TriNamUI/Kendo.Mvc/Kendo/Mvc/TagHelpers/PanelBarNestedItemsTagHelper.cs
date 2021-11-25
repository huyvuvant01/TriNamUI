// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.PanelBarNestedItemsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("items", ParentTag = "panelbar-item")]
  [RestrictChildren("panelbar-item", new string[] {})]
  [SuppressTagRendering]
  [OutputElementHint("ul")]
  public class PanelBarNestedItemsTagHelper : PanelBarItemsTagHelper
  {
    private 
    #nullable disable
    PanelBarNestedItemsTagHelper PreviousInstance { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      PanelBarNestedItemsTagHelper nestedItemsTagHelper = this;
      nestedItemsTagHelper.AddSelfToParent(context);
      Type type = nestedItemsTagHelper.GetType();
      if (context.Items.ContainsKey((object) type))
        nestedItemsTagHelper.PreviousInstance = context.Items[(object) type] as PanelBarNestedItemsTagHelper;
      context.Items[(object) type] = (object) nestedItemsTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      context.Items[(object) type] = (object) nestedItemsTagHelper.PreviousInstance;
      PanelBarItemTagHelper barItemTagHelper = context.Items[(object) typeof (PanelBarItemTagHelper)] as PanelBarItemTagHelper;
      bool? expanded = barItemTagHelper.Expanded;
      if (expanded.HasValue)
      {
        expanded = barItemTagHelper.Expanded;
        if (expanded.Value)
          goto label_6;
      }
      output.Attributes.Add("style", (object) "display:none");
label_6:
      output.TagName = "ul";
      output.TagMode = TagMode.StartTagAndEndTag;
      output.Content.SetHtmlContent((IHtmlContent) childContentAsync);
      type = (Type) null;
    }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (PanelBarItemTagHelper);
      (context.Items[(object) type] as PanelBarItemTagHelper).DeclaredItems = this;
    }
  }
}
