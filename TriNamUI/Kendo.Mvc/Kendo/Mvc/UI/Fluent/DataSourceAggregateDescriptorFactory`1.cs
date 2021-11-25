// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DataSourceAggregateDescriptorFactory`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
  public class DataSourceAggregateDescriptorFactory<TModel> : IHideObjectMembers where TModel : class
  {
    private readonly IList<AggregateDescriptor> descriptors;

    public DataSourceAggregateDescriptorFactory(IList<AggregateDescriptor> descriptors) => this.descriptors = descriptors;

    public DataSourceAggregatesFactory Add<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      return this.AddDescriptor(expression.MemberWithoutInstance(), typeof (TValue));
    }

    public DataSourceAggregatesFactory Add(
      string memberName,
      Type memberType)
    {
      return this.AddDescriptor(memberName, memberType);
    }

    private DataSourceAggregatesFactory AddDescriptor(
      string memberName,
      Type memberType)
    {
      AggregateDescriptor aggregateDescriptor = new AggregateDescriptor();
      aggregateDescriptor.Member = memberName;
      this.descriptors.Add(aggregateDescriptor);
      return new DataSourceAggregatesFactory(aggregateDescriptor.Aggregates, memberName, memberType);
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
