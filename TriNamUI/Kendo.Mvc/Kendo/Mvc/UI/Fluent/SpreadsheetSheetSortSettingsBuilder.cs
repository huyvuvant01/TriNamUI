// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SpreadsheetSheetSortSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class SpreadsheetSheetSortSettingsBuilder
  {
    public SpreadsheetSheetSortSettingsBuilder(SpreadsheetSheetSortSettings container) => this.Container = container;

    protected SpreadsheetSheetSortSettings Container { get; private set; }

    public SpreadsheetSheetSortSettingsBuilder Columns(
      Action<SpreadsheetSheetSortSettingsColumnFactory> configurator)
    {
      configurator(new SpreadsheetSheetSortSettingsColumnFactory(this.Container.Columns)
      {
        Spreadsheet = this.Container.Spreadsheet
      });
      return this;
    }

    public SpreadsheetSheetSortSettingsBuilder Ref(string value)
    {
      this.Container.Ref = value;
      return this;
    }
  }
}
