// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PivotDataSourceRowFactory
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class PivotDataSourceRowFactory : IHideObjectMembers
  {
    private readonly IList<PivotDataSourceRow> container;

    public PivotDataSourceRowFactory(IList<PivotDataSourceRow> container) => this.container = container;

    public PivotDataSourceRowBuilder Add(string name)
    {
      PivotDataSourceRow row = new PivotDataSourceRow();
      row.Name = name;
      this.container.Add(row);
      return new PivotDataSourceRowBuilder(row);
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
