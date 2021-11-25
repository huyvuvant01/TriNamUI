// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.FormEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class FormEventBuilder : EventBuilder
  {
    public FormEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public FormEventBuilder Validate(string handler)
    {
      this.Handler("validate", handler);
      return this;
    }

    public FormEventBuilder Validate(Func<object, object> handler)
    {
      this.Handler("validate", handler);
      return this;
    }

    public FormEventBuilder ValidateField(string handler)
    {
      this.Handler("validateField", handler);
      return this;
    }

    public FormEventBuilder ValidateField(Func<object, object> handler)
    {
      this.Handler("validateField", handler);
      return this;
    }

    public FormEventBuilder Change(string handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public FormEventBuilder Change(Func<object, object> handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public FormEventBuilder Submit(string handler)
    {
      this.Handler("submit", handler);
      return this;
    }

    public FormEventBuilder Submit(Func<object, object> handler)
    {
      this.Handler("submit", handler);
      return this;
    }

    public FormEventBuilder Clear(string handler)
    {
      this.Handler("clear", handler);
      return this;
    }

    public FormEventBuilder Clear(Func<object, object> handler)
    {
      this.Handler("clear", handler);
      return this;
    }
  }
}
