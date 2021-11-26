// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.LoaderThemeColorExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI
{
  internal static class LoaderThemeColorExtensions
  {
    internal static string Serialize(this LoaderThemeColor value)
    {
      switch (value)
      {
        case LoaderThemeColor.Primary:
          return "primary";
        case LoaderThemeColor.Secondary:
          return "secondary";
        case LoaderThemeColor.Tertiary:
          return "tertiary";
        case LoaderThemeColor.Info:
          return "info";
        case LoaderThemeColor.Success:
          return "success";
        case LoaderThemeColor.Warning:
          return "warning";
        case LoaderThemeColor.Error:
          return "error";
        case LoaderThemeColor.Dark:
          return "dark";
        case LoaderThemeColor.Light:
          return "light";
        case LoaderThemeColor.Inverse:
          return "inverse";
        default:
          return value.ToString();
      }
    }
  }
}
