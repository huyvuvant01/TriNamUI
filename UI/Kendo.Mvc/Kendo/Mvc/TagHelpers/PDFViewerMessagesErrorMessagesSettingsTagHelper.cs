// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.PDFViewerMessagesErrorMessagesSettingsTagHelper
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
  [HtmlTargetElement("error-messages", ParentTag = "messages", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class PDFViewerMessagesErrorMessagesSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (PDFViewerMessagesSettingsTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as PDFViewerMessagesSettingsTagHelper).ErrorMessages = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string NotSupported { get; set; }

    public string ParseError { get; set; }

    public string NotFound { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string notSupported = this.NotSupported;
      if ((notSupported != null ? (notSupported.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["notSupported"] = (object) this.NotSupported;
      string parseError = this.ParseError;
      if ((parseError != null ? (parseError.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["parseError"] = (object) this.ParseError;
      string notFound = this.NotFound;
      if ((notFound != null ? (notFound.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["notFound"] = (object) this.NotFound;
      return dictionary;
    }
  }
}
