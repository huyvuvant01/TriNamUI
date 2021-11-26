// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.TreeDataSourceResult
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Infrastructure;
using System.Collections;
using System.Collections.Generic;

namespace Kendo.Mvc.UI
{
  public class TreeDataSourceResult
  {
    public TreeDataSourceResult() => this.AggregateResults = (IDictionary<string, IEnumerable<AggregateResult>>) new Dictionary<string, IEnumerable<AggregateResult>>();

    public IEnumerable Data { get; set; }

    public int Total { get; set; }

    public IDictionary<string, IEnumerable<AggregateResult>> AggregateResults { get; set; }

    public object Errors { get; set; }
  }
}
