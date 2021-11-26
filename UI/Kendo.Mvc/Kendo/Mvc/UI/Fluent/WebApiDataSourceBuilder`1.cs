// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.WebApiDataSourceBuilder`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class WebApiDataSourceBuilder<TModel> : 
    WebApiDataSourceBuilderBase<TModel, WebApiDataSourceBuilder<TModel>>,
    IHideObjectMembers
    where TModel : class
  {
    public WebApiDataSourceBuilder(
      DataSource dataSource,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
      : base(dataSource, viewContext, urlGenerator)
    {
    }

    public WebApiDataSourceBuilder<TModel> Update(
      Action<CrudOperationBuilder> configurator)
    {
      configurator(new CrudOperationBuilder(this.dataSource.Transport.Update, this.viewContext, this.urlGenerator));
      return this;
    }

    public WebApiDataSourceBuilder<TModel> Update(string url)
    {
      this.dataSource.Transport.Update.Url = url;
      return this;
    }

    public WebApiDataSourceBuilder<TModel> Update(
      string actionName,
      string controllerName)
    {
      this.SetOperationUrl(this.dataSource.Transport.Update, actionName, controllerName, (object) null);
      return this;
    }

    public WebApiDataSourceBuilder<TModel> Update(
      string actionName,
      string controllerName,
      object routeValues)
    {
      this.SetOperationUrl(this.dataSource.Transport.Update, actionName, controllerName, routeValues);
      return this;
    }

    public WebApiDataSourceBuilder<TModel> Create(
      Action<CrudOperationBuilder> configurator)
    {
      configurator(new CrudOperationBuilder(this.dataSource.Transport.Create, this.viewContext, this.urlGenerator));
      return this;
    }

    public WebApiDataSourceBuilder<TModel> Create(string url)
    {
      this.dataSource.Transport.Create.Url = url;
      return this;
    }

    public WebApiDataSourceBuilder<TModel> Create(
      string actionName,
      string controllerName)
    {
      this.SetOperationUrl(this.dataSource.Transport.Create, actionName, controllerName, (object) null);
      return this;
    }

    public WebApiDataSourceBuilder<TModel> Create(
      string actionName,
      string controllerName,
      object routeValues)
    {
      this.SetOperationUrl(this.dataSource.Transport.Create, actionName, controllerName, routeValues);
      return this;
    }

    public WebApiDataSourceBuilder<TModel> Destroy(
      Action<CrudOperationBuilder> configurator)
    {
      configurator(new CrudOperationBuilder(this.dataSource.Transport.Destroy, this.viewContext, this.urlGenerator));
      return this;
    }

    public WebApiDataSourceBuilder<TModel> Destroy(string url)
    {
      this.dataSource.Transport.Destroy.Url = url;
      return this;
    }

    public WebApiDataSourceBuilder<TModel> Destroy(
      string actionName,
      string controllerName)
    {
      this.SetOperationUrl(this.dataSource.Transport.Destroy, actionName, controllerName, (object) null);
      return this;
    }

    public WebApiDataSourceBuilder<TModel> Destroy(
      string actionName,
      string controllerName,
      object routeValues)
    {
      this.SetOperationUrl(this.dataSource.Transport.Destroy, actionName, controllerName, routeValues);
      return this;
    }

    public virtual WebApiDataSourceBuilder<TModel> AutoSync(bool enabled)
    {
      this.dataSource.AutoSync = enabled;
      return this;
    }

    public virtual WebApiDataSourceBuilder<TModel> Batch(bool enabled)
    {
      this.dataSource.Batch = enabled;
      return this;
    }

    public WebApiDataSourceBuilder<TModel> GroupPaging(bool enabled)
    {
      this.dataSource.GroupPaging = enabled;
      return this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
