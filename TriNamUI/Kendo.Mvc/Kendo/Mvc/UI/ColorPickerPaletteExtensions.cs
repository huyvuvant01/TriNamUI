﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ColorPickerPaletteExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI
{
  internal static class ColorPickerPaletteExtensions
  {
    internal static string Serialize(this ColorPickerPalette value)
    {
      switch (value)
      {
        case ColorPickerPalette.None:
          return "none";
        case ColorPickerPalette.Basic:
          return "basic";
        case ColorPickerPalette.WebSafe:
          return "websafe";
        default:
          return value.ToString();
      }
    }
  }
}
