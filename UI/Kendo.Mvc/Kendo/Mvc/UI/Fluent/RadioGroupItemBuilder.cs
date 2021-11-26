// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.RadioGroupItemBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class RadioGroupItemBuilder
  {
    public RadioGroupItemBuilder(RadioGroupItem container) => this.Container = container;

    protected RadioGroupItem Container { get; private set; }

    public RadioGroupItemBuilder HtmlAttributes(
      IDictionary<string, object> value)
    {
      this.Container.HtmlAttributes = value;
      return this;
    }

    public RadioGroupItemBuilder HtmlAttributes(object value)
    {
      this.Container.HtmlAttributes = value.ToDictionary();
      return this;
    }

    public RadioGroupItemBuilder CssClass(string value)
    {
      this.Container.CssClass = value;
      return this;
    }

    public RadioGroupItemBuilder Enabled(bool value)
    {
      this.Container.Enabled = new bool?(value);
      return this;
    }

    public RadioGroupItemBuilder Encoded(bool value)
    {
      this.Container.Encoded = new bool?(value);
      return this;
    }

    public RadioGroupItemBuilder Label(string value)
    {
      this.Container.Label = value;
      return this;
    }

    public RadioGroupItemBuilder Value(string value)
    {
      this.Container.Value = value;
      return this;
    }
  }
}
