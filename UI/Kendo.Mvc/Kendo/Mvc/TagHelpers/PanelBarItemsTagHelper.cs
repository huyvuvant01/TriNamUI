// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.PanelBarItemsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("items", ParentTag = "kendo-panelbar")]
  [RestrictChildren("panelbar-item", new string[] {})]
  [SuppressTagRendering]
  public class PanelBarItemsTagHelper : TagHelperCollectionBase<
  #nullable disable
  PanelBarItemTagHelper>
  {
    public IList<PanelBarItemTagHelper> Items => this.InternalRef;

    public PanelBarItemsTagHelper()
      : base((IList<PanelBarItemTagHelper>) new List<PanelBarItemTagHelper>())
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      PanelBarItemsTagHelper barItemsTagHelper = this;
      barItemsTagHelper.AddSelfToParent(context);
      context.Items[(object) barItemsTagHelper.GetType()] = (object) barItemsTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      output.SuppressOutput();
      output.Content.SetHtmlContent((IHtmlContent) childContentAsync);
    }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (PanelBarTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as PanelBarTagHelper).Items = this;
    }
  }
}
