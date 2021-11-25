// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DataSourceSchedulerFilterDescriptorFactory`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace Kendo.Mvc.UI.Fluent
{
  public class DataSourceSchedulerFilterDescriptorFactory<TModel> : 
    DataSourceFilterDescriptorFactory<TModel>,
    IHideObjectMembers
    where TModel : class
  {
    public DataSourceSchedulerFilterDescriptorFactory(IList<IFilterDescriptor> filters)
      : base(filters)
    {
    }

    protected override CompositeFilterDescriptor CreateFilter<TValue>(
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
      Type type = typeof (ISchedulerEvent);
      string member = filterDescriptor2.Member;
      string name = member;
      if (type.GetProperty(name) != (PropertyInfo) null)
      {
        string str = char.ToLowerInvariant(member[0]).ToString() + member.Substring(1);
        filterDescriptor2.Member = str;
      }
      filterDescriptor1.FilterDescriptors.Add((IFilterDescriptor) filterDescriptor2);
      this.Filters.Add((IFilterDescriptor) filterDescriptor1);
      return filterDescriptor1;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
