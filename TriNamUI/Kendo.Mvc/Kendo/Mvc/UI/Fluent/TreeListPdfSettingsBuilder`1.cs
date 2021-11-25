// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TreeListPdfSettingsBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class TreeListPdfSettingsBuilder<T> : PdfSettingsBuilder<TreeListPdfSettingsBuilder<T>>
    where T : class
  {
    public TreeListPdfSettingsBuilder(TreeListPdfSettings<T> container)
      : base((PdfSettings) container)
    {
      this.Container = container;
    }

    protected TreeListPdfSettings<T> Container { get; private set; }

    public TreeListPdfSettingsBuilder<T> AllPages(bool value)
    {
      this.Container.AllPages = new bool?(value);
      return this;
    }

    public TreeListPdfSettingsBuilder<T> AllPages()
    {
      this.Container.AllPages = new bool?(true);
      return this;
    }

    public TreeListPdfSettingsBuilder<T> Author(string value)
    {
      this.Container.Author = value;
      return this;
    }

    public TreeListPdfSettingsBuilder<T> AutoPrint(bool value)
    {
      this.Container.AutoPrint = new bool?(value);
      return this;
    }

    public TreeListPdfSettingsBuilder<T> AutoPrint()
    {
      this.Container.AutoPrint = new bool?(true);
      return this;
    }

    public TreeListPdfSettingsBuilder<T> AvoidLinks(bool value)
    {
      this.Container.AvoidLinks = new bool?(value);
      return this;
    }

    public TreeListPdfSettingsBuilder<T> AvoidLinks()
    {
      this.Container.AvoidLinks = new bool?(true);
      return this;
    }

    public TreeListPdfSettingsBuilder<T> Creator(string value)
    {
      this.Container.Creator = value;
      return this;
    }

    public TreeListPdfSettingsBuilder<T> Date(DateTime value)
    {
      this.Container.Date = new DateTime?(value);
      return this;
    }

    public TreeListPdfSettingsBuilder<T> FileName(string value)
    {
      this.Container.FileName = value;
      return this;
    }

    public TreeListPdfSettingsBuilder<T> ForceProxy(bool value)
    {
      this.Container.ForceProxy = new bool?(value);
      return this;
    }

    public TreeListPdfSettingsBuilder<T> ForceProxy()
    {
      this.Container.ForceProxy = new bool?(true);
      return this;
    }

    public TreeListPdfSettingsBuilder<T> JpegQuality(double value)
    {
      this.Container.JpegQuality = new double?(value);
      return this;
    }

    public TreeListPdfSettingsBuilder<T> KeepPNG(bool value)
    {
      this.Container.KeepPNG = new bool?(value);
      return this;
    }

    public TreeListPdfSettingsBuilder<T> KeepPNG()
    {
      this.Container.KeepPNG = new bool?(true);
      return this;
    }

    public TreeListPdfSettingsBuilder<T> Keywords(string value)
    {
      this.Container.Keywords = value;
      return this;
    }

    public TreeListPdfSettingsBuilder<T> Landscape(bool value)
    {
      this.Container.Landscape = new bool?(value);
      return this;
    }

    public TreeListPdfSettingsBuilder<T> Landscape()
    {
      this.Container.Landscape = new bool?(true);
      return this;
    }

    public TreeListPdfSettingsBuilder<T> ProxyURL(string value)
    {
      this.Container.ProxyURL = value;
      return this;
    }

    public TreeListPdfSettingsBuilder<T> ProxyTarget(string value)
    {
      this.Container.ProxyTarget = value;
      return this;
    }

    public TreeListPdfSettingsBuilder<T> Subject(string value)
    {
      this.Container.Subject = value;
      return this;
    }

    public TreeListPdfSettingsBuilder<T> Title(string value)
    {
      this.Container.Title = value;
      return this;
    }
  }
}
