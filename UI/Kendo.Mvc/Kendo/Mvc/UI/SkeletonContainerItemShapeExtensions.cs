// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SkeletonContainerItemShapeExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI
{
  internal static class SkeletonContainerItemShapeExtensions
  {
    internal static string Serialize(this SkeletonContainerItemShape value)
    {
      switch (value)
      {
        case SkeletonContainerItemShape.Rectangle:
          return "rectangle";
        case SkeletonContainerItemShape.Text:
          return "text";
        case SkeletonContainerItemShape.Circle:
          return "circle";
        default:
          return value.ToString();
      }
    }
  }
}
