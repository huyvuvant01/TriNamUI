// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DashTypeExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI
{
  internal static class DashTypeExtensions
  {
    internal static string Serialize(this DashType value)
    {
      switch (value)
      {
        case DashType.Solid:
          return "solid";
        case DashType.Dot:
          return "dot";
        case DashType.Dash:
          return "dash";
        case DashType.LongDash:
          return "longDash";
        case DashType.DashDot:
          return "dashDot";
        case DashType.LongDashDot:
          return "longDashDot";
        case DashType.LongDashDotDot:
          return "longDashDotDot";
        default:
          return value.ToString();
      }
    }
  }
}
