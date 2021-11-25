// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SpreadsheetSheetFilterSettingsColumnCriteriaBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class SpreadsheetSheetFilterSettingsColumnCriteriaBuilder
  {
    public SpreadsheetSheetFilterSettingsColumnCriteriaBuilder(
      SpreadsheetSheetFilterSettingsColumnCriteria container)
    {
      this.Container = container;
    }

    protected SpreadsheetSheetFilterSettingsColumnCriteria Container { get; private set; }

    public SpreadsheetSheetFilterSettingsColumnCriteriaBuilder Value(
      string value)
    {
      this.Container.Value = (object) value;
      return this;
    }

    public SpreadsheetSheetFilterSettingsColumnCriteriaBuilder Value(
      DateTime value)
    {
      this.Container.Value = (object) value;
      return this;
    }

    public SpreadsheetSheetFilterSettingsColumnCriteriaBuilder Value(
      double value)
    {
      this.Container.Value = (object) value;
      return this;
    }

    public SpreadsheetSheetFilterSettingsColumnCriteriaBuilder Operator(
      SpreadsheetFilterOperator value)
    {
      this.Container.Operator = new SpreadsheetFilterOperator?(value);
      return this;
    }
  }
}
