// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SpreadsheetSheetRowCellBorderTopSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class SpreadsheetSheetRowCellBorderTopSettingsBuilder
  {
    public SpreadsheetSheetRowCellBorderTopSettingsBuilder(
      SpreadsheetSheetRowCellBorderTopSettings container)
    {
      this.Container = container;
    }

    protected SpreadsheetSheetRowCellBorderTopSettings Container { get; private set; }

    public SpreadsheetSheetRowCellBorderTopSettingsBuilder Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public SpreadsheetSheetRowCellBorderTopSettingsBuilder Size(
      string value)
    {
      this.Container.Size = value;
      return this;
    }
  }
}
