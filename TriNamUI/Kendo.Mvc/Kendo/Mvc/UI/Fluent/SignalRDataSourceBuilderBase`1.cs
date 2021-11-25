// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SignalRDataSourceBuilderBase`1
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public abstract class SignalRDataSourceBuilderBase<TSignalRDataSourceBuilder> : IHideObjectMembers
    where TSignalRDataSourceBuilder : SignalRDataSourceBuilderBase<TSignalRDataSourceBuilder>
  {
    protected readonly DataSource dataSource;

    public SignalRDataSourceBuilderBase(DataSource dataSource)
    {
      this.dataSource = dataSource;
      this.dataSource.ServerPaging = false;
      this.dataSource.ServerSorting = false;
      this.dataSource.ServerGrouping = false;
      this.dataSource.ServerFiltering = false;
      this.dataSource.ServerAggregates = false;
      this.dataSource.CustomType = "signalr";
      this.dataSource.Schema.Data = "";
      this.dataSource.Schema.Total = "";
      this.dataSource.Schema.Errors = "";
      this.dataSource.Transport.SerializeEmptyPrefix = false;
    }

    public TSignalRDataSourceBuilder Events(Action<DataSourceEventBuilder> configurator)
    {
      configurator(new DataSourceEventBuilder(this.dataSource.Events));
      return (TSignalRDataSourceBuilder) this;
    }

    public TSignalRDataSourceBuilder Total(int total)
    {
      this.dataSource.Total = total;
      return (TSignalRDataSourceBuilder) this;
    }

    public TSignalRDataSourceBuilder PageSize(int pageSize)
    {
      this.dataSource.PageSize = pageSize;
      return (TSignalRDataSourceBuilder) this;
    }

    public TSignalRDataSourceBuilder Page(int page)
    {
      this.dataSource.Page = page;
      return (TSignalRDataSourceBuilder) this;
    }

    public TSignalRDataSourceBuilder AccentFoldingFiltering(string culture)
    {
      this.dataSource.AccentFoldingFiltering = culture;
      return (TSignalRDataSourceBuilder) this;
    }

    public TSignalRDataSourceBuilder ServerPaging(bool enabled)
    {
      this.dataSource.ServerPaging = enabled;
      return (TSignalRDataSourceBuilder) this;
    }

    public TSignalRDataSourceBuilder ServerSorting(bool enabled)
    {
      this.dataSource.ServerSorting = enabled;
      return (TSignalRDataSourceBuilder) this;
    }

    public TSignalRDataSourceBuilder ServerFiltering(bool enabled)
    {
      this.dataSource.ServerFiltering = enabled;
      return (TSignalRDataSourceBuilder) this;
    }

    public TSignalRDataSourceBuilder ServerGrouping(bool enabled)
    {
      this.dataSource.ServerGrouping = enabled;
      return (TSignalRDataSourceBuilder) this;
    }

    public TSignalRDataSourceBuilder ServerAggregates(bool enabled)
    {
      this.dataSource.ServerAggregates = enabled;
      return (TSignalRDataSourceBuilder) this;
    }

    public virtual TSignalRDataSourceBuilder Batch(bool enabled)
    {
      this.dataSource.Batch = enabled;
      return (TSignalRDataSourceBuilder) this;
    }

    public virtual TSignalRDataSourceBuilder AutoSync(bool enabled)
    {
      this.dataSource.AutoSync = enabled;
      return (TSignalRDataSourceBuilder) this;
    }

    public TSignalRDataSourceBuilder Transport(object settings)
    {
      Dictionary<string, object> instance = new Dictionary<string, object>();
      instance.Merge(settings);
      this.dataSource.CustomTransport = (IDictionary<string, object>) instance;
      return (TSignalRDataSourceBuilder) this;
    }

    Type IHideObjectMembers.GetType() => this.GetType();
  }
}
