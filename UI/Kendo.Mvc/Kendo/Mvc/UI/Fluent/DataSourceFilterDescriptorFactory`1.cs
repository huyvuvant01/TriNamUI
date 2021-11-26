// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DataSourceFilterDescriptorFactory`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
  public class DataSourceFilterDescriptorFactory<TModel> : 
    DataSourceFilterDescriptorFactoryBase,
    IHideObjectMembers
    where TModel : class
  {
    public DataSourceFilterDescriptorFactory(IList<IFilterDescriptor> filters)
      : base(filters)
    {
    }

    public virtual DataSourceFilterEqualityDescriptorBuilder<bool> Add(
      Expression<Func<TModel, bool>> expression)
    {
      return new DataSourceFilterEqualityDescriptorBuilder<bool>(this.CreateFilter<bool>(expression));
    }

    public virtual DataSourceFilterEqualityDescriptorBuilder<bool?> Add(
      Expression<Func<TModel, bool?>> expression)
    {
      return new DataSourceFilterEqualityDescriptorBuilder<bool?>(this.CreateFilter<bool?>(expression));
    }

    public virtual DataSourceFilterComparisonDescriptorBuilder<TValue> Add<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      return new DataSourceFilterComparisonDescriptorBuilder<TValue>(this.CreateFilter<TValue>(expression));
    }

    public virtual DataSourceFilterStringDescriptorBuilder Add(
      Expression<Func<TModel, string>> expression)
    {
      return new DataSourceFilterStringDescriptorBuilder(this.CreateFilter<string>(expression));
    }

    protected virtual CompositeFilterDescriptor CreateFilter<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      CompositeFilterDescriptor filterDescriptor1 = new CompositeFilterDescriptor()
      {
        LogicalOperator = FilterCompositionLogicalOperator.And
      };
      FilterDescriptor filterDescriptor2 = new FilterDescriptor()
      {
        Member = expression.MemberWithoutInstance()
      };
      filterDescriptor1.FilterDescriptors.Add((IFilterDescriptor) filterDescriptor2);
      this.Filters.Add((IFilterDescriptor) filterDescriptor1);
      return filterDescriptor1;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
