// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SpreadsheetDefaultCellStyleSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

namespace Kendo.Mvc.UI.Fluent
{
  public class SpreadsheetDefaultCellStyleSettingsBuilder
  {
    public SpreadsheetDefaultCellStyleSettingsBuilder(SpreadsheetDefaultCellStyleSettings container) => this.Container = container;

    protected SpreadsheetDefaultCellStyleSettings Container { get; private set; }

    public SpreadsheetDefaultCellStyleSettingsBuilder Background(
      string value)
    {
      this.Container.Background = value;
      return this;
    }

    public SpreadsheetDefaultCellStyleSettingsBuilder Color(
      string value)
    {
      this.Container.Color = value;
      return this;
    }

    public SpreadsheetDefaultCellStyleSettingsBuilder FontFamily(
      string value)
    {
      this.Container.FontFamily = value;
      return this;
    }

    public SpreadsheetDefaultCellStyleSettingsBuilder FontSize(
      string value)
    {
      this.Container.FontSize = value;
      return this;
    }

    public SpreadsheetDefaultCellStyleSettingsBuilder Italic(
      bool value)
    {
      this.Container.Italic = new bool?(value);
      return this;
    }

    public SpreadsheetDefaultCellStyleSettingsBuilder Bold(
      bool value)
    {
      this.Container.Bold = new bool?(value);
      return this;
    }

    public SpreadsheetDefaultCellStyleSettingsBuilder Underline(
      bool value)
    {
      this.Container.Underline = new bool?(value);
      return this;
    }

    public SpreadsheetDefaultCellStyleSettingsBuilder Wrap(
      bool value)
    {
      this.Container.Wrap = new bool?(value);
      return this;
    }
  }
}
