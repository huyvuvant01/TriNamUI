// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GanttPdfSettingsBuilder`2
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel>
    where TTaskModel : class, IGanttTask
    where TDependenciesModel : class, IGanttDependency
  {
    public GanttPdfSettingsBuilder(
      GanttPdfSettings<TTaskModel, TDependenciesModel> container)
    {
      this.Container = container;
    }

    protected GanttPdfSettings<TTaskModel, TDependenciesModel> Container { get; private set; }

    public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> Author(
      string value)
    {
      this.Container.Author = value;
      return this;
    }

    public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> AutoPrint(
      bool value)
    {
      this.Container.AutoPrint = new bool?(value);
      return this;
    }

    public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> AutoPrint()
    {
      this.Container.AutoPrint = new bool?(true);
      return this;
    }

    public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> AvoidLinks(
      bool value)
    {
      this.Container.AvoidLinks = new bool?(value);
      return this;
    }

    public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> AvoidLinks()
    {
      this.Container.AvoidLinks = new bool?(true);
      return this;
    }

    public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> Creator(
      string value)
    {
      this.Container.Creator = value;
      return this;
    }

    public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> Date(
      DateTime value)
    {
      this.Container.Date = new DateTime?(value);
      return this;
    }

    public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> FileName(
      string value)
    {
      this.Container.FileName = value;
      return this;
    }

    public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> ForceProxy(
      bool value)
    {
      this.Container.ForceProxy = new bool?(value);
      return this;
    }

    public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> ForceProxy()
    {
      this.Container.ForceProxy = new bool?(true);
      return this;
    }

    public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> JpegQuality(
      double value)
    {
      this.Container.JpegQuality = new double?(value);
      return this;
    }

    public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> KeepPNG(
      bool value)
    {
      this.Container.KeepPNG = new bool?(value);
      return this;
    }

    public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> KeepPNG()
    {
      this.Container.KeepPNG = new bool?(true);
      return this;
    }

    public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> Keywords(
      string value)
    {
      this.Container.Keywords = value;
      return this;
    }

    public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> Landscape(
      bool value)
    {
      this.Container.Landscape = new bool?(value);
      return this;
    }

    public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> Landscape()
    {
      this.Container.Landscape = new bool?(true);
      return this;
    }

    public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> Margin(
      Action<GanttPdfMarginSettingsBuilder<TTaskModel, TDependenciesModel>> configurator)
    {
      this.Container.Margin.Gantt = this.Container.Gantt;
      configurator(new GanttPdfMarginSettingsBuilder<TTaskModel, TDependenciesModel>(this.Container.Margin));
      return this;
    }

    public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> PaperSize(
      string value)
    {
      this.Container.PaperSize = value;
      return this;
    }

    public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> ProxyURL(
      string value)
    {
      this.Container.ProxyURL = value;
      return this;
    }

    public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> ProxyTarget(
      string value)
    {
      this.Container.ProxyTarget = value;
      return this;
    }

    public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> Subject(
      string value)
    {
      this.Container.Subject = value;
      return this;
    }

    public GanttPdfSettingsBuilder<TTaskModel, TDependenciesModel> Title(
      string value)
    {
      this.Container.Title = value;
      return this;
    }
  }
}
