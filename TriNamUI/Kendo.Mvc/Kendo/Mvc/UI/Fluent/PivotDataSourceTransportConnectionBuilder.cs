// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PivotDataSourceTransportConnectionBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class PivotDataSourceTransportConnectionBuilder : IHideObjectMembers
  {
    protected readonly PivotTransportConnection connection;

    public PivotDataSourceTransportConnectionBuilder(PivotTransportConnection connection) => this.connection = connection;

    public PivotDataSourceTransportConnectionBuilder Catalog(
      string catalog)
    {
      this.connection.Catalog = catalog;
      return this;
    }

    public PivotDataSourceTransportConnectionBuilder Cube(
      string cube)
    {
      this.connection.Cube = cube;
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
