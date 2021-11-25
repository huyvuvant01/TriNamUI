// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ColorPickerEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class ColorPickerEventBuilder : EventBuilder
  {
    public ColorPickerEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public ColorPickerEventBuilder Change(string handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public ColorPickerEventBuilder Change(Func<object, object> handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public ColorPickerEventBuilder Select(string handler)
    {
      this.Handler("select", handler);
      return this;
    }

    public ColorPickerEventBuilder Select(Func<object, object> handler)
    {
      this.Handler("select", handler);
      return this;
    }

    public ColorPickerEventBuilder Open(string handler)
    {
      this.Handler("open", handler);
      return this;
    }

    public ColorPickerEventBuilder Open(Func<object, object> handler)
    {
      this.Handler("open", handler);
      return this;
    }

    public ColorPickerEventBuilder Close(string handler)
    {
      this.Handler("close", handler);
      return this;
    }

    public ColorPickerEventBuilder Close(Func<object, object> handler)
    {
      this.Handler("close", handler);
      return this;
    }
  }
}
