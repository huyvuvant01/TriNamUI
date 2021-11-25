// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ColorPickerFormatExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI
{
  internal static class ColorPickerFormatExtensions
  {
    internal static string Serialize(this ColorPickerFormat value)
    {
      if (value == ColorPickerFormat.Hex)
        return "hex";
      return value == ColorPickerFormat.Rgb ? "rgb" : value.ToString();
    }
  }
}
