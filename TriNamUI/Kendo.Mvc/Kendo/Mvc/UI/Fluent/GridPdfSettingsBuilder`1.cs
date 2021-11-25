// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GridPdfSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class GridPdfSettingsBuilder<T> : PdfSettingsBuilder<GridPdfSettingsBuilder<T>>
    where T : class
  {
    public GridPdfSettingsBuilder(GridPdfSettings<T> container)
      : base((PdfSettings) container)
    {
      this.Container = container;
    }

    protected GridPdfSettings<T> Container { get; private set; }

    public GridPdfSettingsBuilder<T> AllPages(bool value)
    {
      this.Container.AllPages = new bool?(value);
      return this;
    }

    public GridPdfSettingsBuilder<T> AllPages()
    {
      this.Container.AllPages = new bool?(true);
      return this;
    }

    public GridPdfSettingsBuilder<T> Author(string value)
    {
      this.Container.Author = value;
      return this;
    }

    public GridPdfSettingsBuilder<T> AutoPrint(bool value)
    {
      this.Container.AutoPrint = new bool?(value);
      return this;
    }

    public GridPdfSettingsBuilder<T> AutoPrint()
    {
      this.Container.AutoPrint = new bool?(true);
      return this;
    }

    public GridPdfSettingsBuilder<T> AvoidLinks(bool value)
    {
      this.Container.AvoidLinks = new bool?(value);
      return this;
    }

    public GridPdfSettingsBuilder<T> AvoidLinks()
    {
      this.Container.AvoidLinks = new bool?(true);
      return this;
    }

    public GridPdfSettingsBuilder<T> Creator(string value)
    {
      this.Container.Creator = value;
      return this;
    }

    public GridPdfSettingsBuilder<T> Date(DateTime value)
    {
      this.Container.Date = new DateTime?(value);
      return this;
    }

    public GridPdfSettingsBuilder<T> FileName(string value)
    {
      this.Container.FileName = value;
      return this;
    }

    public GridPdfSettingsBuilder<T> ForceProxy(bool value)
    {
      this.Container.ForceProxy = new bool?(value);
      return this;
    }

    public GridPdfSettingsBuilder<T> ForceProxy()
    {
      this.Container.ForceProxy = new bool?(true);
      return this;
    }

    public GridPdfSettingsBuilder<T> JpegQuality(double value)
    {
      this.Container.JpegQuality = new double?(value);
      return this;
    }

    public GridPdfSettingsBuilder<T> KeepPNG(bool value)
    {
      this.Container.KeepPNG = new bool?(value);
      return this;
    }

    public GridPdfSettingsBuilder<T> KeepPNG()
    {
      this.Container.KeepPNG = new bool?(true);
      return this;
    }

    public GridPdfSettingsBuilder<T> Keywords(string value)
    {
      this.Container.Keywords = value;
      return this;
    }

    public GridPdfSettingsBuilder<T> Landscape(bool value)
    {
      this.Container.Landscape = new bool?(value);
      return this;
    }

    public GridPdfSettingsBuilder<T> Landscape()
    {
      this.Container.Landscape = new bool?(true);
      return this;
    }

    public GridPdfSettingsBuilder<T> Template(string value)
    {
      this.Container.Template = value;
      return this;
    }

    public GridPdfSettingsBuilder<T> TemplateId(string templateId)
    {
      this.Container.TemplateId = templateId;
      return this;
    }

    public GridPdfSettingsBuilder<T> RepeatHeaders(bool value)
    {
      this.Container.RepeatHeaders = new bool?(value);
      return this;
    }

    public GridPdfSettingsBuilder<T> RepeatHeaders()
    {
      this.Container.RepeatHeaders = new bool?(true);
      return this;
    }

    public GridPdfSettingsBuilder<T> Scale(double value)
    {
      this.Container.Scale = new double?(value);
      return this;
    }

    public GridPdfSettingsBuilder<T> ProxyURL(string value)
    {
      this.Container.ProxyURL = value;
      return this;
    }

    public GridPdfSettingsBuilder<T> ProxyTarget(string value)
    {
      this.Container.ProxyTarget = value;
      return this;
    }

    public GridPdfSettingsBuilder<T> Subject(string value)
    {
      this.Container.Subject = value;
      return this;
    }

    public GridPdfSettingsBuilder<T> Title(string value)
    {
      this.Container.Title = value;
      return this;
    }
  }
}
