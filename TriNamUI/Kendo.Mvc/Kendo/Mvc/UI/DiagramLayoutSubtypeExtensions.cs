// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DiagramLayoutSubtypeExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI
{
  internal static class DiagramLayoutSubtypeExtensions
  {
    internal static string Serialize(this DiagramLayoutSubtype value)
    {
      switch (value)
      {
        case DiagramLayoutSubtype.Down:
          return "down";
        case DiagramLayoutSubtype.Up:
          return "up";
        case DiagramLayoutSubtype.Left:
          return "left";
        case DiagramLayoutSubtype.Right:
          return "right";
        case DiagramLayoutSubtype.Radial:
          return "radial";
        case DiagramLayoutSubtype.Tipover:
          return "tipover";
        case DiagramLayoutSubtype.Mindmapvertical:
          return "mindmapvertical";
        case DiagramLayoutSubtype.Mindmaphorizontal:
          return "mindmaphorizontal";
        default:
          return value.ToString();
      }
    }
  }
}
