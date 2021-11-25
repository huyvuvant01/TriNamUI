// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.Infrastructure.Implementation.Expressions.GroupDescriptorCollectionExpressionBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.Infrastructure.Implementation.Expressions
{
  public class GroupDescriptorCollectionExpressionBuilder : ExpressionBuilderBase
  {
    private readonly IQueryable queryable;
    private readonly IEnumerable<GroupDescriptor> groupDescriptors;
    private readonly IQueryable notPagedData;
    private readonly bool includeItems;

    public GroupDescriptorCollectionExpressionBuilder(
      IQueryable queryable,
      IEnumerable<GroupDescriptor> groupDescriptors,
      IQueryable notPagedData)
      : base(queryable.ElementType)
    {
      this.queryable = queryable;
      this.groupDescriptors = groupDescriptors;
      this.notPagedData = notPagedData;
    }

    public GroupDescriptorCollectionExpressionBuilder(
      IQueryable queryable,
      IEnumerable<GroupDescriptor> groupDescriptors,
      IQueryable notPagedData,
      bool includeItems)
      : base(queryable.ElementType)
    {
      this.queryable = queryable;
      this.groupDescriptors = groupDescriptors;
      this.notPagedData = notPagedData;
      this.includeItems = includeItems;
    }

    public IQueryable CreateQuery()
    {
      GroupDescriptorExpressionBuilder childBuilder = (GroupDescriptorExpressionBuilder) null;
      foreach (GroupDescriptor groupDescriptor in this.groupDescriptors.Reverse<GroupDescriptor>())
      {
        GroupDescriptorExpressionBuilder expressionBuilder = new GroupDescriptorExpressionBuilder(this.queryable, groupDescriptor, childBuilder, this.notPagedData, this.includeItems);
        expressionBuilder.Options.LiftMemberAccessToNull = this.queryable.Provider.IsLinqToObjectsProvider();
        childBuilder = expressionBuilder;
      }
      return childBuilder != null ? childBuilder.CreateQuery() : this.queryable;
    }
  }
}
