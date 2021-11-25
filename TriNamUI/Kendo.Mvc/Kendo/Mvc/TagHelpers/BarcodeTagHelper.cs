// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.BarcodeTagHelper
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
  [HtmlTargetElement("kendo-barcode")]
  [RestrictChildren("border", new string[] {"padding", "barcode-text"})]
  public class BarcodeTagHelper : TagHelperBase
  {
    public BarcodeTagHelper(
    #nullable disable
    IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      BarcodeTagHelper barcodeTagHelper = this;
      context.Items[(object) barcodeTagHelper.GetType()] = (object) barcodeTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await barcodeTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "div";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript() => this.Initializer.Initialize(this.Selector, "Barcode", (IDictionary<string, object>) this.SerializeSettings());

    protected override Dictionary<string, object> SerializeEvents() => new Dictionary<string, object>();

    public RenderingMode? RenderAs { get; set; }

    public string Background { get; set; }

    [HtmlAttributeNotBound]
    public BarcodeBorderSettingsTagHelper Border { get; set; }

    public bool? Checksum { get; set; }

    public string Color { get; set; }

    public double? Height { get; set; }

    [HtmlAttributeNotBound]
    public BarcodePaddingSettingsTagHelper Padding { get; set; }

    [HtmlAttributeNotBound]
    public BarcodeTextSettingsTagHelper Text { get; set; }

    public BarcodeSymbology? Type { get; set; }

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
      if (this.Border != null)
      {
        Dictionary<string, object> source = this.Border.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["border"] = (object) source;
      }
      if (this.Checksum.HasValue)
        dictionary1["checksum"] = (object) this.Checksum;
      string color = this.Color;
      if ((color != null ? (color.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["color"] = (object) this.Color;
      if (this.Height.HasValue)
        dictionary1["height"] = (object) this.Height;
      if (this.Padding != null)
      {
        Dictionary<string, object> source = this.Padding.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["padding"] = (object) source;
      }
      if (this.Text != null)
      {
        Dictionary<string, object> source = this.Text.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["text"] = (object) source;
      }
      if (this.Type.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        BarcodeSymbology? type = this.Type;
        ref BarcodeSymbology? local = ref type;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["type"] = (object) str;
      }
      string str1 = this.Value;
      if ((str1 != null ? (str1.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["value"] = (object) this.Value;
      if (this.Width.HasValue)
        dictionary1["width"] = (object) this.Width;
      return dictionary1;
    }
  }
}
