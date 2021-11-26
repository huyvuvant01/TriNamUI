// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DataSourceAggregatesFactory
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class DataSourceAggregatesFactory : IHideObjectMembers
  {
    private readonly ICollection<AggregateFunction> aggregates;
    private readonly string member;
    private readonly Type memberType;

    public DataSourceAggregatesFactory(
      ICollection<AggregateFunction> aggregates,
      string member,
      Type memberType)
    {
      this.aggregates = aggregates;
      this.member = member;
      this.memberType = memberType;
    }

    public DataSourceAggregatesFactory Min()
    {
      ICollection<AggregateFunction> aggregates = this.aggregates;
      MinFunction minFunction = new MinFunction();
      minFunction.SourceField = this.member;
      aggregates.Add((AggregateFunction) minFunction);
      return this;
    }

    public DataSourceAggregatesFactory Max()
    {
      ICollection<AggregateFunction> aggregates = this.aggregates;
      MaxFunction maxFunction = new MaxFunction();
      maxFunction.SourceField = this.member;
      aggregates.Add((AggregateFunction) maxFunction);
      return this;
    }

    public DataSourceAggregatesFactory Count()
    {
      ICollection<AggregateFunction> aggregates = this.aggregates;
      CountFunction countFunction = new CountFunction();
      countFunction.SourceField = this.member;
      aggregates.Add((AggregateFunction) countFunction);
      return this;
    }

    public DataSourceAggregatesFactory Average()
    {
      ICollection<AggregateFunction> aggregates = this.aggregates;
      AverageFunction averageFunction = new AverageFunction();
      averageFunction.SourceField = this.member;
      averageFunction.MemberType = this.memberType;
      aggregates.Add((AggregateFunction) averageFunction);
      return this;
    }

    public DataSourceAggregatesFactory Sum()
    {
      ICollection<AggregateFunction> aggregates = this.aggregates;
      SumFunction sumFunction = new SumFunction();
      sumFunction.SourceField = this.member;
      sumFunction.MemberType = this.memberType;
      aggregates.Add((AggregateFunction) sumFunction);
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
