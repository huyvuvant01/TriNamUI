// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SpreadsheetTextAlignExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI
{
  internal static class SpreadsheetTextAlignExtensions
  {
    internal static string Serialize(this SpreadsheetTextAlign value)
    {
      switch (value)
      {
        case SpreadsheetTextAlign.Left:
          return "left";
        case SpreadsheetTextAlign.Right:
          return "right";
        case SpreadsheetTextAlign.Center:
          return "center";
        case SpreadsheetTextAlign.Justify:
          return "justify";
        default:
          return value.ToString();
      }
    }
  }
}
