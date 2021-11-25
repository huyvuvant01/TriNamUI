// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.PDFViewerDplProcessingSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("dpl-processing", ParentTag = "kendo-pdfviewer", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("read", new string[] {"upload", "download"})]
  [SuppressTagRendering]
  public class PDFViewerDplProcessingSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (PDFViewerTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as PDFViewerTagHelper).DplProcessing = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    [HtmlAttributeNotBound]
    public PDFViewerDplProcessingReadSettingsTagHelper Read { get; set; }

    [HtmlAttributeNotBound]
    public PDFViewerDplProcessingUploadSettingsTagHelper Upload { get; set; }

    [HtmlAttributeNotBound]
    public PDFViewerDplProcessingDownloadSettingsTagHelper Download { get; set; }

    public bool? LoadOnDemand { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.Read != null)
      {
        Dictionary<string, object> source = this.Read.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["read"] = (object) source;
      }
      if (this.Upload != null)
      {
        Dictionary<string, object> source = this.Upload.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["upload"] = (object) source;
      }
      if (this.Download != null)
      {
        Dictionary<string, object> source = this.Download.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["download"] = (object) source;
      }
      if (this.LoadOnDemand.HasValue)
        dictionary["loadOnDemand"] = (object) this.LoadOnDemand;
      return dictionary;
    }
  }
}
