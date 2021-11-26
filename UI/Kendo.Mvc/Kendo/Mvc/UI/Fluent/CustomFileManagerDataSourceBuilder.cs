// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.CustomFileManagerDataSourceBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class CustomFileManagerDataSourceBuilder : 
    CustomDataSourceBuilderBase<CustomFileManagerDataSourceBuilder>
  {
    public CustomFileManagerDataSourceBuilder(
      DataSource dataSource,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
      : base(dataSource, viewContext, urlGenerator)
    {
    }

    public CustomFileManagerDataSourceBuilder Transport(
      Action<CustomDataSourceTransportBuilder> configurator)
    {
      configurator(new CustomDataSourceTransportBuilder(this.dataSource.Transport, this.viewContext, this.urlGenerator));
      return this;
    }

    public CustomFileManagerDataSourceBuilder Schema(
      Action<CustomHierarchicalDataSourceSchemaBuilder<object>> configurator)
    {
      configurator(new CustomHierarchicalDataSourceSchemaBuilder<object>(this.dataSource.Schema, this.viewContext, this.urlGenerator));
      return this;
    }

    public virtual CustomFileManagerDataSourceBuilder Filter(
      Action<ReadOnlyCustomDataSourceFilterDescriptorFactory> configurator)
    {
      configurator(new ReadOnlyCustomDataSourceFilterDescriptorFactory(this.dataSource.Filters));
      return this;
    }

    public virtual CustomFileManagerDataSourceBuilder Sort(
      Action<ReadOnlyCustomDataSourceSortDescriptorFactory> configurator)
    {
      configurator(new ReadOnlyCustomDataSourceSortDescriptorFactory(this.dataSource.OrderBy));
      return this;
    }
  }
}
