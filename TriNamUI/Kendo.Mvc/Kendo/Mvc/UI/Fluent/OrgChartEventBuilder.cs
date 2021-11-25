// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.OrgChartEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class OrgChartEventBuilder : EventBuilder
  {
    public OrgChartEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public OrgChartEventBuilder Cancel(string handler)
    {
      this.Handler("cancel", handler);
      return this;
    }

    public OrgChartEventBuilder Cancel(Func<object, object> handler)
    {
      this.Handler("cancel", handler);
      return this;
    }

    public OrgChartEventBuilder Change(string handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public OrgChartEventBuilder Change(Func<object, object> handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public OrgChartEventBuilder Collapse(string handler)
    {
      this.Handler("collapse", handler);
      return this;
    }

    public OrgChartEventBuilder Collapse(Func<object, object> handler)
    {
      this.Handler("collapse", handler);
      return this;
    }

    public OrgChartEventBuilder Create(string handler)
    {
      this.Handler("create", handler);
      return this;
    }

    public OrgChartEventBuilder Create(Func<object, object> handler)
    {
      this.Handler("create", handler);
      return this;
    }

    public OrgChartEventBuilder DataBinding(string handler)
    {
      this.Handler("dataBinding", handler);
      return this;
    }

    public OrgChartEventBuilder DataBinding(Func<object, object> handler)
    {
      this.Handler("dataBinding", handler);
      return this;
    }

    public OrgChartEventBuilder DataBound(string handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public OrgChartEventBuilder DataBound(Func<object, object> handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public OrgChartEventBuilder Delete(string handler)
    {
      this.Handler("delete", handler);
      return this;
    }

    public OrgChartEventBuilder Delete(Func<object, object> handler)
    {
      this.Handler("delete", handler);
      return this;
    }

    public OrgChartEventBuilder Edit(string handler)
    {
      this.Handler("edit", handler);
      return this;
    }

    public OrgChartEventBuilder Edit(Func<object, object> handler)
    {
      this.Handler("edit", handler);
      return this;
    }

    public OrgChartEventBuilder Expand(string handler)
    {
      this.Handler("expand", handler);
      return this;
    }

    public OrgChartEventBuilder Expand(Func<object, object> handler)
    {
      this.Handler("expand", handler);
      return this;
    }

    public OrgChartEventBuilder Save(string handler)
    {
      this.Handler("save", handler);
      return this;
    }

    public OrgChartEventBuilder Save(Func<object, object> handler)
    {
      this.Handler("save", handler);
      return this;
    }

    public OrgChartEventBuilder Select(string handler)
    {
      this.Handler("select", handler);
      return this;
    }

    public OrgChartEventBuilder Select(Func<object, object> handler)
    {
      this.Handler("select", handler);
      return this;
    }
  }
}
