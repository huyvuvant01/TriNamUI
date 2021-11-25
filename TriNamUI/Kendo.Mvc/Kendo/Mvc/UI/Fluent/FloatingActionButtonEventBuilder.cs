// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FloatingActionButtonEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class FloatingActionButtonEventBuilder : EventBuilder
  {
    public FloatingActionButtonEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public FloatingActionButtonEventBuilder Click(string handler)
    {
      this.Handler("click", handler);
      return this;
    }

    public FloatingActionButtonEventBuilder Click(
      Func<object, object> handler)
    {
      this.Handler("click", handler);
      return this;
    }

    public FloatingActionButtonEventBuilder Collapse(string handler)
    {
      this.Handler("collapse", handler);
      return this;
    }

    public FloatingActionButtonEventBuilder Collapse(
      Func<object, object> handler)
    {
      this.Handler("collapse", handler);
      return this;
    }

    public FloatingActionButtonEventBuilder Expand(string handler)
    {
      this.Handler("expand", handler);
      return this;
    }

    public FloatingActionButtonEventBuilder Expand(
      Func<object, object> handler)
    {
      this.Handler("expand", handler);
      return this;
    }
  }
}
