// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.TabStripEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class TabStripEventBuilder : EventBuilder
  {
    public TabStripEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public TabStripEventBuilder Activate(string handler)
    {
      this.Handler("activate", handler);
      return this;
    }

    public TabStripEventBuilder Activate(Func<object, object> handler)
    {
      this.Handler("activate", handler);
      return this;
    }

    public TabStripEventBuilder ContentLoad(string handler)
    {
      this.Handler("contentLoad", handler);
      return this;
    }

    public TabStripEventBuilder ContentLoad(Func<object, object> handler)
    {
      this.Handler("contentLoad", handler);
      return this;
    }

    public TabStripEventBuilder Error(string handler)
    {
      this.Handler("error", handler);
      return this;
    }

    public TabStripEventBuilder Error(Func<object, object> handler)
    {
      this.Handler("error", handler);
      return this;
    }

    public TabStripEventBuilder Select(string handler)
    {
      this.Handler("select", handler);
      return this;
    }

    public TabStripEventBuilder Select(Func<object, object> handler)
    {
      this.Handler("select", handler);
      return this;
    }

    public TabStripEventBuilder Show(string handler)
    {
      this.Handler("show", handler);
      return this;
    }

    public TabStripEventBuilder Show(Func<object, object> handler)
    {
      this.Handler("show", handler);
      return this;
    }
  }
}
