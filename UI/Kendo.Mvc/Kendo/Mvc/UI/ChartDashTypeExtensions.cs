// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartDashTypeExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI
{
  internal static class ChartDashTypeExtensions
  {
    internal static string Serialize(this ChartDashType value)
    {
      switch (value)
      {
        case ChartDashType.Solid:
          return "solid";
        case ChartDashType.Dot:
          return "dot";
        case ChartDashType.Dash:
          return "dash";
        case ChartDashType.LongDash:
          return "longDash";
        case ChartDashType.DashDot:
          return "dashDot";
        case ChartDashType.LongDashDot:
          return "longDashDot";
        case ChartDashType.LongDashDotDot:
          return "longDashDotDot";
        default:
          return value.ToString();
      }
    }
  }
}
