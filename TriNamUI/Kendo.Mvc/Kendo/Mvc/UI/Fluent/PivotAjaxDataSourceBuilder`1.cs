// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PivotAjaxDataSourceBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class PivotAjaxDataSourceBuilder<TModel> where TModel : class
  {
    protected readonly PivotDataSource dataSource;
    protected readonly IUrlGenerator urlGenerator;
    protected readonly ViewContext viewContext;

    public PivotAjaxDataSourceBuilder(
      PivotDataSource dataSource,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
    {
      this.viewContext = viewContext;
      this.urlGenerator = urlGenerator;
      this.dataSource = dataSource;
      this.dataSource.Schema.Data = "Data";
      this.dataSource.Schema.Total = "Total";
      this.dataSource.Schema.Errors = "Errors";
    }

    public PivotAjaxDataSourceBuilder<TModel> Events(
      Action<DataSourceEventBuilder> configurator)
    {
      configurator(new DataSourceEventBuilder(this.dataSource.Events));
      return this;
    }

    public PivotAjaxDataSourceBuilder<TModel> Transport(
      Action<PivotAjaxDataSourceTransportBuilder> configurator)
    {
      configurator(new PivotAjaxDataSourceTransportBuilder(this.dataSource.Transport, this.viewContext, this.urlGenerator));
      return this;
    }

    public PivotAjaxDataSourceBuilder<TModel> Columns(
      Action<PivotDataSourceColumnFactory> addColumnAction)
    {
      PivotDataSourceColumnFactory sourceColumnFactory = new PivotDataSourceColumnFactory(this.dataSource.Columns);
      addColumnAction(sourceColumnFactory);
      return this;
    }

    public PivotAjaxDataSourceBuilder<TModel> Rows(
      Action<PivotDataSourceRowFactory> addRowAction)
    {
      PivotDataSourceRowFactory sourceRowFactory = new PivotDataSourceRowFactory(this.dataSource.Rows);
      addRowAction(sourceRowFactory);
      return this;
    }

    public PivotAjaxDataSourceBuilder<TModel> Measures(
      Action<PivotDataSourceMeasureBuilder> configurator)
    {
      configurator(new PivotDataSourceMeasureBuilder(this.dataSource.Measure));
      return this;
    }

    public PivotAjaxDataSourceBuilder<TModel> Schema(
      Action<PivotAjaxDataSourceSchemaBuilder<TModel>> configurator)
    {
      configurator(new PivotAjaxDataSourceSchemaBuilder<TModel>(this.dataSource.Schema));
      return this;
    }

    public PivotAjaxDataSourceBuilder<TModel> Sort(
      Action<DataSourceSortDescriptorFactory<TModel>> configurator)
    {
      configurator(new DataSourceSortDescriptorFactory<TModel>(this.dataSource.OrderBy));
      return this;
    }
  }
}
