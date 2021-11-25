// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MenuEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class MenuEventBuilder : EventBuilder
  {
    public MenuEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public MenuEventBuilder Close(string handler)
    {
      this.Handler("close", handler);
      return this;
    }

    public MenuEventBuilder Close(Func<object, object> handler)
    {
      this.Handler("close", handler);
      return this;
    }

    public MenuEventBuilder DataBound(string handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public MenuEventBuilder DataBound(Func<object, object> handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public MenuEventBuilder Open(string handler)
    {
      this.Handler("open", handler);
      return this;
    }

    public MenuEventBuilder Open(Func<object, object> handler)
    {
      this.Handler("open", handler);
      return this;
    }

    public MenuEventBuilder Activate(string handler)
    {
      this.Handler("activate", handler);
      return this;
    }

    public MenuEventBuilder Activate(Func<object, object> handler)
    {
      this.Handler("activate", handler);
      return this;
    }

    public MenuEventBuilder Deactivate(string handler)
    {
      this.Handler("deactivate", handler);
      return this;
    }

    public MenuEventBuilder Deactivate(Func<object, object> handler)
    {
      this.Handler("deactivate", handler);
      return this;
    }

    public MenuEventBuilder Select(string handler)
    {
      this.Handler("select", handler);
      return this;
    }

    public MenuEventBuilder Select(Func<object, object> handler)
    {
      this.Handler("select", handler);
      return this;
    }
  }
}
