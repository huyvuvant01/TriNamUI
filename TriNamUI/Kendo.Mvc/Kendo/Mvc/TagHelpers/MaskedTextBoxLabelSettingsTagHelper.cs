// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.MaskedTextBoxLabelSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("maskedtextbox-label", ParentTag = "kendo-maskedtextbox", TagStructure = TagStructure.WithoutEndTag)]
  [HtmlTargetElement("maskedtextbox-label", ParentTag = "maskedtextbox-editor", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class MaskedTextBoxLabelSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (MaskedTextBoxTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as MaskedTextBoxTagHelper).Label = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Content { get; set; }

    public string ContentHandler { get; set; }

    public bool? Floating { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string contentHandler = this.ContentHandler;
      if ((contentHandler != null ? (contentHandler.HasValue() ? 1 : 0) : 0) != 0)
      {
        dictionary["content"] = (object) this.CreateHandler(this.ContentHandler);
      }
      else
      {
        string content = this.Content;
        if ((content != null ? (content.HasValue() ? 1 : 0) : 0) != 0)
          dictionary["content"] = (object) this.Content;
      }
      if (this.Floating.HasValue)
        dictionary["floating"] = (object) this.Floating;
      return dictionary;
    }
  }
}
