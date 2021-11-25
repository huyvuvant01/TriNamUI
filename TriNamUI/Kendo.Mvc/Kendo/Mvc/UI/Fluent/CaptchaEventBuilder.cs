// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.CaptchaEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class CaptchaEventBuilder : EventBuilder
  {
    public CaptchaEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public CaptchaEventBuilder Change(string handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public CaptchaEventBuilder Change(Func<object, object> handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public CaptchaEventBuilder RequestEnd(string handler)
    {
      this.Handler("requestEnd", handler);
      return this;
    }

    public CaptchaEventBuilder RequestEnd(Func<object, object> handler)
    {
      this.Handler("requestEnd", handler);
      return this;
    }

    public CaptchaEventBuilder RequestStart(string handler)
    {
      this.Handler("requestStart", handler);
      return this;
    }

    public CaptchaEventBuilder RequestStart(Func<object, object> handler)
    {
      this.Handler("requestStart", handler);
      return this;
    }

    public CaptchaEventBuilder Error(string handler)
    {
      this.Handler("error", handler);
      return this;
    }

    public CaptchaEventBuilder Error(Func<object, object> handler)
    {
      this.Handler("error", handler);
      return this;
    }
  }
}
