// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.CheckBoxGroupItemBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class CheckBoxGroupItemBuilder
  {
    public CheckBoxGroupItemBuilder(CheckBoxGroupItem container) => this.Container = container;

    protected CheckBoxGroupItem Container { get; private set; }

    public CheckBoxGroupItemBuilder HtmlAttributes(
      IDictionary<string, object> value)
    {
      this.Container.HtmlAttributes = value;
      return this;
    }

    public CheckBoxGroupItemBuilder HtmlAttributes(object value)
    {
      this.Container.HtmlAttributes = value.ToDictionary();
      return this;
    }

    public CheckBoxGroupItemBuilder CssClass(string value)
    {
      this.Container.CssClass = value;
      return this;
    }

    public CheckBoxGroupItemBuilder Enabled(bool value)
    {
      this.Container.Enabled = new bool?(value);
      return this;
    }

    public CheckBoxGroupItemBuilder Encoded(bool value)
    {
      this.Container.Encoded = new bool?(value);
      return this;
    }

    public CheckBoxGroupItemBuilder Label(string value)
    {
      this.Container.Label = value;
      return this;
    }

    public CheckBoxGroupItemBuilder Value(string value)
    {
      this.Container.Value = value;
      return this;
    }
  }
}
