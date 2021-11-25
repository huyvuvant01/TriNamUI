// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SpreadsheetSheetBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class SpreadsheetSheetBuilder
  {
    public SpreadsheetSheetBuilder(SpreadsheetSheet container)
    {
      this.Container = container;
      this.Spreadsheet = container.Spreadsheet;
    }

    protected SpreadsheetSheet Container { get; private set; }

    protected Spreadsheet Spreadsheet { get; private set; }

    public SpreadsheetSheetBuilder DataSource<T>(
      Action<DataSourceBuilder<T>> configurator)
      where T : class
    {
      this.Container.DataSource = new Kendo.Mvc.UI.DataSource(this.Spreadsheet.ModelMetadataProvider)
      {
        Type = new DataSourceType?(DataSourceType.Ajax)
      };
      this.Container.DataSource.ModelType(typeof (T));
      configurator(new DataSourceBuilder<T>(this.Container.DataSource, this.Spreadsheet.ViewContext, this.Spreadsheet.UrlGenerator));
      return this;
    }

    public SpreadsheetSheetBuilder ActiveCell(string value)
    {
      this.Container.ActiveCell = value;
      return this;
    }

    public SpreadsheetSheetBuilder Name(string value)
    {
      this.Container.Name = value;
      return this;
    }

    public SpreadsheetSheetBuilder Columns(
      Action<SpreadsheetSheetColumnFactory> configurator)
    {
      configurator(new SpreadsheetSheetColumnFactory(this.Container.Columns)
      {
        Spreadsheet = this.Container.Spreadsheet
      });
      return this;
    }

    public SpreadsheetSheetBuilder Drawings(
      Action<SpreadsheetSheetDrawingFactory> configurator)
    {
      configurator(new SpreadsheetSheetDrawingFactory(this.Container.Drawings)
      {
        Spreadsheet = this.Container.Spreadsheet
      });
      return this;
    }

    public SpreadsheetSheetBuilder Filter(
      Action<SpreadsheetSheetFilterSettingsBuilder> configurator)
    {
      this.Container.Filter.Spreadsheet = this.Container.Spreadsheet;
      configurator(new SpreadsheetSheetFilterSettingsBuilder(this.Container.Filter));
      return this;
    }

    public SpreadsheetSheetBuilder FrozenColumns(int value)
    {
      this.Container.FrozenColumns = new int?(value);
      return this;
    }

    public SpreadsheetSheetBuilder FrozenRows(int value)
    {
      this.Container.FrozenRows = new int?(value);
      return this;
    }

    public SpreadsheetSheetBuilder MergedCells(params string[] value)
    {
      this.Container.MergedCells = value;
      return this;
    }

    public SpreadsheetSheetBuilder Rows(
      Action<SpreadsheetSheetRowFactory> configurator)
    {
      configurator(new SpreadsheetSheetRowFactory(this.Container.Rows)
      {
        Spreadsheet = this.Container.Spreadsheet
      });
      return this;
    }

    public SpreadsheetSheetBuilder Selection(string value)
    {
      this.Container.Selection = value;
      return this;
    }

    public SpreadsheetSheetBuilder ShowGridLines(bool value)
    {
      this.Container.ShowGridLines = new bool?(value);
      return this;
    }

    public SpreadsheetSheetBuilder Sort(
      Action<SpreadsheetSheetSortSettingsBuilder> configurator)
    {
      this.Container.Sort.Spreadsheet = this.Container.Spreadsheet;
      configurator(new SpreadsheetSheetSortSettingsBuilder(this.Container.Sort));
      return this;
    }
  }
}
