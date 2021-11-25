// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DiagramEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class DiagramEventBuilder : EventBuilder
  {
    public DiagramEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public DiagramEventBuilder Add(string handler)
    {
      this.Handler("add", handler);
      return this;
    }

    public DiagramEventBuilder Add(Func<object, object> handler)
    {
      this.Handler("add", handler);
      return this;
    }

    public DiagramEventBuilder Cancel(string handler)
    {
      this.Handler("cancel", handler);
      return this;
    }

    public DiagramEventBuilder Cancel(Func<object, object> handler)
    {
      this.Handler("cancel", handler);
      return this;
    }

    public DiagramEventBuilder Change(string handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public DiagramEventBuilder Change(Func<object, object> handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public DiagramEventBuilder Click(string handler)
    {
      this.Handler("click", handler);
      return this;
    }

    public DiagramEventBuilder Click(Func<object, object> handler)
    {
      this.Handler("click", handler);
      return this;
    }

    public DiagramEventBuilder DataBound(string handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public DiagramEventBuilder DataBound(Func<object, object> handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public DiagramEventBuilder Drag(string handler)
    {
      this.Handler("drag", handler);
      return this;
    }

    public DiagramEventBuilder Drag(Func<object, object> handler)
    {
      this.Handler("drag", handler);
      return this;
    }

    public DiagramEventBuilder DragEnd(string handler)
    {
      this.Handler("dragEnd", handler);
      return this;
    }

    public DiagramEventBuilder DragEnd(Func<object, object> handler)
    {
      this.Handler("dragEnd", handler);
      return this;
    }

    public DiagramEventBuilder DragStart(string handler)
    {
      this.Handler("dragStart", handler);
      return this;
    }

    public DiagramEventBuilder DragStart(Func<object, object> handler)
    {
      this.Handler("dragStart", handler);
      return this;
    }

    public DiagramEventBuilder Edit(string handler)
    {
      this.Handler("edit", handler);
      return this;
    }

    public DiagramEventBuilder Edit(Func<object, object> handler)
    {
      this.Handler("edit", handler);
      return this;
    }

    public DiagramEventBuilder ItemBoundsChange(string handler)
    {
      this.Handler("itemBoundsChange", handler);
      return this;
    }

    public DiagramEventBuilder ItemBoundsChange(Func<object, object> handler)
    {
      this.Handler("itemBoundsChange", handler);
      return this;
    }

    public DiagramEventBuilder ItemRotate(string handler)
    {
      this.Handler("itemRotate", handler);
      return this;
    }

    public DiagramEventBuilder ItemRotate(Func<object, object> handler)
    {
      this.Handler("itemRotate", handler);
      return this;
    }

    public DiagramEventBuilder MouseEnter(string handler)
    {
      this.Handler("mouseEnter", handler);
      return this;
    }

    public DiagramEventBuilder MouseEnter(Func<object, object> handler)
    {
      this.Handler("mouseEnter", handler);
      return this;
    }

    public DiagramEventBuilder MouseLeave(string handler)
    {
      this.Handler("mouseLeave", handler);
      return this;
    }

    public DiagramEventBuilder MouseLeave(Func<object, object> handler)
    {
      this.Handler("mouseLeave", handler);
      return this;
    }

    public DiagramEventBuilder Pan(string handler)
    {
      this.Handler("pan", handler);
      return this;
    }

    public DiagramEventBuilder Pan(Func<object, object> handler)
    {
      this.Handler("pan", handler);
      return this;
    }

    public DiagramEventBuilder Remove(string handler)
    {
      this.Handler("remove", handler);
      return this;
    }

    public DiagramEventBuilder Remove(Func<object, object> handler)
    {
      this.Handler("remove", handler);
      return this;
    }

    public DiagramEventBuilder Save(string handler)
    {
      this.Handler("save", handler);
      return this;
    }

    public DiagramEventBuilder Save(Func<object, object> handler)
    {
      this.Handler("save", handler);
      return this;
    }

    public DiagramEventBuilder Select(string handler)
    {
      this.Handler("select", handler);
      return this;
    }

    public DiagramEventBuilder Select(Func<object, object> handler)
    {
      this.Handler("select", handler);
      return this;
    }

    public DiagramEventBuilder ToolBarClick(string handler)
    {
      this.Handler("toolBarClick", handler);
      return this;
    }

    public DiagramEventBuilder ToolBarClick(Func<object, object> handler)
    {
      this.Handler("toolBarClick", handler);
      return this;
    }

    public DiagramEventBuilder ZoomEnd(string handler)
    {
      this.Handler("zoomEnd", handler);
      return this;
    }

    public DiagramEventBuilder ZoomEnd(Func<object, object> handler)
    {
      this.Handler("zoomEnd", handler);
      return this;
    }

    public DiagramEventBuilder ZoomStart(string handler)
    {
      this.Handler("zoomStart", handler);
      return this;
    }

    public DiagramEventBuilder ZoomStart(Func<object, object> handler)
    {
      this.Handler("zoomStart", handler);
      return this;
    }
  }
}
