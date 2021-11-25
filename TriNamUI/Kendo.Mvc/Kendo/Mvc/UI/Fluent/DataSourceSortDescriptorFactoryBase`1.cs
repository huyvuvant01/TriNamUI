// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DataSourceSortDescriptorFactoryBase`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public abstract class DataSourceSortDescriptorFactoryBase<TDataSourceSortDescriptorFactory> : 
    IHideObjectMembers
    where TDataSourceSortDescriptorFactory : DataSourceSortDescriptorFactoryBase<TDataSourceSortDescriptorFactory>
  {
    private readonly IList<SortDescriptor> descriptors;

    public DataSourceSortDescriptorFactoryBase(IList<SortDescriptor> descriptors) => this.descriptors = descriptors;

    public virtual DataSourceSortDescriptorBuilder Add(
      string memberName)
    {
      return this.Add(new SortDescriptor()
      {
        Member = memberName,
        SortDirection = ListSortDirection.Ascending
      });
    }

    protected DataSourceSortDescriptorBuilder Add(
      SortDescriptor descriptor)
    {
      this.descriptors.Add(descriptor);
      return new DataSourceSortDescriptorBuilder(descriptor);
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
