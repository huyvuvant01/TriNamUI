// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SpreadsheetSheetRowCellBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class SpreadsheetSheetRowCellBuilder
  {
    public SpreadsheetSheetRowCellBuilder(SpreadsheetSheetRowCell container) => this.Container = container;

    protected SpreadsheetSheetRowCell Container { get; private set; }

    public SpreadsheetSheetRowCellBuilder Background(string value)
    {
      this.Container.Background = value;
      return this;
    }

    public SpreadsheetSheetRowCellBuilder BorderBottom(
      Action<SpreadsheetSheetRowCellBorderBottomSettingsBuilder> configurator)
    {
      this.Container.BorderBottom.Spreadsheet = this.Container.Spreadsheet;
      configurator(new SpreadsheetSheetRowCellBorderBottomSettingsBuilder(this.Container.BorderBottom));
      return this;
    }

    public SpreadsheetSheetRowCellBuilder BorderLeft(
      Action<SpreadsheetSheetRowCellBorderLeftSettingsBuilder> configurator)
    {
      this.Container.BorderLeft.Spreadsheet = this.Container.Spreadsheet;
      configurator(new SpreadsheetSheetRowCellBorderLeftSettingsBuilder(this.Container.BorderLeft));
      return this;
    }

    public SpreadsheetSheetRowCellBuilder BorderTop(
      Action<SpreadsheetSheetRowCellBorderTopSettingsBuilder> configurator)
    {
      this.Container.BorderTop.Spreadsheet = this.Container.Spreadsheet;
      configurator(new SpreadsheetSheetRowCellBorderTopSettingsBuilder(this.Container.BorderTop));
      return this;
    }

    public SpreadsheetSheetRowCellBuilder BorderRight(
      Action<SpreadsheetSheetRowCellBorderRightSettingsBuilder> configurator)
    {
      this.Container.BorderRight.Spreadsheet = this.Container.Spreadsheet;
      configurator(new SpreadsheetSheetRowCellBorderRightSettingsBuilder(this.Container.BorderRight));
      return this;
    }

    public SpreadsheetSheetRowCellBuilder Color(string value)
    {
      this.Container.Color = value;
      return this;
    }

    public SpreadsheetSheetRowCellBuilder Comment(string value)
    {
      this.Container.Comment = value;
      return this;
    }

    public SpreadsheetSheetRowCellBuilder FontFamily(string value)
    {
      this.Container.FontFamily = value;
      return this;
    }

    public SpreadsheetSheetRowCellBuilder FontSize(double value)
    {
      this.Container.FontSize = new double?(value);
      return this;
    }

    public SpreadsheetSheetRowCellBuilder Italic(bool value)
    {
      this.Container.Italic = new bool?(value);
      return this;
    }

    public SpreadsheetSheetRowCellBuilder Bold(bool value)
    {
      this.Container.Bold = new bool?(value);
      return this;
    }

    public SpreadsheetSheetRowCellBuilder Enable(bool value)
    {
      this.Container.Enable = new bool?(value);
      return this;
    }

    public SpreadsheetSheetRowCellBuilder Format(string value)
    {
      this.Container.Format = value;
      return this;
    }

    public SpreadsheetSheetRowCellBuilder Formula(string value)
    {
      this.Container.Formula = value;
      return this;
    }

    public SpreadsheetSheetRowCellBuilder Html(bool value)
    {
      this.Container.Html = new bool?(value);
      return this;
    }

    public SpreadsheetSheetRowCellBuilder Index(int value)
    {
      this.Container.Index = new int?(value);
      return this;
    }

    public SpreadsheetSheetRowCellBuilder Link(string value)
    {
      this.Container.Link = value;
      return this;
    }

    public SpreadsheetSheetRowCellBuilder Underline(bool value)
    {
      this.Container.Underline = new bool?(value);
      return this;
    }

    public SpreadsheetSheetRowCellBuilder Value(object value)
    {
      this.Container.Value = value;
      return this;
    }

    public SpreadsheetSheetRowCellBuilder Validation(
      Action<SpreadsheetSheetRowCellValidationSettingsBuilder> configurator)
    {
      this.Container.Validation.Spreadsheet = this.Container.Spreadsheet;
      configurator(new SpreadsheetSheetRowCellValidationSettingsBuilder(this.Container.Validation));
      return this;
    }

    public SpreadsheetSheetRowCellBuilder Wrap(bool value)
    {
      this.Container.Wrap = new bool?(value);
      return this;
    }

    public SpreadsheetSheetRowCellBuilder TextAlign(
      SpreadsheetTextAlign value)
    {
      this.Container.TextAlign = new SpreadsheetTextAlign?(value);
      return this;
    }

    public SpreadsheetSheetRowCellBuilder VerticalAlign(
      SpreadsheetVerticalAlign value)
    {
      this.Container.VerticalAlign = new SpreadsheetVerticalAlign?(value);
      return this;
    }
  }
}
