// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DataSourceSortDescriptorFactory`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
  public class DataSourceSortDescriptorFactory<TModel> : 
    DataSourceSortDescriptorFactoryBase<DataSourceSortDescriptorFactory<TModel>>,
    IHideObjectMembers
    where TModel : class
  {
    public DataSourceSortDescriptorFactory(IList<SortDescriptor> descriptors)
      : base(descriptors)
    {
    }

    public virtual DataSourceSortDescriptorBuilder Add<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      return this.Add(new SortDescriptor()
      {
        Member = expression.MemberWithoutInstance(),
        SortDirection = ListSortDirection.Ascending
      });
    }

    public virtual DataSourceSortDescriptorBuilder Add<TValue>(
      string fieldName)
    {
      return this.Add(new SortDescriptor()
      {
        Member = fieldName,
        SortDirection = ListSortDirection.Ascending
      });
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
