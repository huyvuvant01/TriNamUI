// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.QRCodeTagHelper
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Rendering;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.TagHelpers
{
  [HtmlTargetElement("kendo-qrcode")]
  [RestrictChildren("border", new string[] {"overlay"})]
  public class QRCodeTagHelper : TagHelperBase
  {
    public QRCodeTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      QRCodeTagHelper qrCodeTagHelper = this;
      context.Items[(object) qrCodeTagHelper.GetType()] = (object) qrCodeTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await qrCodeTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "div";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "QRCode", (IDictionary<string, object>) this.SerializeSettings());

    protected override Dictionary<string, object> SerializeEvents() => new Dictionary<string, object>();

    public string Background { get; set; }

    [HtmlAttributeNotBound]
    public QRCodeBorderSettingsTagHelper Border { get; set; }

    public string Color { get; set; }

    public QREncoding? Encoding { get; set; }

    public QRErrorCorrectionLevel? ErrorCorrection { get; set; }

    [HtmlAttributeNotBound]
    public QRCodeOverlaySettingsTagHelper Overlay { get; set; }

    public double? Padding { get; set; }

    public RenderingMode? RenderAs { get; set; }

    public double? Size { get; set; }

    public string Value { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      string background = this.Background;
      if ((background != null ? (background.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["background"] = (object) this.Background;
      if (this.Border != null)
      {
        Dictionary<string, object> source = this.Border.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["border"] = (object) source;
      }
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["color"] = (object) this.Color;
      QREncoding? encoding = this.Encoding;
      if (encoding.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        encoding = this.Encoding;
        ref QREncoding? local = ref encoding;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["encoding"] = (object) str;
      }
      QRErrorCorrectionLevel? errorCorrection = this.ErrorCorrection;
      if (errorCorrection.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        errorCorrection = this.ErrorCorrection;
        ref QRErrorCorrectionLevel? local = ref errorCorrection;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["errorCorrection"] = (object) str;
      }
      if (this.Overlay != null)
      {
        Dictionary<string, object> source = this.Overlay.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["overlay"] = (object) source;
      }
      double? nullable = this.Padding;
      if (nullable.HasValue)
        dictionary1["padding"] = (object) this.Padding;
      RenderingMode? renderAs = this.RenderAs;
      if (renderAs.HasValue)
      {
        Dictionary<string, object> dictionary4 = dictionary1;
        renderAs = this.RenderAs;
        ref RenderingMode? local = ref renderAs;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary4["renderAs"] = (object) str;
      }
      nullable = this.Size;
      if (nullable.HasValue)
        dictionary1["size"] = (object) this.Size;
      string str1 = this.Value;
      if ((str1 != null ? (str1.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["value"] = (object) this.Value;
      return dictionary1;
    }
  }
}
