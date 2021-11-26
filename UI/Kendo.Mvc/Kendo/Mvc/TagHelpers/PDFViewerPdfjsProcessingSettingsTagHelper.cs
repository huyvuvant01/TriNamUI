// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.PDFViewerPdfjsProcessingSettingsTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("pdfjs-processing", ParentTag = "kendo-pdfviewer", TagStructure = TagStructure.WithoutEndTag)]
  [SuppressTagRendering]
  public class PDFViewerPdfjsProcessingSettingsTagHelper : TagHelperChildBase
  {
    public 
    #nullable disable
    object File { get; set; }

    [HtmlAttributeName("file-url")]
    public object FileUrl { get; set; }

    [HtmlAttributeName("file-data")]
    public object FileData { get; set; }

    [HtmlAttributeName("c-map-url")]
    public object CMapUrl { get; set; }

    [HtmlAttributeName("c-map-packed")]
    public object CMapPacked { get; set; }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (PDFViewerTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as PDFViewerTagHelper).PdfjsProcessing = this;
    }

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      Dictionary<string, object> dictionary2 = this.SerializeSettings();
      if (this.File != null)
        dictionary1["url"] = this.File;
      else if (this.FileUrl != null)
        dictionary1["url"] = this.FileUrl;
      else if (this.FileData != null)
        dictionary1["data"] = this.FileData;
      if (this.CMapUrl != null)
        dictionary1["cMapUrl"] = this.CMapUrl;
      if (this.CMapPacked != null)
        dictionary1["cMapPacked"] = this.CMapPacked;
      dictionary2["file"] = (object) dictionary1;
      return dictionary2;
    }

    internal Dictionary<string, object> SerializeSettings() => new Dictionary<string, object>();
  }
}
