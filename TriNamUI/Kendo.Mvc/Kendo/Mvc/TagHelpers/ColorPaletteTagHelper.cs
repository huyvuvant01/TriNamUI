// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.TagHelpers.ColorPaletteTagHelper
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
  [HtmlTargetElement("kendo-colorpalette")]
  [RestrictChildren("tile-size", new string[] {})]
  [OutputElementHint("div")]
  public class ColorPaletteTagHelper : TagHelperBase
  {
    public 
    #nullable disable
    string[] PaletteColors { get; set; }

    public ColorPaletteTagHelper(IKendoHtmlGenerator generator)
      : base(generator)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
      ColorPaletteTagHelper paletteTagHelper = this;
      context.Items[(object) paletteTagHelper.GetType()] = (object) paletteTagHelper;
      TagHelperContent childContentAsync = await output.GetChildContentAsync();
      // ISSUE: reference to a compiler-generated method
      await paletteTagHelper.\u003C\u003En__0(context, output);
    }

    protected override void WriteHtml(TagHelperOutput output)
    {
      this.GenerateId(output);
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, (IDictionary<string, object>) new Dictionary<string, object>());
      output.TagName = "div";
      output.MergeAttributes(tag);
    }

    protected override string GetInitializationScript()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      if (this.PaletteColors != null && this.PaletteColors.Length > -1)
        dictionary["palette"] = (object) this.PaletteColors;
      return this.Initializer.Initialize(this.Selector, "ColorPalette", (IDictionary<string, object>) dictionary);
    }

    public string OnChange { get; set; }

    protected override Dictionary<string, object> SerializeEvents()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string onChange = this.OnChange;
      if ((onChange != null ? (onChange.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["change"] = (object) this.CreateHandler(this.OnChange);
      return dictionary;
    }

    public double? Columns { get; set; }

    [HtmlAttributeNotBound]
    public ColorPaletteTileSizeSettingsTagHelper TileSize { get; set; }

    public string Value { get; set; }

    public ColorPickerPalette? Palette { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.Columns.HasValue)
        dictionary1["columns"] = (object) this.Columns;
      if (this.TileSize != null)
      {
        Dictionary<string, object> source = this.TileSize.Serialize();
        if (source.Any<KeyValuePair<string, object>>())
          dictionary1["tileSize"] = (object) source;
      }
      string str1 = this.Value;
      if ((str1 != null ? (str1.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["value"] = (object) this.Value;
      if (this.Palette.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        ColorPickerPalette? palette = this.Palette;
        ref ColorPickerPalette? local = ref palette;
        string str2 = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["palette"] = (object) str2;
      }
      return dictionary1;
    }
  }
}
