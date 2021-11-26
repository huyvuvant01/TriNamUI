// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SchedulerEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class SchedulerEventBuilder : EventBuilder
  {
    public SchedulerEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public SchedulerEventBuilder Add(string handler)
    {
      this.Handler("add", handler);
      return this;
    }

    public SchedulerEventBuilder Add(Func<object, object> handler)
    {
      this.Handler("add", handler);
      return this;
    }

    public SchedulerEventBuilder Cancel(string handler)
    {
      this.Handler("cancel", handler);
      return this;
    }

    public SchedulerEventBuilder Cancel(Func<object, object> handler)
    {
      this.Handler("cancel", handler);
      return this;
    }

    public SchedulerEventBuilder Change(string handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public SchedulerEventBuilder Change(Func<object, object> handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public SchedulerEventBuilder DataBinding(string handler)
    {
      this.Handler("dataBinding", handler);
      return this;
    }

    public SchedulerEventBuilder DataBinding(Func<object, object> handler)
    {
      this.Handler("dataBinding", handler);
      return this;
    }

    public SchedulerEventBuilder DataBound(string handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public SchedulerEventBuilder DataBound(Func<object, object> handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public SchedulerEventBuilder Edit(string handler)
    {
      this.Handler("edit", handler);
      return this;
    }

    public SchedulerEventBuilder Edit(Func<object, object> handler)
    {
      this.Handler("edit", handler);
      return this;
    }

    public SchedulerEventBuilder MoveStart(string handler)
    {
      this.Handler("moveStart", handler);
      return this;
    }

    public SchedulerEventBuilder MoveStart(Func<object, object> handler)
    {
      this.Handler("moveStart", handler);
      return this;
    }

    public SchedulerEventBuilder Move(string handler)
    {
      this.Handler("move", handler);
      return this;
    }

    public SchedulerEventBuilder Move(Func<object, object> handler)
    {
      this.Handler("move", handler);
      return this;
    }

    public SchedulerEventBuilder MoveEnd(string handler)
    {
      this.Handler("moveEnd", handler);
      return this;
    }

    public SchedulerEventBuilder MoveEnd(Func<object, object> handler)
    {
      this.Handler("moveEnd", handler);
      return this;
    }

    public SchedulerEventBuilder Navigate(string handler)
    {
      this.Handler("navigate", handler);
      return this;
    }

    public SchedulerEventBuilder Navigate(Func<object, object> handler)
    {
      this.Handler("navigate", handler);
      return this;
    }

    public SchedulerEventBuilder PdfExport(string handler)
    {
      this.Handler("pdfExport", handler);
      return this;
    }

    public SchedulerEventBuilder PdfExport(Func<object, object> handler)
    {
      this.Handler("pdfExport", handler);
      return this;
    }

    public SchedulerEventBuilder Remove(string handler)
    {
      this.Handler("remove", handler);
      return this;
    }

    public SchedulerEventBuilder Remove(Func<object, object> handler)
    {
      this.Handler("remove", handler);
      return this;
    }

    public SchedulerEventBuilder ResizeStart(string handler)
    {
      this.Handler("resizeStart", handler);
      return this;
    }

    public SchedulerEventBuilder ResizeStart(Func<object, object> handler)
    {
      this.Handler("resizeStart", handler);
      return this;
    }

    public SchedulerEventBuilder Resize(string handler)
    {
      this.Handler("resize", handler);
      return this;
    }

    public SchedulerEventBuilder Resize(Func<object, object> handler)
    {
      this.Handler("resize", handler);
      return this;
    }

    public SchedulerEventBuilder ResizeEnd(string handler)
    {
      this.Handler("resizeEnd", handler);
      return this;
    }

    public SchedulerEventBuilder ResizeEnd(Func<object, object> handler)
    {
      this.Handler("resizeEnd", handler);
      return this;
    }

    public SchedulerEventBuilder Save(string handler)
    {
      this.Handler("save", handler);
      return this;
    }

    public SchedulerEventBuilder Save(Func<object, object> handler)
    {
      this.Handler("save", handler);
      return this;
    }
  }
}
