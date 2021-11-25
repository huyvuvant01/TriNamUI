// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ReadOnlyAjaxDataSourceBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;

namespace Kendo.Mvc.UI.Fluent
{
  public class ReadOnlyAjaxDataSourceBuilder<TModel> : 
    AjaxDataSourceBuilderBase<TModel, ReadOnlyAjaxDataSourceBuilder<TModel>>
    where TModel : class
  {
    public ReadOnlyAjaxDataSourceBuilder(
      DataSource dataSource,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
      : base(dataSource, viewContext, urlGenerator)
    {
    }

    public ReadOnlyWebApiDataSourceBuilder<TModel> WebApi()
    {
      this.dataSource.Type = new DataSourceType?(DataSourceType.WebApi);
      return new ReadOnlyWebApiDataSourceBuilder<TModel>(this.dataSource, this.viewContext, this.urlGenerator);
    }

    public ReadOnlyCustomDataSourceBuilder Custom()
    {
      this.dataSource.Type = new DataSourceType?(DataSourceType.Custom);
      return new ReadOnlyCustomDataSourceBuilder(this.dataSource, this.viewContext, this.urlGenerator);
    }

    public SignalRDataSourceBuilder<TModel> SignalR()
    {
      this.dataSource.Type = new DataSourceType?(DataSourceType.Custom);
      return new SignalRDataSourceBuilder<TModel>(this.dataSource);
    }
  }
}
