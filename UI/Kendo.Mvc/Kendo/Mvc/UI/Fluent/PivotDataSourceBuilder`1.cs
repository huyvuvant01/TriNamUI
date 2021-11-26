// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PivotDataSourceBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class PivotDataSourceBuilder<TModel> : IHideObjectMembers where TModel : class
  {
    protected readonly PivotDataSource dataSource;
    protected readonly IUrlGenerator urlGenerator;
    protected readonly ViewContext viewContext;

    public PivotDataSourceBuilder(
      PivotDataSource dataSource,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
    {
      this.viewContext = viewContext;
      this.urlGenerator = urlGenerator;
      this.dataSource = dataSource;
    }

    public PivotXmlaDataSourceBuilder Xmla()
    {
      this.dataSource.Type = new PivotDataSourceType?(PivotDataSourceType.Xmla);
      this.dataSource.Schema.Type = "xmla";
      return new PivotXmlaDataSourceBuilder(this.dataSource, this.viewContext, this.urlGenerator);
    }

    public PivotCustomDataSourceBuilder Custom()
    {
      this.dataSource.Type = new PivotDataSourceType?(PivotDataSourceType.Custom);
      return new PivotCustomDataSourceBuilder(this.dataSource, this.viewContext, this.urlGenerator);
    }

    public PivotAjaxDataSourceBuilder<TModel> Ajax()
    {
      this.dataSource.Type = new PivotDataSourceType?(PivotDataSourceType.Ajax);
      return new PivotAjaxDataSourceBuilder<TModel>(this.dataSource, this.viewContext, this.urlGenerator);
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
