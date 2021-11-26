// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.PDFViewerTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-pdfviewer")]
  [RestrictChildren("dpl-processing", new string[] {"pdfjs-processing", "view", "toolbar", "messages"})]
  public class PDFViewerTagHelper : TagHelperBase
  {
    public PDFViewerTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      PDFViewerTagHelper pdfViewerTagHelper = this;
      context.Items[(object) pdfViewerTagHelper.GetType()] = (object) pdfViewerTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await pdfViewerTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "div";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "PDFViewer", (IDictionary<string, object>) this.SerializeSettings());

    public string OnRender { get; set; }

    public string OnOpen { get; set; }

    public string OnError { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onRender = this.OnRender;
      if ((onRender != null ? (onRender.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["render"] = (object) this.CreateHandler(this.OnRender);
      string onOpen = this.OnOpen;
      if ((onOpen != null ? (onOpen.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["open"] = (object) this.CreateHandler(this.OnOpen);
      string onError = this.OnError;
      if ((onError != null ? (onError.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["error"] = (object) this.CreateHandler(this.OnError);
      return dictionary;
    }

    [HtmlAttributeNotBound]
    public PDFViewerPdfjsProcessingSettingsTagHelper PdfjsProcessing { get; set; }

    [HtmlAttributeNotBound]
    public PDFViewerDplProcessingSettingsTagHelper DplProcessing { get; set; }

    public double? Width { get; set; }

    public double? Height { get; set; }

    [HtmlAttributeNotBound]
    public PDFViewerDefaultPageSizeSettingsTagHelper DefaultPageSize { get; set; }

    public double? Page { get; set; }

    public double? Scale { get; set; }

    public double? ZoomMin { get; set; }

    public double? ZoomMax { get; set; }

    public double? ZoomRate { get; set; }

    [HtmlAttributeNotBound]
    public PDFViewerViewSettingsTagHelper View { get; set; }

    [HtmlAttributeNotBound]
    public PDFViewerToolbarSettingsTagHelper Toolbar { get; set; }

    [HtmlAttributeNotBound]
    public PDFViewerMessagesSettingsTagHelper Messages { get; set; }

    public string Document { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.PdfjsProcessing != null)
      {
        Dictionary<string, object> source = this.PdfjsProcessing.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["pdfjsProcessing"] = (object) source;
      }
      if (this.DplProcessing != null)
      {
        Dictionary<string, object> source = this.DplProcessing.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["dplProcessing"] = (object) source;
      }
      if (this.Width.HasValue)
        dictionary["width"] = (object) this.Width;
      if (this.Height.HasValue)
        dictionary["height"] = (object) this.Height;
      if (this.DefaultPageSize != null)
      {
        Dictionary<string, object> source = this.DefaultPageSize.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["defaultPageSize"] = (object) source;
      }
      if (this.Page.HasValue)
        dictionary["page"] = (object) this.Page;
      if (this.Scale.HasValue)
        dictionary["scale"] = (object) this.Scale;
      if (this.ZoomMin.HasValue)
        dictionary["zoomMin"] = (object) this.ZoomMin;
      if (this.ZoomMax.HasValue)
        dictionary["zoomMax"] = (object) this.ZoomMax;
      if (this.ZoomRate.HasValue)
        dictionary["zoomRate"] = (object) this.ZoomRate;
      if (this.View != null)
      {
        Dictionary<string, object> source = this.View.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["view"] = (object) source;
      }
      if (this.Toolbar != null)
      {
        Dictionary<string, object> source = this.Toolbar.Serialize();
        if (source.Any<KeyValuePair<string, object>>() && (!this.Toolbar.Enabled.HasValue || this.Toolbar.Enabled.Value))
          dictionary["toolbar"] = (object) source;
        else if (this.Toolbar.Enabled.HasValue && !this.Toolbar.Enabled.Value)
          dictionary["toolbar"] = (object) this.Toolbar.Enabled;
      }
      if (this.Messages != null)
      {
        Dictionary<string, object> source = this.Messages.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary["messages"] = (object) source;
      }
      string document = this.Document;
      if ((document != null ? (document.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["document"] = (object) this.CreateHandler(this.Document);
      return dictionary;
    }
  }
}
