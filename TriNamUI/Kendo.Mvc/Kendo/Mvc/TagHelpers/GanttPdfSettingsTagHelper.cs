// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GanttPdfSettingsTagHelper
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
  [HtmlTargetElement("pdf", ParentTag = "kendo-gantt", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("gantt-pdf-margin", new string[] {})]
  [SuppressTagRendering]
  public class GanttPdfSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (GanttTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as GanttTagHelper).Pdf = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Author { get; set; }

    public bool? AutoPrint { get; set; }

    public bool? AvoidLinks { get; set; }

    public string Creator { get; set; }

    public DateTime? Date { get; set; }

    public string FileName { get; set; }

    public bool? ForceProxy { get; set; }

    public double? JpegQuality { get; set; }

    public bool? KeepPNG { get; set; }

    public string Keywords { get; set; }

    public bool? Landscape { get; set; }

    [HtmlAttributeNotBound]
    public GanttPdfMarginSettingsTagHelper Margin { get; set; }

    public string PaperSize { get; set; }

    public string ProxyURL { get; set; }

    public string ProxyTarget { get; set; }

    public string Subject { get; set; }

    public string Title { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string author = this.Author;
      if ((author != null ? (author.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["author"] = (object) this.Author;
      bool? nullable = this.AutoPrint;
      if (nullable.HasValue)
        dictionary["autoPrint"] = (object) this.AutoPrint;
      nullable = this.AvoidLinks;
      if (nullable.HasValue)
        dictionary["avoidLinks"] = (object) this.AvoidLinks;
      string creator = this.Creator;
      if ((creator != null ? (creator.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["creator"] = (object) this.Creator;
      if (this.Date.HasValue)
        dictionary["date"] = (object) this.Date;
      string fileName = this.FileName;
      if ((fileName != null ? (fileName.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["fileName"] = (object) this.FileName;
      nullable = this.ForceProxy;
      if (nullable.HasValue)
        dictionary["forceProxy"] = (object) this.ForceProxy;
      if (this.JpegQuality.HasValue)
        dictionary["jpegQuality"] = (object) this.JpegQuality;
      nullable = this.KeepPNG;
      if (nullable.HasValue)
        dictionary["keepPNG"] = (object) this.KeepPNG;
      string keywords = this.Keywords;
      if ((keywords != null ? (keywords.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["keywords"] = (object) this.Keywords;
      nullable = this.Landscape;
      if (nullable.HasValue)
        dictionary["landscape"] = (object) this.Landscape;
      if (this.Margin != null)
      {
        Dictionary<string, object> source = this.Margin.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["margin"] = (object) source;
      }
      string paperSize = this.PaperSize;
      if ((paperSize != null ? (paperSize.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["paperSize"] = (object) this.PaperSize;
      string proxyUrl = this.ProxyURL;
      if ((proxyUrl != null ? (proxyUrl.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["proxyURL"] = (object) this.ProxyURL;
      string proxyTarget = this.ProxyTarget;
      if ((proxyTarget != null ? (proxyTarget.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["proxyTarget"] = (object) this.ProxyTarget;
      string subject = this.Subject;
      if ((subject != null ? (subject.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["subject"] = (object) this.Subject;
      string title = this.Title;
      if ((title != null ? (title.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["title"] = (object) this.Title;
      return dictionary;
    }
  }
}
