// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SpreadsheetSheetSortSettingsColumnFactory
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class SpreadsheetSheetSortSettingsColumnFactory
  {
    public SpreadsheetSheetSortSettingsColumnFactory(
      List<SpreadsheetSheetSortSettingsColumn> container)
    {
      this.Container = container;
    }

    protected List<SpreadsheetSheetSortSettingsColumn> Container { get; private set; }

    public Spreadsheet Spreadsheet { get; set; }

    public virtual SpreadsheetSheetSortSettingsColumnBuilder Add()
    {
      SpreadsheetSheetSortSettingsColumn container = new SpreadsheetSheetSortSettingsColumn();
      container.Spreadsheet = this.Spreadsheet;
      this.Container.Add(container);
      return new SpreadsheetSheetSortSettingsColumnBuilder(container);
    }
  }
}
