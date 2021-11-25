// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PivotXmlaDataSourceBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class PivotXmlaDataSourceBuilder : IHideObjectMembers
  {
    protected readonly PivotDataSource dataSource;
    protected readonly IUrlGenerator urlGenerator;
    protected readonly ViewContext viewContext;

    public PivotXmlaDataSourceBuilder(
      PivotDataSource dataSource,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
    {
      this.viewContext = viewContext;
      this.urlGenerator = urlGenerator;
      this.dataSource = dataSource;
      this.dataSource.Transport.SerializeEmptyPrefix = false;
    }

    public PivotXmlaDataSourceBuilder Events(
      Action<DataSourceEventBuilder> configurator)
    {
      configurator(new DataSourceEventBuilder(this.dataSource.Events));
      return this;
    }

    public PivotXmlaDataSourceBuilder Transport(
      Action<PivotDataSourceTransportBuilder> configurator)
    {
      configurator(new PivotDataSourceTransportBuilder(this.dataSource.Transport, this.viewContext, this.urlGenerator));
      return this;
    }

    public PivotXmlaDataSourceBuilder Columns(
      Action<PivotDataSourceColumnFactory> addColumnAction)
    {
      PivotDataSourceColumnFactory sourceColumnFactory = new PivotDataSourceColumnFactory(this.dataSource.Columns);
      addColumnAction(sourceColumnFactory);
      return this;
    }

    public PivotXmlaDataSourceBuilder Rows(
      Action<PivotDataSourceRowFactory> addRowAction)
    {
      PivotDataSourceRowFactory sourceRowFactory = new PivotDataSourceRowFactory(this.dataSource.Rows);
      addRowAction(sourceRowFactory);
      return this;
    }

    public PivotXmlaDataSourceBuilder Measures(
      Action<PivotDataSourceMeasureBuilder> configurator)
    {
      configurator(new PivotDataSourceMeasureBuilder(this.dataSource.Measure));
      return this;
    }

    public PivotXmlaDataSourceBuilder Sort(
      Action<DataSourceSortDescriptorFactory<object>> configurator)
    {
      configurator(new DataSourceSortDescriptorFactory<object>(this.dataSource.OrderBy));
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
