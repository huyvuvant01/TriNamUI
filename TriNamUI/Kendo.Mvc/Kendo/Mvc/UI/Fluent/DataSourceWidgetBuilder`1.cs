// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DataSourceWidgetBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.IO;
using System.Text.Encodings.Web;
using System.Threading.Tasks;


#nullable enable
namespace Kendo.Mvc.UI.Fluent
{
  public class DataSourceWidgetBuilder<T> : HelperResult where T : 
  #nullable disable
  class
  {
    protected readonly IUrlGenerator urlGenerator;
    protected readonly ViewContext viewContext;

    public DataSourceWidgetBuilder(DataSourceWidget<T> component)
      : base((Func<TextWriter, Task>) (async writer => await Task.Yield()))
    {
      this.Component = component;
    }

    protected internal DataSourceWidget<T> Component { get; set; }

    public virtual DataSourceWidgetBuilder<T> Name(string componentName)
    {
      this.Component.Name = componentName;
      return this;
    }

    public override void WriteTo(TextWriter writer, HtmlEncoder encoder) => this.Component.Render();

    public DataSourceWidgetBuilder<T> Ajax(
      Action<AjaxDataSourceBuilder<T>> configurator)
    {
      this.Component.DataSource.Type = new DataSourceType?(DataSourceType.Ajax);
      configurator(new AjaxDataSourceBuilder<T>(this.Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public DataSourceWidgetBuilder<T> WebApi(
      Action<WebApiDataSourceBuilder<T>> configurator)
    {
      this.Component.DataSource.Type = new DataSourceType?(DataSourceType.WebApi);
      configurator(new WebApiDataSourceBuilder<T>(this.Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public DataSourceWidgetBuilder<T> Custom(
      Action<CustomDataSourceBuilder<T>> configurator)
    {
      this.Component.DataSource.Type = new DataSourceType?(DataSourceType.Custom);
      configurator(new CustomDataSourceBuilder<T>(this.Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public DataSourceWidgetBuilder<T> SignalR(
      Action<SignalRDataSourceBuilder<T>> configurator)
    {
      this.Component.DataSource.Type = new DataSourceType?(DataSourceType.Custom);
      configurator(new SignalRDataSourceBuilder<T>(this.Component.DataSource));
      return this;
    }

    public DataSourceWidgetBuilder<T> Gantt(
      Action<GanttDataSourceBuilder<T>> configurator)
    {
      this.Component.ClassName = "GanttDataSource";
      this.Component.DataSource.Schema.Model = (ModelDescriptor) new GanttTaskModelDescriptor(typeof (T), this.Component.ModelMetadataProvider);
      configurator(new GanttDataSourceBuilder<T>(this.Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public DataSourceWidgetBuilder<T> GanttDependency(
      Action<GanttDependenciesDataSourceBuilder<T>> configurator)
    {
      this.Component.ClassName = "GanttDependencyDataSource";
      this.Component.DataSource.Schema.Model = (ModelDescriptor) new GanttDependencyModelDescriptor(typeof (T), this.Component.ModelMetadataProvider);
      configurator(new GanttDependenciesDataSourceBuilder<T>(this.Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public DataSourceWidgetBuilder<T> Pivot(
      Action<PivotDataSourceBuilder<T>> configurator)
    {
      this.Component.PivotDataSource = new PivotDataSource(this.Component.ModelMetadataProvider);
      this.Component.ClassName = "PivotDataSource";
      configurator(new PivotDataSourceBuilder<T>(this.Component.PivotDataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public DataSourceWidgetBuilder<T> Hierarchical(
      Action<HierarchicalDataSourceBuilder<T>> configurator)
    {
      this.Component.ClassName = "HierarchicalDataSource";
      this.Component.DataSource.Schema.Model = (ModelDescriptor) new TreeListModelDescriptor(typeof (object), this.Component.ModelMetadataProvider);
      configurator(new HierarchicalDataSourceBuilder<T>(this.Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public DataSourceWidgetBuilder<T> TreeList(
      Action<TreeListAjaxDataSourceBuilder<T>> configurator)
    {
      this.Component.ClassName = "TreeListDataSource";
      this.Component.DataSource.Schema.Model = (ModelDescriptor) new TreeListModelDescriptor(typeof (object), this.Component.ModelMetadataProvider);
      configurator(new TreeListAjaxDataSourceBuilder<T>(this.Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));
      return this;
    }

    public virtual void Render() => this.Component.Render();
  }
}
