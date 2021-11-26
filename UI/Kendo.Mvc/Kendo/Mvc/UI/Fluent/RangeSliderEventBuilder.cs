// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.RangeSliderEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class RangeSliderEventBuilder : EventBuilder
  {
    public RangeSliderEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public RangeSliderEventBuilder Change(string handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public RangeSliderEventBuilder Change(Func<object, object> handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public RangeSliderEventBuilder Slide(string handler)
    {
      this.Handler("slide", handler);
      return this;
    }

    public RangeSliderEventBuilder Slide(Func<object, object> handler)
    {
      this.Handler("slide", handler);
      return this;
    }
  }
}
