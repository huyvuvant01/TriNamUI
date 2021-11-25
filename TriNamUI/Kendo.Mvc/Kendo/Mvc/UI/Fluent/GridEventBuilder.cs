// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.GridEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class GridEventBuilder : EventBuilder
  {
    public GridEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public GridEventBuilder BeforeEdit(string handler)
    {
      this.Handler("beforeEdit", handler);
      return this;
    }

    public GridEventBuilder BeforeEdit(Func<object, object> handler)
    {
      this.Handler("beforeEdit", handler);
      return this;
    }

    public GridEventBuilder Cancel(string handler)
    {
      this.Handler("cancel", handler);
      return this;
    }

    public GridEventBuilder Cancel(Func<object, object> handler)
    {
      this.Handler("cancel", handler);
      return this;
    }

    public GridEventBuilder CellClose(string handler)
    {
      this.Handler("cellClose", handler);
      return this;
    }

    public GridEventBuilder CellClose(Func<object, object> handler)
    {
      this.Handler("cellClose", handler);
      return this;
    }

    public GridEventBuilder Change(string handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public GridEventBuilder Change(Func<object, object> handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public GridEventBuilder ColumnHide(string handler)
    {
      this.Handler("columnHide", handler);
      return this;
    }

    public GridEventBuilder ColumnHide(Func<object, object> handler)
    {
      this.Handler("columnHide", handler);
      return this;
    }

    public GridEventBuilder ColumnLock(string handler)
    {
      this.Handler("columnLock", handler);
      return this;
    }

    public GridEventBuilder ColumnLock(Func<object, object> handler)
    {
      this.Handler("columnLock", handler);
      return this;
    }

    public GridEventBuilder ColumnMenuInit(string handler)
    {
      this.Handler("columnMenuInit", handler);
      return this;
    }

    public GridEventBuilder ColumnMenuInit(Func<object, object> handler)
    {
      this.Handler("columnMenuInit", handler);
      return this;
    }

    public GridEventBuilder ColumnMenuOpen(string handler)
    {
      this.Handler("columnMenuOpen", handler);
      return this;
    }

    public GridEventBuilder ColumnMenuOpen(Func<object, object> handler)
    {
      this.Handler("columnMenuOpen", handler);
      return this;
    }

    public GridEventBuilder ColumnReorder(string handler)
    {
      this.Handler("columnReorder", handler);
      return this;
    }

    public GridEventBuilder ColumnReorder(Func<object, object> handler)
    {
      this.Handler("columnReorder", handler);
      return this;
    }

    public GridEventBuilder ColumnResize(string handler)
    {
      this.Handler("columnResize", handler);
      return this;
    }

    public GridEventBuilder ColumnResize(Func<object, object> handler)
    {
      this.Handler("columnResize", handler);
      return this;
    }

    public GridEventBuilder ColumnShow(string handler)
    {
      this.Handler("columnShow", handler);
      return this;
    }

    public GridEventBuilder ColumnShow(Func<object, object> handler)
    {
      this.Handler("columnShow", handler);
      return this;
    }

    public GridEventBuilder ColumnStick(string handler)
    {
      this.Handler("columnStick", handler);
      return this;
    }

    public GridEventBuilder ColumnStick(Func<object, object> handler)
    {
      this.Handler("columnStick", handler);
      return this;
    }

    public GridEventBuilder ColumnUnlock(string handler)
    {
      this.Handler("columnUnlock", handler);
      return this;
    }

    public GridEventBuilder ColumnUnlock(Func<object, object> handler)
    {
      this.Handler("columnUnlock", handler);
      return this;
    }

    public GridEventBuilder ColumnUnstick(string handler)
    {
      this.Handler("columnUnstick", handler);
      return this;
    }

    public GridEventBuilder ColumnUnstick(Func<object, object> handler)
    {
      this.Handler("columnUnstick", handler);
      return this;
    }

    public GridEventBuilder DataBinding(string handler)
    {
      this.Handler("dataBinding", handler);
      return this;
    }

    public GridEventBuilder DataBinding(Func<object, object> handler)
    {
      this.Handler("dataBinding", handler);
      return this;
    }

    public GridEventBuilder DataBound(string handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public GridEventBuilder DataBound(Func<object, object> handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public GridEventBuilder DetailCollapse(string handler)
    {
      this.Handler("detailCollapse", handler);
      return this;
    }

    public GridEventBuilder DetailCollapse(Func<object, object> handler)
    {
      this.Handler("detailCollapse", handler);
      return this;
    }

    public GridEventBuilder DetailExpand(string handler)
    {
      this.Handler("detailExpand", handler);
      return this;
    }

    public GridEventBuilder DetailExpand(Func<object, object> handler)
    {
      this.Handler("detailExpand", handler);
      return this;
    }

    public GridEventBuilder DetailInit(string handler)
    {
      this.Handler("detailInit", handler);
      return this;
    }

    public GridEventBuilder DetailInit(Func<object, object> handler)
    {
      this.Handler("detailInit", handler);
      return this;
    }

    public GridEventBuilder Edit(string handler)
    {
      this.Handler("edit", handler);
      return this;
    }

    public GridEventBuilder Edit(Func<object, object> handler)
    {
      this.Handler("edit", handler);
      return this;
    }

    public GridEventBuilder ExcelExport(string handler)
    {
      this.Handler("excelExport", handler);
      return this;
    }

    public GridEventBuilder ExcelExport(Func<object, object> handler)
    {
      this.Handler("excelExport", handler);
      return this;
    }

    public GridEventBuilder Filter(string handler)
    {
      this.Handler("filter", handler);
      return this;
    }

    public GridEventBuilder Filter(Func<object, object> handler)
    {
      this.Handler("filter", handler);
      return this;
    }

    public GridEventBuilder FilterMenuInit(string handler)
    {
      this.Handler("filterMenuInit", handler);
      return this;
    }

    public GridEventBuilder FilterMenuInit(Func<object, object> handler)
    {
      this.Handler("filterMenuInit", handler);
      return this;
    }

    public GridEventBuilder FilterMenuOpen(string handler)
    {
      this.Handler("filterMenuOpen", handler);
      return this;
    }

    public GridEventBuilder FilterMenuOpen(Func<object, object> handler)
    {
      this.Handler("filterMenuOpen", handler);
      return this;
    }

    public GridEventBuilder Group(string handler)
    {
      this.Handler("group", handler);
      return this;
    }

    public GridEventBuilder Group(Func<object, object> handler)
    {
      this.Handler("group", handler);
      return this;
    }

    public GridEventBuilder GroupCollapse(string handler)
    {
      this.Handler("groupCollapse", handler);
      return this;
    }

    public GridEventBuilder GroupCollapse(Func<object, object> handler)
    {
      this.Handler("groupCollapse", handler);
      return this;
    }

    public GridEventBuilder GroupExpand(string handler)
    {
      this.Handler("groupExpand", handler);
      return this;
    }

    public GridEventBuilder GroupExpand(Func<object, object> handler)
    {
      this.Handler("groupExpand", handler);
      return this;
    }

    public GridEventBuilder Navigate(string handler)
    {
      this.Handler("navigate", handler);
      return this;
    }

    public GridEventBuilder Navigate(Func<object, object> handler)
    {
      this.Handler("navigate", handler);
      return this;
    }

    public GridEventBuilder Page(string handler)
    {
      this.Handler("page", handler);
      return this;
    }

    public GridEventBuilder Page(Func<object, object> handler)
    {
      this.Handler("page", handler);
      return this;
    }

    public GridEventBuilder PdfExport(string handler)
    {
      this.Handler("pdfExport", handler);
      return this;
    }

    public GridEventBuilder PdfExport(Func<object, object> handler)
    {
      this.Handler("pdfExport", handler);
      return this;
    }

    public GridEventBuilder Remove(string handler)
    {
      this.Handler("remove", handler);
      return this;
    }

    public GridEventBuilder Remove(Func<object, object> handler)
    {
      this.Handler("remove", handler);
      return this;
    }

    public GridEventBuilder Save(string handler)
    {
      this.Handler("save", handler);
      return this;
    }

    public GridEventBuilder Save(Func<object, object> handler)
    {
      this.Handler("save", handler);
      return this;
    }

    public GridEventBuilder SaveChanges(string handler)
    {
      this.Handler("saveChanges", handler);
      return this;
    }

    public GridEventBuilder SaveChanges(Func<object, object> handler)
    {
      this.Handler("saveChanges", handler);
      return this;
    }

    public GridEventBuilder Sort(string handler)
    {
      this.Handler("sort", handler);
      return this;
    }

    public GridEventBuilder Sort(Func<object, object> handler)
    {
      this.Handler("sort", handler);
      return this;
    }
  }
}
