// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.DatePickerEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class DatePickerEventBuilder : EventBuilder
  {
    public DatePickerEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public DatePickerEventBuilder Change(string handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public DatePickerEventBuilder Change(Func<object, object> handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public DatePickerEventBuilder Close(string handler)
    {
      this.Handler("close", handler);
      return this;
    }

    public DatePickerEventBuilder Close(Func<object, object> handler)
    {
      this.Handler("close", handler);
      return this;
    }

    public DatePickerEventBuilder Open(string handler)
    {
      this.Handler("open", handler);
      return this;
    }

    public DatePickerEventBuilder Open(Func<object, object> handler)
    {
      this.Handler("open", handler);
      return this;
    }
  }
}
