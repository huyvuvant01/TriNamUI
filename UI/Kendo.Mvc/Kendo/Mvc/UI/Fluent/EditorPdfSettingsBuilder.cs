// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.EditorPdfSettingsBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class EditorPdfSettingsBuilder : PdfSettingsBuilder<EditorPdfSettingsBuilder>
  {
    public EditorPdfSettingsBuilder(EditorPdfSettings container)
      : base((PdfSettings) container)
    {
      this.Container = container;
    }

    protected EditorPdfSettings Container { get; private set; }

    public EditorPdfSettingsBuilder Author(string value)
    {
      this.Container.Author = value;
      return this;
    }

    public EditorPdfSettingsBuilder AutoPrint(bool value)
    {
      this.Container.AutoPrint = new bool?(value);
      return this;
    }

    public EditorPdfSettingsBuilder AutoPrint()
    {
      this.Container.AutoPrint = new bool?(true);
      return this;
    }

    public EditorPdfSettingsBuilder AvoidLinks(bool value)
    {
      this.Container.AvoidLinks = new bool?(value);
      return this;
    }

    public EditorPdfSettingsBuilder AvoidLinks()
    {
      this.Container.AvoidLinks = new bool?(true);
      return this;
    }

    public EditorPdfSettingsBuilder Creator(string value)
    {
      this.Container.Creator = value;
      return this;
    }

    public EditorPdfSettingsBuilder Date(DateTime value)
    {
      this.Container.Date = new DateTime?(value);
      return this;
    }

    public EditorPdfSettingsBuilder FileName(string value)
    {
      this.Container.FileName = value;
      return this;
    }

    public EditorPdfSettingsBuilder ForceProxy(bool value)
    {
      this.Container.ForceProxy = new bool?(value);
      return this;
    }

    public EditorPdfSettingsBuilder ForceProxy()
    {
      this.Container.ForceProxy = new bool?(true);
      return this;
    }

    public EditorPdfSettingsBuilder JpegQuality(double value)
    {
      this.Container.JpegQuality = new double?(value);
      return this;
    }

    public EditorPdfSettingsBuilder KeepPNG(bool value)
    {
      this.Container.KeepPNG = new bool?(value);
      return this;
    }

    public EditorPdfSettingsBuilder KeepPNG()
    {
      this.Container.KeepPNG = new bool?(true);
      return this;
    }

    public EditorPdfSettingsBuilder Keywords(string value)
    {
      this.Container.Keywords = value;
      return this;
    }

    public EditorPdfSettingsBuilder Landscape(bool value)
    {
      this.Container.Landscape = new bool?(value);
      return this;
    }

    public EditorPdfSettingsBuilder Landscape()
    {
      this.Container.Landscape = new bool?(true);
      return this;
    }

    public EditorPdfSettingsBuilder ProxyURL(string value)
    {
      this.Container.ProxyURL = value;
      return this;
    }

    public EditorPdfSettingsBuilder ProxyTarget(string value)
    {
      this.Container.ProxyTarget = value;
      return this;
    }

    public EditorPdfSettingsBuilder Subject(string value)
    {
      this.Container.Subject = value;
      return this;
    }

    public EditorPdfSettingsBuilder Title(string value)
    {
      this.Container.Title = value;
      return this;
    }
  }
}
