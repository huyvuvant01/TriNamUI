// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SpreadsheetSheetRowBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class SpreadsheetSheetRowBuilder
  {
    public SpreadsheetSheetRowBuilder(SpreadsheetSheetRow container) => this.Container = container;

    protected SpreadsheetSheetRow Container { get; private set; }

    public SpreadsheetSheetRowBuilder Cells(
      Action<SpreadsheetSheetRowCellFactory> configurator)
    {
      configurator(new SpreadsheetSheetRowCellFactory(this.Container.Cells)
      {
        Spreadsheet = this.Container.Spreadsheet
      });
      return this;
    }

    public SpreadsheetSheetRowBuilder Height(double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }

    public SpreadsheetSheetRowBuilder Index(int value)
    {
      this.Container.Index = new int?(value);
      return this;
    }

    public SpreadsheetSheetRowBuilder Type(string value)
    {
      this.Container.Type = value;
      return this;
    }
  }
}
