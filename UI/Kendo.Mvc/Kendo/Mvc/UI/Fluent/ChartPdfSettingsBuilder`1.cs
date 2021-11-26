// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ChartPdfSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ChartPdfSettingsBuilder<T> where T : class
  {
    public ChartPdfSettingsBuilder(ChartPdfSettings<T> container) => this.Container = container;

    protected ChartPdfSettings<T> Container { get; private set; }

    public ChartPdfSettingsBuilder<T> Author(string value)
    {
      this.Container.Author = value;
      return this;
    }

    public ChartPdfSettingsBuilder<T> AutoPrint(bool value)
    {
      this.Container.AutoPrint = new bool?(value);
      return this;
    }

    public ChartPdfSettingsBuilder<T> AutoPrint()
    {
      this.Container.AutoPrint = new bool?(true);
      return this;
    }

    public ChartPdfSettingsBuilder<T> Creator(string value)
    {
      this.Container.Creator = value;
      return this;
    }

    public ChartPdfSettingsBuilder<T> Date(DateTime value)
    {
      this.Container.Date = new DateTime?(value);
      return this;
    }

    public ChartPdfSettingsBuilder<T> ForceProxy(bool value)
    {
      this.Container.ForceProxy = new bool?(value);
      return this;
    }

    public ChartPdfSettingsBuilder<T> ForceProxy()
    {
      this.Container.ForceProxy = new bool?(true);
      return this;
    }

    public ChartPdfSettingsBuilder<T> FileName(string value)
    {
      this.Container.FileName = value;
      return this;
    }

    public ChartPdfSettingsBuilder<T> JpegQuality(double value)
    {
      this.Container.JpegQuality = new double?(value);
      return this;
    }

    public ChartPdfSettingsBuilder<T> KeepPNG(bool value)
    {
      this.Container.KeepPNG = new bool?(value);
      return this;
    }

    public ChartPdfSettingsBuilder<T> KeepPNG()
    {
      this.Container.KeepPNG = new bool?(true);
      return this;
    }

    public ChartPdfSettingsBuilder<T> Keywords(string value)
    {
      this.Container.Keywords = value;
      return this;
    }

    public ChartPdfSettingsBuilder<T> Landscape(bool value)
    {
      this.Container.Landscape = new bool?(value);
      return this;
    }

    public ChartPdfSettingsBuilder<T> Landscape()
    {
      this.Container.Landscape = new bool?(true);
      return this;
    }

    public ChartPdfSettingsBuilder<T> Margin(
      Action<ChartPdfMarginSettingsBuilder<T>> configurator)
    {
      this.Container.Margin.Chart = this.Container.Chart;
      configurator(new ChartPdfMarginSettingsBuilder<T>(this.Container.Margin));
      return this;
    }

    public ChartPdfSettingsBuilder<T> PaperSize(string value)
    {
      this.Container.PaperSize = value;
      return this;
    }

    public ChartPdfSettingsBuilder<T> ProxyURL(string value)
    {
      this.Container.ProxyURL = value;
      return this;
    }

    public ChartPdfSettingsBuilder<T> ProxyTarget(string value)
    {
      this.Container.ProxyTarget = value;
      return this;
    }

    public ChartPdfSettingsBuilder<T> Subject(string value)
    {
      this.Container.Subject = value;
      return this;
    }

    public ChartPdfSettingsBuilder<T> Title(string value)
    {
      this.Container.Title = value;
      return this;
    }
  }
}
