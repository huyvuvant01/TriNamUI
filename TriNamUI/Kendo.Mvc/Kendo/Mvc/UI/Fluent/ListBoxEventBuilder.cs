// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ListBoxEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class ListBoxEventBuilder : EventBuilder
  {
    public ListBoxEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public ListBoxEventBuilder Add(string handler)
    {
      this.Handler("add", handler);
      return this;
    }

    public ListBoxEventBuilder Add(Func<object, object> handler)
    {
      this.Handler("add", handler);
      return this;
    }

    public ListBoxEventBuilder Change(string handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public ListBoxEventBuilder Change(Func<object, object> handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public ListBoxEventBuilder DataBound(string handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public ListBoxEventBuilder DataBound(Func<object, object> handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public ListBoxEventBuilder DragStart(string handler)
    {
      this.Handler("dragstart", handler);
      return this;
    }

    public ListBoxEventBuilder DragStart(Func<object, object> handler)
    {
      this.Handler("dragstart", handler);
      return this;
    }

    public ListBoxEventBuilder Drag(string handler)
    {
      this.Handler("drag", handler);
      return this;
    }

    public ListBoxEventBuilder Drag(Func<object, object> handler)
    {
      this.Handler("drag", handler);
      return this;
    }

    public ListBoxEventBuilder Drop(string handler)
    {
      this.Handler("drop", handler);
      return this;
    }

    public ListBoxEventBuilder Drop(Func<object, object> handler)
    {
      this.Handler("drop", handler);
      return this;
    }

    public ListBoxEventBuilder DragEnd(string handler)
    {
      this.Handler("dragend", handler);
      return this;
    }

    public ListBoxEventBuilder DragEnd(Func<object, object> handler)
    {
      this.Handler("dragend", handler);
      return this;
    }

    public ListBoxEventBuilder Remove(string handler)
    {
      this.Handler("remove", handler);
      return this;
    }

    public ListBoxEventBuilder Remove(Func<object, object> handler)
    {
      this.Handler("remove", handler);
      return this;
    }

    public ListBoxEventBuilder Reorder(string handler)
    {
      this.Handler("reorder", handler);
      return this;
    }

    public ListBoxEventBuilder Reorder(Func<object, object> handler)
    {
      this.Handler("reorder", handler);
      return this;
    }
  }
}
