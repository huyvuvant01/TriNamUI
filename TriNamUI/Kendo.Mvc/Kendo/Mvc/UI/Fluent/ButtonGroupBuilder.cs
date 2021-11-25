// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ButtonGroupBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
  public class ButtonGroupBuilder : WidgetBuilderBase<ButtonGroup, ButtonGroupBuilder>
  {
    public ButtonGroupBuilder(ButtonGroup component)
      : base(component)
    {
    }

    public ButtonGroupBuilder BindTo(IEnumerable<ButtonGroupItem> items)
    {
      this.Component.Items.Clear();
      foreach (ButtonGroupItem buttonGroupItem in items)
        this.Component.Items.Add(buttonGroupItem);
      return this;
    }

    public ButtonGroupBuilder Enable(bool value)
    {
      this.Container.Enable = new bool?(value);
      return this;
    }

    public ButtonGroupBuilder Index(double value)
    {
      this.Container.Index = new double?(value);
      return this;
    }

    public ButtonGroupBuilder Selection(string value)
    {
      this.Container.Selection = value;
      return this;
    }

    public ButtonGroupBuilder Items(Action<ButtonGroupItemFactory> configurator)
    {
      configurator(new ButtonGroupItemFactory(this.Container.Items)
      {
        ButtonGroup = this.Container
      });
      return this;
    }

    public ButtonGroupBuilder Events(Action<ButtonGroupEventBuilder> configurator)
    {
      configurator(new ButtonGroupEventBuilder(this.Container.Events));
      return this;
    }
  }
}
