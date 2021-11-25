// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SpreadsheetPdfMarginSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class SpreadsheetPdfMarginSettingsBuilder
  {
    public SpreadsheetPdfMarginSettingsBuilder(SpreadsheetPdfMarginSettings container) => this.Container = container;

    protected SpreadsheetPdfMarginSettings Container { get; private set; }

    public SpreadsheetPdfMarginSettingsBuilder Bottom(
      double value)
    {
      this.Container.Bottom = new double?(value);
      return this;
    }

    public SpreadsheetPdfMarginSettingsBuilder Left(double value)
    {
      this.Container.Left = new double?(value);
      return this;
    }

    public SpreadsheetPdfMarginSettingsBuilder Right(double value)
    {
      this.Container.Right = new double?(value);
      return this;
    }

    public SpreadsheetPdfMarginSettingsBuilder Top(double value)
    {
      this.Container.Top = new double?(value);
      return this;
    }
  }
}
