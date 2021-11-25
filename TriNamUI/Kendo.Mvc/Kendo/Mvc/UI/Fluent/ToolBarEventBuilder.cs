// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ToolBarEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class ToolBarEventBuilder : EventBuilder
  {
    public ToolBarEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public ToolBarEventBuilder Click(string handler)
    {
      this.Handler("click", handler);
      return this;
    }

    public ToolBarEventBuilder Click(Func<object, object> handler)
    {
      this.Handler("click", handler);
      return this;
    }

    public ToolBarEventBuilder Close(string handler)
    {
      this.Handler("close", handler);
      return this;
    }

    public ToolBarEventBuilder Close(Func<object, object> handler)
    {
      this.Handler("close", handler);
      return this;
    }

    public ToolBarEventBuilder Open(string handler)
    {
      this.Handler("open", handler);
      return this;
    }

    public ToolBarEventBuilder Open(Func<object, object> handler)
    {
      this.Handler("open", handler);
      return this;
    }

    public ToolBarEventBuilder Toggle(string handler)
    {
      this.Handler("toggle", handler);
      return this;
    }

    public ToolBarEventBuilder Toggle(Func<object, object> handler)
    {
      this.Handler("toggle", handler);
      return this;
    }

    public ToolBarEventBuilder OverflowClose(string handler)
    {
      this.Handler("overflowClose", handler);
      return this;
    }

    public ToolBarEventBuilder OverflowClose(Func<object, object> handler)
    {
      this.Handler("overflowClose", handler);
      return this;
    }

    public ToolBarEventBuilder OverflowOpen(string handler)
    {
      this.Handler("overflowOpen", handler);
      return this;
    }

    public ToolBarEventBuilder OverflowOpen(Func<object, object> handler)
    {
      this.Handler("overflowOpen", handler);
      return this;
    }
  }
}
