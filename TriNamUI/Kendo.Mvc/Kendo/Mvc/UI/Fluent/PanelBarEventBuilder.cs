// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PanelBarEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class PanelBarEventBuilder : EventBuilder
  {
    public PanelBarEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public PanelBarEventBuilder Activate(string handler)
    {
      this.Handler("activate", handler);
      return this;
    }

    public PanelBarEventBuilder Activate(Func<object, object> handler)
    {
      this.Handler("activate", handler);
      return this;
    }

    public PanelBarEventBuilder Collapse(string handler)
    {
      this.Handler("collapse", handler);
      return this;
    }

    public PanelBarEventBuilder Collapse(Func<object, object> handler)
    {
      this.Handler("collapse", handler);
      return this;
    }

    public PanelBarEventBuilder ContentLoad(string handler)
    {
      this.Handler("contentLoad", handler);
      return this;
    }

    public PanelBarEventBuilder ContentLoad(Func<object, object> handler)
    {
      this.Handler("contentLoad", handler);
      return this;
    }

    public PanelBarEventBuilder DataBound(string handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public PanelBarEventBuilder DataBound(Func<object, object> handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public PanelBarEventBuilder Error(string handler)
    {
      this.Handler("error", handler);
      return this;
    }

    public PanelBarEventBuilder Error(Func<object, object> handler)
    {
      this.Handler("error", handler);
      return this;
    }

    public PanelBarEventBuilder Expand(string handler)
    {
      this.Handler("expand", handler);
      return this;
    }

    public PanelBarEventBuilder Expand(Func<object, object> handler)
    {
      this.Handler("expand", handler);
      return this;
    }

    public PanelBarEventBuilder Select(string handler)
    {
      this.Handler("select", handler);
      return this;
    }

    public PanelBarEventBuilder Select(Func<object, object> handler)
    {
      this.Handler("select", handler);
      return this;
    }
  }
}
