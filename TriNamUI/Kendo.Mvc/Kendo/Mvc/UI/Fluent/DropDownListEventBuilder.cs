// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DropDownListEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class DropDownListEventBuilder : EventBuilder
  {
    public DropDownListEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public DropDownListEventBuilder Change(string handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public DropDownListEventBuilder Change(Func<object, object> handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public DropDownListEventBuilder Close(string handler)
    {
      this.Handler("close", handler);
      return this;
    }

    public DropDownListEventBuilder Close(Func<object, object> handler)
    {
      this.Handler("close", handler);
      return this;
    }

    public DropDownListEventBuilder DataBound(string handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public DropDownListEventBuilder DataBound(Func<object, object> handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public DropDownListEventBuilder Filtering(string handler)
    {
      this.Handler("filtering", handler);
      return this;
    }

    public DropDownListEventBuilder Filtering(Func<object, object> handler)
    {
      this.Handler("filtering", handler);
      return this;
    }

    public DropDownListEventBuilder Open(string handler)
    {
      this.Handler("open", handler);
      return this;
    }

    public DropDownListEventBuilder Open(Func<object, object> handler)
    {
      this.Handler("open", handler);
      return this;
    }

    public DropDownListEventBuilder Select(string handler)
    {
      this.Handler("select", handler);
      return this;
    }

    public DropDownListEventBuilder Select(Func<object, object> handler)
    {
      this.Handler("select", handler);
      return this;
    }

    public DropDownListEventBuilder Cascade(string handler)
    {
      this.Handler("cascade", handler);
      return this;
    }

    public DropDownListEventBuilder Cascade(Func<object, object> handler)
    {
      this.Handler("cascade", handler);
      return this;
    }
  }
}
