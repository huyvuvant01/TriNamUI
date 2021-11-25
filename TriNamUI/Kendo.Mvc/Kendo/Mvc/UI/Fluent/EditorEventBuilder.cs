// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.EditorEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class EditorEventBuilder : EventBuilder
  {
    public EditorEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public EditorEventBuilder Change(string handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public EditorEventBuilder Change(Func<object, object> handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public EditorEventBuilder Execute(string handler)
    {
      this.Handler("execute", handler);
      return this;
    }

    public EditorEventBuilder Execute(Func<object, object> handler)
    {
      this.Handler("execute", handler);
      return this;
    }

    public EditorEventBuilder Keydown(string handler)
    {
      this.Handler("keydown", handler);
      return this;
    }

    public EditorEventBuilder Keydown(Func<object, object> handler)
    {
      this.Handler("keydown", handler);
      return this;
    }

    public EditorEventBuilder Keyup(string handler)
    {
      this.Handler("keyup", handler);
      return this;
    }

    public EditorEventBuilder Keyup(Func<object, object> handler)
    {
      this.Handler("keyup", handler);
      return this;
    }

    public EditorEventBuilder Paste(string handler)
    {
      this.Handler("paste", handler);
      return this;
    }

    public EditorEventBuilder Paste(Func<object, object> handler)
    {
      this.Handler("paste", handler);
      return this;
    }

    public EditorEventBuilder PdfExport(string handler)
    {
      this.Handler("pdfExport", handler);
      return this;
    }

    public EditorEventBuilder PdfExport(Func<object, object> handler)
    {
      this.Handler("pdfExport", handler);
      return this;
    }

    public EditorEventBuilder Select(string handler)
    {
      this.Handler("select", handler);
      return this;
    }

    public EditorEventBuilder Select(Func<object, object> handler)
    {
      this.Handler("select", handler);
      return this;
    }
  }
}
