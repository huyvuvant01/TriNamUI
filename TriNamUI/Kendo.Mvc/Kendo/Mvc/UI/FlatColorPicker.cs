// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.FlatColorPicker
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
  public class FlatColorPicker : WidgetBase
  {
    public FlatColorPicker(ViewContext viewContext)
      : base(viewContext)
    {
      this.Enabled = true;
      this.Buttons = new bool?(false);
      this.Preview = new bool?(true);
    }

    public bool Enabled { get; set; }

    public IEnumerable<string> PaletteColors { get; set; }

    public IEnumerable<string> Formats { get; set; }

    public IEnumerable<string> Views { get; set; }

    protected override void WriteHtml(TextWriter writer)
    {
      TagBuilder tag = this.Generator.GenerateTag("div", this.ViewContext, this.Id, this.Name, this.HtmlAttributes);
      tag.AddCssClass("k-flatcolorpicker");
      if (!this.Enabled)
        tag.MergeAttribute("disabled", "disabled");
      tag.WriteTo(writer, this.HtmlEncoder);
      base.WriteHtml(writer);
    }

    public override void WriteInitializationScript(TextWriter writer)
    {
      Dictionary<string, object> dictionary1 = this.SerializeSettings();
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
      if (this.Formats != null && this.Formats.Any<string>())
        dictionary1["formats"] = (object) this.Formats;
      if (this.Views != null && this.Views.Any<string>())
        dictionary1["views"] = (object) this.Views;
      writer.Write(this.Initializer.Initialize(this.Selector, nameof (FlatColorPicker), (IDictionary<string, object>) dictionary1));
    }

    public bool? Opacity { get; set; }

    public bool? Buttons { get; set; }

    public double? Columns { get; set; }

    public FlatColorPickerContrastToolSettings ContrastTool { get; } = new FlatColorPickerContrastToolSettings();

    public bool? Input { get; set; }

    public string Value { get; set; }

    public bool? Preview { get; set; }

    public bool? Autoupdate { get; set; }

    public FlatColorPickerMessagesSettings Messages { get; } = new FlatColorPickerMessagesSettings();

    public ColorPickerPalette? Palette { get; set; }

    public ColorPickerFormat? Format { get; set; }

    protected override Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary1 = base.SerializeSettings();
      if (this.Opacity.HasValue)
        dictionary1["opacity"] = (object) this.Opacity;
      if (this.Buttons.HasValue)
        dictionary1["buttons"] = (object) this.Buttons;
      if (this.Columns.HasValue)
        dictionary1["columns"] = (object) this.Columns;
      Dictionary<string, object> source1 = this.ContrastTool.Serialize();
      if (source1.Any<KeyValuePair<string, object>>())
        dictionary1["contrastTool"] = (object) source1;
      else if (this.ContrastTool.Enabled.HasValue)
        dictionary1["contrastTool"] = (object) this.ContrastTool.Enabled;
      if (this.Input.HasValue)
        dictionary1["input"] = (object) this.Input;
      string str1 = this.Value;
      if ((str1 != null ? (str1.HasValue() ? 1 : 0) : 0) != 0)
        dictionary1["value"] = (object) this.Value;
      if (this.Preview.HasValue)
        dictionary1["preview"] = (object) this.Preview;
      if (this.Autoupdate.HasValue)
        dictionary1["autoupdate"] = (object) this.Autoupdate;
      Dictionary<string, object> source2 = this.Messages.Serialize();
      if (source2.Any<KeyValuePair<string, object>>())
        dictionary1["messages"] = (object) source2;
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
      return dictionary1;
    }
  }
}
