// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.GroupDescriptor
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Kendo.Mvc.Infrastructure.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc
{
  public class GroupDescriptor : SortDescriptor
  {
    private object displayContent;
    private AggregateFunctionCollection aggregateFunctions;

    public Type MemberType { get; set; }

    public object DisplayContent
    {
      get => this.displayContent == null ? (object) this.Member : this.displayContent;
      set => this.displayContent = value;
    }

    public AggregateFunctionCollection AggregateFunctions => this.aggregateFunctions = this.aggregateFunctions ?? new AggregateFunctionCollection();

    public void CycleSortDirection() => this.SortDirection = GroupDescriptor.GetNextSortDirection(new ListSortDirection?(this.SortDirection));

    private static ListSortDirection GetNextSortDirection(
      ListSortDirection? sortDirection)
    {
      return sortDirection.HasValue && sortDirection.GetValueOrDefault() == ListSortDirection.Ascending ? ListSortDirection.Descending : ListSortDirection.Ascending;
    }

    protected override void Serialize(IDictionary<string, object> json)
    {
      base.Serialize(json);
      if (!this.AggregateFunctions.Any<AggregateFunction>())
        return;
      json["aggregates"] = (object) ((IEnumerable<JsonObject>) this.AggregateFunctions).ToJson();
    }
  }
}
