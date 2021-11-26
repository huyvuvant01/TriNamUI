// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DiagramPannableKeyExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI
{
  internal static class DiagramPannableKeyExtensions
  {
    internal static string Serialize(this DiagramPannableKey value)
    {
      switch (value)
      {
        case DiagramPannableKey.None:
          return "none";
        case DiagramPannableKey.Ctrl:
          return "ctrl";
        case DiagramPannableKey.Shift:
          return "shift";
        case DiagramPannableKey.Alt:
          return "alt";
        default:
          return value.ToString();
      }
    }
  }
}
