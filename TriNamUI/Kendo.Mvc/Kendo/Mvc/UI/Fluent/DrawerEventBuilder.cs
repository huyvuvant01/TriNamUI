// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DrawerEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class DrawerEventBuilder : EventBuilder
  {
    public DrawerEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public DrawerEventBuilder Hide(string handler)
    {
      this.Handler("hide", handler);
      return this;
    }

    public DrawerEventBuilder Hide(Func<object, object> handler)
    {
      this.Handler("hide", handler);
      return this;
    }

    public DrawerEventBuilder Show(string handler)
    {
      this.Handler("show", handler);
      return this;
    }

    public DrawerEventBuilder Show(Func<object, object> handler)
    {
      this.Handler("show", handler);
      return this;
    }

    public DrawerEventBuilder ItemClick(string handler)
    {
      this.Handler("itemClick", handler);
      return this;
    }

    public DrawerEventBuilder ItemClick(Func<object, object> handler)
    {
      this.Handler("itemClick", handler);
      return this;
    }
  }
}
