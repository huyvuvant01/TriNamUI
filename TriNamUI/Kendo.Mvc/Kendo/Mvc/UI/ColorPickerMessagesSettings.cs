// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ColorPickerMessagesSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class ColorPickerMessagesSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string Apply { get; set; }

    public string Cancel { get; set; }

    public string ClearColor { get; set; }

    public string PreviewInput { get; set; }

    public string ContrastRatio { get; set; }

    public string Fail { get; set; }

    public string Pass { get; set; }

    public string Gradient { get; set; }

    public string Palette { get; set; }

    public string ToggleFormat { get; set; }

    public string Red { get; set; }

    public string Green { get; set; }

    public string Blue { get; set; }

    public string Hex { get; set; }

    public ColorPicker ColorPicker { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string apply = this.Apply;
      if ((apply != null ? (apply.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["apply"] = (object) this.Apply;
      string cancel = this.Cancel;
      if ((cancel != null ? (cancel.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["cancel"] = (object) this.Cancel;
      string clearColor = this.ClearColor;
      if ((clearColor != null ? (clearColor.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["clearColor"] = (object) this.ClearColor;
      string previewInput = this.PreviewInput;
      if ((previewInput != null ? (previewInput.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["previewInput"] = (object) this.PreviewInput;
      string contrastRatio = this.ContrastRatio;
      if ((contrastRatio != null ? (contrastRatio.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["contrastRatio"] = (object) this.ContrastRatio;
      string fail = this.Fail;
      if ((fail != null ? (fail.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["fail"] = (object) this.Fail;
      string pass = this.Pass;
      if ((pass != null ? (pass.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["pass"] = (object) this.Pass;
      string gradient = this.Gradient;
      if ((gradient != null ? (gradient.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["gradient"] = (object) this.Gradient;
      string palette = this.Palette;
      if ((palette != null ? (palette.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["palette"] = (object) this.Palette;
      string toggleFormat = this.ToggleFormat;
      if ((toggleFormat != null ? (toggleFormat.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["toggleFormat"] = (object) this.ToggleFormat;
      string red = this.Red;
      if ((red != null ? (red.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["red"] = (object) this.Red;
      string green = this.Green;
      if ((green != null ? (green.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["green"] = (object) this.Green;
      string blue = this.Blue;
      if ((blue != null ? (blue.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["blue"] = (object) this.Blue;
      string hex = this.Hex;
      if ((hex != null ? (hex.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["hex"] = (object) this.Hex;
      return dictionary;
    }
  }
}
