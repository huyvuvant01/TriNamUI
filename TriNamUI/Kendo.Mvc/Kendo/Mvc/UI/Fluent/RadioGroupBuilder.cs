// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.RadioGroupBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI.Fluent
{
  public class RadioGroupBuilder : WidgetBuilderBase<RadioGroup, RadioGroupBuilder>
  {
    public RadioGroupBuilder(RadioGroup component)
      : base(component)
    {
    }

    public RadioGroupBuilder Layout(string value)
    {
      if (value.ToLower() == "horizontal")
        this.Container.Layout = new RadioGroupLayout?(RadioGroupLayout.Horizontal);
      return this;
    }

    public RadioGroupBuilder LabelPosition(string value)
    {
      if (value.ToLower() == "before")
        this.Container.LabelPosition = new RadioGroupLabelPosition?(RadioGroupLabelPosition.Before);
      return this;
    }

    public RadioGroupBuilder BindTo(string[] values)
    {
      this.Container.Items = ((IEnumerable<string>) values).Select<string, RadioGroupItem>((Func<string, RadioGroupItem>) (v => new RadioGroupItem()
      {
        Value = v,
        Label = v
      })).ToList<RadioGroupItem>();
      return this;
    }

    public RadioGroupBuilder BindTo(IEnumerable<IInputGroupItem> values)
    {
      this.Container.Items = values.Select<IInputGroupItem, RadioGroupItem>((Func<IInputGroupItem, RadioGroupItem>) (v => new RadioGroupItem()
      {
        CssClass = v.CssClass,
        Enabled = v.Enabled,
        Encoded = v.Encoded,
        HtmlAttributes = v.HtmlAttributes,
        Label = v.Label,
        Value = v.Value
      })).ToList<RadioGroupItem>();
      return this;
    }

    public RadioGroupBuilder Enabled(bool value)
    {
      this.Container.Enabled = new bool?(value);
      return this;
    }

    public RadioGroupBuilder InputName(string value)
    {
      this.Container.InputName = value;
      return this;
    }

    public RadioGroupBuilder Items(Action<RadioGroupItemFactory> configurator)
    {
      configurator(new RadioGroupItemFactory(this.Container.Items)
      {
        RadioGroup = this.Container
      });
      return this;
    }

    public RadioGroupBuilder Value(string value)
    {
      this.Container.Value = value;
      return this;
    }

    public RadioGroupBuilder Layout(RadioGroupLayout value)
    {
      this.Container.Layout = new RadioGroupLayout?(value);
      return this;
    }

    public RadioGroupBuilder LabelPosition(RadioGroupLabelPosition value)
    {
      this.Container.LabelPosition = new RadioGroupLabelPosition?(value);
      return this;
    }

    public RadioGroupBuilder Events(Action<RadioGroupEventBuilder> configurator)
    {
      configurator(new RadioGroupEventBuilder(this.Container.Events));
      return this;
    }
  }
}
