// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DataSourceBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class DataSourceBuilder<TModel> : IHideObjectMembers where TModel : class
  {
    protected readonly DataSource dataSource;
    protected readonly IUrlGenerator urlGenerator;
    protected readonly ViewContext viewContext;

    public DataSourceBuilder(
      DataSource dataSource,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
    {
      this.viewContext = viewContext;
      this.urlGenerator = urlGenerator;
      this.dataSource = dataSource;
    }

    public AjaxDataSourceBuilder<TModel> Ajax()
    {
      this.dataSource.Type = new DataSourceType?(DataSourceType.Ajax);
      return new AjaxDataSourceBuilder<TModel>(this.dataSource, this.viewContext, this.urlGenerator);
    }

    public WebApiDataSourceBuilder<TModel> WebApi()
    {
      this.dataSource.Type = new DataSourceType?(DataSourceType.WebApi);
      return new WebApiDataSourceBuilder<TModel>(this.dataSource, this.viewContext, this.urlGenerator);
    }

    public CustomDataSourceBuilder<TModel> Custom()
    {
      this.dataSource.Type = new DataSourceType?(DataSourceType.Custom);
      return new CustomDataSourceBuilder<TModel>(this.dataSource, this.viewContext, this.urlGenerator);
    }

    public SignalRDataSourceBuilder<TModel> SignalR()
    {
      this.dataSource.Type = new DataSourceType?(DataSourceType.Custom);
      return new SignalRDataSourceBuilder<TModel>(this.dataSource);
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
