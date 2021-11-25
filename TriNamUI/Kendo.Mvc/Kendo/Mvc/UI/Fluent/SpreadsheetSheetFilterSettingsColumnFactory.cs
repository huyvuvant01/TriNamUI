// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SpreadsheetSheetFilterSettingsColumnFactory
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class SpreadsheetSheetFilterSettingsColumnFactory
  {
    public SpreadsheetSheetFilterSettingsColumnFactory(
      List<SpreadsheetSheetFilterSettingsColumn> container)
    {
      this.Container = container;
    }

    protected List<SpreadsheetSheetFilterSettingsColumn> Container { get; private set; }

    public virtual SpreadsheetSheetFilterSettingsColumnFactory ValueFilter(
      Action<SpreadsheetValueFilterBuilder> configuration)
    {
      SpreadsheetSheetFilterSettingsColumn container = new SpreadsheetSheetFilterSettingsColumn()
      {
        Filter = "value",
        Spreadsheet = this.Spreadsheet
      };
      this.Container.Add(container);
      configuration(new SpreadsheetValueFilterBuilder(container));
      return this;
    }

    public virtual SpreadsheetSheetFilterSettingsColumnFactory TopFilter(
      Action<SpreadsheetTopFilterBuilder> configuration)
    {
      SpreadsheetSheetFilterSettingsColumn container = new SpreadsheetSheetFilterSettingsColumn()
      {
        Filter = "top",
        Spreadsheet = this.Spreadsheet
      };
      this.Container.Add(container);
      configuration(new SpreadsheetTopFilterBuilder(container));
      return this;
    }

    public virtual SpreadsheetSheetFilterSettingsColumnFactory DynamicFilter(
      Action<SpreadsheetDynamicFilterBuilder> configuration)
    {
      SpreadsheetSheetFilterSettingsColumn container = new SpreadsheetSheetFilterSettingsColumn()
      {
        Filter = "dynamic",
        Spreadsheet = this.Spreadsheet
      };
      this.Container.Add(container);
      configuration(new SpreadsheetDynamicFilterBuilder(container));
      return this;
    }

    public virtual SpreadsheetSheetFilterSettingsColumnFactory CustomFilter(
      Action<SpreadsheetCustomFilterBuilder> configuration)
    {
      SpreadsheetSheetFilterSettingsColumn settings = new SpreadsheetSheetFilterSettingsColumn()
      {
        Filter = "custom",
        Spreadsheet = this.Spreadsheet
      };
      this.Container.Add(settings);
      configuration(new SpreadsheetCustomFilterBuilder(settings));
      return this;
    }

    public Spreadsheet Spreadsheet { get; set; }

    public virtual SpreadsheetSheetFilterSettingsColumnBuilder Add()
    {
      SpreadsheetSheetFilterSettingsColumn container = new SpreadsheetSheetFilterSettingsColumn();
      container.Spreadsheet = this.Spreadsheet;
      this.Container.Add(container);
      return new SpreadsheetSheetFilterSettingsColumnBuilder(container);
    }
  }
}
