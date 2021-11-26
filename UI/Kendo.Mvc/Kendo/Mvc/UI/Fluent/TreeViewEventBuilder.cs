// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TreeViewEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class TreeViewEventBuilder : EventBuilder
  {
    public TreeViewEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public TreeViewEventBuilder Change(string handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public TreeViewEventBuilder Change(Func<object, object> handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public TreeViewEventBuilder Check(string handler)
    {
      this.Handler("check", handler);
      return this;
    }

    public TreeViewEventBuilder Check(Func<object, object> handler)
    {
      this.Handler("check", handler);
      return this;
    }

    public TreeViewEventBuilder Collapse(string handler)
    {
      this.Handler("collapse", handler);
      return this;
    }

    public TreeViewEventBuilder Collapse(Func<object, object> handler)
    {
      this.Handler("collapse", handler);
      return this;
    }

    public TreeViewEventBuilder DataBound(string handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public TreeViewEventBuilder DataBound(Func<object, object> handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public TreeViewEventBuilder Drag(string handler)
    {
      this.Handler("drag", handler);
      return this;
    }

    public TreeViewEventBuilder Drag(Func<object, object> handler)
    {
      this.Handler("drag", handler);
      return this;
    }

    public TreeViewEventBuilder DragEnd(string handler)
    {
      this.Handler("dragend", handler);
      return this;
    }

    public TreeViewEventBuilder DragEnd(Func<object, object> handler)
    {
      this.Handler("dragend", handler);
      return this;
    }

    public TreeViewEventBuilder DragStart(string handler)
    {
      this.Handler("dragstart", handler);
      return this;
    }

    public TreeViewEventBuilder DragStart(Func<object, object> handler)
    {
      this.Handler("dragstart", handler);
      return this;
    }

    public TreeViewEventBuilder Drop(string handler)
    {
      this.Handler("drop", handler);
      return this;
    }

    public TreeViewEventBuilder Drop(Func<object, object> handler)
    {
      this.Handler("drop", handler);
      return this;
    }

    public TreeViewEventBuilder Expand(string handler)
    {
      this.Handler("expand", handler);
      return this;
    }

    public TreeViewEventBuilder Expand(Func<object, object> handler)
    {
      this.Handler("expand", handler);
      return this;
    }

    public TreeViewEventBuilder KendoKeydown(string handler)
    {
      this.Handler("kendoKeydown", handler);
      return this;
    }

    public TreeViewEventBuilder KendoKeydown(Func<object, object> handler)
    {
      this.Handler("kendoKeydown", handler);
      return this;
    }

    public TreeViewEventBuilder Navigate(string handler)
    {
      this.Handler("navigate", handler);
      return this;
    }

    public TreeViewEventBuilder Navigate(Func<object, object> handler)
    {
      this.Handler("navigate", handler);
      return this;
    }

    public TreeViewEventBuilder Select(string handler)
    {
      this.Handler("select", handler);
      return this;
    }

    public TreeViewEventBuilder Select(Func<object, object> handler)
    {
      this.Handler("select", handler);
      return this;
    }
  }
}
