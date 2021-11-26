// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.ChartSeriesStyleExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI
{
  internal static class ChartSeriesStyleExtensions
  {
    internal static string Serialize(this ChartSeriesStyle value)
    {
      switch (value)
      {
        case ChartSeriesStyle.Normal:
          return "normal";
        case ChartSeriesStyle.Smooth:
          return "smooth";
        case ChartSeriesStyle.Step:
          return "step";
        default:
          return value.ToString();
      }
    }
  }
}
