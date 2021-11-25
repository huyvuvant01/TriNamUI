// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ListViewEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class ListViewEventBuilder : EventBuilder
  {
    public ListViewEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public ListViewEventBuilder Cancel(string handler)
    {
      this.Handler("cancel", handler);
      return this;
    }

    public ListViewEventBuilder Cancel(Func<object, object> handler)
    {
      this.Handler("cancel", handler);
      return this;
    }

    public ListViewEventBuilder Change(string handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public ListViewEventBuilder Change(Func<object, object> handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public ListViewEventBuilder DataBound(string handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public ListViewEventBuilder DataBound(Func<object, object> handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public ListViewEventBuilder DataBinding(string handler)
    {
      this.Handler("dataBinding", handler);
      return this;
    }

    public ListViewEventBuilder DataBinding(Func<object, object> handler)
    {
      this.Handler("dataBinding", handler);
      return this;
    }

    public ListViewEventBuilder Edit(string handler)
    {
      this.Handler("edit", handler);
      return this;
    }

    public ListViewEventBuilder Edit(Func<object, object> handler)
    {
      this.Handler("edit", handler);
      return this;
    }

    public ListViewEventBuilder Remove(string handler)
    {
      this.Handler("remove", handler);
      return this;
    }

    public ListViewEventBuilder Remove(Func<object, object> handler)
    {
      this.Handler("remove", handler);
      return this;
    }

    public ListViewEventBuilder Save(string handler)
    {
      this.Handler("save", handler);
      return this;
    }

    public ListViewEventBuilder Save(Func<object, object> handler)
    {
      this.Handler("save", handler);
      return this;
    }
  }
}
