// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.FloatingActionButtonShapeExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI
{
  internal static class FloatingActionButtonShapeExtensions
  {
    internal static string Serialize(this FloatingActionButtonShape value)
    {
      switch (value)
      {
        case FloatingActionButtonShape.Rectangle:
          return "rectangle";
        case FloatingActionButtonShape.Rounded:
          return "rounded";
        case FloatingActionButtonShape.Pill:
          return "pill";
        case FloatingActionButtonShape.Circle:
          return "circle";
        default:
          return value.ToString();
      }
    }
  }
}
