// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.DataSourceRequest
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class DataSourceRequest
  {
    public DataSourceRequest()
    {
      this.Page = 1;
      this.Aggregates = (IList<AggregateDescriptor>) new List<AggregateDescriptor>();
    }

    public int Page { get; set; }

    public int PageSize { get; set; }

    public IList<SortDescriptor> Sorts { get; set; }

    public IList<IFilterDescriptor> Filters { get; set; }

    public IList<GroupDescriptor> Groups { get; set; }

    public IList<AggregateDescriptor> Aggregates { get; set; }

    public bool GroupPaging { get; set; }

    public bool IncludeSubGroupCount { get; set; }

    public int Skip { get; set; }

    public int Take { get; set; }
  }
}
