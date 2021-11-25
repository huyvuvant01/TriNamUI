// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.PDFViewerEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class PDFViewerEventBuilder : EventBuilder
  {
    public PDFViewerEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public PDFViewerEventBuilder Render(string handler)
    {
      this.Handler("render", handler);
      return this;
    }

    public PDFViewerEventBuilder Render(Func<object, object> handler)
    {
      this.Handler("render", handler);
      return this;
    }

    public PDFViewerEventBuilder Open(string handler)
    {
      this.Handler("open", handler);
      return this;
    }

    public PDFViewerEventBuilder Open(Func<object, object> handler)
    {
      this.Handler("open", handler);
      return this;
    }

    public PDFViewerEventBuilder Error(string handler)
    {
      this.Handler("error", handler);
      return this;
    }

    public PDFViewerEventBuilder Error(Func<object, object> handler)
    {
      this.Handler("error", handler);
      return this;
    }
  }
}
