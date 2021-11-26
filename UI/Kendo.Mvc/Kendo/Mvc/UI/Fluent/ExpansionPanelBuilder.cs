// Decompiled with JetBrains decompiler
// Type: Kendo.Mvc.UI.Fluent.ExpansionPanelBuilder
// Assembly: Kendo.Mvc, Version=2021.3.1109.0, Culture=neutral, PublicKeyToken=121fae78165ba3d4
// MVID: 21B8CA96-D514-4435-8358-0B5915A38622
// Assembly location: D:\TriNam\Git\TriNamUI\TriNamUI\TestTelerikNetCore\bin\Debug\net6.0\Kendo.Mvc.dll

using System;

namespace Kendo.Mvc.UI.Fluent
{
  public class ExpansionPanelBuilder : WidgetBuilderBase<ExpansionPanel, ExpansionPanelBuilder>
  {
    public ExpansionPanelBuilder(ExpansionPanel component)
      : base(component)
    {
    }

    public ExpansionPanelBuilder Content(Action value)
    {
      this.Container.Content.Content = value;
      return this;
    }

    public ExpansionPanelBuilder Content(Func<object, object> value)
    {
      this.Container.Content.InlineTemplate = value;
      return this;
    }

    public ExpansionPanelBuilder Content(string value)
    {
      this.Container.Content.Html = value;
      return this;
    }

    public ExpansionPanelBuilder Animation(
      Action<ExpansionPanelAnimationSettingsBuilder> configurator)
    {
      this.Container.Animation.Enabled = new bool?(true);
      this.Container.Animation.ExpansionPanel = this.Container;
      configurator(new ExpansionPanelAnimationSettingsBuilder(this.Container.Animation));
      return this;
    }

    public ExpansionPanelBuilder Animation(bool enabled)
    {
      this.Container.Animation.Enabled = new bool?(enabled);
      return this;
    }

    public ExpansionPanelBuilder CollapseIconClass(string value)
    {
      this.Container.CollapseIconClass = value;
      return this;
    }

    public ExpansionPanelBuilder Disabled(bool value)
    {
      this.Container.Disabled = new bool?(value);
      return this;
    }

    public ExpansionPanelBuilder Disabled()
    {
      this.Container.Disabled = new bool?(true);
      return this;
    }

    public ExpansionPanelBuilder Expanded(bool value)
    {
      this.Container.Expanded = new bool?(value);
      return this;
    }

    public ExpansionPanelBuilder Expanded()
    {
      this.Container.Expanded = new bool?(true);
      return this;
    }

    public ExpansionPanelBuilder ExpandIconClass(string value)
    {
      this.Container.ExpandIconClass = value;
      return this;
    }

    public ExpansionPanelBuilder Height(double value)
    {
      this.Container.Height = new double?(value);
      return this;
    }

    public ExpansionPanelBuilder SubTitle(string value)
    {
      this.Container.SubTitle = value;
      return this;
    }

    public ExpansionPanelBuilder Title(string value)
    {
      this.Container.Title = value;
      return this;
    }

    public ExpansionPanelBuilder Toggleable(bool value)
    {
      this.Container.Toggleable = new bool?(value);
      return this;
    }

    public ExpansionPanelBuilder Events(
      Action<ExpansionPanelEventBuilder> configurator)
    {
      configurator(new ExpansionPanelEventBuilder(this.Container.Events));
      return this;
    }
  }
}
