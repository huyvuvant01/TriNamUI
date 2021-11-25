// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.BottomNavigationThemeColorExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI
{
  internal static class BottomNavigationThemeColorExtensions
  {
    internal static string Serialize(this BottomNavigationThemeColor value)
    {
      switch (value)
      {
        case BottomNavigationThemeColor.Inherit:
          return "inherit";
        case BottomNavigationThemeColor.Default:
          return "default";
        case BottomNavigationThemeColor.Primary:
          return "primary";
        case BottomNavigationThemeColor.Secondary:
          return "secondary";
        case BottomNavigationThemeColor.Tertiary:
          return "tertiary";
        case BottomNavigationThemeColor.Info:
          return "info";
        case BottomNavigationThemeColor.Success:
          return "success";
        case BottomNavigationThemeColor.Warning:
          return "warning";
        case BottomNavigationThemeColor.Error:
          return "error";
        case BottomNavigationThemeColor.Dark:
          return "dark";
        case BottomNavigationThemeColor.Light:
          return "light";
        case BottomNavigationThemeColor.Inverse:
          return "inverse";
        default:
          return value.ToString();
      }
    }
  }
}
