// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.CustomDataSourceBuilderBase`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public abstract class CustomDataSourceBuilderBase<TCustomDataSourceBuilder> : IHideObjectMembers
    where TCustomDataSourceBuilder : CustomDataSourceBuilderBase<TCustomDataSourceBuilder>
  {
    protected readonly DataSource dataSource;
    protected readonly IUrlGenerator urlGenerator;
    protected readonly ViewContext viewContext;

    public CustomDataSourceBuilderBase(
      DataSource dataSource,
      ViewContext viewContext,
      IUrlGenerator urlGenerator)
    {
      this.viewContext = viewContext;
      this.urlGenerator = urlGenerator;
      this.dataSource = dataSource;
      this.dataSource.ServerPaging = false;
      this.dataSource.ServerSorting = false;
      this.dataSource.ServerGrouping = false;
      this.dataSource.ServerFiltering = false;
      this.dataSource.ServerAggregates = false;
      this.dataSource.Schema.Data = "";
      this.dataSource.Schema.Total = "";
      this.dataSource.Schema.Errors = "";
      this.dataSource.Transport.SerializeEmptyPrefix = false;
    }

    public TCustomDataSourceBuilder Events(Action<DataSourceEventBuilder> configurator)
    {
      configurator(new DataSourceEventBuilder(this.dataSource.Events));
      return (TCustomDataSourceBuilder) this;
    }

    public TCustomDataSourceBuilder Total(int total)
    {
      this.dataSource.Total = total;
      return (TCustomDataSourceBuilder) this;
    }

    public TCustomDataSourceBuilder PageSize(int pageSize)
    {
      this.dataSource.PageSize = pageSize;
      return (TCustomDataSourceBuilder) this;
    }

    public TCustomDataSourceBuilder AccentFoldingFiltering(string culture)
    {
      this.dataSource.AccentFoldingFiltering = culture;
      return (TCustomDataSourceBuilder) this;
    }

    public TCustomDataSourceBuilder Page(int page)
    {
      this.dataSource.Page = page;
      return (TCustomDataSourceBuilder) this;
    }

    public TCustomDataSourceBuilder ServerPaging(bool enabled)
    {
      this.dataSource.ServerPaging = enabled;
      return (TCustomDataSourceBuilder) this;
    }

    public TCustomDataSourceBuilder ServerSorting(bool enabled)
    {
      this.dataSource.ServerSorting = enabled;
      return (TCustomDataSourceBuilder) this;
    }

    public TCustomDataSourceBuilder ServerFiltering(bool enabled)
    {
      this.dataSource.ServerFiltering = enabled;
      return (TCustomDataSourceBuilder) this;
    }

    public TCustomDataSourceBuilder ServerGrouping(bool enabled)
    {
      this.dataSource.ServerGrouping = enabled;
      return (TCustomDataSourceBuilder) this;
    }

    public TCustomDataSourceBuilder ServerAggregates(bool enabled)
    {
      this.dataSource.ServerAggregates = enabled;
      return (TCustomDataSourceBuilder) this;
    }

    public virtual TCustomDataSourceBuilder Batch(bool enabled)
    {
      this.dataSource.Batch = enabled;
      return (TCustomDataSourceBuilder) this;
    }

    public virtual TCustomDataSourceBuilder AutoSync(bool enabled)
    {
      this.dataSource.AutoSync = enabled;
      return (TCustomDataSourceBuilder) this;
    }

    public TCustomDataSourceBuilder Transport(object settings)
    {
      Dictionary<string, object> instance = new Dictionary<string, object>();
      instance.Merge(settings);
      this.dataSource.CustomTransport = (IDictionary<string, object>) instance;
      return (TCustomDataSourceBuilder) this;
    }

    public TCustomDataSourceBuilder Type(string type)
    {
      this.dataSource.CustomType = type;
      return (TCustomDataSourceBuilder) this;
    }

    System.Type IHideObjectMembers.GetType() => this.GetType();
  }
}
