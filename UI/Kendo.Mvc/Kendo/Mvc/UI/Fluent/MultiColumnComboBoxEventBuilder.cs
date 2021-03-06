// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.MultiColumnComboBoxEventBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class MultiColumnComboBoxEventBuilder : EventBuilder
  {
    public MultiColumnComboBoxEventBuilder(IDictionary<string, object> events)
      : base(events)
    {
    }

    public MultiColumnComboBoxEventBuilder Change(string handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public MultiColumnComboBoxEventBuilder Change(
      Func<object, object> handler)
    {
      this.Handler("change", handler);
      return this;
    }

    public MultiColumnComboBoxEventBuilder Close(string handler)
    {
      this.Handler("close", handler);
      return this;
    }

    public MultiColumnComboBoxEventBuilder Close(
      Func<object, object> handler)
    {
      this.Handler("close", handler);
      return this;
    }

    public MultiColumnComboBoxEventBuilder DataBound(string handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public MultiColumnComboBoxEventBuilder DataBound(
      Func<object, object> handler)
    {
      this.Handler("dataBound", handler);
      return this;
    }

    public MultiColumnComboBoxEventBuilder Filtering(string handler)
    {
      this.Handler("filtering", handler);
      return this;
    }

    public MultiColumnComboBoxEventBuilder Filtering(
      Func<object, object> handler)
    {
      this.Handler("filtering", handler);
      return this;
    }

    public MultiColumnComboBoxEventBuilder Open(string handler)
    {
      this.Handler("open", handler);
      return this;
    }

    public MultiColumnComboBoxEventBuilder Open(
      Func<object, object> handler)
    {
      this.Handler("open", handler);
      return this;
    }

    public MultiColumnComboBoxEventBuilder Select(string handler)
    {
      this.Handler("select", handler);
      return this;
    }

    public MultiColumnComboBoxEventBuilder Select(
      Func<object, object> handler)
    {
      this.Handler("select", handler);
      return this;
    }

    public MultiColumnComboBoxEventBuilder Cascade(string handler)
    {
      this.Handler("cascade", handler);
      return this;
    }

    public MultiColumnComboBoxEventBuilder Cascade(
      Func<object, object> handler)
    {
      this.Handler("cascade", handler);
      return this;
    }
  }
}
