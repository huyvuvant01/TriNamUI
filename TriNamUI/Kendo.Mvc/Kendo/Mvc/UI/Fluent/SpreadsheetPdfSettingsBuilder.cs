// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SpreadsheetPdfSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class SpreadsheetPdfSettingsBuilder
  {
    public SpreadsheetPdfSettingsBuilder(SpreadsheetPdfSettings container) => this.Container = container;

    protected SpreadsheetPdfSettings Container { get; private set; }

    public SpreadsheetPdfSettingsBuilder Area(string value)
    {
      this.Container.Area = value;
      return this;
    }

    public SpreadsheetPdfSettingsBuilder Author(string value)
    {
      this.Container.Author = value;
      return this;
    }

    public SpreadsheetPdfSettingsBuilder AutoPrint(bool value)
    {
      this.Container.AutoPrint = new bool?(value);
      return this;
    }

    public SpreadsheetPdfSettingsBuilder AutoPrint()
    {
      this.Container.AutoPrint = new bool?(true);
      return this;
    }

    public SpreadsheetPdfSettingsBuilder Creator(string value)
    {
      this.Container.Creator = value;
      return this;
    }

    public SpreadsheetPdfSettingsBuilder Date(DateTime value)
    {
      this.Container.Date = new DateTime?(value);
      return this;
    }

    public SpreadsheetPdfSettingsBuilder FileName(string value)
    {
      this.Container.FileName = value;
      return this;
    }

    public SpreadsheetPdfSettingsBuilder FitWidth(bool value)
    {
      this.Container.FitWidth = new bool?(value);
      return this;
    }

    public SpreadsheetPdfSettingsBuilder FitWidth()
    {
      this.Container.FitWidth = new bool?(true);
      return this;
    }

    public SpreadsheetPdfSettingsBuilder ForceProxy(bool value)
    {
      this.Container.ForceProxy = new bool?(value);
      return this;
    }

    public SpreadsheetPdfSettingsBuilder ForceProxy()
    {
      this.Container.ForceProxy = new bool?(true);
      return this;
    }

    public SpreadsheetPdfSettingsBuilder Guidelines(bool value)
    {
      this.Container.Guidelines = new bool?(value);
      return this;
    }

    public SpreadsheetPdfSettingsBuilder Guidelines()
    {
      this.Container.Guidelines = new bool?(true);
      return this;
    }

    public SpreadsheetPdfSettingsBuilder HCenter(bool value)
    {
      this.Container.HCenter = new bool?(value);
      return this;
    }

    public SpreadsheetPdfSettingsBuilder HCenter()
    {
      this.Container.HCenter = new bool?(true);
      return this;
    }

    public SpreadsheetPdfSettingsBuilder JpegQuality(double value)
    {
      this.Container.JpegQuality = new double?(value);
      return this;
    }

    public SpreadsheetPdfSettingsBuilder KeepPNG(bool value)
    {
      this.Container.KeepPNG = new bool?(value);
      return this;
    }

    public SpreadsheetPdfSettingsBuilder KeepPNG()
    {
      this.Container.KeepPNG = new bool?(true);
      return this;
    }

    public SpreadsheetPdfSettingsBuilder Keywords(string value)
    {
      this.Container.Keywords = value;
      return this;
    }

    public SpreadsheetPdfSettingsBuilder Landscape(bool value)
    {
      this.Container.Landscape = new bool?(value);
      return this;
    }

    public SpreadsheetPdfSettingsBuilder Margin(
      Action<SpreadsheetPdfMarginSettingsBuilder> configurator)
    {
      this.Container.Margin.Spreadsheet = this.Container.Spreadsheet;
      configurator(new SpreadsheetPdfMarginSettingsBuilder(this.Container.Margin));
      return this;
    }

    public SpreadsheetPdfSettingsBuilder PaperSize(string value)
    {
      this.Container.PaperSize = value;
      return this;
    }

    public SpreadsheetPdfSettingsBuilder ProxyURL(string value)
    {
      this.Container.ProxyURL = value;
      return this;
    }

    public SpreadsheetPdfSettingsBuilder ProxyTarget(string value)
    {
      this.Container.ProxyTarget = value;
      return this;
    }

    public SpreadsheetPdfSettingsBuilder Subject(string value)
    {
      this.Container.Subject = value;
      return this;
    }

    public SpreadsheetPdfSettingsBuilder Title(string value)
    {
      this.Container.Title = value;
      return this;
    }

    public SpreadsheetPdfSettingsBuilder VCenter(bool value)
    {
      this.Container.VCenter = new bool?(value);
      return this;
    }

    public SpreadsheetPdfSettingsBuilder VCenter()
    {
      this.Container.VCenter = new bool?(true);
      return this;
    }
  }
}
