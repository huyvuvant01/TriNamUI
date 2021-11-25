// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MultiSelectEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class MultiSelectEventBuilder : EventBuilder
  {
    public MultiSelectEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public MultiSelectEventBuilder Change(string handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public MultiSelectEventBuilder Change(Func<object, object> handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public MultiSelectEventBuilder Close(string handler)
    {
      this.Handler("close", handler);
      return this;
    }

    public MultiSelectEventBuilder Close(Func<object, object> handler)
    {
      this.Handler("close", handler);
      return this;
    }

    public MultiSelectEventBuilder DataBound(string handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public MultiSelectEventBuilder DataBound(Func<object, object> handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public MultiSelectEventBuilder Filtering(string handler)
    {
      this.Handler("filtering", handler);
      return this;
    }

    public MultiSelectEventBuilder Filtering(Func<object, object> handler)
    {
      this.Handler("filtering", handler);
      return this;
    }

    public MultiSelectEventBuilder Open(string handler)
    {
      this.Handler("open", handler);
      return this;
    }

    public MultiSelectEventBuilder Open(Func<object, object> handler)
    {
      this.Handler("open", handler);
      return this;
    }

    public MultiSelectEventBuilder Select(string handler)
    {
      this.Handler("select", handler);
      return this;
    }

    public MultiSelectEventBuilder Select(Func<object, object> handler)
    {
      this.Handler("select", handler);
      return this;
    }

    public MultiSelectEventBuilder Deselect(string handler)
    {
      this.Handler("deselect", handler);
      return this;
    }

    public MultiSelectEventBuilder Deselect(Func<object, object> handler)
    {
      this.Handler("deselect", handler);
      return this;
    }
  }
}
