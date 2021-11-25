// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SpreadsheetSheetFilterSettingsColumnBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class SpreadsheetSheetFilterSettingsColumnBuilder
  {
    public SpreadsheetSheetFilterSettingsColumnBuilder(
      SpreadsheetSheetFilterSettingsColumn container)
    {
      this.Container = container;
    }

    protected SpreadsheetSheetFilterSettingsColumn Container { get; private set; }

    public SpreadsheetSheetFilterSettingsColumnBuilder Criteria(
      Action<SpreadsheetSheetFilterSettingsColumnCriteriaFactory> configurator)
    {
      configurator(new SpreadsheetSheetFilterSettingsColumnCriteriaFactory(this.Container.Criteria)
      {
        Spreadsheet = this.Container.Spreadsheet
      });
      return this;
    }

    public SpreadsheetSheetFilterSettingsColumnBuilder Filter(
      string value)
    {
      this.Container.Filter = value;
      return this;
    }

    public SpreadsheetSheetFilterSettingsColumnBuilder Index(
      double value)
    {
      this.Container.Index = new double?(value);
      return this;
    }

    public SpreadsheetSheetFilterSettingsColumnBuilder Logic(
      string value)
    {
      this.Container.Logic = value;
      return this;
    }

    public SpreadsheetSheetFilterSettingsColumnBuilder Type(
      string value)
    {
      this.Container.Type = value;
      return this;
    }

    public SpreadsheetSheetFilterSettingsColumnBuilder Value(
      double value)
    {
      this.Container.Value = new double?(value);
      return this;
    }

    public SpreadsheetSheetFilterSettingsColumnBuilder Values(
      params object[] value)
    {
      this.Container.Values = value;
      return this;
    }
  }
}
