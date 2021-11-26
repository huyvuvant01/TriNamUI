// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ButtonGroupItemBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class ButtonGroupItemBuilder
  {
    public ButtonGroupItemBuilder(ButtonGroupItem container) => this.Container = container;

    protected ButtonGroupItem Container { get; private set; }

    public ButtonGroupItemBuilder Badge(string value)
    {
      this.Container.Badge.Text = value;
      return this;
    }

    public ButtonGroupItemBuilder HtmlAttributes(
      IDictionary<string, object> value)
    {
      this.Container.HtmlAttributes = value;
      return this;
    }

    public ButtonGroupItemBuilder HtmlAttributes(object value)
    {
      this.Container.HtmlAttributes = value.ToDictionary();
      return this;
    }

    public ButtonGroupItemBuilder Badge(
      Action<ButtonGroupItemBadgeSettingsBuilder> configurator)
    {
      this.Container.Badge.Enabled = new bool?(true);
      this.Container.Badge.ButtonGroup = this.Container.ButtonGroup;
      configurator(new ButtonGroupItemBadgeSettingsBuilder(this.Container.Badge));
      return this;
    }

    public ButtonGroupItemBuilder Badge(bool enabled)
    {
      this.Container.Badge.Enabled = new bool?(enabled);
      return this;
    }

    public ButtonGroupItemBuilder Enabled(bool value)
    {
      this.Container.Enabled = new bool?(value);
      return this;
    }

    public ButtonGroupItemBuilder Icon(string value)
    {
      this.Container.Icon = value;
      return this;
    }

    public ButtonGroupItemBuilder IconClass(string value)
    {
      this.Container.IconClass = value;
      return this;
    }

    public ButtonGroupItemBuilder ImageUrl(string value)
    {
      this.Container.ImageUrl = value;
      return this;
    }

    public ButtonGroupItemBuilder Selected(bool value)
    {
      this.Container.Selected = new bool?(value);
      return this;
    }

    public ButtonGroupItemBuilder Selected()
    {
      this.Container.Selected = new bool?(true);
      return this;
    }

    public ButtonGroupItemBuilder Text(string value)
    {
      this.Container.Text = value;
      return this;
    }

    public ButtonGroupItemBuilder Encoded(bool value)
    {
      this.Container.Encoded = new bool?(value);
      return this;
    }
  }
}
