// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ReadOnlyCustomDataSourceBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ReadOnlyCustomDataSourceBuilder : 
    CustomDataSourceBuilderBase<ReadOnlyCustomDataSourceBuilder>
  {
    public ReadOnlyCustomDataSourceBuilder(
      DataSource dataSource,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
      : base(dataSource, viewContext, urlGenerator)
    {
    }

    public virtual ReadOnlyCustomDataSourceBuilder Group(
      Action<ReadOnlyCustomDataSourceGroupDescriptorFactory> configurator)
    {
      configurator(new ReadOnlyCustomDataSourceGroupDescriptorFactory(this.dataSource.Groups));
      return this;
    }

    public ReadOnlyCustomDataSourceBuilder Transport(
      Action<ReadOnlyCustomDataSourceTransportBuilder> configurator)
    {
      configurator(new ReadOnlyCustomDataSourceTransportBuilder(this.dataSource.Transport, this.viewContext, this.urlGenerator));
      return this;
    }

    public ReadOnlyCustomDataSourceBuilder Schema(
      Action<ReadOnlyCustomDataSourceSchemaBuilder<object>> configurator)
    {
      configurator(new ReadOnlyCustomDataSourceSchemaBuilder<object>(this.dataSource.Schema, this.dataSource.ModelMetaDataProvider));
      return this;
    }

    public virtual ReadOnlyCustomDataSourceBuilder Filter(
      Action<ReadOnlyCustomDataSourceFilterDescriptorFactory> configurator)
    {
      configurator(new ReadOnlyCustomDataSourceFilterDescriptorFactory(this.dataSource.Filters));
      return this;
    }

    public virtual ReadOnlyCustomDataSourceBuilder Sort(
      Action<ReadOnlyCustomDataSourceSortDescriptorFactory> configurator)
    {
      configurator(new ReadOnlyCustomDataSourceSortDescriptorFactory(this.dataSource.OrderBy));
      return this;
    }
  }
}
