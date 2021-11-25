// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.CheckBoxGroupBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI.Fluent
{
  public class CheckBoxGroupBuilder : WidgetBuilderBase<CheckBoxGroup, CheckBoxGroupBuilder>
  {
    public CheckBoxGroupBuilder(CheckBoxGroup component)
      : base(component)
    {
    }

    public CheckBoxGroupBuilder Layout(string value)
    {
      if (value.ToLower() == "horizontal")
        this.Container.Layout = new CheckBoxGroupLayout?(CheckBoxGroupLayout.Horizontal);
      return this;
    }

    public CheckBoxGroupBuilder LabelPosition(string value)
    {
      if (value.ToLower() == "before")
        this.Container.LabelPosition = new CheckBoxGroupLabelPosition?(CheckBoxGroupLabelPosition.Before);
      return this;
    }

    public CheckBoxGroupBuilder BindTo(string[] values)
    {
      this.Container.Items = ((IEnumerable<string>) values).Select<string, CheckBoxGroupItem>((Func<string, CheckBoxGroupItem>) (v => new CheckBoxGroupItem()
      {
        Value = v,
        Label = v
      })).ToList<CheckBoxGroupItem>();
      return this;
    }

    public CheckBoxGroupBuilder BindTo(IEnumerable<IInputGroupItem> values)
    {
      this.Container.Items = values.Select<IInputGroupItem, CheckBoxGroupItem>((Func<IInputGroupItem, CheckBoxGroupItem>) (v => new CheckBoxGroupItem()
      {
        CssClass = v.CssClass,
        Enabled = v.Enabled,
        Encoded = v.Encoded,
        HtmlAttributes = v.HtmlAttributes,
        Label = v.Label,
        Value = v.Value
      })).ToList<CheckBoxGroupItem>();
      return this;
    }

    public CheckBoxGroupBuilder Value(IEnumerable<string> value)
    {
      this.Container.Value = value;
      return this;
    }

    public CheckBoxGroupBuilder Enabled(bool value)
    {
      this.Container.Enabled = new bool?(value);
      return this;
    }

    public CheckBoxGroupBuilder InputName(string value)
    {
      this.Container.InputName = value;
      return this;
    }

    public CheckBoxGroupBuilder Items(
      Action<CheckBoxGroupItemFactory> configurator)
    {
      configurator(new CheckBoxGroupItemFactory(this.Container.Items)
      {
        CheckBoxGroup = this.Container
      });
      return this;
    }

    public CheckBoxGroupBuilder Layout(CheckBoxGroupLayout value)
    {
      this.Container.Layout = new CheckBoxGroupLayout?(value);
      return this;
    }

    public CheckBoxGroupBuilder LabelPosition(CheckBoxGroupLabelPosition value)
    {
      this.Container.LabelPosition = new CheckBoxGroupLabelPosition?(value);
      return this;
    }

    public CheckBoxGroupBuilder Events(
      Action<CheckBoxGroupEventBuilder> configurator)
    {
      configurator(new CheckBoxGroupEventBuilder(this.Container.Events));
      return this;
    }
  }
}
