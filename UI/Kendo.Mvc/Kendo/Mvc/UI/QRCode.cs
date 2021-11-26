// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.QRCode
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class QRCode : WidgetBase
  {
    public QRCode(ViewContext viewContext)
      : base(viewContext)
    {
      this.ErrorCorrection = new QRErrorCorrectionLevel?(QRErrorCorrectionLevel.L);
      this.Encoding = new QREncoding?(QREncoding.ISO_8859_1);
    }

    protected override void WriteHtml(TextWriter writer)
    {
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes);
      tag.AddCssClass("k-qrcode");
      tag.WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (QRCode), (IDictionary<string, object>) dictionary));
    }

    public string Background { get; set; }

    public QRCodeBorderSettings Border { get; } = new QRCodeBorderSettings();

    public string Color { get; set; }

    public QRCodeOverlaySettings Overlay { get; } = new QRCodeOverlaySettings();

    public double? Padding { get; set; }

    public RenderingMode? RenderAs { get; set; }

    public double? Size { get; set; }

    public string Value { get; set; }

    public QREncoding? Encoding { get; set; }

    public QRErrorCorrectionLevel? ErrorCorrection { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      string background = this.Background;
      if ((background != null ? (background.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["background"] = (object) this.Background;
      Dictionary<string, object> source1 = this.Border.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary1["border"] = (object) source1;
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["color"] = (object) this.Color;
      Dictionary<string, object> source2 = this.Overlay.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary1["overlay"] = (object) source2;
      double? nullable = this.Padding;
      if (nullable.HasValue)
        dictionary1["padding"] = (object) this.Padding;
      RenderingMode? renderAs = this.RenderAs;
      if (renderAs.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        renderAs = this.RenderAs;
        ref RenderingMode? local = ref renderAs;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["renderAs"] = (object) str;
      }
      nullable = this.Size;
      if (nullable.HasValue)
        dictionary1["size"] = (object) this.Size;
      string str1 = this.Value;
      if ((str1 != null ? (str1.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["value"] = (object) this.Value;
      QREncoding? encoding = this.Encoding;
      if (encoding.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        encoding = this.Encoding;
        ref QREncoding? local = ref encoding;
        string str2 = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["encoding"] = (object) str2;
      }
      QRErrorCorrectionLevel? errorCorrection = this.ErrorCorrection;
      if (errorCorrection.HasValue)
      {
        Dictionary<string, object> dictionary4 = dictionary1;
        errorCorrection = this.ErrorCorrection;
        ref QRErrorCorrectionLevel? local = ref errorCorrection;
        string str3 = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary4["errorCorrection"] = (object) str3;
      }
      return dictionary1;
    }
  }
}
