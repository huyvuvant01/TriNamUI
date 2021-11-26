// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SpreadsheetDynamicFilterTypeExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI
{
  internal static class SpreadsheetDynamicFilterTypeExtensions
  {
    internal static string Serialize(this SpreadsheetDynamicFilterType value)
    {
      switch (value)
      {
        case SpreadsheetDynamicFilterType.AboveAverage:
          return "aboveAverage";
        case SpreadsheetDynamicFilterType.BelowAverage:
          return "belowAverage";
        case SpreadsheetDynamicFilterType.Tomorrow:
          return "tomorrow";
        case SpreadsheetDynamicFilterType.Today:
          return "today";
        case SpreadsheetDynamicFilterType.Yesterday:
          return "yesterday";
        case SpreadsheetDynamicFilterType.NextWeek:
          return "nextWeek";
        case SpreadsheetDynamicFilterType.ThisWeek:
          return "thisWeek";
        case SpreadsheetDynamicFilterType.LastWeek:
          return "lastWeek";
        case SpreadsheetDynamicFilterType.NextMonth:
          return "nextMonth";
        case SpreadsheetDynamicFilterType.ThisMonth:
          return "thisMonth";
        case SpreadsheetDynamicFilterType.LastMonth:
          return "lastMonth";
        case SpreadsheetDynamicFilterType.NextQuarter:
          return "nextQuarter";
        case SpreadsheetDynamicFilterType.ThisQuarter:
          return "thisQuarter";
        case SpreadsheetDynamicFilterType.LastQuarter:
          return "lastQuarter";
        case SpreadsheetDynamicFilterType.NextYear:
          return "nextYear";
        case SpreadsheetDynamicFilterType.ThisYear:
          return "thisYear";
        case SpreadsheetDynamicFilterType.LastYear:
          return "lastYear";
        case SpreadsheetDynamicFilterType.YearToDate:
          return "yearToDate";
        default:
          return value.ToString();
      }
    }
  }
}
