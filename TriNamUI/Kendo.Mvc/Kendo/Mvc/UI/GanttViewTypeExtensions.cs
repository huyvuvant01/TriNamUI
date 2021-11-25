// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.GanttViewTypeExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI
{
  internal static class GanttViewTypeExtensions
  {
    internal static string Serialize(this GanttViewType value)
    {
      switch (value)
      {
        case GanttViewType.Day:
          return "day";
        case GanttViewType.Week:
          return "week";
        case GanttViewType.Month:
          return "month";
        case GanttViewType.Year:
          return "year";
        default:
          return value.ToString();
      }
    }
  }
}
