// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TimelineEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class TimelineEventBuilder : EventBuilder
  {
    public TimelineEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public TimelineEventBuilder Change(string handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public TimelineEventBuilder Change(Func<object, object> handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public TimelineEventBuilder DataBound(string handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public TimelineEventBuilder DataBound(Func<object, object> handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public TimelineEventBuilder Expand(string handler)
    {
      this.Handler("expand", handler);
      return this;
    }

    public TimelineEventBuilder Expand(Func<object, object> handler)
    {
      this.Handler("expand", handler);
      return this;
    }

    public TimelineEventBuilder Collapse(string handler)
    {
      this.Handler("collapse", handler);
      return this;
    }

    public TimelineEventBuilder Collapse(Func<object, object> handler)
    {
      this.Handler("collapse", handler);
      return this;
    }

    public TimelineEventBuilder ActionClick(string handler)
    {
      this.Handler("actionClick", handler);
      return this;
    }

    public TimelineEventBuilder ActionClick(Func<object, object> handler)
    {
      this.Handler("actionClick", handler);
      return this;
    }

    public TimelineEventBuilder Navigate(string handler)
    {
      this.Handler("navigate", handler);
      return this;
    }

    public TimelineEventBuilder Navigate(Func<object, object> handler)
    {
      this.Handler("navigate", handler);
      return this;
    }
  }
}
