// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.BadgeColorExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI
{
  internal static class BadgeColorExtensions
  {
    internal static string Serialize(this BadgeColor value)
    {
      switch (value)
      {
        case BadgeColor.Inherit:
          return "inherit";
        case BadgeColor.Default:
          return "default";
        case BadgeColor.Primary:
          return "primary";
        case BadgeColor.Secondary:
          return "secondary";
        case BadgeColor.Tertiary:
          return "tertiary";
        case BadgeColor.Info:
          return "info";
        case BadgeColor.Success:
          return "success";
        case BadgeColor.Warning:
          return "warning";
        case BadgeColor.Error:
          return "error";
        case BadgeColor.Dark:
          return "dark";
        case BadgeColor.Light:
          return "light";
        case BadgeColor.Inverted:
          return "inverted";
        default:
          return value.ToString();
      }
    }
  }
}
