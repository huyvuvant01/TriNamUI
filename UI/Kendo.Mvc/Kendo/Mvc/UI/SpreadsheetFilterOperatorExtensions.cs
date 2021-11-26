// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.SpreadsheetFilterOperatorExtensions
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI
{
  internal static class SpreadsheetFilterOperatorExtensions
  {
    internal static string Serialize(this SpreadsheetFilterOperator value)
    {
      switch (value)
      {
        case SpreadsheetFilterOperator.Contains:
          return "contains";
        case SpreadsheetFilterOperator.DoesNotContain:
          return "doesnotcontain";
        case SpreadsheetFilterOperator.StartsWith:
          return "startswith";
        case SpreadsheetFilterOperator.EndsWith:
          return "endswith";
        case SpreadsheetFilterOperator.EqualTo:
          return "eq";
        case SpreadsheetFilterOperator.NotEqualTo:
          return "neq";
        case SpreadsheetFilterOperator.LowerThan:
          return "lt";
        case SpreadsheetFilterOperator.GreaterThan:
          return "gt";
        case SpreadsheetFilterOperator.GreaterThanOrEqualTo:
          return "gte";
        case SpreadsheetFilterOperator.LowerThanOrEqualTo:
          return "lte";
        default:
          return value.ToString();
      }
    }
  }
}
