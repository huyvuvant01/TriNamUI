// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SpreadsheetBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class SpreadsheetBuilder : WidgetBuilderBase<Spreadsheet, SpreadsheetBuilder>
  {
    public SpreadsheetBuilder(Spreadsheet component)
      : base(component)
    {
    }

    public SpreadsheetBuilder BindTo(IEnumerable<SpreadsheetSheet> value)
    {
      this.Container.Sheets.Clear();
      this.Container.Sheets.AddRange(value);
      return this;
    }

    public SpreadsheetBuilder BindTo(Dictionary<string, object> workbook)
    {
      this.Container.DplSettings = workbook;
      return this;
    }

    public SpreadsheetBuilder Images(object value)
    {
      this.Container.Images = value;
      return this;
    }

    public SpreadsheetBuilder Toolbar(
      Action<SpreadsheetToolbarSettingsBuilder> configurator)
    {
      this.Container.Toolbar.Enabled = new bool?(true);
      this.Container.Toolbar.Spreadsheet = this.Container;
      configurator(new SpreadsheetToolbarSettingsBuilder(this.Container.Toolbar));
      return this;
    }

    public SpreadsheetBuilder Toolbar(bool enabled)
    {
      this.Container.Toolbar.Enabled = new bool?(enabled);
      return this;
    }

    public SpreadsheetBuilder ActiveSheet(string value)
    {
      this.Container.ActiveSheet = value;
      return this;
    }

    public SpreadsheetBuilder ColumnWidth(double value)
    {
      this.Container.ColumnWidth = new double?(value);
      return this;
    }

    public SpreadsheetBuilder Columns(double value)
    {
      this.Container.Columns = new double?(value);
      return this;
    }

    public SpreadsheetBuilder DefaultCellStyle(
      Action<SpreadsheetDefaultCellStyleSettingsBuilder> configurator)
    {
      this.Container.DefaultCellStyle.Spreadsheet = this.Container;
      configurator(new SpreadsheetDefaultCellStyleSettingsBuilder(this.Container.DefaultCellStyle));
      return this;
    }

    public SpreadsheetBuilder HeaderHeight(double value)
    {
      this.Container.HeaderHeight = new double?(value);
      return this;
    }

    public SpreadsheetBuilder HeaderWidth(double value)
    {
      this.Container.HeaderWidth = new double?(value);
      return this;
    }

    public SpreadsheetBuilder Excel(
      Action<SpreadsheetExcelSettingsBuilder> configurator)
    {
      this.Container.Excel.Spreadsheet = this.Container;
      configurator(new SpreadsheetExcelSettingsBuilder(this.Container.Excel));
      return this;
    }

    public SpreadsheetBuilder Pdf(
      Action<SpreadsheetPdfSettingsBuilder> configurator)
    {
      this.Container.Pdf.Spreadsheet = this.Container;
      configurator(new SpreadsheetPdfSettingsBuilder(this.Container.Pdf));
      return this;
    }

    public SpreadsheetBuilder RowHeight(double value)
    {
      this.Container.RowHeight = new double?(value);
      return this;
    }

    public SpreadsheetBuilder Rows(double value)
    {
      this.Container.Rows = new double?(value);
      return this;
    }

    public SpreadsheetBuilder Sheets(Action<SpreadsheetSheetFactory> configurator)
    {
      configurator(new SpreadsheetSheetFactory(this.Container.Sheets)
      {
        Spreadsheet = this.Container
      });
      return this;
    }

    public SpreadsheetBuilder Sheetsbar(bool value)
    {
      this.Container.Sheetsbar = new bool?(value);
      return this;
    }

    public SpreadsheetBuilder UseCultureDecimals(bool value)
    {
      this.Container.UseCultureDecimals = new bool?(value);
      return this;
    }

    public SpreadsheetBuilder UseCultureDecimals()
    {
      this.Container.UseCultureDecimals = new bool?(true);
      return this;
    }

    public SpreadsheetBuilder Events(Action<SpreadsheetEventBuilder> configurator)
    {
      configurator(new SpreadsheetEventBuilder(this.Container.Events));
      return this;
    }
  }
}
