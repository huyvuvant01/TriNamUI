// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.PanelBarItemContentTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("content", ParentTag = "panelbar-item")]
  [OutputElementHint("div")]
  public class PanelBarItemContentTagHelper : TagHelperChildBase
  {
    public 
    #nullable disable
    string Html { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      PanelBarItemContentTagHelper contentTagHelper = this;
      string content = (await output.GetChildContentAsync()).GetContent();
      output.SuppressOutput();
      contentTagHelper.Html = content.Trim();
      contentTagHelper.AddSelfToContext(context);
      contentTagHelper.AddSelfToParent(context);
    }

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (PanelBarItemTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      PanelBarItemTagHelper barItemTagHelper = context.Items[(object) type] as PanelBarItemTagHelper;
      barItemTagHelper.Content = this.Html;
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      foreach (TagHelperAttribute allAttribute in (ReadOnlyCollection<TagHelperAttribute>) context.AllAttributes)
        dictionary.Add(allAttribute.Name, allAttribute.Value);
      barItemTagHelper.ContentHtmlAttributes = (object) dictionary;
    }
  }
}
