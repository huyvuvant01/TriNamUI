﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.CheckBoxGroupEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class CheckBoxGroupEventBuilder : EventBuilder
  {
    public CheckBoxGroupEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public CheckBoxGroupEventBuilder Change(string handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public CheckBoxGroupEventBuilder Change(Func<object, object> handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public CheckBoxGroupEventBuilder Focus(string handler)
    {
      this.Handler("focus", handler);
      return this;
    }

    public CheckBoxGroupEventBuilder Focus(Func<object, object> handler)
    {
      this.Handler("focus", handler);
      return this;
    }

    public CheckBoxGroupEventBuilder Select(string handler)
    {
      this.Handler("select", handler);
      return this;
    }

    public CheckBoxGroupEventBuilder Select(Func<object, object> handler)
    {
      this.Handler("select", handler);
      return this;
    }
  }
}
