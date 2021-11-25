// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.SwitchBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class SwitchBuilder : WidgetBuilderBase<Switch, SwitchBuilder>
  {
    public SwitchBuilder(Switch component)
      : base(component)
    {
    }

    public SwitchBuilder Checked(bool value)
    {
      this.Container.Checked = new bool?(value);
      return this;
    }

    public SwitchBuilder Checked()
    {
      this.Container.Checked = new bool?(true);
      return this;
    }

    public SwitchBuilder Enabled(bool value)
    {
      this.Container.Enabled = new bool?(value);
      return this;
    }

    public SwitchBuilder Readonly(bool value)
    {
      this.Container.Readonly = new bool?(value);
      return this;
    }

    public SwitchBuilder Readonly()
    {
      this.Container.Readonly = new bool?(true);
      return this;
    }

    public SwitchBuilder Messages(Action<SwitchMessagesSettingsBuilder> configurator)
    {
      this.Container.Messages.Switch = this.Container;
      configurator(new SwitchMessagesSettingsBuilder(this.Container.Messages));
      return this;
    }

    public SwitchBuilder Width(double value)
    {
      this.Container.Width = new double?(value);
      return this;
    }

    public SwitchBuilder Events(Action<SwitchEventBuilder> configurator)
    {
      configurator(new SwitchEventBuilder(this.Container.Events));
      return this;
    }
  }
}
