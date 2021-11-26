// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.GridPdfSettingsTagHelper
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
  [HtmlTargetElement("pdf", ParentTag = "kendo-grid", TagStructure = TagStructure.NormalOrSelfClosing)]
  [RestrictChildren("grid-pdf-margin", new string[] {})]
  [SuppressTagRendering]
  public class GridPdfSettingsTagHelper : TagHelperChildBase
  {
    public override async 
    #nullable disable
    Task ProcessAsync(TagHelperContext context, TagHelperOutput output) => await base.ProcessAsync(context, output);

    protected override void AddSelfToParent(TagHelperContext context)
    {
      Type type = typeof (GridTagHelper);
      if (!context.Items.ContainsKey((object) type))
        return;
      (context.Items[(object) type] as GridTagHelper).Pdf = this;
    }

    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public bool? AllPages { get; set; }

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
    public GridPdfMarginSettingsTagHelper Margin { get; set; }

    public string PaperSize { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public bool? RepeatHeaders { get; set; }

    public double? Scale { get; set; }

    public string ProxyURL { get; set; }

    public string ProxyTarget { get; set; }

    public string Subject { get; set; }

    public string Title { get; set; }

    internal Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      if (this.AllPages.HasValue)
        dictionary["allPages"] = (object) this.AllPages;
      string author = this.Author;
      if ((author != null ? (author.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["author"] = (object) this.Author;
      if (this.AutoPrint.HasValue)
        dictionary["autoPrint"] = (object) this.AutoPrint;
      if (this.AvoidLinks.HasValue)
        dictionary["avoidLinks"] = (object) this.AvoidLinks;
      string creator = this.Creator;
      if ((creator != null ? (creator.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["creator"] = (object) this.Creator;
      if (this.Date.HasValue)
        dictionary["date"] = (object) this.Date;
      string fileName = this.FileName;
      if ((fileName != null ? (fileName.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["fileName"] = (object) this.FileName;
      if (this.ForceProxy.HasValue)
        dictionary["forceProxy"] = (object) this.ForceProxy;
      if (this.JpegQuality.HasValue)
        dictionary["jpegQuality"] = (object) this.JpegQuality;
      if (this.KeepPNG.HasValue)
        dictionary["keepPNG"] = (object) this.KeepPNG;
      string keywords = this.Keywords;
      if ((keywords != null ? (keywords.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["keywords"] = (object) this.Keywords;
      if (this.Landscape.HasValue)
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
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      if (this.RepeatHeaders.HasValue)
        dictionary["repeatHeaders"] = (object) this.RepeatHeaders;
      if (this.Scale.HasValue)
        dictionary["scale"] = (object) this.Scale;
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
