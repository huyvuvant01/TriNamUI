// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SpreadsheetValueFilterBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class SpreadsheetValueFilterBuilder
  {
    public SpreadsheetValueFilterBuilder(SpreadsheetSheetFilterSettingsColumn container) => this.Container = container;

    protected SpreadsheetSheetFilterSettingsColumn Container { get; private set; }

    public SpreadsheetValueFilterBuilder Index(double value)
    {
      this.Container.Index = new double?(value);
      return this;
    }

    public SpreadsheetValueFilterBuilder Values(params object[] value)
    {
      this.Container.Values = value;
      return this;
    }
  }
}
