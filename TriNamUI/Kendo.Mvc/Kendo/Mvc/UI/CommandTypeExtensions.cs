// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.CommandTypeExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI
{
  internal static class CommandTypeExtensions
  {
    internal static string Serialize(this CommandType value)
    {
      switch (value)
      {
        case CommandType.Button:
          return "button";
        case CommandType.SplitButton:
          return "splitButton";
        case CommandType.ButtonGroup:
          return "buttonGroup";
        case CommandType.Separator:
          return "separator";
        case CommandType.Spacer:
          return "spacer";
        default:
          return value.ToString();
      }
    }
  }
}
