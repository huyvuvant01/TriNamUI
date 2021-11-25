﻿// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ActionSheetEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class ActionSheetEventBuilder : EventBuilder
  {
    public ActionSheetEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public ActionSheetEventBuilder Close(string handler)
    {
      this.Handler("close", handler);
      return this;
    }

    public ActionSheetEventBuilder Close(Func<object, object> handler)
    {
      this.Handler("close", handler);
      return this;
    }

    public ActionSheetEventBuilder Open(string handler)
    {
      this.Handler("open", handler);
      return this;
    }

    public ActionSheetEventBuilder Open(Func<object, object> handler)
    {
      this.Handler("open", handler);
      return this;
    }
  }
}