// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartAxisBaseUnitExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI
{
  internal static class ChartAxisBaseUnitExtensions
  {
    internal static string Serialize(this ChartAxisBaseUnit value)
    {
      switch (value)
      {
        case ChartAxisBaseUnit.Seconds:
          return "seconds";
        case ChartAxisBaseUnit.Minutes:
          return "minutes";
        case ChartAxisBaseUnit.Hours:
          return "hours";
        case ChartAxisBaseUnit.Days:
          return "days";
        case ChartAxisBaseUnit.Weeks:
          return "weeks";
        case ChartAxisBaseUnit.Months:
          return "months";
        case ChartAxisBaseUnit.Years:
          return "years";
        case ChartAxisBaseUnit.Fit:
          return "fit";
        default:
          return value.ToString();
      }
    }
  }
}
