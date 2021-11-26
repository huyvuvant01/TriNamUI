// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SpreadsheetCustomFilterBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class SpreadsheetCustomFilterBuilder
  {
    public SpreadsheetCustomFilterBuilder(SpreadsheetSheetFilterSettingsColumn settings) => this.Container = settings;

    protected SpreadsheetSheetFilterSettingsColumn Container { get; private set; }

    public SpreadsheetCustomFilterBuilder Criteria(
      Action<SpreadsheetSheetFilterSettingsColumnCriteriaFactory> configurator)
    {
      configurator(new SpreadsheetSheetFilterSettingsColumnCriteriaFactory(this.Container.Criteria));
      return this;
    }

    public SpreadsheetCustomFilterBuilder Index(double value)
    {
      this.Container.Index = new double?(value);
      return this;
    }

    public SpreadsheetCustomFilterBuilder Logic(
      SpreadsheetFilterLogic value)
    {
      this.Container.Logic = value.Serialize();
      return this;
    }
  }
}
