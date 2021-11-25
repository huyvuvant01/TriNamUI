// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ColorPalette
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
  public class ColorPalette : WidgetBase
  {
    public const int ColumnsDefault = 10;

    public ColorPalette(ViewContext viewContext)
      : base(viewContext)
    {
      this.Palette = new ColorPickerPalette?(ColorPickerPalette.Basic);
      this.Columns = new int?(10);
    }

    public IEnumerable<string> PaletteColors { get; set; }

    public ColorPickerPalette? Palette { get; set; }

    protected override void WriteHtml(TextWriter writer)
    {
      this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes).WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary1 = this.SerializeSettings();
      int? columns = this.Columns;
      int num = 10;
      if (columns.GetValueOrDefault() == num & columns.HasValue)
        dictionary1.Remove("columns");
      if (this.Palette.HasValue)
      {
        Dictionary<string, object> dictionary2 = dictionary1;
        ColorPickerPalette? palette = this.Palette;
        ref ColorPickerPalette? local = ref palette;
        string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary2["palette"] = (object) str;
        palette = this.Palette;
        ColorPickerPalette colorPickerPalette = ColorPickerPalette.None;
        if (palette.GetValueOrDefault() == colorPickerPalette & palette.HasValue)
        {
          if (this.PaletteColors != null && this.PaletteColors.Any<string>())
            dictionary1["palette"] = (object) this.PaletteColors;
          else
            dictionary1.Remove("palette");
        }
      }
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (ColorPalette), (IDictionary<string, object>) dictionary1));
    }

    public int? Columns { get; set; }

    public ColorPaletteTileSizeSettings TileSize { get; } = new ColorPaletteTileSizeSettings();

    public string Value { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = base.SerializeSettings();
      if (this.Columns.HasValue)
        dictionary["columns"] = (object) this.Columns;
      Dictionary<string, object> source = this.TileSize.Serialize();
      if (source.Any<KeyValuePair<string, object>>())
        dictionary["tileSize"] = (object) source;
      string str = this.Value;
      if ((str != null ? (str.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["value"] = (object) this.Value;
      return dictionary;
    }
  }
}
