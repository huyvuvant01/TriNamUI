// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.PDFViewerMessagesSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("messages", ParentTag = "kendo-pdfviewer", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("toolbar", new string[] {"dialogs", "error-messages"})]
  [SuppressTagRendering]
  public class PDFViewerMessagesSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (PDFViewerTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as PDFViewerTagHelper).Messages = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string DefaultFileName { get; set; }

    [HtmlAttributeNotBound]
    public PDFViewerMessagesToolbarSettingsTagHelper Toolbar { get; set; }

    [HtmlAttributeNotBound]
    public PDFViewerMessagesErrorMessagesSettingsTagHelper ErrorMessages { get; set; }

    [HtmlAttributeNotBound]
    public PDFViewerMessagesDialogsSettingsTagHelper Dialogs { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string defaultFileName = this.DefaultFileName;
      if ((defaultFileName != null ? (defaultFileName.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["defaultFileName"] = (object) this.DefaultFileName;
      if (this.Toolbar != null)
      {
        Dictionary<string, object> source = this.Toolbar.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["toolbar"] = (object) source;
      }
      if (this.ErrorMessages != null)
      {
        Dictionary<string, object> source = this.ErrorMessages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["errorMessages"] = (object) source;
      }
      if (this.Dialogs != null)
      {
        Dictionary<string, object> source = this.Dialogs.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["dialogs"] = (object) source;
      }
      return dictionary;
    }
  }
}
