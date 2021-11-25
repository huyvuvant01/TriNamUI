// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TreeListEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class TreeListEventBuilder : EventBuilder
  {
    public TreeListEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public TreeListEventBuilder BeforeEdit(string handler)
    {
      this.Handler("beforeEdit", handler);
      return this;
    }

    public TreeListEventBuilder BeforeEdit(Func<object, object> handler)
    {
      this.Handler("beforeEdit", handler);
      return this;
    }

    public TreeListEventBuilder Cancel(string handler)
    {
      this.Handler("cancel", handler);
      return this;
    }

    public TreeListEventBuilder Cancel(Func<object, object> handler)
    {
      this.Handler("cancel", handler);
      return this;
    }

    public TreeListEventBuilder CellClose(string handler)
    {
      this.Handler("cellClose", handler);
      return this;
    }

    public TreeListEventBuilder CellClose(Func<object, object> handler)
    {
      this.Handler("cellClose", handler);
      return this;
    }

    public TreeListEventBuilder Change(string handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public TreeListEventBuilder Change(Func<object, object> handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public TreeListEventBuilder Collapse(string handler)
    {
      this.Handler("collapse", handler);
      return this;
    }

    public TreeListEventBuilder Collapse(Func<object, object> handler)
    {
      this.Handler("collapse", handler);
      return this;
    }

    public TreeListEventBuilder DataBinding(string handler)
    {
      this.Handler("dataBinding", handler);
      return this;
    }

    public TreeListEventBuilder DataBinding(Func<object, object> handler)
    {
      this.Handler("dataBinding", handler);
      return this;
    }

    public TreeListEventBuilder DataBound(string handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public TreeListEventBuilder DataBound(Func<object, object> handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public TreeListEventBuilder DragStart(string handler)
    {
      this.Handler("dragstart", handler);
      return this;
    }

    public TreeListEventBuilder DragStart(Func<object, object> handler)
    {
      this.Handler("dragstart", handler);
      return this;
    }

    public TreeListEventBuilder Drag(string handler)
    {
      this.Handler("drag", handler);
      return this;
    }

    public TreeListEventBuilder Drag(Func<object, object> handler)
    {
      this.Handler("drag", handler);
      return this;
    }

    public TreeListEventBuilder DragEnd(string handler)
    {
      this.Handler("dragend", handler);
      return this;
    }

    public TreeListEventBuilder DragEnd(Func<object, object> handler)
    {
      this.Handler("dragend", handler);
      return this;
    }

    public TreeListEventBuilder Drop(string handler)
    {
      this.Handler("drop", handler);
      return this;
    }

    public TreeListEventBuilder Drop(Func<object, object> handler)
    {
      this.Handler("drop", handler);
      return this;
    }

    public TreeListEventBuilder Edit(string handler)
    {
      this.Handler("edit", handler);
      return this;
    }

    public TreeListEventBuilder Edit(Func<object, object> handler)
    {
      this.Handler("edit", handler);
      return this;
    }

    public TreeListEventBuilder ExcelExport(string handler)
    {
      this.Handler("excelExport", handler);
      return this;
    }

    public TreeListEventBuilder ExcelExport(Func<object, object> handler)
    {
      this.Handler("excelExport", handler);
      return this;
    }

    public TreeListEventBuilder Expand(string handler)
    {
      this.Handler("expand", handler);
      return this;
    }

    public TreeListEventBuilder Expand(Func<object, object> handler)
    {
      this.Handler("expand", handler);
      return this;
    }

    public TreeListEventBuilder FilterMenuInit(string handler)
    {
      this.Handler("filterMenuInit", handler);
      return this;
    }

    public TreeListEventBuilder FilterMenuInit(Func<object, object> handler)
    {
      this.Handler("filterMenuInit", handler);
      return this;
    }

    public TreeListEventBuilder FilterMenuOpen(string handler)
    {
      this.Handler("filterMenuOpen", handler);
      return this;
    }

    public TreeListEventBuilder FilterMenuOpen(Func<object, object> handler)
    {
      this.Handler("filterMenuOpen", handler);
      return this;
    }

    public TreeListEventBuilder PdfExport(string handler)
    {
      this.Handler("pdfExport", handler);
      return this;
    }

    public TreeListEventBuilder PdfExport(Func<object, object> handler)
    {
      this.Handler("pdfExport", handler);
      return this;
    }

    public TreeListEventBuilder Remove(string handler)
    {
      this.Handler("remove", handler);
      return this;
    }

    public TreeListEventBuilder Remove(Func<object, object> handler)
    {
      this.Handler("remove", handler);
      return this;
    }

    public TreeListEventBuilder Save(string handler)
    {
      this.Handler("save", handler);
      return this;
    }

    public TreeListEventBuilder Save(Func<object, object> handler)
    {
      this.Handler("save", handler);
      return this;
    }

    public TreeListEventBuilder SaveChanges(string handler)
    {
      this.Handler("saveChanges", handler);
      return this;
    }

    public TreeListEventBuilder SaveChanges(Func<object, object> handler)
    {
      this.Handler("saveChanges", handler);
      return this;
    }

    public TreeListEventBuilder ColumnShow(string handler)
    {
      this.Handler("columnShow", handler);
      return this;
    }

    public TreeListEventBuilder ColumnShow(Func<object, object> handler)
    {
      this.Handler("columnShow", handler);
      return this;
    }

    public TreeListEventBuilder ColumnHide(string handler)
    {
      this.Handler("columnHide", handler);
      return this;
    }

    public TreeListEventBuilder ColumnHide(Func<object, object> handler)
    {
      this.Handler("columnHide", handler);
      return this;
    }

    public TreeListEventBuilder ColumnReorder(string handler)
    {
      this.Handler("columnReorder", handler);
      return this;
    }

    public TreeListEventBuilder ColumnReorder(Func<object, object> handler)
    {
      this.Handler("columnReorder", handler);
      return this;
    }

    public TreeListEventBuilder ColumnResize(string handler)
    {
      this.Handler("columnResize", handler);
      return this;
    }

    public TreeListEventBuilder ColumnResize(Func<object, object> handler)
    {
      this.Handler("columnResize", handler);
      return this;
    }

    public TreeListEventBuilder ColumnMenuInit(string handler)
    {
      this.Handler("columnMenuInit", handler);
      return this;
    }

    public TreeListEventBuilder ColumnMenuInit(Func<object, object> handler)
    {
      this.Handler("columnMenuInit", handler);
      return this;
    }

    public TreeListEventBuilder ColumnMenuOpen(string handler)
    {
      this.Handler("columnMenuOpen", handler);
      return this;
    }

    public TreeListEventBuilder ColumnMenuOpen(Func<object, object> handler)
    {
      this.Handler("columnMenuOpen", handler);
      return this;
    }

    public TreeListEventBuilder ColumnLock(string handler)
    {
      this.Handler("columnLock", handler);
      return this;
    }

    public TreeListEventBuilder ColumnLock(Func<object, object> handler)
    {
      this.Handler("columnLock", handler);
      return this;
    }

    public TreeListEventBuilder ColumnUnlock(string handler)
    {
      this.Handler("columnUnlock", handler);
      return this;
    }

    public TreeListEventBuilder ColumnUnlock(Func<object, object> handler)
    {
      this.Handler("columnUnlock", handler);
      return this;
    }
  }
}
