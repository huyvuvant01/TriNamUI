﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.FlatColorPickerContrastToolSettings
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class FlatColorPickerContrastToolSettings
  {
    public Dictionary<string, object> Serialize() => this.SerializeSettings();

    public string BackgroundColor { get; set; }

    public bool? Enabled { get; set; }

    public FlatColorPicker FlatColorPicker { get; set; }

    protected virtual Dictionary<string, object> SerializeSettings()
    {
      Dictionary<string, object> dictionary = new Dictionary<string, object>();
      string backgroundColor = this.BackgroundColor;
      if ((backgroundColor != null ? (backgroundColor.HasValue() ? 1 : 0) : 0) != 0)
        dictionary["backgroundColor"] = (object) this.BackgroundColor;
      return dictionary;
    }
  }
}
