// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PivotGridPdfSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class PivotGridPdfSettingsBuilder<T> where T : class
  {
    public PivotGridPdfSettingsBuilder(PivotGridPdfSettings<T> container) => this.Container = container;

    protected PivotGridPdfSettings<T> Container { get; private set; }

    public PivotGridPdfSettingsBuilder<T> Author(string value)
    {
      this.Container.Author = value;
      return this;
    }

    public PivotGridPdfSettingsBuilder<T> AutoPrint(bool value)
    {
      this.Container.AutoPrint = new bool?(value);
      return this;
    }

    public PivotGridPdfSettingsBuilder<T> AutoPrint()
    {
      this.Container.AutoPrint = new bool?(true);
      return this;
    }

    public PivotGridPdfSettingsBuilder<T> AvoidLinks(bool value)
    {
      this.Container.AvoidLinks = new bool?(value);
      return this;
    }

    public PivotGridPdfSettingsBuilder<T> AvoidLinks()
    {
      this.Container.AvoidLinks = new bool?(true);
      return this;
    }

    public PivotGridPdfSettingsBuilder<T> Creator(string value)
    {
      this.Container.Creator = value;
      return this;
    }

    public PivotGridPdfSettingsBuilder<T> Date(DateTime value)
    {
      this.Container.Date = new DateTime?(value);
      return this;
    }

    public PivotGridPdfSettingsBuilder<T> FileName(string value)
    {
      this.Container.FileName = value;
      return this;
    }

    public PivotGridPdfSettingsBuilder<T> ForceProxy(bool value)
    {
      this.Container.ForceProxy = new bool?(value);
      return this;
    }

    public PivotGridPdfSettingsBuilder<T> ForceProxy()
    {
      this.Container.ForceProxy = new bool?(true);
      return this;
    }

    public PivotGridPdfSettingsBuilder<T> JpegQuality(double value)
    {
      this.Container.JpegQuality = new double?(value);
      return this;
    }

    public PivotGridPdfSettingsBuilder<T> KeepPNG(bool value)
    {
      this.Container.KeepPNG = new bool?(value);
      return this;
    }

    public PivotGridPdfSettingsBuilder<T> KeepPNG()
    {
      this.Container.KeepPNG = new bool?(true);
      return this;
    }

    public PivotGridPdfSettingsBuilder<T> Keywords(string value)
    {
      this.Container.Keywords = value;
      return this;
    }

    public PivotGridPdfSettingsBuilder<T> Landscape(bool value)
    {
      this.Container.Landscape = new bool?(value);
      return this;
    }

    public PivotGridPdfSettingsBuilder<T> Landscape()
    {
      this.Container.Landscape = new bool?(true);
      return this;
    }

    public PivotGridPdfSettingsBuilder<T> Margin(
      Action<PivotGridPdfMarginSettingsBuilder<T>> configurator)
    {
      this.Container.Margin.PivotGrid = this.Container.PivotGrid;
      configurator(new PivotGridPdfMarginSettingsBuilder<T>(this.Container.Margin));
      return this;
    }

    public PivotGridPdfSettingsBuilder<T> PaperSize(string value)
    {
      this.Container.PaperSize = value;
      return this;
    }

    public PivotGridPdfSettingsBuilder<T> ProxyURL(string value)
    {
      this.Container.ProxyURL = value;
      return this;
    }

    public PivotGridPdfSettingsBuilder<T> ProxyTarget(string value)
    {
      this.Container.ProxyTarget = value;
      return this;
    }

    public PivotGridPdfSettingsBuilder<T> Subject(string value)
    {
      this.Container.Subject = value;
      return this;
    }

    public PivotGridPdfSettingsBuilder<T> Title(string value)
    {
      this.Container.Title = value;
      return this;
    }
  }
}
