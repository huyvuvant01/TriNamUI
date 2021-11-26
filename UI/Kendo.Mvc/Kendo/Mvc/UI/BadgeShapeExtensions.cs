// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.BadgeShapeExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI
{
  internal static class BadgeShapeExtensions
  {
    internal static string Serialize(this BadgeShape value)
    {
      switch (value)
      {
        case BadgeShape.Rectangle:
          return "rectangle";
        case BadgeShape.Rounded:
          return "rounded";
        case BadgeShape.Pill:
          return "pill";
        case BadgeShape.Circle:
          return "circle";
        case BadgeShape.Dot:
          return "dot";
        default:
          return value.ToString();
      }
    }
  }
}
