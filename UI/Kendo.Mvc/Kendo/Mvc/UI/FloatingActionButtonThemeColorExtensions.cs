// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.FloatingActionButtonThemeColorExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI
{
  internal static class FloatingActionButtonThemeColorExtensions
  {
    internal static string Serialize(this FloatingActionButtonThemeColor value)
    {
      switch (value)
      {
        case FloatingActionButtonThemeColor.Primary:
          return "primary";
        case FloatingActionButtonThemeColor.Secondary:
          return "secondary";
        case FloatingActionButtonThemeColor.Tertiary:
          return "tertiary";
        case FloatingActionButtonThemeColor.Info:
          return "info";
        case FloatingActionButtonThemeColor.Success:
          return "success";
        case FloatingActionButtonThemeColor.Warning:
          return "warning";
        case FloatingActionButtonThemeColor.Error:
          return "error";
        case FloatingActionButtonThemeColor.Dark:
          return "dark";
        case FloatingActionButtonThemeColor.Light:
          return "light";
        default:
          return value.ToString();
      }
    }
  }
}
