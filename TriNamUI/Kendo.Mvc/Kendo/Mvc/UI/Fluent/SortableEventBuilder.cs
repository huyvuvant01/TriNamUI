// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SortableEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class SortableEventBuilder : EventBuilder
  {
    public SortableEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public SortableEventBuilder Start(string handler)
    {
      this.Handler("start", handler);
      return this;
    }

    public SortableEventBuilder Start(Func<object, object> handler)
    {
      this.Handler("start", handler);
      return this;
    }

    public SortableEventBuilder Move(string handler)
    {
      this.Handler("move", handler);
      return this;
    }

    public SortableEventBuilder Move(Func<object, object> handler)
    {
      this.Handler("move", handler);
      return this;
    }

    public SortableEventBuilder End(string handler)
    {
      this.Handler("end", handler);
      return this;
    }

    public SortableEventBuilder End(Func<object, object> handler)
    {
      this.Handler("end", handler);
      return this;
    }

    public SortableEventBuilder Change(string handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public SortableEventBuilder Change(Func<object, object> handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public SortableEventBuilder Cancel(string handler)
    {
      this.Handler("cancel", handler);
      return this;
    }

    public SortableEventBuilder Cancel(Func<object, object> handler)
    {
      this.Handler("cancel", handler);
      return this;
    }
  }
}
