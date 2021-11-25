// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DataSourceEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class DataSourceEventBuilder : EventBuilder
  {
    public DataSourceEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public DataSourceEventBuilder Change(string handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public DataSourceEventBuilder Change(Func<object, object> handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public DataSourceEventBuilder Sync(string handler)
    {
      this.Handler("sync", handler);
      return this;
    }

    public DataSourceEventBuilder Sync(Func<object, object> handler)
    {
      this.Handler("sync", handler);
      return this;
    }

    public DataSourceEventBuilder RequestStart(string handler)
    {
      this.Handler("requestStart", handler);
      return this;
    }

    public DataSourceEventBuilder RequestStart(Func<object, object> handler)
    {
      this.Handler("requestStart", handler);
      return this;
    }

    public DataSourceEventBuilder RequestEnd(string handler)
    {
      this.Handler("requestEnd", handler);
      return this;
    }

    public DataSourceEventBuilder RequestEnd(Func<object, object> handler)
    {
      this.Handler("requestEnd", handler);
      return this;
    }

    public DataSourceEventBuilder Error(string handler)
    {
      this.Handler("error", handler);
      return this;
    }

    public DataSourceEventBuilder Error(Func<object, object> handler)
    {
      this.Handler("error", handler);
      return this;
    }

    public DataSourceEventBuilder Push(string handler)
    {
      this.Handler("push", handler);
      return this;
    }

    public DataSourceEventBuilder Push(Func<object, object> handler)
    {
      this.Handler("push", handler);
      return this;
    }
  }
}
