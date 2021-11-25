// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SpreadsheetExcelSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class SpreadsheetExcelSettingsBuilder
  {
    public SpreadsheetExcelSettingsBuilder(SpreadsheetExcelSettings container) => this.Container = container;

    protected SpreadsheetExcelSettings Container { get; private set; }

    public SpreadsheetExcelSettingsBuilder FileName(string value)
    {
      this.Container.FileName = value;
      return this;
    }

    public SpreadsheetExcelSettingsBuilder ForceProxy(bool value)
    {
      this.Container.ForceProxy = new bool?(value);
      return this;
    }

    public SpreadsheetExcelSettingsBuilder ForceProxy()
    {
      this.Container.ForceProxy = new bool?(true);
      return this;
    }

    public SpreadsheetExcelSettingsBuilder ProxyURL(string value)
    {
      this.Container.ProxyURL = value;
      return this;
    }
  }
}
