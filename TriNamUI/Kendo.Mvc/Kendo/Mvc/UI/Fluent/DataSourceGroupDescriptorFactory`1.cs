// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DataSourceGroupDescriptorFactory`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
  public class DataSourceGroupDescriptorFactory<TModel> : IHideObjectMembers where TModel : class
  {
    private readonly IList<GroupDescriptor> descriptors;

    public DataSourceGroupDescriptorFactory(IList<GroupDescriptor> descriptors) => this.descriptors = descriptors;

    public DataSourceGroupDescriptorBuilder<TModel> Add<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      return this.AddDescriptor<TValue>(expression.MemberWithoutInstance(), ListSortDirection.Ascending);
    }

    public DataSourceGroupDescriptorBuilder<TModel> Add<TValue>(
      string memberName)
    {
      return this.AddDescriptor<TValue>(memberName, ListSortDirection.Ascending);
    }

    public DataSourceGroupDescriptorBuilder<TModel> Add(
      string memberName,
      Type memberType)
    {
      return this.AddDescriptor(memberName, memberType, ListSortDirection.Ascending);
    }

    public DataSourceGroupDescriptorBuilder<TModel> Add(
      string memberName,
      Type memberType,
      ListSortDirection sortDirection)
    {
      return this.AddDescriptor(memberName, memberType, sortDirection);
    }

    public DataSourceGroupDescriptorBuilder<TModel> Add<TValue>(
      string memberName,
      ListSortDirection sortDirection)
    {
      return this.AddDescriptor<TValue>(memberName, sortDirection);
    }

    public DataSourceGroupDescriptorBuilder<TModel> Add<TValue>(
      string memberName,
      ListSortDirection sortDirection,
      string sortCompare)
    {
      return this.AddDescriptor<TValue>(memberName, sortDirection, sortCompare);
    }

    public DataSourceGroupDescriptorBuilder<TModel> AddDescending<TValue>(
      Expression<Func<TModel, TValue>> expression)
    {
      return this.AddDescriptor<TValue>(expression.MemberWithoutInstance(), ListSortDirection.Descending);
    }

    public DataSourceGroupDescriptorBuilder<TModel> AddDescending<TValue>(
      string memberName)
    {
      return this.AddDescriptor<TValue>(memberName, ListSortDirection.Descending);
    }

    public DataSourceGroupDescriptorBuilder<TModel> AddDescending(
      string memberName,
      Type memberType)
    {
      return this.AddDescriptor(memberName, memberType, ListSortDirection.Descending);
    }

    private DataSourceGroupDescriptorBuilder<TModel> AddDescriptor<TValue>(
      string memberName,
      ListSortDirection sortDirection,
      string sortCompare = null)
    {
      return this.AddDescriptor(memberName, typeof (TValue), sortDirection, sortCompare);
    }

    private DataSourceGroupDescriptorBuilder<TModel> AddDescriptor(
      string memberName,
      Type memberType,
      ListSortDirection sortDirection,
      string sortCompare = null)
    {
      GroupDescriptor descriptor = new GroupDescriptor();
      descriptor.Member = memberName;
      descriptor.SortDirection = sortDirection;
      descriptor.MemberType = memberType;
      descriptor.SortCompare = new ClientHandlerDescriptor()
      {
        HandlerName = sortCompare
      };
      this.descriptors.Add(descriptor);
      return new DataSourceGroupDescriptorBuilder<TModel>(descriptor);
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
