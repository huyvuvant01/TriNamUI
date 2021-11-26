// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PivotDataSourceColumnFactory
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class PivotDataSourceColumnFactory : IHideObjectMembers
  {
    private readonly IList<PivotDataSourceColumn> container;

    public PivotDataSourceColumnFactory(IList<PivotDataSourceColumn> container) => this.container = container;

    public PivotDataSourceColumnBuilder Add(string name)
    {
      PivotDataSourceColumn column = new PivotDataSourceColumn();
      column.Name = name;
      this.container.Add(column);
      return new PivotDataSourceColumnBuilder(column);
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
