// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.FloatingActionButtonAlignExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI
{
  internal static class FloatingActionButtonAlignExtensions
  {
    internal static string Serialize(this FloatingActionButtonAlign value)
    {
      switch (value)
      {
        case FloatingActionButtonAlign.TopStart:
          return "top start";
        case FloatingActionButtonAlign.TopCenter:
          return "top center";
        case FloatingActionButtonAlign.TopEnd:
          return "top end";
        case FloatingActionButtonAlign.MiddleStart:
          return "middle start";
        case FloatingActionButtonAlign.MiddleEnd:
          return "middle end";
        case FloatingActionButtonAlign.BottomStart:
          return "bottom start";
        case FloatingActionButtonAlign.BottomCenter:
          return "bottom center";
        case FloatingActionButtonAlign.BottomEnd:
          return "bottom end";
        default:
          return value.ToString();
      }
    }
  }
}
