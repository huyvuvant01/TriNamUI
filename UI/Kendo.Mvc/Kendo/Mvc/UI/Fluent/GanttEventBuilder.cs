// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GanttEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class GanttEventBuilder : EventBuilder
  {
    public GanttEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public GanttEventBuilder DataBinding(string handler)
    {
      this.Handler("dataBinding", handler);
      return this;
    }

    public GanttEventBuilder DataBinding(Func<object, object> handler)
    {
      this.Handler("dataBinding", handler);
      return this;
    }

    public GanttEventBuilder DataBound(string handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public GanttEventBuilder DataBound(Func<object, object> handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public GanttEventBuilder Add(string handler)
    {
      this.Handler("add", handler);
      return this;
    }

    public GanttEventBuilder Add(Func<object, object> handler)
    {
      this.Handler("add", handler);
      return this;
    }

    public GanttEventBuilder Edit(string handler)
    {
      this.Handler("edit", handler);
      return this;
    }

    public GanttEventBuilder Edit(Func<object, object> handler)
    {
      this.Handler("edit", handler);
      return this;
    }

    public GanttEventBuilder Remove(string handler)
    {
      this.Handler("remove", handler);
      return this;
    }

    public GanttEventBuilder Remove(Func<object, object> handler)
    {
      this.Handler("remove", handler);
      return this;
    }

    public GanttEventBuilder Cancel(string handler)
    {
      this.Handler("cancel", handler);
      return this;
    }

    public GanttEventBuilder Cancel(Func<object, object> handler)
    {
      this.Handler("cancel", handler);
      return this;
    }

    public GanttEventBuilder Save(string handler)
    {
      this.Handler("save", handler);
      return this;
    }

    public GanttEventBuilder Save(Func<object, object> handler)
    {
      this.Handler("save", handler);
      return this;
    }

    public GanttEventBuilder Change(string handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public GanttEventBuilder Change(Func<object, object> handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public GanttEventBuilder ColumnHide(string handler)
    {
      this.Handler("columnHide", handler);
      return this;
    }

    public GanttEventBuilder ColumnHide(Func<object, object> handler)
    {
      this.Handler("columnHide", handler);
      return this;
    }

    public GanttEventBuilder ColumnReorder(string handler)
    {
      this.Handler("columnReorder", handler);
      return this;
    }

    public GanttEventBuilder ColumnReorder(Func<object, object> handler)
    {
      this.Handler("columnReorder", handler);
      return this;
    }

    public GanttEventBuilder ColumnResize(string handler)
    {
      this.Handler("columnResize", handler);
      return this;
    }

    public GanttEventBuilder ColumnResize(Func<object, object> handler)
    {
      this.Handler("columnResize", handler);
      return this;
    }

    public GanttEventBuilder ColumnShow(string handler)
    {
      this.Handler("columnShow", handler);
      return this;
    }

    public GanttEventBuilder ColumnShow(Func<object, object> handler)
    {
      this.Handler("columnShow", handler);
      return this;
    }

    public GanttEventBuilder Navigate(string handler)
    {
      this.Handler("navigate", handler);
      return this;
    }

    public GanttEventBuilder Navigate(Func<object, object> handler)
    {
      this.Handler("navigate", handler);
      return this;
    }

    public GanttEventBuilder MoveStart(string handler)
    {
      this.Handler("moveStart", handler);
      return this;
    }

    public GanttEventBuilder MoveStart(Func<object, object> handler)
    {
      this.Handler("moveStart", handler);
      return this;
    }

    public GanttEventBuilder Move(string handler)
    {
      this.Handler("move", handler);
      return this;
    }

    public GanttEventBuilder Move(Func<object, object> handler)
    {
      this.Handler("move", handler);
      return this;
    }

    public GanttEventBuilder MoveEnd(string handler)
    {
      this.Handler("moveEnd", handler);
      return this;
    }

    public GanttEventBuilder MoveEnd(Func<object, object> handler)
    {
      this.Handler("moveEnd", handler);
      return this;
    }

    public GanttEventBuilder PdfExport(string handler)
    {
      this.Handler("pdfExport", handler);
      return this;
    }

    public GanttEventBuilder PdfExport(Func<object, object> handler)
    {
      this.Handler("pdfExport", handler);
      return this;
    }

    public GanttEventBuilder ResizeStart(string handler)
    {
      this.Handler("resizeStart", handler);
      return this;
    }

    public GanttEventBuilder ResizeStart(Func<object, object> handler)
    {
      this.Handler("resizeStart", handler);
      return this;
    }

    public GanttEventBuilder Resize(string handler)
    {
      this.Handler("resize", handler);
      return this;
    }

    public GanttEventBuilder Resize(Func<object, object> handler)
    {
      this.Handler("resize", handler);
      return this;
    }

    public GanttEventBuilder ResizeEnd(string handler)
    {
      this.Handler("resizeEnd", handler);
      return this;
    }

    public GanttEventBuilder ResizeEnd(Func<object, object> handler)
    {
      this.Handler("resizeEnd", handler);
      return this;
    }

    public GanttEventBuilder TogglePlannedTasks(string handler)
    {
      this.Handler("togglePlannedTasks", handler);
      return this;
    }

    public GanttEventBuilder TogglePlannedTasks(Func<object, object> handler)
    {
      this.Handler("togglePlannedTasks", handler);
      return this;
    }
  }
}
