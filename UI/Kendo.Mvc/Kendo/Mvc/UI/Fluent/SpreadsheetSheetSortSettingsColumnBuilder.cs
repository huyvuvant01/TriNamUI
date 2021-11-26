// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SpreadsheetSheetSortSettingsColumnBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class SpreadsheetSheetSortSettingsColumnBuilder
  {
    public SpreadsheetSheetSortSettingsColumnBuilder(SpreadsheetSheetSortSettingsColumn container) => this.Container = container;

    protected SpreadsheetSheetSortSettingsColumn Container { get; private set; }

    public SpreadsheetSheetSortSettingsColumnBuilder Ascending(
      bool value)
    {
      this.Container.Ascending = new bool?(value);
      return this;
    }

    public SpreadsheetSheetSortSettingsColumnBuilder Index(
      double value)
    {
      this.Container.Index = new double?(value);
      return this;
    }
  }
}
