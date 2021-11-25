// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TooltipEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class TooltipEventBuilder : EventBuilder
  {
    public TooltipEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public TooltipEventBuilder ContentLoad(string handler)
    {
      this.Handler("contentLoad", handler);
      return this;
    }

    public TooltipEventBuilder ContentLoad(Func<object, object> handler)
    {
      this.Handler("contentLoad", handler);
      return this;
    }

    public TooltipEventBuilder Show(string handler)
    {
      this.Handler("show", handler);
      return this;
    }

    public TooltipEventBuilder Show(Func<object, object> handler)
    {
      this.Handler("show", handler);
      return this;
    }

    public TooltipEventBuilder Hide(string handler)
    {
      this.Handler("hide", handler);
      return this;
    }

    public TooltipEventBuilder Hide(Func<object, object> handler)
    {
      this.Handler("hide", handler);
      return this;
    }

    public TooltipEventBuilder RequestStart(string handler)
    {
      this.Handler("requestStart", handler);
      return this;
    }

    public TooltipEventBuilder RequestStart(Func<object, object> handler)
    {
      this.Handler("requestStart", handler);
      return this;
    }

    public TooltipEventBuilder Error(string handler)
    {
      this.Handler("error", handler);
      return this;
    }

    public TooltipEventBuilder Error(Func<object, object> handler)
    {
      this.Handler("error", handler);
      return this;
    }
  }
}
