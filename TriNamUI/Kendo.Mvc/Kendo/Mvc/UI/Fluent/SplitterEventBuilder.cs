// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SplitterEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class SplitterEventBuilder : EventBuilder
  {
    public SplitterEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public SplitterEventBuilder Collapse(string handler)
    {
      this.Handler("collapse", handler);
      return this;
    }

    public SplitterEventBuilder Collapse(Func<object, object> handler)
    {
      this.Handler("collapse", handler);
      return this;
    }

    public SplitterEventBuilder ContentLoad(string handler)
    {
      this.Handler("contentLoad", handler);
      return this;
    }

    public SplitterEventBuilder ContentLoad(Func<object, object> handler)
    {
      this.Handler("contentLoad", handler);
      return this;
    }

    public SplitterEventBuilder Error(string handler)
    {
      this.Handler("error", handler);
      return this;
    }

    public SplitterEventBuilder Error(Func<object, object> handler)
    {
      this.Handler("error", handler);
      return this;
    }

    public SplitterEventBuilder Expand(string handler)
    {
      this.Handler("expand", handler);
      return this;
    }

    public SplitterEventBuilder Expand(Func<object, object> handler)
    {
      this.Handler("expand", handler);
      return this;
    }

    public SplitterEventBuilder LayoutChange(string handler)
    {
      this.Handler("layoutChange", handler);
      return this;
    }

    public SplitterEventBuilder LayoutChange(Func<object, object> handler)
    {
      this.Handler("layoutChange", handler);
      return this;
    }

    public SplitterEventBuilder Resize(string handler)
    {
      this.Handler("resize", handler);
      return this;
    }

    public SplitterEventBuilder Resize(Func<object, object> handler)
    {
      this.Handler("resize", handler);
      return this;
    }
  }
}
