// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PivotGridEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class PivotGridEventBuilder : EventBuilder
  {
    public PivotGridEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public PivotGridEventBuilder DataBinding(string handler)
    {
      this.Handler("dataBinding", handler);
      return this;
    }

    public PivotGridEventBuilder DataBinding(Func<object, object> handler)
    {
      this.Handler("dataBinding", handler);
      return this;
    }

    public PivotGridEventBuilder DataBound(string handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public PivotGridEventBuilder DataBound(Func<object, object> handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public PivotGridEventBuilder ExpandMember(string handler)
    {
      this.Handler("expandMember", handler);
      return this;
    }

    public PivotGridEventBuilder ExpandMember(Func<object, object> handler)
    {
      this.Handler("expandMember", handler);
      return this;
    }

    public PivotGridEventBuilder CollapseMember(string handler)
    {
      this.Handler("collapseMember", handler);
      return this;
    }

    public PivotGridEventBuilder CollapseMember(Func<object, object> handler)
    {
      this.Handler("collapseMember", handler);
      return this;
    }

    public PivotGridEventBuilder ExcelExport(string handler)
    {
      this.Handler("excelExport", handler);
      return this;
    }

    public PivotGridEventBuilder ExcelExport(Func<object, object> handler)
    {
      this.Handler("excelExport", handler);
      return this;
    }

    public PivotGridEventBuilder PdfExport(string handler)
    {
      this.Handler("pdfExport", handler);
      return this;
    }

    public PivotGridEventBuilder PdfExport(Func<object, object> handler)
    {
      this.Handler("pdfExport", handler);
      return this;
    }
  }
}
