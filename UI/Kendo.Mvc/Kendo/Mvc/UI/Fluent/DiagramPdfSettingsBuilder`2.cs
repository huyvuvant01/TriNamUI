// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramPdfSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramPdfSettingsBuilder<TShapeModel, TConnectionModel>
    where TShapeModel : class
    where TConnectionModel : class
  {
    public DiagramPdfSettingsBuilder(
      DiagramPdfSettings<TShapeModel, TConnectionModel> container)
    {
      this.Container = container;
    }

    protected DiagramPdfSettings<TShapeModel, TConnectionModel> Container { get; private set; }

    public DiagramPdfSettingsBuilder<TShapeModel, TConnectionModel> Author(
      string value)
    {
      this.Container.Author = value;
      return this;
    }

    public DiagramPdfSettingsBuilder<TShapeModel, TConnectionModel> Creator(
      string value)
    {
      this.Container.Creator = value;
      return this;
    }

    public DiagramPdfSettingsBuilder<TShapeModel, TConnectionModel> Date(
      DateTime value)
    {
      this.Container.Date = new DateTime?(value);
      return this;
    }

    public DiagramPdfSettingsBuilder<TShapeModel, TConnectionModel> FileName(
      string value)
    {
      this.Container.FileName = value;
      return this;
    }

    public DiagramPdfSettingsBuilder<TShapeModel, TConnectionModel> ForceProxy(
      bool value)
    {
      this.Container.ForceProxy = new bool?(value);
      return this;
    }

    public DiagramPdfSettingsBuilder<TShapeModel, TConnectionModel> ForceProxy()
    {
      this.Container.ForceProxy = new bool?(true);
      return this;
    }

    public DiagramPdfSettingsBuilder<TShapeModel, TConnectionModel> Keywords(
      string value)
    {
      this.Container.Keywords = value;
      return this;
    }

    public DiagramPdfSettingsBuilder<TShapeModel, TConnectionModel> Landscape(
      bool value)
    {
      this.Container.Landscape = new bool?(value);
      return this;
    }

    public DiagramPdfSettingsBuilder<TShapeModel, TConnectionModel> Landscape()
    {
      this.Container.Landscape = new bool?(true);
      return this;
    }

    public DiagramPdfSettingsBuilder<TShapeModel, TConnectionModel> Margin(
      Action<DiagramPdfMarginSettingsBuilder<TShapeModel, TConnectionModel>> configurator)
    {
      this.Container.Margin.Diagram = this.Container.Diagram;
      configurator(new DiagramPdfMarginSettingsBuilder<TShapeModel, TConnectionModel>(this.Container.Margin));
      return this;
    }

    public DiagramPdfSettingsBuilder<TShapeModel, TConnectionModel> PaperSize(
      string value)
    {
      this.Container.PaperSize = value;
      return this;
    }

    public DiagramPdfSettingsBuilder<TShapeModel, TConnectionModel> ProxyURL(
      string value)
    {
      this.Container.ProxyURL = value;
      return this;
    }

    public DiagramPdfSettingsBuilder<TShapeModel, TConnectionModel> ProxyTarget(
      string value)
    {
      this.Container.ProxyTarget = value;
      return this;
    }

    public DiagramPdfSettingsBuilder<TShapeModel, TConnectionModel> Subject(
      string value)
    {
      this.Container.Subject = value;
      return this;
    }

    public DiagramPdfSettingsBuilder<TShapeModel, TConnectionModel> Title(
      string value)
    {
      this.Container.Title = value;
      return this;
    }
  }
}
