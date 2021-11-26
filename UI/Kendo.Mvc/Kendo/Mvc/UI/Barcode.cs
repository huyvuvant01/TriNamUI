// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Barcode
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Resources;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class Barcode : WidgetBase
  {
    public Barcode(ViewContext viewContext)
      : base(viewContext)
    {
      this.Encoding = BarcodeSymbology.Code128;
      this.Text = new BarcodeTextSettings();
      this.Text.Visible = new bool?(true);
    }

    public BarcodeSymbology Encoding { get; set; }

    protected override void WriteHtml(TextWriter writer)
    {
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes);
      tag.AddCssClass("k-barcode");
      tag.WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      dictionary["type"] = (object) this.Encoding;
      if (this.Encoding == BarcodeSymbology.GS1128)
        dictionary["type"] = (object) "gs1-128";
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (Barcode), (IDictionary<string, object>) dictionary));
    }

    public override void VerifySettings()
    {
      base.VerifySettings();
      if (string.IsNullOrEmpty(this.Value))
        throw new ArgumentException(Exceptions.CannotBeNullOrEmpty.FormatWith((object) "Value"));
      if (this.Encoding == BarcodeSymbology.EAN8 && this.Value.Length != 7)
        throw new ArgumentException(Exceptions.ValueNotValidForProperty.FormatWith((object) "Value"));
    }

    public RenderingMode? RenderAs { get; set; }

    public string Background { get; set; }

    public BarcodeBorderSettings Border { get; } = new BarcodeBorderSettings();

    public bool? Checksum { get; set; }

    public string Color { get; set; }

    public double? Height { get; set; }

    public BarcodePaddingSettings Padding { get; } = new BarcodePaddingSettings();

    public BarcodeTextSettings Text { get; } = new BarcodeTextSettings();

    public string Value { get; set; }

    public double? Width { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.RenderAs.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        RenderingMode? renderAs = this.RenderAs;
        ref RenderingMode? local = ref renderAs;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["renderAs"] = (object) str;
      }
      string background = this.Background;
      if ((background != null ? (background.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["background"] = (object) this.Background;
      Dictionary<string, object> source1 = this.Border.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary1["border"] = (object) source1;
      if (this.Checksum.HasValue)
        dictionary1["checksum"] = (object) this.Checksum;
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["color"] = (object) this.Color;
      if (this.Height.HasValue)
        dictionary1["height"] = (object) this.Height;
      Dictionary<string, object> source2 = this.Padding.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary1["padding"] = (object) source2;
      Dictionary<string, object> source3 = this.Text.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary1["text"] = (object) source3;
      string str1 = this.Value;
      if ((str1 != null ? (str1.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["value"] = (object) this.Value;
      if (this.Width.HasValue)
        dictionary1["width"] = (object) this.Width;
      return dictionary1;
    }
  }
}
