// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ColorPicker
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class ColorPicker : WidgetBase, IFormEditor
  {
    public ColorPicker(ViewContext viewContext)
      : base(viewContext)
    {
      this.Enabled = true;
      this.Palette = new ColorPickerPalette?(ColorPickerPalette.None);
    }

    public IEnumerable<string> PaletteColors { get; set; }

    public bool Enabled { get; set; }

    public IEnumerable<string> Views { get; set; }

    public IEnumerable<string> Formats { get; set; }

    protected override void WriteHtml(TextWriter writer)
    {
      TagBuilder colorInput = this.Generator.GenerateColorInput(this.ViewContext, this.Explorer ?? ExpressionMetadataProvider.FromStringExpression(this.Name, this.HtmlHelper.ViewData, this.HtmlHelper.MetadataProvider), this.Id, this.Name, (object) this.Value, this.HtmlAttributes);
      if (string.IsNullOrEmpty(this.Value))
        colorInput.Attributes.Remove("value");
      if (this.Opacity.HasValue)
        colorInput.Attributes.Remove("type");
      if (!this.Enabled)
        colorInput.MergeAttribute("disabled", "disabled");
      colorInput.WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public IDictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary = this.SerializeSettings();
      ColorPickerPalette? palette = this.Palette;
      ColorPickerPalette colorPickerPalette = ColorPickerPalette.None;
      if (palette.GetValueOrDefault() == colorPickerPalette & palette.HasValue)
      {
        if (this.PaletteColors != null && this.PaletteColors.Any<string>())
          dictionary["palette"] = (object) this.PaletteColors;
        else
          dictionary.Remove("palette");
      }
      if (this.Views != null && this.Views.Any<string>())
        dictionary["views"] = (object) this.Views;
      if (this.Formats != null && this.Formats.Any<string>())
        dictionary["formats"] = (object) this.Formats;
      return (IDictionary<string, object>) dictionary;
    }

    public override void WriteInitializationScript(TextWriter writer) => writer.Write(this.Initializer.Initialize(this.Selector, nameof (ColorPicker), this.Serialize()));

    public bool? Buttons { get; set; }

    public ColorPickerContrastToolSettings ContrastTool { get; } = new ColorPickerContrastToolSettings();

    public bool? CloseOnSelect { get; set; }

    public double? Columns { get; set; }

    public bool? Input { get; set; }

    public ColorPickerTileSizeSettings TileSize { get; } = new ColorPickerTileSizeSettings();

    public ColorPickerMessagesSettings Messages { get; } = new ColorPickerMessagesSettings();

    public bool? Opacity { get; set; }

    public bool? Preview { get; set; }

    public string ToolIcon { get; set; }

    public string Value { get; set; }

    public ColorPickerPalette? Palette { get; set; }

    public ColorPickerFormat? Format { get; set; }

    public ColorPickerView? View { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.Buttons.HasValue)
        dictionary1["buttons"] = (object) this.Buttons;
      Dictionary<string, object> source1 = this.ContrastTool.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary1["contrastTool"] = (object) source1;
      else if (this.ContrastTool.Enabled.HasValue)
        dictionary1["contrastTool"] = (object) this.ContrastTool.Enabled;
      if (this.CloseOnSelect.HasValue)
        dictionary1["closeOnSelect"] = (object) this.CloseOnSelect;
      if (this.Columns.HasValue)
        dictionary1["columns"] = (object) this.Columns;
      if (this.Input.HasValue)
        dictionary1["input"] = (object) this.Input;
      Dictionary<string, object> source2 = this.TileSize.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary1["tileSize"] = (object) source2;
      Dictionary<string, object> source3 = this.Messages.Serialize();
      if (source3.Any<KeyValuePair<string, object>>())
        dictionary1["messages"] = (object) source3;
      if (this.Opacity.HasValue)
        dictionary1["opacity"] = (object) this.Opacity;
      if (this.Preview.HasValue)
        dictionary1["preview"] = (object) this.Preview;
      string toolIcon = this.ToolIcon;
      if ((toolIcon != null ? (toolIcon.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["toolIcon"] = (object) this.ToolIcon;
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
      if (this.Format.HasValue)
      {
        Dictionary<string, object> dictionary3 = dictionary1;
        ColorPickerFormat? format = this.Format;
        ref ColorPickerFormat? local = ref format;
        string str3 = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary3["format"] = (object) str3;
      }
      if (this.View.HasValue)
      {
        Dictionary<string, object> dictionary4 = dictionary1;
        ColorPickerView? view = this.View;
        ref ColorPickerView? local = ref view;
        string str4 = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
        dictionary4["view"] = (object) str4;
      }
      return dictionary1;
    }
  }
}
