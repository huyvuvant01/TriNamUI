// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.EditorTool
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
  public class EditorTool
  {
    public IEnumerable<string> PaletteColors { get; set; } = (IEnumerable<string>) new List<string>();

    public Dictionary<string, object> Serialize()
    {
      Dictionary<string, object> dictionary1 = this.SerializeSettings();
      ColorPickerPalette? palette;
      if (this.Palette.HasValue)
      {
        palette = this.Palette;
        ColorPickerPalette colorPickerPalette = ColorPickerPalette.None;
        if (!(palette.GetValueOrDefault() == colorPickerPalette & palette.HasValue))
        {
          Dictionary<string, object> dictionary2 = dictionary1;
          palette = this.Palette;
          ref ColorPickerPalette? local = ref palette;
          string str = local.HasValue ? local.GetValueOrDefault().Serialize() : (string) null;
          dictionary2["palette"] = (object) str;
          goto label_7;
        }
      }
      palette = this.Palette;
      ColorPickerPalette colorPickerPalette1 = ColorPickerPalette.None;
      if (palette.GetValueOrDefault() == colorPickerPalette1 & palette.HasValue)
        dictionary1["palette"] = (object) null;
      else if (this.PaletteColors != null && this.PaletteColors.Any<string>())
        dictionary1["palette"] = (object) this.PaletteColors;
label_7:
      return dictionary1;
    }

    public string Name { get; set; }

    public string Tooltip { get; set; }

    public ClientHandlerDescriptor Exec { get; set; }

    public List<EditorToolItem> Items { get; set; } = new List<EditorToolItem>();

    public int? Columns { get; set; }

    public string Template { get; set; }

    public string TemplateId { get; set; }

    public ColorPickerPalette? Palette { get; set; }

    public Editor Editor { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string name = this.Name;
      if ((name != null ? (name.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["name"] = (object) this.Name;
      string tooltip = this.Tooltip;
      if ((tooltip != null ? (tooltip.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["tooltip"] = (object) this.Tooltip;
      ClientHandlerDescriptor exec = this.Exec;
      if ((exec != null ? (exec.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["exec"] = (object) this.Exec;
      IEnumerable<Dictionary<string, object>> source = this.Items.Select<EditorToolItem, Dictionary<string, object>>((Func<EditorToolItem, Dictionary<string, object>>) (i => i.Serialize()));
      if (source.Any<Dictionary<string, object>>())
        dictionary["items"] = (object) source;
      if (this.Columns.HasValue)
        dictionary["columns"] = (object) this.Columns;
      if (this.TemplateId.HasValue())
        dictionary["template"] = (object) new ClientHandlerDescriptor()
        {
          HandlerName = string.Format("jQuery('{0}{1}').html()", (object) this.Editor.IdPrefix, (object) this.TemplateId)
        };
      else if (this.Template.HasValue())
        dictionary["template"] = (object) this.Template;
      return dictionary;
    }
  }
}
