// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SpreadsheetEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class SpreadsheetEventBuilder : EventBuilder
  {
    public SpreadsheetEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public SpreadsheetEventBuilder InsertSheet(string handler)
    {
      this.Handler("insertSheet", handler);
      return this;
    }

    public SpreadsheetEventBuilder InsertSheet(Func<object, object> handler)
    {
      this.Handler("insertSheet", handler);
      return this;
    }

    public SpreadsheetEventBuilder RemoveSheet(string handler)
    {
      this.Handler("removeSheet", handler);
      return this;
    }

    public SpreadsheetEventBuilder RemoveSheet(Func<object, object> handler)
    {
      this.Handler("removeSheet", handler);
      return this;
    }

    public SpreadsheetEventBuilder RenameSheet(string handler)
    {
      this.Handler("renameSheet", handler);
      return this;
    }

    public SpreadsheetEventBuilder RenameSheet(Func<object, object> handler)
    {
      this.Handler("renameSheet", handler);
      return this;
    }

    public SpreadsheetEventBuilder SelectSheet(string handler)
    {
      this.Handler("selectSheet", handler);
      return this;
    }

    public SpreadsheetEventBuilder SelectSheet(Func<object, object> handler)
    {
      this.Handler("selectSheet", handler);
      return this;
    }

    public SpreadsheetEventBuilder UnhideColumn(string handler)
    {
      this.Handler("unhideColumn", handler);
      return this;
    }

    public SpreadsheetEventBuilder UnhideColumn(Func<object, object> handler)
    {
      this.Handler("unhideColumn", handler);
      return this;
    }

    public SpreadsheetEventBuilder UnhideRow(string handler)
    {
      this.Handler("unhideRow", handler);
      return this;
    }

    public SpreadsheetEventBuilder UnhideRow(Func<object, object> handler)
    {
      this.Handler("unhideRow", handler);
      return this;
    }

    public SpreadsheetEventBuilder HideColumn(string handler)
    {
      this.Handler("hideColumn", handler);
      return this;
    }

    public SpreadsheetEventBuilder HideColumn(Func<object, object> handler)
    {
      this.Handler("hideColumn", handler);
      return this;
    }

    public SpreadsheetEventBuilder HideRow(string handler)
    {
      this.Handler("hideRow", handler);
      return this;
    }

    public SpreadsheetEventBuilder HideRow(Func<object, object> handler)
    {
      this.Handler("hideRow", handler);
      return this;
    }

    public SpreadsheetEventBuilder DeleteColumn(string handler)
    {
      this.Handler("deleteColumn", handler);
      return this;
    }

    public SpreadsheetEventBuilder DeleteColumn(Func<object, object> handler)
    {
      this.Handler("deleteColumn", handler);
      return this;
    }

    public SpreadsheetEventBuilder DeleteRow(string handler)
    {
      this.Handler("deleteRow", handler);
      return this;
    }

    public SpreadsheetEventBuilder DeleteRow(Func<object, object> handler)
    {
      this.Handler("deleteRow", handler);
      return this;
    }

    public SpreadsheetEventBuilder InsertColumn(string handler)
    {
      this.Handler("insertColumn", handler);
      return this;
    }

    public SpreadsheetEventBuilder InsertColumn(Func<object, object> handler)
    {
      this.Handler("insertColumn", handler);
      return this;
    }

    public SpreadsheetEventBuilder InsertRow(string handler)
    {
      this.Handler("insertRow", handler);
      return this;
    }

    public SpreadsheetEventBuilder InsertRow(Func<object, object> handler)
    {
      this.Handler("insertRow", handler);
      return this;
    }

    public SpreadsheetEventBuilder Select(string handler)
    {
      this.Handler("select", handler);
      return this;
    }

    public SpreadsheetEventBuilder Select(Func<object, object> handler)
    {
      this.Handler("select", handler);
      return this;
    }

    public SpreadsheetEventBuilder ChangeFormat(string handler)
    {
      this.Handler("changeFormat", handler);
      return this;
    }

    public SpreadsheetEventBuilder ChangeFormat(Func<object, object> handler)
    {
      this.Handler("changeFormat", handler);
      return this;
    }

    public SpreadsheetEventBuilder Changing(string handler)
    {
      this.Handler("changing", handler);
      return this;
    }

    public SpreadsheetEventBuilder Changing(Func<object, object> handler)
    {
      this.Handler("changing", handler);
      return this;
    }

    public SpreadsheetEventBuilder Change(string handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public SpreadsheetEventBuilder Change(Func<object, object> handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public SpreadsheetEventBuilder Render(string handler)
    {
      this.Handler("render", handler);
      return this;
    }

    public SpreadsheetEventBuilder Render(Func<object, object> handler)
    {
      this.Handler("render", handler);
      return this;
    }

    public SpreadsheetEventBuilder ExcelExport(string handler)
    {
      this.Handler("excelExport", handler);
      return this;
    }

    public SpreadsheetEventBuilder ExcelExport(Func<object, object> handler)
    {
      this.Handler("excelExport", handler);
      return this;
    }

    public SpreadsheetEventBuilder ExcelImport(string handler)
    {
      this.Handler("excelImport", handler);
      return this;
    }

    public SpreadsheetEventBuilder ExcelImport(Func<object, object> handler)
    {
      this.Handler("excelImport", handler);
      return this;
    }

    public SpreadsheetEventBuilder PdfExport(string handler)
    {
      this.Handler("pdfExport", handler);
      return this;
    }

    public SpreadsheetEventBuilder PdfExport(Func<object, object> handler)
    {
      this.Handler("pdfExport", handler);
      return this;
    }

    public SpreadsheetEventBuilder Copy(string handler)
    {
      this.Handler("copy", handler);
      return this;
    }

    public SpreadsheetEventBuilder Copy(Func<object, object> handler)
    {
      this.Handler("copy", handler);
      return this;
    }

    public SpreadsheetEventBuilder Cut(string handler)
    {
      this.Handler("cut", handler);
      return this;
    }

    public SpreadsheetEventBuilder Cut(Func<object, object> handler)
    {
      this.Handler("cut", handler);
      return this;
    }

    public SpreadsheetEventBuilder Paste(string handler)
    {
      this.Handler("paste", handler);
      return this;
    }

    public SpreadsheetEventBuilder Paste(Func<object, object> handler)
    {
      this.Handler("paste", handler);
      return this;
    }

    public SpreadsheetEventBuilder DataBinding(string handler)
    {
      this.Handler("dataBinding", handler);
      return this;
    }

    public SpreadsheetEventBuilder DataBinding(Func<object, object> handler)
    {
      this.Handler("dataBinding", handler);
      return this;
    }

    public SpreadsheetEventBuilder DataBound(string handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public SpreadsheetEventBuilder DataBound(Func<object, object> handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }
  }
}
